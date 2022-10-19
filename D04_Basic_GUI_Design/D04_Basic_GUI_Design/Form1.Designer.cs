namespace D04_Basic_GUI_Design
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputDataBtn = new System.Windows.Forms.Button();
            this.outputDataBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputDataBtn
            // 
            this.inputDataBtn.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.inputDataBtn.Location = new System.Drawing.Point(25, 588);
            this.inputDataBtn.Name = "inputDataBtn";
            this.inputDataBtn.Size = new System.Drawing.Size(147, 54);
            this.inputDataBtn.TabIndex = 0;
            this.inputDataBtn.Text = "輸入資料";
            this.inputDataBtn.UseVisualStyleBackColor = true;
            // 
            // outputDataBtn
            // 
            this.outputDataBtn.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputDataBtn.Location = new System.Drawing.Point(195, 588);
            this.outputDataBtn.Name = "outputDataBtn";
            this.outputDataBtn.Size = new System.Drawing.Size(147, 54);
            this.outputDataBtn.TabIndex = 1;
            this.outputDataBtn.Text = "輸出資料";
            this.outputDataBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.outputDataBtn);
            this.Controls.Add(this.inputDataBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inputDataBtn;
        private System.Windows.Forms.Button outputDataBtn;
    }
}

