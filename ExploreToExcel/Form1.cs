using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace ExploreToExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            string connetionStr = this.richTextBox1.Text;
            string queryScript = this.richTextBox2.Text;
           DataTable dt=SQLHelper.GetDataSet(connetionStr,queryScript);

            XSSFWorkbook book = new XSSFWorkbook();
            int fristNum = 1;
            ISheet sheet = book.CreateSheet("sheet1");
            NPOI.SS.UserModel.ICellStyle style = book.CreateCellStyle();
            NPOI.SS.UserModel.IRow headerrow = sheet.CreateRow(0);
            ICell cell_1 = headerrow.CreateCell(0);
            cell_1.CellStyle = style;
            cell_1.SetCellValue("Name");
            ICell cell_2 = headerrow.CreateCell(1);
            cell_2.CellStyle = style;
            cell_2.SetCellValue("FSourceUrl");
            ICell cell_3 = headerrow.CreateCell(2);
            cell_3.CellStyle = style;
            cell_3.SetCellValue("FVisitTime");
           
            int splitNum = 500000;

            int j = 1;
            bool newBook = false;
            // int lessNum = dt.Rows.Count % splitNum;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (newBook)
                {
                    book = new XSSFWorkbook();
                    sheet = book.CreateSheet("sheet1");
                    style = book.CreateCellStyle();
                    headerrow = sheet.CreateRow(0);
                    cell_1 = headerrow.CreateCell(0);
                    cell_1.CellStyle = style;
                    cell_1.SetCellValue("Name");
                    cell_2 = headerrow.CreateCell(1);
                    cell_2.CellStyle = style;
                    cell_2.SetCellValue("FSourceUrl");
                    cell_3 = headerrow.CreateCell(2);
                    cell_3.CellStyle = style;
                    cell_3.SetCellValue("FVisitTime");
                }

                if (i <= splitNum * j)
                {
                    newBook = false;

                    NPOI.SS.UserModel.IRow headerrow_1 = sheet.CreateRow(i + fristNum - splitNum * (j - 1));
                    ICell cell_1_1 = headerrow_1.CreateCell(0);
                    cell_1_1.CellStyle = style;
                    cell_1_1.SetCellValue(dt.Rows[i]["Name"].ToString());
                    ICell cell_1_2 = headerrow_1.CreateCell(1);
                    cell_1_2.CellStyle = style;
                    cell_1_2.SetCellValue(dt.Rows[i]["FSourceUrl"].ToString());
                    ICell cell_1_3 = headerrow_1.CreateCell(2);
                    cell_1_3.CellStyle = style;
                    cell_1_3.SetCellValue(dt.Rows[i]["FVisitTime"].ToString());

                }
                if ((i % splitNum) == 0 && i != 0 || i == dt.Rows.Count - 1)
                {
                    using (FileStream stm = File.OpenWrite(@"D: \DataExcle\BrowseRecord_" + j + ".xlsx"))
                    {
                        book.Write(stm);
                        newBook = true;
                        j++;
                        fristNum = 0;
                    }
                }
            }

        }
    }
}
