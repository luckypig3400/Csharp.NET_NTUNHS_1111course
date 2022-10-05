namespace D2_basicSyntax_and_Git
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.p1BtnBMI = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // p1BtnBMI
            // 
            this.p1BtnBMI.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.p1BtnBMI.Location = new System.Drawing.Point(59, 34);
            this.p1BtnBMI.Name = "p1BtnBMI";
            this.p1BtnBMI.Size = new System.Drawing.Size(106, 61);
            this.p1BtnBMI.TabIndex = 0;
            this.p1BtnBMI.Text = "練習一: 我的BMI";
            this.p1BtnBMI.UseVisualStyleBackColor = true;
            this.p1BtnBMI.Click += new System.EventHandler(this.p1BtnBMI_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 111);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(776, 327);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("https://github.com/", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.p1BtnBMI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button p1BtnBMI;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

