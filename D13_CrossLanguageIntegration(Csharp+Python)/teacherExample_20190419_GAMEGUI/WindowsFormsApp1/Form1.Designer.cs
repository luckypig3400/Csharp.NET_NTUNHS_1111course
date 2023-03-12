namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1_2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCase1 = new System.Windows.Forms.TextBox();
            this.button1_1 = new System.Windows.Forms.Button();
            this.label_elpased_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1_3 = new System.Windows.Forms.Button();
            this.label_start_time = new System.Windows.Forms.Label();
            this.label_end_time = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2_2 = new System.Windows.Forms.Button();
            this.button2_3 = new System.Windows.Forms.Button();
            this.button1_4 = new System.Windows.Forms.Button();
            this.button2_4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCase2 = new System.Windows.Forms.TextBox();
            this.button2_1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCase3 = new System.Windows.Forms.TextBox();
            this.button3_1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button4_1 = new System.Windows.Forms.Button();
            this.textBoxCase4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button3_4 = new System.Windows.Forms.Button();
            this.button3_3 = new System.Windows.Forms.Button();
            this.button3_2 = new System.Windows.Forms.Button();
            this.button4_4 = new System.Windows.Forms.Button();
            this.button4_3 = new System.Windows.Forms.Button();
            this.button4_2 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button5_1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.richTextBox_MSG = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_2
            // 
            this.button1_2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1_2.Location = new System.Drawing.Point(396, 16);
            this.button1_2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button1_2.Name = "button1_2";
            this.button1_2.Size = new System.Drawing.Size(101, 45);
            this.button1_2.TabIndex = 0;
            this.button1_2.Text = "Start";
            this.button1_2.UseVisualStyleBackColor = true;
            this.button1_2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 535);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 589);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 645);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Elapsed Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 40);
            this.label4.TabIndex = 5;
            this.label4.Text = "Case 1";
            // 
            // textBoxCase1
            // 
            this.textBoxCase1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxCase1.Location = new System.Drawing.Point(145, 16);
            this.textBoxCase1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBoxCase1.Name = "textBoxCase1";
            this.textBoxCase1.Size = new System.Drawing.Size(154, 43);
            this.textBoxCase1.TabIndex = 6;
            // 
            // button1_1
            // 
            this.button1_1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1_1.Location = new System.Drawing.Point(320, 16);
            this.button1_1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button1_1.Name = "button1_1";
            this.button1_1.Size = new System.Drawing.Size(63, 45);
            this.button1_1.TabIndex = 7;
            this.button1_1.Text = "...";
            this.button1_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1_1.UseVisualStyleBackColor = true;
            this.button1_1.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_elpased_time
            // 
            this.label_elpased_time.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_elpased_time.Location = new System.Drawing.Point(306, 645);
            this.label_elpased_time.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_elpased_time.Name = "label_elpased_time";
            this.label_elpased_time.Size = new System.Drawing.Size(379, 40);
            this.label_elpased_time.TabIndex = 8;
            this.label_elpased_time.Text = "0";
            this.label_elpased_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1_3
            // 
            this.button1_3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1_3.Location = new System.Drawing.Point(509, 16);
            this.button1_3.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button1_3.Name = "button1_3";
            this.button1_3.Size = new System.Drawing.Size(101, 45);
            this.button1_3.TabIndex = 11;
            this.button1_3.Text = "Stop";
            this.button1_3.UseVisualStyleBackColor = true;
            this.button1_3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_start_time
            // 
            this.label_start_time.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_start_time.Location = new System.Drawing.Point(299, 535);
            this.label_start_time.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_start_time.Name = "label_start_time";
            this.label_start_time.Size = new System.Drawing.Size(379, 40);
            this.label_start_time.TabIndex = 12;
            this.label_start_time.Text = "--";
            this.label_start_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_end_time
            // 
            this.label_end_time.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_end_time.Location = new System.Drawing.Point(306, 589);
            this.label_end_time.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_end_time.Name = "label_end_time";
            this.label_end_time.Size = new System.Drawing.Size(372, 40);
            this.label_end_time.TabIndex = 13;
            this.label_end_time.Text = "--";
            this.label_end_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 473);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 40);
            this.label8.TabIndex = 14;
            this.label8.Text = "Sample Group Size";
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxInterval.Location = new System.Drawing.Point(353, 473);
            this.textBoxInterval.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(142, 43);
            this.textBoxInterval.TabIndex = 15;
            this.textBoxInterval.Text = "10";
            this.textBoxInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Far;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(751, 16);
            this.chart1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Case1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Case2";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Case3";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Case4";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(803, 595);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // button2_2
            // 
            this.button2_2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2_2.Location = new System.Drawing.Point(396, 136);
            this.button2_2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button2_2.Name = "button2_2";
            this.button2_2.Size = new System.Drawing.Size(101, 45);
            this.button2_2.TabIndex = 18;
            this.button2_2.Text = "Start";
            this.button2_2.UseVisualStyleBackColor = true;
            this.button2_2.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2_3
            // 
            this.button2_3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2_3.Location = new System.Drawing.Point(509, 136);
            this.button2_3.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button2_3.Name = "button2_3";
            this.button2_3.Size = new System.Drawing.Size(101, 45);
            this.button2_3.TabIndex = 20;
            this.button2_3.Text = "Stop";
            this.button2_3.UseVisualStyleBackColor = true;
            this.button2_3.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1_4
            // 
            this.button1_4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1_4.Location = new System.Drawing.Point(621, 16);
            this.button1_4.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button1_4.Name = "button1_4";
            this.button1_4.Size = new System.Drawing.Size(119, 45);
            this.button1_4.TabIndex = 22;
            this.button1_4.Text = "Reset";
            this.button1_4.UseVisualStyleBackColor = true;
            this.button1_4.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2_4
            // 
            this.button2_4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2_4.Location = new System.Drawing.Point(621, 136);
            this.button2_4.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button2_4.Name = "button2_4";
            this.button2_4.Size = new System.Drawing.Size(119, 45);
            this.button2_4.TabIndex = 23;
            this.button2_4.Text = "Reset";
            this.button2_4.UseVisualStyleBackColor = true;
            this.button2_4.Click += new System.EventHandler(this.button8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 137);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 40);
            this.label9.TabIndex = 24;
            this.label9.Text = "Case 2";
            // 
            // textBoxCase2
            // 
            this.textBoxCase2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxCase2.Location = new System.Drawing.Point(145, 137);
            this.textBoxCase2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBoxCase2.Name = "textBoxCase2";
            this.textBoxCase2.Size = new System.Drawing.Size(154, 43);
            this.textBoxCase2.TabIndex = 25;
            // 
            // button2_1
            // 
            this.button2_1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2_1.Location = new System.Drawing.Point(320, 136);
            this.button2_1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button2_1.Name = "button2_1";
            this.button2_1.Size = new System.Drawing.Size(63, 45);
            this.button2_1.TabIndex = 26;
            this.button2_1.Text = "...";
            this.button2_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2_1.UseVisualStyleBackColor = true;
            this.button2_1.Click += new System.EventHandler(this.button4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 253);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 40);
            this.label10.TabIndex = 27;
            this.label10.Text = "Case 3";
            // 
            // textBoxCase3
            // 
            this.textBoxCase3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxCase3.Location = new System.Drawing.Point(145, 248);
            this.textBoxCase3.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBoxCase3.Name = "textBoxCase3";
            this.textBoxCase3.Size = new System.Drawing.Size(154, 43);
            this.textBoxCase3.TabIndex = 28;
            // 
            // button3_1
            // 
            this.button3_1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3_1.Location = new System.Drawing.Point(320, 248);
            this.button3_1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button3_1.Name = "button3_1";
            this.button3_1.Size = new System.Drawing.Size(63, 45);
            this.button3_1.TabIndex = 29;
            this.button3_1.Text = "...";
            this.button3_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3_1.UseVisualStyleBackColor = true;
            this.button3_1.Click += new System.EventHandler(this.button9_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 364);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 40);
            this.label11.TabIndex = 30;
            this.label11.Text = "Case 4";
            // 
            // button4_1
            // 
            this.button4_1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4_1.Location = new System.Drawing.Point(320, 357);
            this.button4_1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button4_1.Name = "button4_1";
            this.button4_1.Size = new System.Drawing.Size(63, 45);
            this.button4_1.TabIndex = 32;
            this.button4_1.Text = "...";
            this.button4_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4_1.UseVisualStyleBackColor = true;
            this.button4_1.Click += new System.EventHandler(this.Button10_Click);
            // 
            // textBoxCase4
            // 
            this.textBoxCase4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxCase4.Location = new System.Drawing.Point(145, 357);
            this.textBoxCase4.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBoxCase4.Name = "textBoxCase4";
            this.textBoxCase4.Size = new System.Drawing.Size(154, 43);
            this.textBoxCase4.TabIndex = 31;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox6.Location = new System.Drawing.Point(145, 75);
            this.textBox6.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(591, 43);
            this.textBox6.TabIndex = 33;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox7.Location = new System.Drawing.Point(145, 195);
            this.textBox7.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(591, 43);
            this.textBox7.TabIndex = 34;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox8.Location = new System.Drawing.Point(145, 301);
            this.textBox8.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(591, 43);
            this.textBox8.TabIndex = 35;
            // 
            // button3_4
            // 
            this.button3_4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3_4.Location = new System.Drawing.Point(621, 247);
            this.button3_4.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button3_4.Name = "button3_4";
            this.button3_4.Size = new System.Drawing.Size(119, 45);
            this.button3_4.TabIndex = 38;
            this.button3_4.Text = "Reset";
            this.button3_4.UseVisualStyleBackColor = true;
            this.button3_4.Click += new System.EventHandler(this.Button11_Click);
            // 
            // button3_3
            // 
            this.button3_3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3_3.Location = new System.Drawing.Point(509, 247);
            this.button3_3.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button3_3.Name = "button3_3";
            this.button3_3.Size = new System.Drawing.Size(101, 45);
            this.button3_3.TabIndex = 37;
            this.button3_3.Text = "Stop";
            this.button3_3.UseVisualStyleBackColor = true;
            this.button3_3.Click += new System.EventHandler(this.Button12_Click);
            // 
            // button3_2
            // 
            this.button3_2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3_2.Location = new System.Drawing.Point(396, 247);
            this.button3_2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button3_2.Name = "button3_2";
            this.button3_2.Size = new System.Drawing.Size(101, 45);
            this.button3_2.TabIndex = 36;
            this.button3_2.Text = "Start";
            this.button3_2.UseVisualStyleBackColor = true;
            this.button3_2.Click += new System.EventHandler(this.Button13_Click);
            // 
            // button4_4
            // 
            this.button4_4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4_4.Location = new System.Drawing.Point(621, 357);
            this.button4_4.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button4_4.Name = "button4_4";
            this.button4_4.Size = new System.Drawing.Size(119, 45);
            this.button4_4.TabIndex = 41;
            this.button4_4.Text = "Reset";
            this.button4_4.UseVisualStyleBackColor = true;
            this.button4_4.Click += new System.EventHandler(this.Button14_Click);
            // 
            // button4_3
            // 
            this.button4_3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4_3.Location = new System.Drawing.Point(509, 357);
            this.button4_3.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button4_3.Name = "button4_3";
            this.button4_3.Size = new System.Drawing.Size(101, 45);
            this.button4_3.TabIndex = 40;
            this.button4_3.Text = "Stop";
            this.button4_3.UseVisualStyleBackColor = true;
            this.button4_3.Click += new System.EventHandler(this.Button15_Click);
            // 
            // button4_2
            // 
            this.button4_2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4_2.Location = new System.Drawing.Point(396, 357);
            this.button4_2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button4_2.Name = "button4_2";
            this.button4_2.Size = new System.Drawing.Size(101, 45);
            this.button4_2.TabIndex = 39;
            this.button4_2.Text = "Start";
            this.button4_2.UseVisualStyleBackColor = true;
            this.button4_2.Click += new System.EventHandler(this.Button16_Click);
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox9.Location = new System.Drawing.Point(145, 414);
            this.textBox9.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(591, 43);
            this.textBox9.TabIndex = 42;
            // 
            // button5_1
            // 
            this.button5_1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5_1.Location = new System.Drawing.Point(509, 473);
            this.button5_1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button5_1.Name = "button5_1";
            this.button5_1.Size = new System.Drawing.Size(228, 45);
            this.button5_1.TabIndex = 43;
            this.button5_1.Text = "Redraw Chart";
            this.button5_1.UseVisualStyleBackColor = true;
            this.button5_1.Click += new System.EventHandler(this.button17_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(751, 620);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1141, 620);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(413, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // richTextBox_MSG
            // 
            this.richTextBox_MSG.Location = new System.Drawing.Point(1586, 83);
            this.richTextBox_MSG.Name = "richTextBox_MSG";
            this.richTextBox_MSG.Size = new System.Drawing.Size(327, 602);
            this.richTextBox_MSG.TabIndex = 46;
            this.richTextBox_MSG.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1579, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 40);
            this.label12.TabIndex = 47;
            this.label12.Text = "Debug Msg";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 700);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.richTextBox_MSG);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5_1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.button4_4);
            this.Controls.Add(this.button4_3);
            this.Controls.Add(this.button4_2);
            this.Controls.Add(this.button3_4);
            this.Controls.Add(this.button3_3);
            this.Controls.Add(this.button3_2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button4_1);
            this.Controls.Add(this.textBoxCase4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3_1);
            this.Controls.Add(this.textBoxCase3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2_1);
            this.Controls.Add(this.textBoxCase2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2_4);
            this.Controls.Add(this.button1_4);
            this.Controls.Add(this.button2_3);
            this.Controls.Add(this.button2_2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBoxInterval);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_end_time);
            this.Controls.Add(this.label_start_time);
            this.Controls.Add(this.button1_3);
            this.Controls.Add(this.label_elpased_time);
            this.Controls.Add(this.button1_1);
            this.Controls.Add(this.textBoxCase1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "北護資管網路動態實驗室";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCase1;
        private System.Windows.Forms.Button button1_1;
        private System.Windows.Forms.Label label_elpased_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1_3;
        private System.Windows.Forms.Label label_start_time;
        private System.Windows.Forms.Label label_end_time;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button2_2;
        private System.Windows.Forms.Button button2_3;
        private System.Windows.Forms.Button button1_4;
        private System.Windows.Forms.Button button2_4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCase2;
        private System.Windows.Forms.Button button2_1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCase3;
        private System.Windows.Forms.Button button3_1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4_1;
        private System.Windows.Forms.TextBox textBoxCase4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button3_4;
        private System.Windows.Forms.Button button3_3;
        private System.Windows.Forms.Button button3_2;
        private System.Windows.Forms.Button button4_4;
        private System.Windows.Forms.Button button4_3;
        private System.Windows.Forms.Button button4_2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button5_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richTextBox_MSG;
        private System.Windows.Forms.Label label12;
    }
}

