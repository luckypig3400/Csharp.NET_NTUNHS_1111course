using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace D10_1_Read_Write_Excel_CSV_JSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void outputExcelBTN_Click(object sender, EventArgs e)
        {
            // 如果出現類似以下的錯誤可以嘗試安裝WPS或是手動更改註冊碼試試看
            // 無法將類型爲“Microsoft.Office.Interop.Excel.ApplicationClass”的 COM 對象強制轉換爲接口類型“Microsoft.Office.Interop.Excel._Application”。此操作失敗的原因是對 IID 爲“{ 000208D5 - 0000 - 0000 - C000 - 000000000046}”的接口的 COM 組件調用 QueryInterface 因以下錯誤而失敗: 庫沒有註冊。 (異常來自 HRESULT: 0x8002801D(TYPE_E_LIBNOTREGISTERED))。
            // 巴哈 C# Excel 輸出異常排除方法:https://home.gamer.com.tw/creationDetail.php?sn=4763231
            // 更改註冊碼: https://www.cnblogs.com/beginner-boy/p/7998017.html

            // Excel 物件
            Excel.Application xls = null; // 新增一個excel應用程式
            try
            {
                // 打開excel應用程式
                xls = new Excel.Application();

                // 新增第一個sheet(工作表)
                // Excel WorkBook
                Excel.Workbook book = xls.Workbooks.Add();
                //Excel.Worksheet Sheet = (Excel.Worksheet)book.Worksheets[1];

                // 這個新增的工作表，設成預設工作表(一打開excel，先看這個工作表)
                Excel.Worksheet Sheet = xls.ActiveSheet;


                // 把資料塞進 Excel 內

                // 標題 Sheet.Cells[y,x] 資料
                Sheet.Cells[1, 1] = "體重範圍";
                Sheet.Cells[1, 2] = "人數";

                // 內容
                for (int k = 1; k < 10; k++)
                {
                    Sheet.Cells[k + 1, 1] = k;
                    Sheet.Cells[k + 1, 2] = 2 * k;
                }

                // 新增第二個sheet，放到最後一個
                // Excel WorkBook
                Excel.Worksheet Sheet2 = book.Sheets.Add(After: book.Sheets[book.Sheets.Count]);
                Sheet2.Name = "1234";
                // 把資料塞進 Excel 內

                // 標題
                Sheet2.Cells[1, 1] = "身高範圍";
                Sheet2.Cells[1, 2] = "學生統計";

                // 內容
                for (int k = 11; k < 110; k++)
                {
                    Sheet2.Cells[k + 1, 1] = k;
                    Sheet2.Cells[k + 1, 2] = 2 * k;
                }

                // 新增第三個sheet，放到第一個
                // Excel WorkBook
                Excel.Worksheet Sheet3 = book.Sheets.Add(Before: book.Sheets[1]);
                Sheet3.Name = "第0頁";
                // 把資料塞進 Excel 內

                // 標題
                Sheet3.Cells[1, 1] = "我是第一頁";
                Sheet3.Cells[1, 2] = "哇哈哈";

                // 修改第三頁sheet
                // book.Sheets[3] => 第3頁工作表
                // Cell[4,5] 修改y=4, x=5的資料
                book.Sheets[3].Cells[4, 5] = "補充說明";

                // 儲存檔案
                // 設定儲存excel檔的位置
                SaveFileDialog save = new SaveFileDialog(); //新增存檔的視窗
                                                            // 檔案優先存在桌面
                save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                // 檔案名稱優先設定為Export_Chart_Data
                save.FileName = "Export_Chart_Data";
                // 副檔案名稱優先設定為xlsx
                save.Filter = "*.xlsx|*.xlsx";
                //跳出新增存檔的視窗
                if (save.ShowDialog() != DialogResult.OK) return;
                //把excel存到檔案裡
                book.SaveAs(save.FileName);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                xls.Quit();
            }
        }
    }
}
