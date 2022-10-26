using System;
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
    public partial class WordReaderForm : Form
    {
        public WordReaderForm()
        {
            InitializeComponent();
        }

        private void openWordBtn_Click(object sender, EventArgs e)
        {
            // 找出Word檔案位置
            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.Title = "Select Word File";
            fileDlg.InitialDirectory = ".\\";
            fileDlg.Filter = "word files (*.*)|*.docx";
            string word_path = "";
            if(fileDlg.ShowDialog() == DialogResult.OK)
            {
                word_path = fileDlg.FileName;
            }

            // 打開Word檔案
            object readOnly = false;
            object visible = true;
            object save = false;
            object fileName = word_path;
            object newTemplate = false;
            object docType = 0;
            object missing = Type.Missing;
            Microsoft.Office.Interop.Word._Document document;
            Microsoft.Office.Interop.Word._Application application = new
            Microsoft.Office.Interop.Word.Application()
            { Visible = false };
            document = application.Documents.Open(ref fileName, ref missing, ref readOnly,
            ref missing, ref missing, ref missing,
            ref missing, ref missing, ref missing,
            ref missing, ref missing, ref visible,
            ref missing, ref missing, ref missing,
            ref missing);
            document.ActiveWindow.Selection.WholeStory();
            document.ActiveWindow.Selection.Copy();
            IDataObject dataObject = Clipboard.GetDataObject();
            
            // 將word檔顯示在rich text box
            richTextBox1.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
            
            // 關掉視窗時，把word也關掉
            application.Quit(ref missing, ref missing, ref missing);
        }
    }
}
