﻿namespace HPES
{
    partial class frmSubjectEval
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Janus.Windows.Common.SuperTipSettings superTipSettings2 = new Janus.Windows.Common.SuperTipSettings();
            Janus.Windows.Common.SuperTipSettings superTipSettings3 = new Janus.Windows.Common.SuperTipSettings();
            Janus.Windows.Common.SuperTipSettings superTipSettings4 = new Janus.Windows.Common.SuperTipSettings();
            Janus.Windows.Common.SuperTipSettings superTipSettings5 = new Janus.Windows.Common.SuperTipSettings();
            Janus.Windows.Common.SuperTipSettings superTipSettings6 = new Janus.Windows.Common.SuperTipSettings();
            Janus.Windows.Common.SuperTipSettings superTipSettings7 = new Janus.Windows.Common.SuperTipSettings();
            Janus.Windows.Common.SuperTipSettings superTipSettings8 = new Janus.Windows.Common.SuperTipSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubjectEval));
            Janus.Windows.GridEX.GridEXLayout gridEX1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.SuperTipSettings superTipSettings1 = new Janus.Windows.Common.SuperTipSettings();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.boxServerInfo = new Janus.Windows.EditControls.UIGroupBox();
            this.edtFISDBName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.edtFISPassword = new Janus.Windows.GridEX.EditControls.EditBox();
            this.edtFISUserName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.edtFISServerIP = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.edtHISDBName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.edtHISPassword = new Janus.Windows.GridEX.EditControls.EditBox();
            this.edtHISUserName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.edtHISServerIP = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcAll = new Janus.Windows.EditControls.UIButton();
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.hpes_queryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQuery = new HPES.dsQuery();
            this.gridEXExporter1 = new Janus.Windows.GridEX.Export.GridEXExporter(this.components);
            this.gridEXPrintDocument1 = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.janusSuperTip = new Janus.Windows.Common.JanusSuperTip(this.components);
            this.tableAdapterManager = new HPES.dsEvaluationTableAdapters.TableAdapterManager();
            this.dsHospital1 = new HPES.dsHospital();
            this.dsHospitalTableAdapter1 = new HPES.dsHospitalTableAdapters.dsHospitalTableAdapter();
            this.tableAdapterManager1 = new HPES.dsPointTableAdapters.TableAdapterManager();
            this.hpes_standard_pointTableAdapter = new HPES.dsPointTableAdapters.hpes_standard_pointTableAdapter();
            this.dsPoint = new HPES.dsPoint();
            this.hpes_queryTableAdapter = new HPES.dsQueryTableAdapters.hpes_queryTableAdapter();
            this.hpes_query_dataTableAdapter = new HPES.dsQueryTableAdapters.hpes_query_dataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxServerInfo)).BeginInit();
            this.boxServerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpes_queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHospital1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // officeFormAdorner1
            // 
            this.officeFormAdorner1.Form = this;
            this.officeFormAdorner1.VisualStyle = Janus.Windows.Ribbon.VisualStyle.Office2010;
            // 
            // boxServerInfo
            // 
            this.boxServerInfo.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel;
            this.boxServerInfo.Controls.Add(this.edtFISDBName);
            this.boxServerInfo.Controls.Add(this.edtFISPassword);
            this.boxServerInfo.Controls.Add(this.edtFISUserName);
            this.boxServerInfo.Controls.Add(this.edtFISServerIP);
            this.boxServerInfo.Controls.Add(this.label6);
            this.boxServerInfo.Controls.Add(this.label7);
            this.boxServerInfo.Controls.Add(this.label8);
            this.boxServerInfo.Controls.Add(this.label9);
            this.boxServerInfo.Controls.Add(this.label10);
            this.boxServerInfo.Controls.Add(this.edtHISDBName);
            this.boxServerInfo.Controls.Add(this.edtHISPassword);
            this.boxServerInfo.Controls.Add(this.edtHISUserName);
            this.boxServerInfo.Controls.Add(this.edtHISServerIP);
            this.boxServerInfo.Controls.Add(this.label5);
            this.boxServerInfo.Controls.Add(this.label4);
            this.boxServerInfo.Controls.Add(this.label3);
            this.boxServerInfo.Controls.Add(this.label2);
            this.boxServerInfo.Controls.Add(this.label1);
            this.boxServerInfo.Controls.Add(this.btnCalcAll);
            this.boxServerInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxServerInfo.FrameStyle = Janus.Windows.EditControls.FrameStyle.None;
            this.boxServerInfo.Location = new System.Drawing.Point(0, 0);
            this.boxServerInfo.Name = "boxServerInfo";
            this.boxServerInfo.Size = new System.Drawing.Size(903, 100);
            this.boxServerInfo.TabIndex = 0;
            this.boxServerInfo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
            // 
            // edtFISDBName
            // 
            this.edtFISDBName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtFISDBName.Location = new System.Drawing.Point(494, 66);
            this.edtFISDBName.Name = "edtFISDBName";
            this.edtFISDBName.Size = new System.Drawing.Size(131, 22);
            superTipSettings2.FooterText = "系统提示";
            superTipSettings2.HeaderText = "数据库名称";
            superTipSettings2.ImageListProvider = null;
            superTipSettings2.Text = "请输入数据库名称";
            this.janusSuperTip.SetSuperTip(this.edtFISDBName, superTipSettings2);
            this.edtFISDBName.TabIndex = 7;
            this.edtFISDBName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            // 
            // edtFISPassword
            // 
            this.edtFISPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtFISPassword.Location = new System.Drawing.Point(686, 66);
            this.edtFISPassword.Name = "edtFISPassword";
            this.edtFISPassword.PasswordChar = '*';
            this.edtFISPassword.Size = new System.Drawing.Size(104, 22);
            superTipSettings3.FooterText = "系统提示";
            superTipSettings3.HeaderText = "密码";
            superTipSettings3.ImageListProvider = null;
            superTipSettings3.Text = "请输入数据库密码";
            this.janusSuperTip.SetSuperTip(this.edtFISPassword, superTipSettings3);
            this.edtFISPassword.TabIndex = 9;
            this.edtFISPassword.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            // 
            // edtFISUserName
            // 
            this.edtFISUserName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtFISUserName.Location = new System.Drawing.Point(686, 37);
            this.edtFISUserName.Name = "edtFISUserName";
            this.edtFISUserName.Size = new System.Drawing.Size(104, 22);
            superTipSettings4.FooterText = "系统提示";
            superTipSettings4.HeaderText = "用户名";
            superTipSettings4.ImageListProvider = null;
            superTipSettings4.Text = "请输入数据库连接用户名";
            this.janusSuperTip.SetSuperTip(this.edtFISUserName, superTipSettings4);
            this.edtFISUserName.TabIndex = 8;
            this.edtFISUserName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            // 
            // edtFISServerIP
            // 
            this.edtFISServerIP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtFISServerIP.Location = new System.Drawing.Point(494, 37);
            this.edtFISServerIP.Name = "edtFISServerIP";
            this.edtFISServerIP.Size = new System.Drawing.Size(131, 22);
            superTipSettings5.FooterText = "系统提示";
            superTipSettings5.HeaderText = "数据库地址";
            superTipSettings5.ImageListProvider = null;
            superTipSettings5.Text = "请输入军财一号SQL Server数据库服务器IP地址";
            this.janusSuperTip.SetSuperTip(this.edtFISServerIP, superTipSettings5);
            this.edtFISServerIP.TabIndex = 6;
            this.edtFISServerIP.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(416, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "数据库名称：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(646, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "密码：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(631, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "用户名：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(416, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "数据库地址：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(418, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "军财一号系统信息：";
            // 
            // edtHISDBName
            // 
            this.edtHISDBName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtHISDBName.Location = new System.Drawing.Point(102, 66);
            this.edtHISDBName.Name = "edtHISDBName";
            this.edtHISDBName.Size = new System.Drawing.Size(117, 22);
            this.edtHISDBName.TabIndex = 3;
            this.edtHISDBName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            // 
            // edtHISPassword
            // 
            this.edtHISPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtHISPassword.Location = new System.Drawing.Point(281, 66);
            this.edtHISPassword.Name = "edtHISPassword";
            this.edtHISPassword.PasswordChar = '*';
            this.edtHISPassword.Size = new System.Drawing.Size(104, 22);
            superTipSettings6.FooterText = "系统提示";
            superTipSettings6.HeaderText = "密码";
            superTipSettings6.ImageListProvider = null;
            superTipSettings6.Text = "输入数据库连接密码";
            this.janusSuperTip.SetSuperTip(this.edtHISPassword, superTipSettings6);
            this.edtHISPassword.TabIndex = 5;
            this.edtHISPassword.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            // 
            // edtHISUserName
            // 
            this.edtHISUserName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtHISUserName.Location = new System.Drawing.Point(281, 37);
            this.edtHISUserName.Name = "edtHISUserName";
            this.edtHISUserName.Size = new System.Drawing.Size(104, 22);
            superTipSettings7.FooterText = "系统提示";
            superTipSettings7.HeaderText = "用户名";
            superTipSettings7.ImageListProvider = null;
            superTipSettings7.Text = "输入数据库连接用户名";
            this.janusSuperTip.SetSuperTip(this.edtHISUserName, superTipSettings7);
            this.edtHISUserName.TabIndex = 4;
            this.edtHISUserName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            // 
            // edtHISServerIP
            // 
            this.edtHISServerIP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtHISServerIP.Location = new System.Drawing.Point(102, 37);
            this.edtHISServerIP.Name = "edtHISServerIP";
            this.edtHISServerIP.Size = new System.Drawing.Size(117, 22);
            superTipSettings8.FooterText = "系统提示";
            superTipSettings8.HeaderText = "数据库别名";
            superTipSettings8.ImageListProvider = null;
            superTipSettings8.Text = "输入在 Oracle 客户端（Net Manager）中配置的军卫一号数据库别名，请咨询数据库管理员";
            this.janusSuperTip.SetSuperTip(this.edtHISServerIP, superTipSettings8);
            this.edtHISServerIP.TabIndex = 2;
            this.edtHISServerIP.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            this.edtHISServerIP.TextChanged += new System.EventHandler(this.edtHISServerIP_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(24, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "全局数据库：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(243, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "密码：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(231, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "用户名：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(23, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "数据库别名：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "军卫一号系统信息：";
            // 
            // btnCalcAll
            // 
            this.btnCalcAll.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCalcAll.Image = global::HPES.Properties.Resources.calculator;
            this.btnCalcAll.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center;
            this.btnCalcAll.ImageSize = new System.Drawing.Size(48, 48);
            this.btnCalcAll.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.TopOfText;
            this.btnCalcAll.Location = new System.Drawing.Point(805, 8);
            this.btnCalcAll.Name = "btnCalcAll";
            this.btnCalcAll.Size = new System.Drawing.Size(87, 79);
            this.btnCalcAll.TabIndex = 10;
            this.btnCalcAll.Text = "全部计算(&P)";
            this.btnCalcAll.TextVerticalAlignment = Janus.Windows.EditControls.TextAlignment.Far;
            this.btnCalcAll.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
            this.btnCalcAll.Click += new System.EventHandler(this.btnCalcAll_Click);
            // 
            // gridEX1
            // 
            this.gridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridEX1.AlternatingColors = true;
            this.gridEX1.BuiltInTextsData = resources.GetString("gridEX1.BuiltInTextsData");
            this.gridEX1.ControlStyle.HoverBaseColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridEX1.DataSource = this.hpes_queryBindingSource;
            gridEX1_DesignTimeLayout.LayoutString = resources.GetString("gridEX1_DesignTimeLayout.LayoutString");
            this.gridEX1.DesignTimeLayout = gridEX1_DesignTimeLayout;
            this.gridEX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEX1.EmptyGridInfoAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.gridEX1.Font = new System.Drawing.Font("宋体", 9F);
            this.gridEX1.GroupIndent = 12;
            this.gridEX1.GroupRowFormatStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.gridEX1.GroupRowFormatStyle.Key = "SubjectEval";
            this.gridEX1.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003;
            this.gridEX1.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup;
            this.gridEX1.HasEditorsControlStyle = true;
            this.gridEX1.HeaderFormatStyle.Font = new System.Drawing.Font("宋体", 10.5F);
            this.gridEX1.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEX1.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.gridEX1.Hierarchical = true;
            this.gridEX1.HierarchicalExpandBoxStyle = Janus.Windows.GridEX.ExpandBoxStyle.Arrows;
            this.gridEX1.Location = new System.Drawing.Point(0, 100);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue;
            this.gridEX1.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridEX1.ShowEmptyFields = false;
            this.gridEX1.Size = new System.Drawing.Size(903, 442);
            superTipSettings1.ImageListProvider = null;
            this.janusSuperTip.SetSuperTip(this.gridEX1, superTipSettings1);
            this.gridEX1.TabIndex = 1;
            this.gridEX1.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.gridEX1.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.gridEX1.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            this.gridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            this.gridEX1.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.gridEX1_ColumnButtonClick);
            this.gridEX1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridEX1_MouseMove);
            // 
            // hpes_queryBindingSource
            // 
            this.hpes_queryBindingSource.DataMember = "hpes_query";
            this.hpes_queryBindingSource.DataSource = this.dsQuery;
            // 
            // dsQuery
            // 
            this.dsQuery.DataSetName = "dsQuery";
            this.dsQuery.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridEXExporter1
            // 
            this.gridEXExporter1.GridEX = this.gridEX1;
            // 
            // gridEXPrintDocument1
            // 
            this.gridEXPrintDocument1.GridEX = this.gridEX1;
            this.gridEXPrintDocument1.PageHeaderLeft = "医院内涵建设指标量化考评管理系统";
            this.gridEXPrintDocument1.PageHeaderRight = "客观评分打印";
            // 
            // janusSuperTip
            // 
            this.janusSuperTip.AutoPopDelay = 2000;
            this.janusSuperTip.ImageList = null;
            this.janusSuperTip.OfficeColorScheme = Janus.Windows.Common.OfficeColorScheme.Blue;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = HPES.dsEvaluationTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dsHospital1
            // 
            this.dsHospital1.DataSetName = "dsHospital";
            this.dsHospital1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsHospitalTableAdapter1
            // 
            this.dsHospitalTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.hpes_standard_pointTableAdapter = this.hpes_standard_pointTableAdapter;
            this.tableAdapterManager1.UpdateOrder = HPES.dsPointTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hpes_standard_pointTableAdapter
            // 
            this.hpes_standard_pointTableAdapter.ClearBeforeFill = true;
            // 
            // dsPoint
            // 
            this.dsPoint.DataSetName = "dsPoint";
            this.dsPoint.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hpes_queryTableAdapter
            // 
            this.hpes_queryTableAdapter.ClearBeforeFill = true;
            // 
            // hpes_query_dataTableAdapter
            // 
            this.hpes_query_dataTableAdapter.ClearBeforeFill = true;
            // 
            // frmSubjectEval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 542);
            this.Controls.Add(this.gridEX1);
            this.Controls.Add(this.boxServerInfo);
            this.Name = "frmSubjectEval";
            this.Text = "外部数据提取";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSubjectEval_Load);
            this.Activated += new System.EventHandler(this.frmSubjectEval_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxServerInfo)).EndInit();
            this.boxServerInfo.ResumeLayout(false);
            this.boxServerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpes_queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHospital1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPoint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private Janus.Windows.EditControls.UIGroupBox boxServerInfo;
        private Janus.Windows.EditControls.UIButton btnCalcAll;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.GridEX.EditControls.EditBox edtHISServerIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.GridEX.EditControls.EditBox edtHISPassword;
        private Janus.Windows.GridEX.EditControls.EditBox edtHISUserName;
        private System.Windows.Forms.Label label5;
        private Janus.Windows.GridEX.EditControls.EditBox edtHISDBName;
        private Janus.Windows.GridEX.GridEX gridEX1;
        private HPES.dsEvaluationTableAdapters.TableAdapterManager tableAdapterManager;
        public Janus.Windows.GridEX.Export.GridEXExporter gridEXExporter1;
        public Janus.Windows.GridEX.GridEXPrintDocument gridEXPrintDocument1;
        private Janus.Windows.GridEX.EditControls.EditBox edtFISDBName;
        private Janus.Windows.GridEX.EditControls.EditBox edtFISPassword;
        private Janus.Windows.GridEX.EditControls.EditBox edtFISUserName;
        private Janus.Windows.GridEX.EditControls.EditBox edtFISServerIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private dsHospital dsHospital1;
        private HPES.dsHospitalTableAdapters.dsHospitalTableAdapter dsHospitalTableAdapter1;
        private HPES.dsPointTableAdapters.TableAdapterManager tableAdapterManager1;
        private dsQuery dsQuery;
        private System.Windows.Forms.BindingSource hpes_queryBindingSource;
        private HPES.dsQueryTableAdapters.hpes_queryTableAdapter hpes_queryTableAdapter;
        private HPES.dsPointTableAdapters.hpes_standard_pointTableAdapter hpes_standard_pointTableAdapter;
        private dsPoint dsPoint;
        private HPES.dsQueryTableAdapters.hpes_query_dataTableAdapter hpes_query_dataTableAdapter;
        private Janus.Windows.Common.JanusSuperTip janusSuperTip;
    }
}