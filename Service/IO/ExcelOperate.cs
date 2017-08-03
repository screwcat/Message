using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Service.Common.IO
{
    public class ExcelOperate
    {
        public static string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES;IMEX={1}';";
        /// <summary>
        /// 获取Excel中的表名
        /// </summary>
        /// <param name="stPath"></param>
        /// <returns></returns>
        public static String[] GetExcelSheetNames(string stPath)
        {
            OleDbConnection objConn = null;
            System.Data.DataTable dt = null;

            try
            {
                objConn = new OleDbConnection(string.Format(connString, stPath, "1"));
                objConn.Open();
                dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                if (dt == null)
                {
                    return null;
                }
                for (int n = 0; n < dt.Rows.Count; n++)
                {
                    string[] strTableName = dt.Rows[n]["TABLE_NAME"].ToString().Split('$');
                    if (strTableName.Length < 3 && strTableName[1].ToString() == "")
                    {

                    }
                    else
                    {
                        dt.Rows.RemoveAt(n);
                    }
                }

                int m = dt.Rows.Count;
                String[] excelSheets = new String[dt.Rows.Count];
                int i = 0;

                foreach (DataRow row in dt.Rows)
                {
                    excelSheets[i] = row["TABLE_NAME"].ToString();
                    i++;
                }

                return excelSheets;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (objConn != null)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
                if (dt != null)
                {
                    dt.Dispose();
                }
            }
        }


        /// <summary>
        /// 获取源数据标题
        /// </summary>
        /// <param name="Spath">源文件路径</param>
        /// <param name="sheetName">Sheet页名称</param>
        /// <returns></returns>
        public static DataTable GetTitle(string Spath, string sheetName)
        {
            DataTable dtData = new DataTable();
            OleDbDataReader datareader = null;
            OleDbConnection Conn = null;
            try
            {
                dtData.Columns.Add("CNC");
                dtData.Columns.Add("CNE");
                dtData.Columns.Add("CK");
                dtData.Columns.Add("CJ");
                Conn = new OleDbConnection(string.Format(connString, Spath, "0"));
                Conn.Open();
                string stSQL = "select * from [" + sheetName + "$]";
                OleDbCommand dbCommand = new OleDbCommand(stSQL, Conn);
                datareader = dbCommand.ExecuteReader();
                bool IsChinese = false;
                if (datareader.FieldCount != 0)
                {
                    IsChinese = FileOperate.IsChineseChar(datareader.GetName(0));
                }
                else
                {
                    return null;
                }
                List<string> myAL = new List<string>();
                int j = 0;
                for (int i = 0; i < datareader.FieldCount; i++)
                {
                    string itemEn = StrToPinyin.GetChineseSpell(datareader.GetName(i)).ToString();
                    if (myAL.Count != 0)
                    {
                        if (myAL.Contains(itemEn) == false)
                        {
                            myAL.Add(itemEn);
                        }
                        else
                        {
                            itemEn = itemEn + j.ToString();
                            j++;
                        }
                    }
                    else
                    {
                        myAL.Add(itemEn);
                    }
                    DataRow dr = dtData.NewRow();
                    if (FileOperate.IsChineseChar(datareader.GetName(i)))
                    {
                        dr["CNC"] = datareader.GetName(i);
                        dr["CNE"] = itemEn;
                    }
                    else
                    {
                        dr["CNC"] = datareader.GetName(i);
                        dr["CNE"] = datareader.GetName(i);
                    }
                    dtData.Rows.Add(dr);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                Conn.Close();
                datareader.Dispose();
            }
            return dtData;
        }
    }
}
