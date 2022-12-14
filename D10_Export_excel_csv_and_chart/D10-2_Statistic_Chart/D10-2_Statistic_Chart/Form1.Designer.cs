namespace D10_2_Statistic_Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.drawChartBTN = new System.Windows.Forms.Button();
            this.exportImageBTN = new System.Windows.Forms.Button();
            this.exportExcelBTN = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // drawChartBTN
            // 
            this.drawChartBTN.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.drawChartBTN.Location = new System.Drawing.Point(12, 472);
            this.drawChartBTN.Name = "drawChartBTN";
            this.drawChartBTN.Size = new System.Drawing.Size(240, 69);
            this.drawChartBTN.TabIndex = 0;
            this.drawChartBTN.Text = "繪圖";
            this.drawChartBTN.UseVisualStyleBackColor = true;
            this.drawChartBTN.Click += new System.EventHandler(this.drawChartBTN_Click);
            // 
            // exportImageBTN
            // 
            this.exportImageBTN.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exportImageBTN.Location = new System.Drawing.Point(270, 472);
            this.exportImageBTN.Name = "exportImageBTN";
            this.exportImageBTN.Size = new System.Drawing.Size(240, 69);
            this.exportImageBTN.TabIndex = 1;
            this.exportImageBTN.Text = "匯出圖片";
            this.exportImageBTN.UseVisualStyleBackColor = true;
            this.exportImageBTN.Click += new System.EventHandler(this.exportImageBTN_Click);
            // 
            // exportExcelBTN
            // 
            this.exportExcelBTN.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exportExcelBTN.Location = new System.Drawing.Point(530, 472);
            this.exportExcelBTN.Name = "exportExcelBTN";
            this.exportExcelBTN.Size = new System.Drawing.Size(240, 69);
            this.exportExcelBTN.TabIndex = 2;
            this.exportExcelBTN.Text = "匯出Excel";
            this.exportExcelBTN.UseVisualStyleBackColor = true;
            this.exportExcelBTN.Click += new System.EventHandler(this.exportExcelBTN_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Label = "#VAL";
            series2.Legend = "Legend1";
            series2.Name = "stocks";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(758, 454);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.exportExcelBTN);
            this.Controls.Add(this.exportImageBTN);
            this.Controls.Add(this.drawChartBTN);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button drawChartBTN;
        private System.Windows.Forms.Button exportImageBTN;
        private System.Windows.Forms.Button exportExcelBTN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

