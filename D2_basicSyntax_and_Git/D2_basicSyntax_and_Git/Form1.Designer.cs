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
            this.testBtn = new System.Windows.Forms.Button();
            this.p2BtnMonth = new System.Windows.Forms.Button();
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
            // testBtn
            // 
            this.testBtn.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.testBtn.Location = new System.Drawing.Point(216, 34);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(174, 60);
            this.testBtn.TabIndex = 1;
            this.testBtn.Text = "Test for Git Detach";
            this.testBtn.UseVisualStyleBackColor = true;
            // 
            // p2BtnMonth
            // 
            this.p2BtnMonth.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.p2BtnMonth.Location = new System.Drawing.Point(59, 136);
            this.p2BtnMonth.Name = "p2BtnMonth";
            this.p2BtnMonth.Size = new System.Drawing.Size(331, 61);
            this.p2BtnMonth.TabIndex = 2;
            this.p2BtnMonth.Text = "練習二:if else判斷月份 (隨機產生月份)";
            this.p2BtnMonth.UseVisualStyleBackColor = true;
            this.p2BtnMonth.Click += new System.EventHandler(this.p2BtnMonth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p2BtnMonth);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.p1BtnBMI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button p1BtnBMI;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button p2BtnMonth;
    }
}

