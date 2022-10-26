namespace D05_Multiple_Forms_Design
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pdfReaderBtn = new System.Windows.Forms.Button();
            this.wordReaderBtn = new System.Windows.Forms.Button();
            this.excelReaderBtn = new System.Windows.Forms.Button();
            this.mdiBtn = new System.Windows.Forms.Button();
            this.ThreeIn1DocsReaderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(776, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "兩個Form獨立操作互不影響";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(12, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(776, 106);
            this.button2.TabIndex = 1;
            this.button2.Text = "鎖定第一個視窗，只能操作第二個視窗，關閉第二個後才能操作第一個";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pdfReaderBtn
            // 
            this.pdfReaderBtn.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pdfReaderBtn.Location = new System.Drawing.Point(12, 322);
            this.pdfReaderBtn.Name = "pdfReaderBtn";
            this.pdfReaderBtn.Size = new System.Drawing.Size(156, 116);
            this.pdfReaderBtn.TabIndex = 2;
            this.pdfReaderBtn.Text = "打開PDF閱讀器";
            this.pdfReaderBtn.UseVisualStyleBackColor = true;
            this.pdfReaderBtn.Click += new System.EventHandler(this.pdfReaderBtn_Click);
            // 
            // wordReaderBtn
            // 
            this.wordReaderBtn.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.wordReaderBtn.Location = new System.Drawing.Point(188, 322);
            this.wordReaderBtn.Name = "wordReaderBtn";
            this.wordReaderBtn.Size = new System.Drawing.Size(174, 116);
            this.wordReaderBtn.TabIndex = 3;
            this.wordReaderBtn.Text = "打開Word文件閱讀器";
            this.wordReaderBtn.UseVisualStyleBackColor = true;
            this.wordReaderBtn.Click += new System.EventHandler(this.wordReaderBtn_Click);
            // 
            // excelReaderBtn
            // 
            this.excelReaderBtn.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.excelReaderBtn.Location = new System.Drawing.Point(386, 322);
            this.excelReaderBtn.Name = "excelReaderBtn";
            this.excelReaderBtn.Size = new System.Drawing.Size(174, 116);
            this.excelReaderBtn.TabIndex = 4;
            this.excelReaderBtn.Text = "打開Excel文件閱讀器";
            this.excelReaderBtn.UseVisualStyleBackColor = true;
            this.excelReaderBtn.Click += new System.EventHandler(this.excelReaderBtn_Click);
            // 
            // mdiBtn
            // 
            this.mdiBtn.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mdiBtn.Location = new System.Drawing.Point(580, 322);
            this.mdiBtn.Name = "mdiBtn";
            this.mdiBtn.Size = new System.Drawing.Size(208, 116);
            this.mdiBtn.TabIndex = 5;
            this.mdiBtn.Text = "打開多重文件介面(MDI)";
            this.mdiBtn.UseVisualStyleBackColor = true;
            this.mdiBtn.Click += new System.EventHandler(this.mdiBtn_Click);
            // 
            // ThreeIn1DocsReaderBtn
            // 
            this.ThreeIn1DocsReaderBtn.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ThreeIn1DocsReaderBtn.Location = new System.Drawing.Point(12, 226);
            this.ThreeIn1DocsReaderBtn.Name = "ThreeIn1DocsReaderBtn";
            this.ThreeIn1DocsReaderBtn.Size = new System.Drawing.Size(776, 70);
            this.ThreeIn1DocsReaderBtn.TabIndex = 6;
            this.ThreeIn1DocsReaderBtn.Text = "三合一各類文件閱讀器";
            this.ThreeIn1DocsReaderBtn.UseVisualStyleBackColor = true;
            this.ThreeIn1DocsReaderBtn.Click += new System.EventHandler(this.ThreeIn1DocsReaderBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ThreeIn1DocsReaderBtn);
            this.Controls.Add(this.mdiBtn);
            this.Controls.Add(this.excelReaderBtn);
            this.Controls.Add(this.wordReaderBtn);
            this.Controls.Add(this.pdfReaderBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D05 Main Window";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button pdfReaderBtn;
        private System.Windows.Forms.Button wordReaderBtn;
        private System.Windows.Forms.Button excelReaderBtn;
        private System.Windows.Forms.Button mdiBtn;
        private System.Windows.Forms.Button ThreeIn1DocsReaderBtn;
    }
}

