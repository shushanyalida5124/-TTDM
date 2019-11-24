using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Web;
using System.IO;
using Aspose.Cells;
namespace TTDM_BLL
{
    //public class AsposeExcel
    //{
    //    public Aspose.Cells.License li = new Aspose.Cells.License();
    //    private string outFileName = "";
    //    private string fullFilename = "";
    //    private Workbook book = null;
    //    private Worksheet sheet = null;
    //    public AsposeExcel(string outfilename, string tempfilename) //导出构造数  
    //    {
    //        outFileName = outfilename;
    //        book = new Workbook(); 
    //        sheet = book.Worksheets[0];
    //    }
    //    public AsposeExcel(string fullfilename) //导入构造数  
    //    {
    //        fullFilename = fullfilename;  
    //    }
    //    private void AddTitle(string title, int columnCount)
    //    {
    //        sheet.Cells.Merge(0, 0, 1, columnCount);
    //        sheet.Cells.Merge(1, 0, 1, columnCount);
    //        Cell cell1 = sheet.Cells[0, 0];
    //        cell1.PutValue(title);
    //        cell1.Style.HorizontalAlignment = TextAlignmentType.Center;
    //        cell1.Style.Font.Name = "黑体";
    //        cell1.Style.Font.Size = 14;
    //        cell1.Style.Font.IsBold = true;
    //        Cell cell2 = sheet.Cells[1, 0];
    //        cell1.PutValue("查询时间：" + DateTime.Now.ToLocalTime());
    //        cell2.SetStyle(cell1.Style);
    //    }
    //    private void AddHeader(DataTable dt)
    //    {
    //        Cell cell = null;
    //        for (int col = 0; col < dt.Columns.Count; col++)
    //        {
    //            cell = sheet.Cells[0, col];
    //            cell.PutValue(dt.Columns[col].ColumnName);
    //            //cell.Style.Font.IsBold = true;
    //        }
    //    }
    //    private void AddBody(DataTable dt)
    //    {
    //        for (int r = 0; r < dt.Rows.Count; r++)
    //        {
    //            for (int c = 0; c < dt.Columns.Count; c++)
    //            {
    //                DataRow dr = dt.Rows[r];
    //                sheet.Cells[r + 1, c].PutValue(dr[c] + "");
    //            }
    //        }
    //    }

    //    public Boolean DatatableToExcel(DataTable dt)
    //    {
    //        Boolean yn = false;
    //        try
    //        {
    //            //sheet.Name = sheetName;  
    //            //AddTitle(title, dt.Columns.Count);  
    //            //AddHeader(dt);  
    //            AddBody(dt);
    //            sheet.AutoFitColumns();
    //            //sheet.AutoFitRows();  
    //            book.Save(outFileName);
    //            yn = true;
    //            return yn;
    //        }
    //        catch (Exception e)
    //        {
    //            return yn;
    //            // throw e;  
    //        }
    //    }

    //}
}
