﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace HPES.Model
{
    public class DataSetToExcell
    {

        /// 导出DataSet到Excel(如果DataSet中有多个DataTable,则会导出到不同的sheet中,但只生成一个excel文件)
        /// </summary>
        /// <param name="ds">数据集</param>
        /// <param name="fileName">D:\\test.xlsx</param>
        public  static string ExportToExcel(DataSet ds, string fileName)
        {
            //添加引用-->COM-->Microsoft Excel 12.0 Object Library  

            //Excel程序

            Microsoft.Office.Interop.Excel.Application excelApplication = new Microsoft.Office.Interop.Excel.Application();
            excelApplication.DisplayAlerts = false;
            //工作薄
            Workbook workBook = excelApplication.Workbooks.Add(Missing.Value);
            //上一个工作薄
            Worksheet lastWorkSheet = (Worksheet)workBook.Worksheets.get_Item(workBook.Worksheets.Count);
            //空白工作薄
            Worksheet newSheet = null;
            int i = 0;
            foreach (System.Data.DataTable dt in ds.Tables)
            {
                newSheet = (Worksheet)workBook.Worksheets.Add(Type.Missing, lastWorkSheet, Type.Missing, Type.Missing);
                newSheet.Name = dt.TableName;
                i++;
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    newSheet.Cells[1, col + 1] = dt.Columns[col].ColumnName;
                    ((Range)newSheet.Rows[1, Missing.Value]).Font.Size = 14;
                }
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    for (int col = 0; col < dt.Columns.Count; col++)
                    {
                        newSheet.Cells[row + 2, col + 1] = (dt.Rows[row][col] == null ? "" : dt.Rows[row][col].ToString());
                    }
                }



                if (newSheet.Name.Equals("医用耗材"))
                {
                    var column = (Range)newSheet.Columns["F", Missing.Value];
                    var column1 = (Range)newSheet.Columns["G", Missing.Value];

                    column.Validation.Delete();
                    column.Validation.Add(XlDVType.xlValidateList, XlDVAlertStyle.xlValidAlertWarning, XlFormatConditionOperator.xlBetween, "是,否", Type.Missing);
                    //column.Validation.IgnoreBlank = true;
                    //column.Validation.InCellDropdown = true;
                    column1.Validation.Delete();
                    column1.Validation.Add(XlDVType.xlValidateList, XlDVAlertStyle.xlValidAlertWarning, XlFormatConditionOperator.xlBetween, "是,否", Type.Missing);

                }
                else if (newSheet.Name.Equals("医院在用药品"))
                {
                    var column = (Range)newSheet.Columns["F", Missing.Value];
                    var column1 = (Range)newSheet.Columns["G", Missing.Value];
                    var column2 = (Range)newSheet.Columns["H", Missing.Value];
                    column.Validation.Delete();
                    column.Validation.Add(XlDVType.xlValidateList, XlDVAlertStyle.xlValidAlertWarning, XlFormatConditionOperator.xlBetween, "是,否", Type.Missing);
                    column1.Validation.Delete();
                    column1.Validation.Add(XlDVType.xlValidateList, XlDVAlertStyle.xlValidAlertWarning, XlFormatConditionOperator.xlBetween, "是,否", Type.Missing);
                    column2.Validation.Delete();
                    column2.Validation.Add(XlDVType.xlValidateList, XlDVAlertStyle.xlValidAlertWarning, XlFormatConditionOperator.xlBetween, "是,否", Type.Missing);


                }
                else if (newSheet.Name.Equals("基础数据"))
                {

                    var column = (Range)newSheet.Columns["A", Missing.Value];

                    column.ColumnWidth = 20;

                }


            }

            try
            {
                //删除默认的3个sheet
                ((Worksheet)workBook.Worksheets.get_Item(1)).Delete();
                ((Worksheet)workBook.Worksheets.get_Item(1)).Delete();
                ((Worksheet)workBook.Worksheets.get_Item(1)).Delete();

                workBook.Close(true, fileName, Missing.Value);
                return "模板导出成功！";
            }
            catch (Exception e)
            {
                return "操作无法完成！因为文件已在Microsoft Excel中打开";

            }
            
        }

        
    }
}
