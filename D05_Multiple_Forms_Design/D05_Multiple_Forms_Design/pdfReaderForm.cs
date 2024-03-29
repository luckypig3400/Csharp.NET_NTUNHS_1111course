﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D05_Multiple_Forms_Design
{
    public partial class pdfReaderForm : Form
    {
        public pdfReaderForm()
        {
            InitializeComponent();
        }

        private void openPDFbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();

            // set file filter of dialog
            fileDlg.Filter = "pdf files (*.pdf) |*.pdf;";
            fileDlg.ShowDialog();

            if(fileDlg.FileName != null)
            {
                // 讀取PDF
                axAcroPDF1.LoadFile(fileDlg.FileName);
            }
        }
    }
}
