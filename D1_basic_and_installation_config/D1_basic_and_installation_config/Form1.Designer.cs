namespace D1_basic_and_installation_config
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
            this.helloWordButton = new System.Windows.Forms.Button();
            this.practice1Btn = new System.Windows.Forms.Button();
            this.practice2Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloWordButton
            // 
            this.helloWordButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.helloWordButton.Location = new System.Drawing.Point(310, 177);
            this.helloWordButton.Name = "helloWordButton";
            this.helloWordButton.Size = new System.Drawing.Size(177, 92);
            this.helloWordButton.TabIndex = 0;
            this.helloWordButton.Text = "Please Click Me";
            this.helloWordButton.UseVisualStyleBackColor = true;
            this.helloWordButton.Click += new System.EventHandler(this.helloWorldButton_Click);
            // 
            // practice1Btn
            // 
            this.practice1Btn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.practice1Btn.Location = new System.Drawing.Point(80, 56);
            this.practice1Btn.Name = "practice1Btn";
            this.practice1Btn.Size = new System.Drawing.Size(89, 47);
            this.practice1Btn.TabIndex = 1;
            this.practice1Btn.Text = "練習1";
            this.practice1Btn.UseVisualStyleBackColor = true;
            this.practice1Btn.Click += new System.EventHandler(this.practice1Btn_Click);
            // 
            // practice2Btn
            // 
            this.practice2Btn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.practice2Btn.Location = new System.Drawing.Point(80, 181);
            this.practice2Btn.Name = "practice2Btn";
            this.practice2Btn.Size = new System.Drawing.Size(89, 81);
            this.practice2Btn.TabIndex = 2;
            this.practice2Btn.Text = "練習2 顯示我的BMI";
            this.practice2Btn.UseVisualStyleBackColor = true;
            this.practice2Btn.Click += new System.EventHandler(this.practice2Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.practice2Btn);
            this.Controls.Add(this.practice1Btn);
            this.Controls.Add(this.helloWordButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button helloWordButton;
        private System.Windows.Forms.Button practice1Btn;
        private System.Windows.Forms.Button practice2Btn;
    }
}

