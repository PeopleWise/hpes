using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HPES.Formview.Main;
using HPES.Formview.Scoreview;
using System.Data.OleDb;
using Janus.Windows.GridEX;
using Janus.Windows.Common;

namespace HPES
{
    public partial class frmSubjectEval : Form
    {
        public OleDbConnection oleconnhis=new OleDbConnection();
        public OleDbConnection oleconnfis=new OleDbConnection();
        public frmSubjectEval()
        {
            InitializeComponent();
        }

        public int hid;
        public int yid;
        public string sDIAGCODES="";
        public frmMain frm;
        public string sName = "";
        public string sSQL;
        public string sParameters;
        public string[] aParameters;
        public string sBEGINDATE, sENDDATE;
        public string sFields = "";
        public string sQID;

        private void frmSubjectEval_Load(object sender, EventArgs e)
        {
            frm = (frmMain)this.ParentForm;
            if (frm.cboHospital.ComboBox.SelectedValue == null || frm.cboYear.ComboBox.SelectedValue == null)
            {
                MessageBox.Show("请先选择要考评的医院和考评年度。", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            hid = int.Parse(frm.cboHospital.ComboBox.SelectedValue.ToString());
            yid = int.Parse(frm.cboYear.ComboBox.SelectedValue.ToString());

            // TODO: 这行代码将数据加载到表“dsQuery.hpes_query”中。您可以根据需要移动或移除它。
            this.hpes_queryTableAdapter.Fill(this.dsQuery.hpes_query);
            this.hpes_query_dataTableAdapter.Fill(this.dsQuery.hpes_query_data, hid, yid);


            OleDbCommand command = new OleDbCommand();
            OleDbDataReader reader;
            command.Connection = this.hpes_standard_pointTableAdapter.Connection;
            if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();

            command.CommandText = "SELECT StartDate, endDate FROM hpes_time WHERE YID = " + yid.ToString();
            reader = command.ExecuteReader();
            reader.Read();
            DateTime dBEGINDATE = Convert.ToDateTime(reader[0].ToString());
            DateTime dENDDDATE = Convert.ToDateTime(reader[1].ToString());

            string sBEGINDATE = dBEGINDATE.ToString("yyyy-MM-dd");
            string sENDDATE = dENDDDATE.ToString("yyyy-MM-dd");

            GridEXRow[] rows;
            rows = gridEX1.GetRows();
            foreach (GridEXRow row in rows)
            {
                row.BeginEdit();
                row.Cells[6].Value = sBEGINDATE;
                row.Cells[7].Value = sENDDATE;
                row.EndEdit();

            }


        }

        private void btnCalcAll_Click(object sender, EventArgs e)
        {
            frm = (frmMain)this.ParentForm;
            frm.lblSysMessage.Text = "正在检查各系统输入信息...";  
            if (this.edtHISServerIP.Text == "" || this.edtHISPassword.Text == "" || this.edtHISUserName.Text  == "") {
                MessageBox.Show("请先输入军卫一号系统数据库连接信息后再执行本操作。", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm.lblSysMessage.Text = "系统已就绪。";
                return;
            }

            /*if (this.edtFISServerIP.Text == "" || this.edtFISDBName.Text == "" || this.edtFISUserName.Text == "")
            {
                MessageBox.Show("请先输入军财一号系统数据库连接信息后再执行本操作。", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm.lblSysMessage.Text = "系统已就绪。";
                return;
            }
            */
            try
            {
                frm.lblSysMessage.Text = "正在尝试连接军卫一号系统数据库...";
                frm.StatusBar1.Refresh();
                Console.WriteLine("正在尝试连接军卫一号系统数据库...");
                //oleconnhis.ConnectionString = "Provider=MSDAORA.Oracle;Data Source=" + this.edtHISServerIP.Text + ";Initial Catalog=" + this.edtHISDBName.Text + ";User Id=" + this.edtHISUserName.Text + ";Password=" + this.edtHISPassword.Text + ";";
                oleconnhis.ConnectionString = "Provider=MSDAORA.Oracle;Data Source=" + this.edtHISServerIP.Text + ";User Id=" + this.edtHISUserName.Text + ";Password=" + this.edtHISPassword.Text + ";";
                oleconnhis.Open();

            }
            catch (Exception exec)
            {
                MessageBox.Show("连接军卫一号系统数据库时出现错误，请检查您输入的连接信息或网络连接。\n错误代码：" + exec.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frm.lblSysMessage.Text = "系统已就绪。";
                ////return;
            }
            /*
            try
            {
                frm.lblSysMessage.Text = "正在尝试连接军财一号系统数据库...";  
                Console.WriteLine("正在尝试连接军财一号系统数据库...");
                oleconnfis.ConnectionString = "Provider=sqloledb;Data Source=" + this.edtFISServerIP.Text  + ";Initial Catalog=" + this.edtFISDBName.Text  + ";User Id=" + this.edtFISUserName.Text  + ";Password=" + this.edtFISPassword.Text + ";";
                oleconnfis.Open();

            }
            catch (Exception exec)
            {
                MessageBox.Show("连接军财一号系统数据库时出现错误，请检查您输入的连接信息或网络。\n" + exec.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frm.lblSysMessage.Text = "系统已就绪。";
                return;
            }
            */
            frm.lblSysMessage.Text = "各系统数据库连接就绪，正在准备查询...";
            frm.StatusBar1.Refresh();
            Console.WriteLine("各系统数据库连接就绪，正在准备查询...");
            this.hpes_standard_pointTableAdapter.Fill(this.dsPoint.hpes_standard_point);
            DataTable dt= this.dsPoint.hpes_standard_point;
            

            OleDbCommand command;
            OleDbDataReader reader;
            OleDbCommand UpdateCommand = new OleDbCommand();
            UpdateCommand.Connection = this.hpes_standard_pointTableAdapter.Connection;

            command = new OleDbCommand();
            command.Connection = this.hpes_standard_pointTableAdapter.Connection;
            if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();

            Application.DoEvents();

            GridEXRow[] rows;
            rows = gridEX1.GetRows();
            foreach (GridEXRow row in rows)
            {
                row.GridEX.MoveToRowIndex(row.Position);
                sName = row.Cells[3].Value.ToString();
                sQID = row.Cells[1].Value.ToString();

                frm.lblSysMessage.Text = "正在执行查询: " + sName;
                frm.StatusBar1.Refresh();

                frm.lblSysMessage.Text = "清除旧的查询数据...";
                frm.StatusBar1.Refresh();
                sSQL = @"DELETE FROM hpes_query_data WHERE HID = " + hid.ToString() + " AND YID = " + yid.ToString() + " AND QID = " + sQID + "";
                UpdateCommand.CommandText = sSQL;
                UpdateCommand.ExecuteNonQuery();
                
                sSQL = row.Cells[4].Value.ToString();
                sBEGINDATE = row.Cells[6].Value.ToString().Replace("-", "");
                sENDDATE = row.Cells[7].Value.ToString().Replace("-", "");
                sFields = row.Cells[8].Value.ToString();
                
                String[] aFields = sFields.Split(';');

                sParameters = row.Cells[5].Value.ToString();
                aParameters = sParameters.Split(';');

                if (sQID == "8" || sQID == "9")
                {
                    string sBEGINAGE = "", sENDAGE = "", sAGETITLES = "";
                    string sBEGINAGES = "0;20;30;40;50;60";
                    string sENDAGES = "20;30;40;50;60;120";
                    sAGETITLES = "20岁以下;21到30岁;31到40岁;41到50岁;51到60岁;60岁以上";
                    string[] aBEGINAGES = sBEGINAGES.Split(';');
                    string[] aENDAGES = sENDAGES.Split(';');
                    string[] aAGETITLES = sAGETITLES.Split(';');


                    if (sDIAGCODES.Length<1)
                    {
                        frmQueryData frmData = new frmQueryData();
                        frmData.Owner = this;
                        frmData.ShowDialog();
                    }

                    if (sDIAGCODES.Length < 1)
                    {
                        MessageBox.Show("计算前5病种的平均费用需要传入诊断编码参数，当前未选择诊断编码，因此无法继续。", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    sBEGINAGE = "";
                    sENDAGE = "";
                    for (int age = 0; age < aBEGINAGES.Length; age++)
                    {
                        string sSQLNew = sSQL;
                        sBEGINAGE = aBEGINAGES[age];
                        sENDAGE = aENDAGES[age];
                        foreach (String sParameter in aParameters)
                        {
                            switch (sParameter)
                            {
                                case "BEGINDATE":
                                    sSQLNew = sSQLNew.Replace("BEGINDATE", sBEGINDATE);
                                    break;
                                case "ENDDATE":
                                    sSQLNew = sSQLNew.Replace("ENDDATE", sENDDATE);
                                    break;
                                case "DIAGNOSISCODES":
                                    sSQLNew = sSQLNew.Replace("DIAGNOSISCODES", sDIAGCODES);
                                    break;
                                case "BEGINAGE":
                                    sSQLNew = sSQLNew.Replace("BEGINAGE", sBEGINAGE);
                                    break;
                                case "ENDAGE":
                                    sSQLNew = sSQLNew.Replace("ENDAGE", sENDAGE);
                                    break;
                                default:
                                    Console.WriteLine("无法识别的查询参数： {0}", sParameter);
                                    break;
                            }
                        }

                        Console.WriteLine("正在执行查询: {0}\n查询语句: {1}", sName, sSQLNew);
                        int iCount = RunExternalQuery(sSQLNew, oleconnhis, sQID, aFields, aAGETITLES[age]);
                        if (iCount > 0) row.Expanded = true;
                    }
                }
                else
                {
                    foreach (String sParameter in aParameters)
                    {
                        switch (sParameter)
                        {
                            case "BEGINDATE":
                                sSQL = sSQL.Replace("BEGINDATE", sBEGINDATE);
                                break;
                            case "ENDDATE":
                                sSQL = sSQL.Replace("ENDDATE", sENDDATE);
                                break;
                            default:
                                Console.WriteLine("无法识别的查询参数： {0}", sParameter);
                                break;
                        }
                    }

                    Console.WriteLine("正在执行查询: {0}\n查询语句: {1}", sName, sSQL);
                    try
                    {
                        command = new OleDbCommand(sSQL, oleconnhis);
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            frm.lblSysMessage.Text = "找到数据，准备插入数据库...";
                            Console.WriteLine("找到数据，准备插入数据库。");
                            string sTemp = "";
                            string sFieldString = "", sValueString = "";
                            while (reader.Read())
                            {
                                sFieldString = ""; sValueString = ""; sTemp = "";
                                for (int i = 0; i < aFields.Length; i++)
                                {
                                    sTemp += aFields[i] + ": " + reader[i].ToString();
                                    sFieldString += aFields[i] + ", ";
                                    if (aFields[i].IndexOf("NUM") > 0)
                                        sValueString += String.Format(reader[i].ToString(), "{N4}") + ", ";
                                    else
                                        sValueString += "'" + reader[i].ToString() + "', ";
                                }
                                sFieldString = sFieldString.Substring(0, sFieldString.Length - 2);
                                sValueString = sValueString.Substring(0, sValueString.Length - 2);
                                frm.lblSysMessage.Text = sTemp;
                                frm.StatusBar1.Refresh();
                                sSQL = @"INSERT INTO hpes_query_data (HID, YID, QID, " + sFieldString + ") VALUES (" + hid.ToString() + ", " + yid.ToString() + ", " + sQID + ", " + sValueString;
                                sSQL += ")";
                                Console.WriteLine(sSQL);
                                UpdateCommand.CommandText = sSQL;
                                UpdateCommand.ExecuteNonQuery();

                                row.Expanded = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("没有找到符合条件的数据。");
                        }
                        reader.Close();

                    }
                    catch (Exception exec)
                    {
                        //MessageBox.Show("执行查询时出现错误，请检查数据库连接或查询语句。\n错误代码：" + exec.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        frm.lblSysMessage.Text = "执行查询时出现错误" + exec.Message;
                    }
                }
                if (row.Position <= gridEX1.RecordCount)
                    frm.uiProgressBar1.Value = row.Position * 100 / gridEX1.RecordCount;
                else
                    frm.uiProgressBar1.Value = frm.uiProgressBar1.Maximum;

                frm.uiProgressBar1.Refresh();
            }

            oleconnfis.Close();
            oleconnfis.Dispose();
            oleconnhis.Close();
            oleconnhis.Dispose();

            this.hpes_query_dataTableAdapter.Fill(this.dsQuery.hpes_query_data, hid, yid);
            gridEX1.Refresh();

            this.UpdateGridTooltip();

            frm.lblSysMessage.Text = "系统已就绪，请继续使用。";
            frm.StatusBar1.Refresh();
        }

        private void frmSubjectEval_Activated(object sender, EventArgs e)
        {
            frm = (frmMain)this.ParentForm;
            if (frm.cboHospital.ComboBox.SelectedValue!=null) {
                this.dsHospitalTableAdapter1.Fill(this.dsHospital1._dsHospital);
                this.dsHospital1._dsHospital.DefaultView.RowFilter = "ID = " + frm.cboHospital.ComboBox.SelectedValue.ToString();
                if (this.dsHospital1._dsHospital.Rows[0]["HISServer"] != null)
                {
                    this.edtHISServerIP.Text = this.dsHospital1._dsHospital.Rows[0]["HISServer"].ToString();
                    this.edtHISUserName.Text = this.dsHospital1._dsHospital.Rows[0]["HISUserName"].ToString();
                    this.edtHISPassword.Text = this.dsHospital1._dsHospital.Rows[0]["HISPassword"].ToString();
                }

                if (this.dsHospital1._dsHospital.Rows[0]["FISServer"] != null)
                {
                    this.edtFISServerIP.Text = this.dsHospital1._dsHospital.Rows[0]["FISServer"].ToString();
                    this.edtFISDBName.Text = this.dsHospital1._dsHospital.Rows[0]["FISDBName"].ToString();
                    this.edtFISUserName.Text = this.dsHospital1._dsHospital.Rows[0]["FISUserName"].ToString();
                    this.edtFISPassword.Text = this.dsHospital1._dsHospital.Rows[0]["FISPassword"].ToString();
                }

            }
        }

        private void UpdateGridTooltip()
        {
            GridEXRow[] rows;
            rows = gridEX1.GetRows();
            foreach (GridEXRow row in rows)
            {
                GridEXRow[] crows=row.GetChildRows();
                string sTitles = row.Cells[9].Value.ToString();
                string[] aTitles = sTitles.Split(';');
                string sFields = row.Cells[8].Value.ToString();
                string[] aFields = sFields.Split(';');
                string sAllFields = "DSTR1;DSTR2;DSTR3;DNUM1;DNUM2;DNUM3";
                string[] aAllFields = sAllFields.Split(';');
                foreach (GridEXRow crow in crows)
                {
                    for (int i = 0; i < aFields.Length; i++)
                    {
                        for (int j = 0; j < aAllFields.Length; j++)
                        {
                            if (aAllFields[j] == aFields[i])
                            {
                                try
                                {
                                    crow.Cells[j + 4].ToolTipText = aTitles[i]+": "+crow.Cells[j + 4].Value.ToString();
                                }
                                catch (Exception exec)
                                {

                                }
                            }
                            else {
                                crow.Cells[j + 4].Enabled = false;
                            }
                        }
                    }
                }

            }
        }

 

        private int RunExternalQuery(string sSQLText, OleDbConnection Conn, string sQueryID, string[] Fields, string sAgeTitle)
        {
            int iAffectedRows = 0;
            string sTemp = "";
            string sSQL;
            string sFieldString = "", sValueString = "'"+sAgeTitle+"', ";
            try
            {
                OleDbCommand command;
                OleDbDataReader reader;

                command = new OleDbCommand(sSQLText, Conn);
                reader = command.ExecuteReader();
                iAffectedRows = reader.RecordsAffected;
                if (reader.HasRows)
                {
                    OleDbCommand UpdateCommand = new OleDbCommand();
                    UpdateCommand.Connection = this.hpes_standard_pointTableAdapter.Connection;

                    frm.lblSysMessage.Text = "找到数据，准备插入数据库...";
                    Console.WriteLine("找到数据，准备插入数据库。");
                    while (reader.Read())
                    {
                        sFieldString = "DSTR3, "; sValueString = "'" + sAgeTitle + "', "; sTemp = "DSTR3:" + sAgeTitle;
                        for (int i = 1; i < Fields.Length; i++)
                        {
                            sTemp += Fields[i] + ": " + reader[i-1].ToString();
                            sFieldString += Fields[i] + ", ";
                            if (Fields[i].IndexOf("NUM") > 0)
                                sValueString += String.Format(reader[i-1].ToString(), "{N4}") + ", ";
                            else
                                sValueString += "'" + reader[i-1].ToString() + "', ";
                        }
                        sFieldString = sFieldString.Substring(0, sFieldString.Length - 2);
                        sValueString = sValueString.Substring(0, sValueString.Length - 2);
                        frm.lblSysMessage.Text = sTemp;
                        frm.StatusBar1.Refresh();
                        sSQL = @"INSERT INTO hpes_query_data (HID, YID, QID, " + sFieldString + ") VALUES (" + hid.ToString() + ", " + yid.ToString() + ", " + sQueryID + ", " + sValueString;
                        sSQL += ")";
                        Console.WriteLine(sSQL);
                        UpdateCommand.CommandText = sSQL;
                        UpdateCommand.ExecuteNonQuery();

                    }
                }
                else
                {
                    Console.WriteLine("没有找到符合条件的数据。");
                }
                reader.Close();
                return iAffectedRows;

            }
            catch (Exception exec)
            {
                //MessageBox.Show("执行查询时出现错误，请检查数据库连接或查询语句。\n错误代码：" + exec.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frm.lblSysMessage.Text = "执行查询时出现错误" + exec.Message;
                return 0;
            }
        }

        private void gridEX1_MouseMove(object sender, MouseEventArgs e)
        {
            Janus.Windows.GridEX.GridArea area;
            area = new GridArea();
            area = this.gridEX1.HitTest(e.X, e.Y);
            if (area.ToString() == "Cell")
            {
                //GridEXRow row = this.gridEX1.CurrentRow;
                //Console.WriteLine(this.gridEX1.CurrentColumn.Caption);
            }
        }

        private void gridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
        {
            if (e.Column.Caption=="操作")
            {
                GridEXRow row = this.gridEX1.CurrentRow;
                frm = (frmMain)this.ParentForm;
                frm.lblSysMessage.Text = "正在检查各系统输入信息...";
                if (this.edtHISServerIP.Text == "" || this.edtHISPassword.Text == "" || this.edtHISUserName.Text == "")
                {
                    MessageBox.Show("请先输入军卫一号系统数据库连接信息后再执行本操作。", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm.lblSysMessage.Text = "系统已就绪。";
                    return;
                }

                /*if (this.edtFISServerIP.Text == "" || this.edtFISDBName.Text == "" || this.edtFISUserName.Text == "")
                {
                    MessageBox.Show("请先输入军财一号系统数据库连接信息后再执行本操作。", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm.lblSysMessage.Text = "系统已就绪。";
                    return;
                }
                */
                try
                {
                    frm.lblSysMessage.Text = "正在尝试连接军卫一号系统数据库...";
                    frm.StatusBar1.Refresh();
                    Console.WriteLine("正在尝试连接军卫一号系统数据库...");
                    //oleconnhis.ConnectionString = "Provider=MSDAORA.Oracle;Data Source=" + this.edtHISServerIP.Text + ";Initial Catalog=" + this.edtHISDBName.Text + ";User Id=" + this.edtHISUserName.Text + ";Password=" + this.edtHISPassword.Text + ";";
                    oleconnhis.ConnectionString = "Provider=MSDAORA.Oracle;Data Source=" + this.edtHISServerIP.Text + ";User Id=" + this.edtHISUserName.Text + ";Password=" + this.edtHISPassword.Text + ";";
                    oleconnhis.Open();

                }
                catch (Exception exec)
                {
                    MessageBox.Show("连接军卫一号系统数据库时出现错误，请检查您输入的连接信息或网络连接。\n错误代码：" + exec.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    frm.lblSysMessage.Text = "系统已就绪。";
                    ////return;
                }
                /*
                try
                {
                    frm.lblSysMessage.Text = "正在尝试连接军财一号系统数据库...";  
                    Console.WriteLine("正在尝试连接军财一号系统数据库...");
                    oleconnfis.ConnectionString = "Provider=sqloledb;Data Source=" + this.edtFISServerIP.Text  + ";Initial Catalog=" + this.edtFISDBName.Text  + ";User Id=" + this.edtFISUserName.Text  + ";Password=" + this.edtFISPassword.Text + ";";
                    oleconnfis.Open();

                }
                catch (Exception exec)
                {
                    MessageBox.Show("连接军财一号系统数据库时出现错误，请检查您输入的连接信息或网络。\n" + exec.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    frm.lblSysMessage.Text = "系统已就绪。";
                    return;
                }
                */
                frm.lblSysMessage.Text = "各系统数据库连接就绪，正在准备查询...";
                frm.StatusBar1.Refresh();
                Console.WriteLine("各系统数据库连接就绪，正在准备查询...");

                this.hpes_standard_pointTableAdapter.Fill(this.dsPoint.hpes_standard_point);
                DataTable dt = this.dsPoint.hpes_standard_point;

                string sName = "";
                string sSQL;
                string sParameters;
                string[] aParameters;

                OleDbCommand command;
                OleDbCommand UpdateCommand = new OleDbCommand();
                UpdateCommand.Connection = this.hpes_standard_pointTableAdapter.Connection;

                command = new OleDbCommand();
                command.Connection = this.hpes_standard_pointTableAdapter.Connection;
                if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();

                sQID = row.Cells[1].Text;
                sName = row.Cells[3].Value.ToString();
                frm.lblSysMessage.Text = "正在执行查询: " + sName;
                frm.StatusBar1.Refresh();

                frm.lblSysMessage.Text = "清除旧的查询数据...";
                frm.StatusBar1.Refresh();
                sSQL = @"DELETE FROM hpes_query_data WHERE HID = " + hid.ToString() + " AND YID = " + yid.ToString() + " AND QID = " + sQID + "";
                UpdateCommand.CommandText = sSQL;
                UpdateCommand.ExecuteNonQuery();


                sSQL = row.Cells[4].Value.ToString();
                sBEGINDATE = row.Cells[6].Value.ToString().Replace("-", "");
                sENDDATE = row.Cells[7].Value.ToString().Replace("-", "");
                sFields = row.Cells[8].Value.ToString();

                String[] aFields = sFields.Split(';');

                sParameters = row.Cells[5].Value.ToString();
                aParameters = sParameters.Split(';');

                if (sQID == "8" || sQID == "9")
                {
                    string sBEGINAGES = "0;20;30;40;50;60";
                    string sENDAGES = "20;30;40;50;60;120";
                    string sAGETITLES = "20岁以下;21到30岁;31到40岁;41到50岁;51到60岁;60岁以上";
                    string[] aBEGINAGES = sBEGINAGES.Split(';');
                    string[] aENDAGES = sENDAGES.Split(';');
                    string[] aAGETITLES = sAGETITLES.Split(';');
                    string sBEGINAGE = "", sENDAGE = "";

                    if (sDIAGCODES.Length < 1)
                    {
                        frmQueryData frmData = new frmQueryData();
                        frmData.Owner = this;
                        frmData.ShowDialog();
                    }

                    if (sDIAGCODES.Length < 1)
                    {
                        MessageBox.Show("计算前5病种的平均费用需要传入诊断编码参数，当前未选择诊断编码，因此无法继续。", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    sBEGINAGE = "";
                    sENDAGE = "";
                    for (int age = 0; age < aBEGINAGES.Length; age++)
                    {
                        string sSQLNew = sSQL;
                        sBEGINAGE = aBEGINAGES[age];
                        sENDAGE = aENDAGES[age];
                        foreach (String sParameter in aParameters)
                        {
                            switch (sParameter)
                            {
                                case "BEGINDATE":
                                    sSQLNew = sSQLNew.Replace("BEGINDATE", sBEGINDATE);
                                    break;
                                case "ENDDATE":
                                    sSQLNew = sSQLNew.Replace("ENDDATE", sENDDATE);
                                    break;
                                case "DIAGNOSISCODES":
                                    sSQLNew = sSQLNew.Replace("DIAGNOSISCODES", sDIAGCODES);
                                    break;
                                case "BEGINAGE":
                                    sSQLNew = sSQLNew.Replace("BEGINAGE", sBEGINAGE);
                                    break;
                                case "ENDAGE":
                                    sSQLNew = sSQLNew.Replace("ENDAGE", sENDAGE);
                                    break;
                                default:
                                    Console.WriteLine("无法识别的查询参数： {0}", sParameter);
                                    break;
                            }
                        }

                        frm.lblSysMessage.Text = "正在执行查询: " + sName;
                        frm.StatusBar1.Refresh();
                        Console.WriteLine("正在执行查询: {0}\n查询语句: {1}", sName, sSQLNew);
                        int iCount = RunExternalQuery(sSQLNew, oleconnhis, sQID, aFields, aAGETITLES[age]);
                        if (iCount > 0) row.Expanded = true;
                    }
                }


                frm.lblSysMessage.Text = "正在关闭数据库连接...";
                if (oleconnfis.State == ConnectionState.Open) oleconnfis.Close();
                if (oleconnhis.State == ConnectionState.Open) oleconnhis.Close();
                oleconnhis.Dispose();
                oleconnfis.Dispose();

                gridEX1.Refresh();
                frm.lblSysMessage.Text = "系统已就绪，请继续使用。";
            }
        }

        private void edtHISServerIP_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
