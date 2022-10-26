namespace D05_Multiple_Forms_Design
{
    partial class MdiFormMain
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
            this.mDI子視窗1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mDI子視窗2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.視窗Form的排版ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平排列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直排列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mDI子視窗1ToolStripMenuItem,
            this.mDI子視窗2ToolStripMenuItem,
            this.視窗Form的排版ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mDI子視窗1ToolStripMenuItem
            // 
            this.mDI子視窗1ToolStripMenuItem.Name = "mDI子視窗1ToolStripMenuItem";
            this.mDI子視窗1ToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.mDI子視窗1ToolStripMenuItem.Text = "MDI子視窗1";
            this.mDI子視窗1ToolStripMenuItem.Click += new System.EventHandler(this.mDI子視窗1ToolStripMenuItem_Click);
            // 
            // mDI子視窗2ToolStripMenuItem
            // 
            this.mDI子視窗2ToolStripMenuItem.Name = "mDI子視窗2ToolStripMenuItem";
            this.mDI子視窗2ToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.mDI子視窗2ToolStripMenuItem.Text = "MDI子視窗2";
            this.mDI子視窗2ToolStripMenuItem.Click += new System.EventHandler(this.mDI子視窗2ToolStripMenuItem_Click);
            // 
            // 視窗Form的排版ToolStripMenuItem
            // 
            this.視窗Form的排版ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.水平排列ToolStripMenuItem,
            this.垂直排列ToolStripMenuItem});
            this.視窗Form的排版ToolStripMenuItem.Name = "視窗Form的排版ToolStripMenuItem";
            this.視窗Form的排版ToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.視窗Form的排版ToolStripMenuItem.Text = "視窗(Form)的排版";
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
            // MdiFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MdiFormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MdiFormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mDI子視窗1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mDI子視窗2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 視窗Form的排版ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平排列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直排列ToolStripMenuItem;
    }
}