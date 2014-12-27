using System;
using System.Data;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace SqlExcel
{
    static class ExcelHelper
    {
        #region 导出DataTable到Excel（Author：hanzhaoxin/2014-12-12）

        public static void DataTableToExcel(DataTable dtSource, string sheetName, string fileName)
        {
            string extension = Path.GetExtension(fileName);
            IWorkbook workbook;
            if (extension.Equals(".xls"))
            {
                workbook = new HSSFWorkbook();
            }
            else if (extension.Equals(".xlsx"))
            {
                workbook = new XSSFWorkbook();
            }
            else
            {
                throw new Exception("不是有效的Excel格式！");
            }
            ISheet sheet = workbook.CreateSheet(sheetName);
            IRow headerRow = sheet.CreateRow(0);
            foreach (DataColumn cl in dtSource.Columns)
            {
                headerRow.CreateCell(cl.Ordinal).SetCellValue(cl.ColumnName);
            }
            int rowIndex = 1;
            foreach (DataRow dr in dtSource.Rows)
            {
                IRow dataRow = sheet.CreateRow(rowIndex);
                foreach (DataColumn cl in dtSource.Columns)
                {
                    #region SetCellValue
                    switch (cl.DataType.ToString())
                    {
                        case "System.String":
                            dataRow.CreateCell(cl.Ordinal).SetCellValue(dr[cl].ToString());
                            break;
                        case "System.DateTime":
                            DateTime dtCellValue = new DateTime();
                            DateTime.TryParse(dr[cl].ToString(), out dtCellValue);
                            dataRow.CreateCell(cl.Ordinal).SetCellValue(dtCellValue);
                            break;
                        case "System.Boolean":
                            bool blCellValue;
                            bool.TryParse(dr[cl].ToString(), out blCellValue);
                            dataRow.CreateCell(cl.Ordinal).SetCellValue(blCellValue);
                            break;
                        case "System.Int16":
                        case "System.Int32":
                        case "System.Int64":
                        case "System.Byte":
                            int iCellValue;
                            int.TryParse(dr[cl].ToString(), out iCellValue);
                            dataRow.CreateCell(cl.Ordinal).SetCellValue(iCellValue);
                            break;
                        case "System.Decimal":
                        case "System.Double":
                            double doubCellValue;
                            double.TryParse(dr[cl].ToString(), out doubCellValue);
                            dataRow.CreateCell(cl.Ordinal).SetCellValue(doubCellValue);
                            break;
                        case "System.DBNull":
                            dataRow.CreateCell(cl.Ordinal).SetCellValue("");
                            break;
                        default:
                            dataRow.CreateCell(cl.Ordinal).SetCellValue(dr[cl].ToString());
                            break;
                    }
                    #endregion
                }
                rowIndex++;
            }
            using (FileStream fs = File.OpenWrite(fileName))
            {
                workbook.Write(fs);
                headerRow = null;
                sheet = null;
                workbook = null;
            }
        }
        #endregion
    }
}
