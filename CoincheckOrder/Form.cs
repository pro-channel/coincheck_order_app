using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoincheckRequest;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace CoincheckOrderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 注文したオーダーIDを格納する
        /// </summary>
        private string orderId = null;

        /// <summary>
        /// コインチェックAPIリクエストオブジェクト
        /// </summary>
        CoincheckRequest.CoincheckFunctions functions;

        /// <summary>
        /// フォームロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Load(object sender, EventArgs e)
        {
            this.functions = new CoincheckFunctions();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        /// <summary>
        /// 売り注文ラジオボタン
        /// チェック変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioSell_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioSell.Checked)
            {
                // 売りチェックON（赤色状態）
                this.panel.BackColor = Color.FromArgb(255, 192, 192);
                this.buttonOrder.ForeColor = Color.FromArgb(192, 0, 0);
            }
            else
            {
                // 買いチェックON（緑色状態）
                this.panel.BackColor = Color.FromArgb(192, 255, 192);
                this.buttonOrder.ForeColor = Color.FromArgb(0, 192, 0);
            }
        }

        /// <summary>
        /// レート、数量のテキストボックスのフォーカスアウトイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            double inputValue = 0;
            try
            {
                inputValue = double.Parse(textBox.Text);
            }
            catch (Exception)
            {
                // 数値でない場合
                textBox.Text = string.Empty;
                this.textBoxTotal.Text = string.Empty;
                return;
            }

            textBox.Text = inputValue.ToString();
            this.showTotal();
        }

        /// <summary>
        /// レート、数量のテキストボックスの値変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            this.showTotal();
        }

        /// <summary>
        /// 注文ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            int rate = 0;
            double amount = 0;

            try
            {
                rate = int.Parse(this.textBoxRate.Text);
                amount = double.Parse(this.textBoxAmount.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("レート・注文量が正しく設定されていません。");
                return;
            }

            try
            {
                if (this.radioBuy.Checked)
                {
                    this.orderId = functions.Buy(rate, amount);
                }
                else
                {
                    this.orderId = functions.Sale(rate, amount);
                }
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder("注文に失敗しました。");
                sb.AppendLine(ex.Message);
                MessageBox.Show(sb.ToString());
                return;
            }

            // 注文ボタンを非活性
            this.buttonOrder.Enabled = false;
            // キャンセルボタンを活性
            this.buttonCancel.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.functions.RequestCancel(this.orderId);
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder("キャンセルに失敗しました。「未約定の注文」が残っているか確認してください。");
                sb.AppendLine(ex.Message);
                MessageBox.Show(sb.ToString());
            }
            finally
            {
                // 注文IDを削除
                this.orderId = null;
                // 注文ボタンを活性
                this.buttonOrder.Enabled = true;
                // キャンセルボタンを非活性
                this.buttonCancel.Enabled = false;
            }
        }

        /// <summary>
        /// 概算の値を表示する
        /// </summary>
        private void showTotal()
        {
            int rate;
            double amount;
            try
            {
                rate = int.Parse(this.textBoxRate.Text);
            }
            catch (Exception)
            {
                // レートに数値が入力されていない場合
                this.textBoxTotal.Text = string.Empty;
                return;
            }

            try
            {
                amount = double.Parse(this.textBoxAmount.Text);
            }
            catch (Exception)
            {
                // 数量に数値が入力されていない場合
                this.textBoxTotal.Text = string.Empty;
                return;
            }

            this.textBoxTotal.Text = (rate * amount).ToString();
        }
    }
}
