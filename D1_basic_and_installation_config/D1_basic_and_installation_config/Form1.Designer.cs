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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.helloWordButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button helloWordButton;
    }
}

