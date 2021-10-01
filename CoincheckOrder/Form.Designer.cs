namespace CoincheckOrderApp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioSell = new System.Windows.Forms.RadioButton();
            this.radioBuy = new System.Windows.Forms.RadioButton();
            this.panel = new System.Windows.Forms.Panel();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioSell
            // 
            this.radioSell.AutoSize = true;
            this.radioSell.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioSell.Location = new System.Drawing.Point(36, 119);
            this.radioSell.Name = "radioSell";
            this.radioSell.Size = new System.Drawing.Size(55, 19);
            this.radioSell.TabIndex = 1;
            this.radioSell.TabStop = true;
            this.radioSell.Text = "売り";
            this.radioSell.UseVisualStyleBackColor = true;
            this.radioSell.CheckedChanged += new System.EventHandler(this.radioSell_CheckedChanged);
            // 
            // radioBuy
            // 
            this.radioBuy.AutoSize = true;
            this.radioBuy.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioBuy.Location = new System.Drawing.Point(133, 119);
            this.radioBuy.Name = "radioBuy";
            this.radioBuy.Size = new System.Drawing.Size(55, 19);
            this.radioBuy.TabIndex = 2;
            this.radioBuy.TabStop = true;
            this.radioBuy.Text = "買い";
            this.radioBuy.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.textBoxAmount);
            this.panel.Controls.Add(this.textBoxTotal);
            this.panel.Controls.Add(this.textBoxRate);
            this.panel.Controls.Add(this.buttonCancel);
            this.panel.Controls.Add(this.buttonOrder);
            this.panel.Controls.Add(this.labelTotal);
            this.panel.Controls.Add(this.labelAmount);
            this.panel.Controls.Add(this.labelRate);
            this.panel.Controls.Add(this.radioBuy);
            this.panel.Controls.Add(this.radioSell);
            this.panel.Location = new System.Drawing.Point(-2, 1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(221, 239);
            this.panel.TabIndex = 3;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxAmount.Location = new System.Drawing.Point(93, 47);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(110, 27);
            this.textBoxAmount.TabIndex = 10;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxAmount.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxTotal.Location = new System.Drawing.Point(93, 81);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(110, 27);
            this.textBoxTotal.TabIndex = 9;
            // 
            // textBoxRate
            // 
            this.textBoxRate.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxRate.Location = new System.Drawing.Point(93, 15);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(110, 27);
            this.textBoxRate.TabIndex = 8;
            this.textBoxRate.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxRate.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonCancel.ForeColor = System.Drawing.Color.DimGray;
            this.buttonCancel.Location = new System.Drawing.Point(17, 191);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(192, 35);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrder.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonOrder.ForeColor = System.Drawing.Color.DimGray;
            this.buttonOrder.Location = new System.Drawing.Point(17, 148);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(192, 35);
            this.buttonOrder.TabIndex = 6;
            this.buttonOrder.Text = "注文する";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("游ゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTotal.Location = new System.Drawing.Point(21, 83);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(34, 17);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "概算";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("游ゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAmount.Location = new System.Drawing.Point(21, 49);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(47, 17);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "注文量";
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("游ゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRate.Location = new System.Drawing.Point(21, 17);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(47, 17);
            this.labelRate.TabIndex = 3;
            this.labelRate.Text = "レート";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 238);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "現物取引";
            this.Load += new System.EventHandler(this.Form_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioSell;
        private System.Windows.Forms.RadioButton radioBuy;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxRate;
    }
}

