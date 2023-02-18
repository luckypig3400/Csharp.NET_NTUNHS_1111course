namespace D13_CrossLanguageIntegration_Csharp_Python_
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.loadPythonScriptBTN = new System.Windows.Forms.Button();
            this.runPythonScriptBTN = new System.Windows.Forms.Button();
            this.stopPythonScriptBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(760, 273);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 355);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(760, 394);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // loadPythonScriptBTN
            // 
            this.loadPythonScriptBTN.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loadPythonScriptBTN.Location = new System.Drawing.Point(12, 291);
            this.loadPythonScriptBTN.Name = "loadPythonScriptBTN";
            this.loadPythonScriptBTN.Size = new System.Drawing.Size(215, 42);
            this.loadPythonScriptBTN.TabIndex = 2;
            this.loadPythonScriptBTN.Text = "Load Python Script";
            this.loadPythonScriptBTN.UseVisualStyleBackColor = true;
            // 
            // runPythonScriptBTN
            // 
            this.runPythonScriptBTN.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.runPythonScriptBTN.Location = new System.Drawing.Point(282, 291);
            this.runPythonScriptBTN.Name = "runPythonScriptBTN";
            this.runPythonScriptBTN.Size = new System.Drawing.Size(215, 42);
            this.runPythonScriptBTN.TabIndex = 3;
            this.runPythonScriptBTN.Text = "Run Script";
            this.runPythonScriptBTN.UseVisualStyleBackColor = true;
            // 
            // stopPythonScriptBTN
            // 
            this.stopPythonScriptBTN.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stopPythonScriptBTN.Location = new System.Drawing.Point(557, 291);
            this.stopPythonScriptBTN.Name = "stopPythonScriptBTN";
            this.stopPythonScriptBTN.Size = new System.Drawing.Size(215, 42);
            this.stopPythonScriptBTN.TabIndex = 4;
            this.stopPythonScriptBTN.Text = "Stop Script";
            this.stopPythonScriptBTN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.stopPythonScriptBTN);
            this.Controls.Add(this.runPythonScriptBTN);
            this.Controls.Add(this.loadPythonScriptBTN);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button loadPythonScriptBTN;
        private System.Windows.Forms.Button runPythonScriptBTN;
        private System.Windows.Forms.Button stopPythonScriptBTN;
    }
}

