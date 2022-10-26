namespace D05_Multiple_Forms_Design
{
    partial class pdfReaderForm
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
            this.openPDFbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openPDFbtn
            // 
            this.openPDFbtn.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.openPDFbtn.Location = new System.Drawing.Point(298, 383);
            this.openPDFbtn.Name = "openPDFbtn";
            this.openPDFbtn.Size = new System.Drawing.Size(221, 55);
            this.openPDFbtn.TabIndex = 0;
            this.openPDFbtn.Text = "打開PDF";
            this.openPDFbtn.UseVisualStyleBackColor = true;
            // 
            // pdfReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openPDFbtn);
            this.Name = "pdfReaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pdfReaderForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openPDFbtn;
    }
}