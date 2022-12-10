namespace D10_1_Read_Write_Excel_CSV_JSON
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
            this.outputExcelBTN = new System.Windows.Forms.Button();
            this.readExcelBTN = new System.Windows.Forms.Button();
            this.readCsvBTN = new System.Windows.Forms.Button();
            this.outputCsvBTN = new System.Windows.Forms.Button();
            this.readJsonBTN = new System.Windows.Forms.Button();
            this.outputJsonBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputExcelBTN
            // 
            this.outputExcelBTN.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputExcelBTN.Location = new System.Drawing.Point(140, 41);
            this.outputExcelBTN.Name = "outputExcelBTN";
            this.outputExcelBTN.Size = new System.Drawing.Size(198, 86);
            this.outputExcelBTN.TabIndex = 0;
            this.outputExcelBTN.Text = "Output Excel";
            this.outputExcelBTN.UseVisualStyleBackColor = true;
            // 
            // readExcelBTN
            // 
            this.readExcelBTN.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.readExcelBTN.Location = new System.Drawing.Point(462, 41);
            this.readExcelBTN.Name = "readExcelBTN";
            this.readExcelBTN.Size = new System.Drawing.Size(198, 86);
            this.readExcelBTN.TabIndex = 1;
            this.readExcelBTN.Text = "Read Excel";
            this.readExcelBTN.UseVisualStyleBackColor = true;
            // 
            // readCsvBTN
            // 
            this.readCsvBTN.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.readCsvBTN.Location = new System.Drawing.Point(462, 182);
            this.readCsvBTN.Name = "readCsvBTN";
            this.readCsvBTN.Size = new System.Drawing.Size(198, 86);
            this.readCsvBTN.TabIndex = 3;
            this.readCsvBTN.Text = "Read CSV";
            this.readCsvBTN.UseVisualStyleBackColor = true;
            // 
            // outputCsvBTN
            // 
            this.outputCsvBTN.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputCsvBTN.Location = new System.Drawing.Point(140, 182);
            this.outputCsvBTN.Name = "outputCsvBTN";
            this.outputCsvBTN.Size = new System.Drawing.Size(198, 86);
            this.outputCsvBTN.TabIndex = 2;
            this.outputCsvBTN.Text = "Output CSV";
            this.outputCsvBTN.UseVisualStyleBackColor = true;
            // 
            // readJsonBTN
            // 
            this.readJsonBTN.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.readJsonBTN.Location = new System.Drawing.Point(462, 323);
            this.readJsonBTN.Name = "readJsonBTN";
            this.readJsonBTN.Size = new System.Drawing.Size(198, 86);
            this.readJsonBTN.TabIndex = 5;
            this.readJsonBTN.Text = "Read JSON";
            this.readJsonBTN.UseVisualStyleBackColor = true;
            // 
            // outputJsonBTN
            // 
            this.outputJsonBTN.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputJsonBTN.Location = new System.Drawing.Point(140, 323);
            this.outputJsonBTN.Name = "outputJsonBTN";
            this.outputJsonBTN.Size = new System.Drawing.Size(198, 86);
            this.outputJsonBTN.TabIndex = 4;
            this.outputJsonBTN.Text = "Output JSON";
            this.outputJsonBTN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.readJsonBTN);
            this.Controls.Add(this.outputJsonBTN);
            this.Controls.Add(this.readCsvBTN);
            this.Controls.Add(this.outputCsvBTN);
            this.Controls.Add(this.readExcelBTN);
            this.Controls.Add(this.outputExcelBTN);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button outputExcelBTN;
        private System.Windows.Forms.Button readExcelBTN;
        private System.Windows.Forms.Button readCsvBTN;
        private System.Windows.Forms.Button outputCsvBTN;
        private System.Windows.Forms.Button readJsonBTN;
        private System.Windows.Forms.Button outputJsonBTN;
    }
}

