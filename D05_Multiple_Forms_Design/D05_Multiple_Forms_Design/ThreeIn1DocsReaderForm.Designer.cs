namespace D05_Multiple_Forms_Design
{
    partial class ThreeIn1DocsReaderForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.打開PDF閱讀器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打開Word閱讀器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打開Excel閱讀器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.子視窗排列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平排列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直排列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打開PDF閱讀器ToolStripMenuItem,
            this.打開Word閱讀器ToolStripMenuItem,
            this.打開Excel閱讀器ToolStripMenuItem,
            this.子視窗排列ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 打開PDF閱讀器ToolStripMenuItem
            // 
            this.打開PDF閱讀器ToolStripMenuItem.Name = "打開PDF閱讀器ToolStripMenuItem";
            this.打開PDF閱讀器ToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.打開PDF閱讀器ToolStripMenuItem.Text = "打開PDF閱讀器";
            this.打開PDF閱讀器ToolStripMenuItem.Click += new System.EventHandler(this.打開PDF閱讀器ToolStripMenuItem_Click);
            // 
            // 打開Word閱讀器ToolStripMenuItem
            // 
            this.打開Word閱讀器ToolStripMenuItem.Name = "打開Word閱讀器ToolStripMenuItem";
            this.打開Word閱讀器ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.打開Word閱讀器ToolStripMenuItem.Text = "打開Word閱讀器";
            this.打開Word閱讀器ToolStripMenuItem.Click += new System.EventHandler(this.打開Word閱讀器ToolStripMenuItem_Click);
            // 
            // 打開Excel閱讀器ToolStripMenuItem
            // 
            this.打開Excel閱讀器ToolStripMenuItem.Name = "打開Excel閱讀器ToolStripMenuItem";
            this.打開Excel閱讀器ToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.打開Excel閱讀器ToolStripMenuItem.Text = "打開Excel閱讀器";
            this.打開Excel閱讀器ToolStripMenuItem.Click += new System.EventHandler(this.打開Excel閱讀器ToolStripMenuItem_Click);
            // 
            // 子視窗排列ToolStripMenuItem
            // 
            this.子視窗排列ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.水平排列ToolStripMenuItem,
            this.垂直排列ToolStripMenuItem});
            this.子視窗排列ToolStripMenuItem.Name = "子視窗排列ToolStripMenuItem";
            this.子視窗排列ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.子視窗排列ToolStripMenuItem.Text = "子視窗排列";
            // 
            // 水平排列ToolStripMenuItem
            // 
            this.水平排列ToolStripMenuItem.Name = "水平排列ToolStripMenuItem";
            this.水平排列ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.水平排列ToolStripMenuItem.Text = "水平排列";
            this.水平排列ToolStripMenuItem.Click += new System.EventHandler(this.水平排列ToolStripMenuItem_Click);
            // 
            // 垂直排列ToolStripMenuItem
            // 
            this.垂直排列ToolStripMenuItem.Name = "垂直排列ToolStripMenuItem";
            this.垂直排列ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.垂直排列ToolStripMenuItem.Text = "垂直排列";
            this.垂直排列ToolStripMenuItem.Click += new System.EventHandler(this.垂直排列ToolStripMenuItem_Click);
            // 
            // ThreeIn1DocsReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ThreeIn1DocsReaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThreeIn1DocsReaderForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打開PDF閱讀器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打開Word閱讀器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打開Excel閱讀器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 子視窗排列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平排列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直排列ToolStripMenuItem;
    }
}