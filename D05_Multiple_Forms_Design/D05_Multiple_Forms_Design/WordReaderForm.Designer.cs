namespace D05_Multiple_Forms_Design
{
    partial class WordReaderForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openWordBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 577);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // openWordBtn
            // 
            this.openWordBtn.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.openWordBtn.Location = new System.Drawing.Point(266, 599);
            this.openWordBtn.Name = "openWordBtn";
            this.openWordBtn.Size = new System.Drawing.Size(269, 62);
            this.openWordBtn.TabIndex = 1;
            this.openWordBtn.Text = "打開Word文件";
            this.openWordBtn.UseVisualStyleBackColor = true;
            // 
            // WordReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 673);
            this.Controls.Add(this.openWordBtn);
            this.Controls.Add(this.richTextBox1);
            this.Name = "WordReaderForm";
            this.Text = "WordReaderForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button openWordBtn;
    }
}