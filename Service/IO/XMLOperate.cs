using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using Service.Common.Log;

namespace Service.Common.IO
{
    public class XMLOperator
    {
        #region 变量
        bool bValid = false;
        string stErrMessage = string.Empty;
        private long lXmlCount = 0;

        /// <summary>
        /// 文件路径
        /// </summary>
        private string stDataFile = null;

        /// <summary>
        /// 数据集
        /// </summary>
        private DataSet dsDataSet = null;

        /// <summary>
        /// 字符过滤数组 比如 "id='1' and userName='trace'" 
        /// </summary>
        private string stFilter = null;

        /// <summary>
        /// 排序的字段 比如 "id desc,userName"
        /// </summary>
        private string stSort = null;

        /// <summary>
        /// 数据集合中的字段名集合
        /// </summary>
        private string[] stFields = null;

        /// <summary>
        /// 数据集合中的数据数组
        /// </summary>
        private string[] stData = null;

        #endregion

        #region 属性
        /// <summary>
        /// 数据文件路径
        /// </summary>
        public string DataFile
        {
            set { this.stDataFile = value; }
            get { return this.stDataFile; }
        }
        /// <summary>
        /// 字符过滤数组
        /// </summary>
        public string FilterString
        {
            set { this.stFilter = value; }
        }
        /// <summary>
        /// 排序的字段
        /// </summary>
        public string SortString
        {
            set { this.stSort = value; }
        }
        /// <summary>
        /// 数据集合中的字段名
        /// </summary>
        public string[] FieldsString
        {
            set { this.stFields = value; }
        }
        /// <summary>
        /// 数据集合中的数据数组
        /// </summary>
        public string[] DataString
        {
            set { this.stData = value; }
        }
        /// <summary>
        /// 数据集合，可以放在缓存供调用
        /// </summary>
        public DataSet DataSetData
        {
            set { this.dsDataSet = value; }
            get { return this.dsDataSet; }
        }
        #endregion

        #region 构造函数

        public XMLOperator()
        {
            //
            // TODO: 提供将XML当作数据库处理的一些方法
            //
        }

        #endregion

        #region 事件

        #endregion

        #region 方法


        /// <summary>
        /// 取得XML文件的内容并填入DataSet
        /// </summary>
        public void Open()
        {
            this.dsDataSet = new DataSet();
            FileStream fin;
            fin = new FileStream(this.DataFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            this.dsDataSet.ReadXml(fin);
            fin.Close();
        }

        /// <summary>
        /// 将操作结果写入XML
        /// </summary>
        public void Save()
        {
            this.dsDataSet.WriteXml(this.DataFile);
            this.Clear();
        }

        /// <summary>
        /// 取得特定的数据视图
        /// 一般在数据绑定的时候，我们可以很方便的生成供绑定的视图
        /// </summary>
        /// <returns>数据视图</returns>
        public DataView SelectView()
        {
            if (this.dsDataSet == null) this.Open();

            DataView myDv = new DataView(this.dsDataSet.Tables[0]);

            if (stFilter != null) myDv.RowFilter = this.stFilter;

            myDv.Sort = this.stSort;

            return myDv;
        }

        /// <summary>
        /// 取得特定的行
        /// 使用行的方式是因为有些时候，我们仅仅只需要某一行或多行记录
        /// 比如我们判断登陆的时候，只是需要某个ID的所在行，然后匹配它的密码项
        /// </summary>
        /// <returns>各行数据</returns>
        public DataRow[] SelectRows()
        {
            if (this.dsDataSet == null) this.Open();
            DataRow[] myRows = dsDataSet.Tables[0].Select(this.stFilter);
            return myRows;
        }

        /// <summary>
        /// 往XML当中插入一条数据
        /// </summary>
        /// <returns>操作是否成功</returns>
        public bool InsertData()
        {
            if (this.dsDataSet == null) this.Open();
            DataRow newRow = dsDataSet.Tables[0].NewRow();

            for (int i = 0; i < this.stFields.Length; i++)
            {
                newRow[this.stFields[i]] = this.stData[i];
            }

            dsDataSet.Tables[0].Rows.Add(newRow);
            this.Save();
            return true;
        }

        /// <summary>
        /// 更新数据,这个时候要确保strFields 与 strData 两个数组的维数一致
        /// </summary>
        /// <returns>是否更新成功</returns>
        public bool UpdateData()
        {
            if (this.dsDataSet == null) this.Open();
            DataRow[] editRow = dsDataSet.Tables[0].Select(this.stFilter);

            for (int j = 0; j < editRow.Length; j++)
            {
                for (int i = 0; i < this.stFields.Length; i++)
                {
                    editRow[j][this.stFields[i]] = this.stData[i];
                }
            }
            this.Save();
            return true;
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <returns>是否删除成功</returns>
        public bool DeleteData()
        {
            if (this.dsDataSet == null) this.Open();

            DataRow[] editRow = dsDataSet.Tables[0].Select(this.stFilter);
            for (int i = 0; i < editRow.Length; i++)
            {
                editRow[i].Delete();
            }
            this.Save();
            return true;
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Clear()
        {
            if (this.dsDataSet != null)
            {
                this.dsDataSet.Dispose();
            }
        }
        /// <summary>
        /// 获取源数据标题
        /// </summary>
        /// <param name="Spath">源文件路径</param>
        /// <returns></returns>
        public static DataTable GetTitle(string Spath)
        {
            DataTable dtData = new DataTable();
            StreamReader sr = null;
            StringReader stringReader = null;
            try
            {
                dtData.Columns.Add("CNC");
                dtData.Columns.Add("CNE");
                dtData.Columns.Add("CK");
                dtData.Columns.Add("CJ");
                FileStream fs = new FileStream(Spath, FileMode.Open);
                Encoding Code = FileOperate.GetEncoding(fs, Encoding.Default);
                fs.Close();
                fs.Dispose();
                sr = new StreamReader(Spath, Code);
                StringBuilder sbRow = new StringBuilder();
                string NextRow = string.Empty;
                string mappingTableName = string.Empty;
                string stCell = string.Empty;
                string RootName = ConfigurationManager.AppSettings.Get("RootName");
                while ((stCell = sr.ReadLine()) != null || (NextRow.Length != 0))
                {
                    stCell = NextRow + stCell;
                    //开头
                    if (stCell.Contains("<" + RootName))
                    {
                        sbRow.Append("<" + RootName + ">");
                        stCell = stCell.Substring(stCell.IndexOf("<" + RootName));
                        NextRow = stCell.Substring(stCell.IndexOf("<" + RootName) + RootName.Length + 1);
                        NextRow = NextRow.Substring(NextRow.IndexOf(">") + 1);
                    }
                    else if (sbRow.ToString() != string.Empty)
                    {
                        if (mappingTableName != string.Empty)
                        {
                            //结尾
                            if (stCell.Contains("</" + mappingTableName + ">"))
                            {
                                sbRow.Append(stCell.Substring(0, stCell.IndexOf("</" + mappingTableName + ">") + mappingTableName.Length + 3));
                                sbRow.Append("</" + RootName + ">");
                                break;
                            }
                            else
                            {
                                NextRow = stCell;
                            }
                        }
                        if (stCell.Contains("<") && mappingTableName == string.Empty)
                        {
                            mappingTableName = stCell.Substring(stCell.IndexOf('<') + 1);
                            mappingTableName = mappingTableName.Substring(0, mappingTableName.IndexOf('>'));
                            dtData.TableName = mappingTableName;
                            sbRow.Append("<" + mappingTableName + ">");
                            NextRow = stCell.Substring(stCell.IndexOf(">") + 1);
                        }
                    }

                }
                if (sbRow.ToString() != string.Empty)
                {
                    DataSet dsTemp = new DataSet();
                    stringReader = new StringReader(sbRow.ToString());
                    dsTemp.ReadXml(stringReader);
                    bool IsChinese = false;
                    if (dsTemp.Tables[0].Columns.Count != 0)
                    {
                        IsChinese = FileOperate.IsChineseChar(dsTemp.Tables[0].Columns[0].ColumnName);
                    }
                    else
                    {
                        return dtData;
                    }
                    ArrayList myAL = new ArrayList();
                    int j = 0;
                    for (int i = 0; i < dsTemp.Tables[0].Columns.Count; i++)
                    {
                        string itemEn = StrToPinyin.GetChineseSpell(dsTemp.Tables[0].Columns[i].ColumnName).ToString();
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
                        if (FileOperate.IsChineseChar(dsTemp.Tables[0].Columns[i].ColumnName))
                        {
                            dr["CNC"] = dsTemp.Tables[0].Columns[i].ColumnName;
                            dr["CNE"] = itemEn;
                        }
                        else
                        {
                            dr["CNE"] = dsTemp.Tables[0].Columns[i].ColumnName;
                        }
                        dtData.Rows.Add(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                return dtData;
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                    sr.Dispose();
                }
                if (stringReader != null)
                {
                    stringReader.Close();
                    stringReader.Dispose();
                }
            }
            return dtData;
        }
        /// <summary>
        /// 读取原始数据前十条
        /// </summary>
        /// <param name="Spath">源文件路径</param>
        /// <returns></returns>
        public static DataTable ReadTopTenBySource(string Spath, string mappingTableName, string[] mappingColumns, int count)
        {
            DataSet dsData = new DataSet();
            StreamReader sr = null;
            StringReader stringReader = null;
            FileStream fs = null;
            int iCount = 0;
            try
            {
                fs = new FileStream(Spath, FileMode.Open);
                Encoding Code = FileOperate.GetEncoding(fs, Encoding.Default);
                fs.Close();
                fs.Dispose();
                sr = new StreamReader(Spath, Code);
                StringBuilder sbRowAll = new StringBuilder();
                bool IsRow = false;
                string Begin = string.Empty;
                string NextRow = string.Empty;
                string stCell = string.Empty;
                string RootName = ConfigurationManager.AppSettings.Get("RootName");
                StringBuilder sbRow = new StringBuilder();
                sbRowAll.Append("<" + RootName + ">");
                while ((stCell = sr.ReadLine()) != null || (NextRow.Length != 0))
                {
                    stCell = NextRow + stCell;
                    //开头
                    if (stCell.Contains("<" + mappingTableName + ">"))
                    {
                        stCell = stCell.Substring(stCell.IndexOf("<" + mappingTableName + ">"));
                        sbRow.Append("<" + mappingTableName + ">");
                        NextRow = stCell.Substring(stCell.IndexOf("<" + mappingTableName + ">") + mappingTableName.Length + 2);
                    }
                    else
                    {
                        //结尾
                        if (stCell.Contains("</" + mappingTableName + ">"))
                        {
                            IsRow = true;
                            sbRow.Append(stCell.Substring(0, stCell.IndexOf("</" + mappingTableName + ">") + mappingTableName.Length + 3));
                            NextRow = stCell.Substring(stCell.IndexOf("</" + mappingTableName + ">") + mappingTableName.Length + 3);
                        }
                        else if (sbRow.ToString() != string.Empty)
                        {
                            sbRow.Append(stCell);
                        }
                        if (IsRow)
                        {
                            //处理一行
                            sbRowAll.Append("<" + mappingTableName + ">");
                            for (int i = 0; i < mappingColumns.Length; i++)
                            {
                                string stTemp = sbRow.ToString();
                                if (stTemp.Contains("<" + mappingColumns[i] + ">") && stTemp.Contains("</" + mappingColumns[i] + ">"))
                                {
                                    Begin = stTemp.Substring(stTemp.IndexOf("<" + mappingColumns[i] + ">") + mappingColumns[i].Length + 2);
                                    sbRowAll.Append("<" + mappingColumns[i] + ">");
                                    string stConten = Begin.Substring(0, Begin.IndexOf("</" + mappingColumns[i] + ">")).Trim();
                                    if (stConten.Contains("<![CDATA[") && stConten.Contains("]]>"))
                                    {
                                        stConten = stConten.Replace("<![CDATA[", "").Replace("]]>", "");
                                    }
                                    sbRowAll.Append("<![CDATA[");
                                    sbRowAll.Append(stConten);
                                    sbRowAll.Append("]]>");
                                    sbRowAll.Append("</" + mappingColumns[i] + ">");
                                }
                                else
                                {
                                    sbRowAll.Append("<" + mappingColumns[i] + " />");
                                }
                            }
                            sbRowAll.Append("</" + mappingTableName + ">");
                            sbRow = new StringBuilder();
                            IsRow = false;
                            iCount++;
                            if (count != -1 && iCount == count)
                            {
                                break;
                            }
                        }
                    }

                }
                sbRowAll.Append("</" + RootName + ">");
                if (sbRowAll.ToString() != string.Empty)
                {
                    stringReader = new StringReader(sbRowAll.ToString());
                    dsData.ReadXml(stringReader);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    fs.Dispose();
                }
                if (sr != null)
                {
                    sr.Close();
                    sr.Dispose();
                }
                if (stringReader != null)
                {
                    stringReader.Close();
                    stringReader.Dispose();
                }
            }
            return dsData.Tables[0];
        }
        /// <summary>
        /// 处理数据生成带特殊字符保护的XML文件
        /// </summary>
        /// <param name="fileName">目标文件名</param>
        /// <param name="Spath">源文件路径</param>
        /// <param name="tableName">原结构表英文名</param>
        /// <param name="columns">原结构表英文列名</param>
        /// <param name="tableName">表英文名</param>
        /// <param name="columns">表英文列名</param>
        /// <param name="Tpath">目标文件路径（不以"\"结尾）</param>
        /// <returns></returns>
        public static ReturnMessage HandleToXml(string fileName, string Spath, string mappingTableName, string[] mappingColumns, string tableName, string[] columns, string Tpath)
        {
            return HandleToXml(fileName, Spath, mappingTableName, mappingColumns, tableName, columns, Tpath, -1);
        }
        /// <summary>
        /// 处理数据生成带特殊字符保护的XML文件
        /// </summary>
        /// <param name="fileName">目标文件名</param>
        /// <param name="Spath">源文件路径</param>
        /// <param name="tableName">原结构表英文名</param>
        /// <param name="columns">原结构表英文列名</param>
        /// <param name="tableName">表英文名</param>
        /// <param name="columns">表英文列名</param>
        /// <param name="Tpath">目标文件路径（不以"\"结尾）</param>
        /// <param name="count">分包条数（条数>0）</param>
        /// <returns></returns>
        public static ReturnMessage HandleToXml(string fileName, string Spath, string mappingTableName, string[] mappingColumns, string tableName, string[] columns, string Tpath, int count)
        {
            ReturnMessage rm = new ReturnMessage();
            StreamReader sr = null;
            XmlWriter xwr = null;
            int iCount = 0;//导出条数
            int IErrorCount = 0;//筛选出去的条数
            int iTableNum = 1;//表的第几部分
            string stImport = string.Empty;
            string[] EspChar = File.ReadAllLines(System.AppDomain.CurrentDomain.BaseDirectory + @"Data\EspecialChar.txt");
            try
            {
                FileStream fs = new FileStream(Spath, FileMode.Open);
                Encoding Code = FileOperate.GetEncoding(fs, Encoding.Default);
                fs.Close();
                fs.Dispose();
                sr = new StreamReader(Spath, Code);
                string RootName = "NewDataSet";
                xwr = new XmlTextWriter(Tpath + "\\" + fileName + "_" + iTableNum.ToString() + ".xml", new System.Text.UTF8Encoding());
                xwr.WriteStartDocument(true);
                xwr.WriteWhitespace("\r\n");
                xwr.WriteStartElement(RootName);
                bool IsRow = false;
                string Begin = string.Empty;
                string NextRow = string.Empty;
                string stCell = string.Empty;
                StringBuilder sbRow = new StringBuilder();
                while ((stCell = sr.ReadLine()) != null || (NextRow.Length != 0))
                {
                    stCell = NextRow + stCell;
                    //开头
                    if (stCell.Contains("<" + mappingTableName + ">"))
                    {
                        stCell = stCell.Substring(stCell.IndexOf("<" + mappingTableName + ">"));
                        sbRow.Append("<" + mappingTableName + ">");
                        NextRow = stCell.Substring(stCell.IndexOf("<" + mappingTableName + ">") + mappingTableName.Length + 2);
                    }
                    else
                    {
                        //结尾
                        if (stCell.Contains("</" + mappingTableName + ">"))
                        {
                            IsRow = true;
                            sbRow.Append(stCell.Substring(0, stCell.IndexOf("</" + mappingTableName + ">") + mappingTableName.Length + 3));
                            NextRow = stCell.Substring(stCell.IndexOf("</" + mappingTableName + ">") + mappingTableName.Length + 3);
                        }
                        else if (sbRow.ToString() != string.Empty)
                        {
                            sbRow.Append(stCell);
                        }
                        if (IsRow)
                        {
                            //获取该行的值
                            string[] stcolumn = new string[mappingColumns.Length];
                            for (int i = 0; i < stcolumn.Length; i++)
                            {
                                string stTemp = sbRow.ToString();
                                if (stTemp.Contains("<" + mappingColumns[i] + ">") && stTemp.Contains("</" + mappingColumns[i] + ">"))
                                {
                                    Begin = stTemp.Substring(stTemp.IndexOf("<" + mappingColumns[i] + ">") + mappingColumns[i].Length + 2);

                                    string stConten = Begin.Substring(0, Begin.IndexOf("</" + mappingColumns[i] + ">")).Trim();
                                    if (stConten.Contains("<![CDATA[") && stConten.Contains("]]>"))
                                    {
                                        stConten = stConten.Replace("<![CDATA[", "").Replace("]]>", "");
                                    }
                                    stcolumn[i] = stConten;
                                }
                                else
                                {
                                    stcolumn[i] = String.Empty;
                                }
                            }
                            //验证非法字符
                            bool lContainsEspChar = false;
                            //若存在特殊字符，将其保存到筛选文件里边。
                            for (int q = 0; q < stcolumn.Length; q++)
                            {
                                foreach (string stTemp in EspChar)
                                {
                                    if (stcolumn[q].ToString().Contains(stTemp))
                                    {
                                        stImport = string.Empty;
                                        for (int p = 0; p < stcolumn.Length; p++)
                                        {
                                            stImport += stcolumn[p].ToString() + "\t";
                                        }
                                        stImport += Environment.NewLine;
                                        File.AppendAllText(Tpath + @"特殊字符筛选\EspecialCharExport_" + tableName + ".txt", stImport);
                                        IErrorCount++;
                                        lContainsEspChar = true;
                                        break;
                                    }
                                }
                                if (lContainsEspChar) break;
                            }
                            if (lContainsEspChar) continue;
                            //若不包含特殊字符则进行导出

                            //判断是否写入新文件
                            if (count > 0 && (iCount + 1) / count > 0 && iCount % count == 0)
                            {
                                //结束文件
                                xwr.WriteWhitespace("\r\n");
                                xwr.WriteEndElement();
                                xwr.WriteEndDocument();
                                xwr.Flush();
                                xwr.Close();
                                //开始新文件
                                iTableNum++;
                                xwr = new XmlTextWriter(Tpath + "\\" + fileName + "_" + iTableNum.ToString() + ".xml", new System.Text.UTF8Encoding());
                                xwr.WriteStartDocument(true);
                                xwr.WriteWhitespace("\r\n");
                                xwr.WriteStartElement(RootName);
                            }
                            //处理一行
                            xwr.WriteWhitespace("\r\n\t");
                            xwr.WriteStartElement(tableName);
                            for (int i = 0; i < mappingColumns.Length; i++)
                            {
                                if (stcolumn[i] != string.Empty)
                                {
                                    xwr.WriteWhitespace("\r\n\t\t");
                                    xwr.WriteStartElement(columns[i]);
                                    xwr.WriteCData(stcolumn[i]);
                                    xwr.WriteEndElement();
                                }
                                else
                                {
                                    xwr.WriteWhitespace("\r\n\t\t");
                                    xwr.WriteElementString(columns[i], String.Empty);
                                }
                            }
                            xwr.WriteWhitespace("\r\n\t");
                            xwr.WriteFullEndElement();
                            IsRow = false;
                            sbRow = new StringBuilder();
                            //if (count != -1 && iCount == count)
                            //{
                            //    break;
                            //}
                            iCount++;
                        }
                    }

                }
                xwr.WriteWhitespace("\r\n");
                xwr.WriteEndElement();
                xwr.WriteEndDocument();
                rm.IsSucessed = true;
                rm.Message = "导出数据" + iCount.ToString() + "行";
            }
            catch (Exception ex)
            {
                rm.IsSucessed = false;
                rm.Message = ex.Message;
            }
            finally
            {
                if (xwr != null)
                {
                    xwr.Flush();
                    xwr.Close();
                }
                if (sr != null)
                {
                    sr.Close();
                    sr.Dispose();
                }
            }
            return rm;
        }
        /// <summary>
        /// 用流读取XML转换后的前10条，并套用新的结构
        /// </summary>
        /// <param name="tableName">英文表名</param>
        /// <param name="Tpath">目标文件路径</param>
        /// <param name="schemaPath">结构文件路径</param>
        /// <returns></returns>
        public static DataTable ReadTopTenByTarget(string tableName, string Spath, string schemaPath)
        {
            DataSet dsData = new DataSet();
            dsData.ReadXmlSchema(schemaPath);
            dsData.ReadXml(Spath);
            for (int j = 0; j < dsData.Tables[tableName].Columns.Count; j++)
            {
                dsData.Tables[tableName].Columns[j].ColumnName = dsData.Tables[tableName].Columns[j].Caption;
            }
            return dsData.Tables[tableName];
        }




        void XmlReaderValidationEventHandler(object sender, ValidationEventArgs e)
        {
            //搜集e.Message中的错误信息，并填充到stErrMessage中
            //将bValid设置成false
            stErrMessage = e.Message.ToString();
            this.bValid = false;
            ReturnMessage message = new ReturnMessage();
            message.Message = stErrMessage;
            message.IsSucessed = bValid;
        }
        /// <summary>
        /// 验证数据文件
        /// </summary>
        /// <param name="xmlSchemaPath">架构文件路径</param>
        /// <param name="xmlPath">数据文件路径</param>
        private  void ValidData(string xmlSchemaPath, string xmlPath)
        {
            bValid = true;
            XmlReaderSettings xrsValid = new XmlReaderSettings();
            xrsValid.CloseInput = true;
            xrsValid.IgnoreComments = true;
            xrsValid.IgnoreWhitespace = true;
            xrsValid.ValidationType = ValidationType.Schema;
            xrsValid.Schemas.Add(null, xmlSchemaPath);
            xrsValid.CheckCharacters = false;
            xrsValid.ValidationEventHandler += new System.Xml.Schema.ValidationEventHandler(XmlReaderValidationEventHandler);
            XmlReader xrdValid = XmlReader.Create(xmlPath, xrsValid);
            while (xrdValid.Read())
            {

            }
            xrdValid.Close();
            //return false;
            //构建一个XmlReaderSettings用于验证要导入的XML信息
            //设置XmlReaderSettings
            //构建XmlReader用以读取数据，附加前面设置好的XmlReaderSettings
            //循环读取XmlReader
        }



        public ReturnMessage XmlSplit(string xmlPath, string xmlSchemaPath)
        {

            int iRowCounter = 20000;
            ArrayList alsSplitXmlName = new ArrayList();
            int iCounters = 0;
            string stSplitXmlName = String.Empty;
            ReturnMessage returnMessage = new ReturnMessage(true);
            try
            {
                //验证数据文件
                ValidData(xmlSchemaPath, xmlPath);
                //拆分文件路径
                string stSystemp = xmlPath.Substring(0, xmlPath.LastIndexOf('\\')) + "\\Systemp";
                if (!Directory.Exists(stSystemp))
                {
                    Directory.CreateDirectory(stSystemp);
                }
                else
                {
                    DirectoryOperate.ClearDirectory(stSystemp);
                }
                //string stProjectName = "";
                int iks = 0;

                if (bValid)
                {
                    #region 拆分XML
                    string stCurrentTableName = String.Empty;
                    ArrayList alsSplitIndex = new ArrayList();
                    XmlTextReader xrdSplit = new XmlTextReader(xmlPath);
                    XmlTextWriter xwrSplit = null;
                    XmlWriterSettings xwsSplitValue = new XmlWriterSettings();
                    xwsSplitValue.Encoding = Encoding.UTF8;
                    while (xrdSplit.Read())
                    {
                        iks = iks + 1;
                        //aa[iks] = ((System.Xml.XmlReader)(xrdSplit)).Value;
                        //深度大于1时，直接向分隔XML里赋值
                        if (xrdSplit.Depth > 1)
                        {
                            xwrSplit.WriteNode(xrdSplit, false);

                        }
                        //深度等于1时，依条件判断处理
                        else if (object.Equals(xrdSplit.Depth, 1))
                        {
                            //当节点为起始节点，并且不是空行节点时
                            if (xrdSplit.IsStartElement() && !xrdSplit.IsEmptyElement)
                            {
                                //当缓存列表为空时，添加新的表名到缓存列表中
                                if (Object.Equals(alsSplitXmlName.Count, 0))
                                {
                                    alsSplitXmlName.Add(xrdSplit.Name.ToString());
                                }
                                //当节点与缓存列表中的最后一位相等时,计数器累加
                                if (Object.Equals((alsSplitXmlName[alsSplitXmlName.Count - 1]).ToString(), xrdSplit.Name.ToString()))
                                {
                                    iCounters++;
                                    //如果当前节点为第一个节点，生成新的Xml头
                                    if (Object.Equals(iCounters, 1))
                                    {
                                        stSplitXmlName = String.Format(stSystemp + "\\{0}.xml", Guid.NewGuid().ToString());
                                        alsSplitIndex.Add(stSplitXmlName);
                                        xwrSplit = new XmlTextWriter(stSplitXmlName, Encoding.UTF8);
                                        xwrSplit.WriteStartDocument();
                                        xwrSplit.WriteWhitespace("\r\n");
                                        xwrSplit.WriteStartElement("NewDataSet");
                                        xwrSplit.WriteWhitespace("\r\n");
                                    }
                                    //读取当前XML节点，到新的XML文件中
                                    xwrSplit.WriteNode(xrdSplit, false);
                                    //如果计数器已达到每页数据最大数据量时，计数器置零，关闭XML文件，并新建XML头
                                    if (Object.Equals(iCounters, iRowCounter))
                                    {
                                        lXmlCount += iCounters;

                                        iCounters = 0;
                                        lXmlCount = 0;
                                        xwrSplit.WriteEndElement();
                                        xwrSplit.WriteWhitespace("\r\n");
                                        xwrSplit.WriteEndDocument();
                                        xwrSplit.Flush();
                                        xwrSplit.Close();
                                    }
                                }
                                //当节点与缓存列表中的最后一位不等时,计数器置零,关闭XML文件，新建XML文件
                                else if (!Object.Equals((alsSplitXmlName[alsSplitXmlName.Count - 1]).ToString(), xrdSplit.Name.ToString()))
                                {
                                    alsSplitXmlName.Add(xrdSplit.Name.ToString());
                                    if (!Object.Equals(iCounters, 0))
                                    {
                                        lXmlCount += iCounters;

                                        xwrSplit.WriteEndElement();
                                        xwrSplit.WriteWhitespace("\r\n");
                                        xwrSplit.WriteEndDocument();
                                        xwrSplit.Flush();
                                        xwrSplit.Close();
                                    }
                                    iCounters = 0;
                                    lXmlCount = 0;
                                    iCounters++;
                                    stSplitXmlName = String.Format(stSystemp + "\\{0}.xml", Guid.NewGuid().ToString());
                                    alsSplitIndex.Add(stSplitXmlName);
                                    xwrSplit = new XmlTextWriter(stSplitXmlName, Encoding.UTF8);
                                    xwrSplit.WriteStartDocument();
                                    xwrSplit.WriteWhitespace("\r\n");
                                    xwrSplit.WriteStartElement("NewDataSet");
                                    xwrSplit.WriteWhitespace("\r\n\t");

                                    xwrSplit.WriteNode(xrdSplit, false);
                                }
                            }
                        }
                    }
                    if (!Object.Equals(iCounters, 0))
                    {
                        lXmlCount += iCounters;

                        xwrSplit.WriteEndElement();
                        xwrSplit.WriteWhitespace("\r\n");
                        xwrSplit.WriteEndDocument();
                        xwrSplit.Flush();
                        xwrSplit.Close();
                    }
                    xrdSplit.Close();
                    #endregion


                }
                else
                {
                    returnMessage.Message = "XML文件不正确，详细信息为：" + stErrMessage;
                    returnMessage.IsSucessed = bValid;
                }
                //删除原文件
                //File.Delete(xmlPath);


                //调用ValidData(string xmlSchemaPath)方法验证导入XML是否合法

                //判断bValid是否为false，若为false，则构造新的ReturnMessage，返回错误信息

                //若bValid为true,则开始对数据以XmlReader读取并进行插入。
                
                return returnMessage;
            }
            catch (Exception ex)
            {
                returnMessage.IsSucessed = false;
                returnMessage.Message = "拆分失败，失败原恩：" + ex.Message.ToString();
                return returnMessage;
            }
            
            
        }
        /// <summary>
        /// XML导入数据库
        /// </summary>
        /// <returns></returns>
        public ReturnMessage XmlInput(string stPath, string stXmlSchemaPath, string taskname)
        {
            ReturnMessage rm = new ReturnMessage(true);
            try
            {
                
                #region 导入数据库


                FileInfo[] files = DirectoryOperate.getAllFile(stPath, "*.xml");

                string str = ConfigurationManager.ConnectionStrings["APPDBSTRING"].ConnectionString.ToString();
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(stXmlSchemaPath);
                foreach (FileInfo fileinfo in files)
                {
                    ds.ReadXml(fileinfo.FullName);
                    //声明数据库连接
                    SqlConnection conn = new SqlConnection(str);
                    conn.Open();
                    //声明SqlBulkCopy ,using释放非托管资源
                    using (SqlBulkCopy sqlBC = new SqlBulkCopy(conn))
                    {
                        //一次批量的插入的数据量
                        sqlBC.BatchSize = 1000;
                        //超时之前操作完成所允许的秒数，如果超时则事务不会提交 ，数据将回滚，所有已复制的行都会从目标表中移除
                        sqlBC.BulkCopyTimeout = 60;

                        //設定 NotifyAfter 属性，以便在每插入10000 条数据时，呼叫相应事件。  
                        sqlBC.NotifyAfter = 10000;
                        //sqlBC.SqlRowsCopied += new SqlRowsCopiedEventHandler(OnSqlRowsCopied);

                        foreach (DataTable dt in ds.Tables)
                        {
                            //设置要批量写入的表
                            sqlBC.DestinationTableName = "dbo.T_" + taskname + "_" + dt.TableName + "_Temp";

                            //自定义的datatable和数据库的字段进行对应
                            //sqlBC.ColumnMappings.Add("id", "tel");
                            //sqlBC.ColumnMappings.Add("name", "neirong");

                            //批量写入
                            sqlBC.WriteToServer(dt);
                        }
                    }
                    conn.Dispose();
                    ds.Clear();
                }
                #endregion
                return rm;
            }
            catch(Exception ex)
            {
                rm.IsSucessed = false;
                rm.Message = ex.Message;
                return rm;
            }
        }

        #endregion


    }
}
