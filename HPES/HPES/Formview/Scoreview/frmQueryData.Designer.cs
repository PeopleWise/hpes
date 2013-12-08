namespace HPES.Formview.Scoreview
{
    partial class frmQueryData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQueryData));
            Janus.Windows.GridEX.GridEXLayout gridEX1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.dsQuery = new HPES.dsQuery();
            this.hpes_query_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hpes_query_dataTableAdapter = new HPES.dsQueryTableAdapters.hpes_query_dataTableAdapter();
            this.tableAdapterManager = new HPES.dsQueryTableAdapters.TableAdapterManager();
            this.hpes_query_dataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.hpes_query_dataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.hIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.hIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.yIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.yIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.uiCommandManager1 = new Janus.Windows.UI.CommandBars.UICommandManager(this.components);
            this.TopRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.LeftRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.RightRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.BottomRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.Command0 = new Janus.Windows.UI.CommandBars.UICommand("Command0");
            this.Command1 = new Janus.Windows.UI.CommandBars.UICommand("Command1");
            this.uiCommandBar1 = new Janus.Windows.UI.CommandBars.UICommandBar();
            this.Command01 = new Janus.Windows.UI.CommandBars.UICommand("Command0");
            this.Command11 = new Janus.Windows.UI.CommandBars.UICommand("Command1");
            this.Separator1 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpes_query_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpes_query_dataBindingNavigator)).BeginInit();
            this.hpes_query_dataBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCommandManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).BeginInit();
            this.BottomRebar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiCommandBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsQuery
            // 
            this.dsQuery.DataSetName = "dsQuery";
            this.dsQuery.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hpes_query_dataBindingSource
            // 
            this.hpes_query_dataBindingSource.DataMember = "hpes_query_data";
            this.hpes_query_dataBindingSource.DataSource = this.dsQuery;
            // 
            // hpes_query_dataTableAdapter
            // 
            this.hpes_query_dataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.hpes_query_dataTableAdapter = this.hpes_query_dataTableAdapter;
            this.tableAdapterManager.hpes_queryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HPES.dsQueryTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hpes_query_dataBindingNavigator
            // 
            this.hpes_query_dataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hpes_query_dataBindingNavigator.BindingSource = this.hpes_query_dataBindingSource;
            this.hpes_query_dataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hpes_query_dataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hpes_query_dataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.hpes_query_dataBindingNavigatorSaveItem});
            this.hpes_query_dataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hpes_query_dataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hpes_query_dataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hpes_query_dataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hpes_query_dataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hpes_query_dataBindingNavigator.Name = "hpes_query_dataBindingNavigator";
            this.hpes_query_dataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hpes_query_dataBindingNavigator.Size = new System.Drawing.Size(899, 25);
            this.hpes_query_dataBindingNavigator.TabIndex = 0;
            this.hpes_query_dataBindingNavigator.Text = "bindingNavigator1";
            this.hpes_query_dataBindingNavigator.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // hpes_query_dataBindingNavigatorSaveItem
            // 
            this.hpes_query_dataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hpes_query_dataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hpes_query_dataBindingNavigatorSaveItem.Image")));
            this.hpes_query_dataBindingNavigatorSaveItem.Name = "hpes_query_dataBindingNavigatorSaveItem";
            this.hpes_query_dataBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hpes_query_dataBindingNavigatorSaveItem.Text = "保存数据";
            this.hpes_query_dataBindingNavigatorSaveItem.Click += new System.EventHandler(this.hpes_query_dataBindingNavigatorSaveItem_Click);
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hIDToolStripLabel,
            this.hIDToolStripTextBox,
            this.yIDToolStripLabel,
            this.yIDToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(899, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            this.fillToolStrip.Visible = false;
            // 
            // hIDToolStripLabel
            // 
            this.hIDToolStripLabel.Name = "hIDToolStripLabel";
            this.hIDToolStripLabel.Size = new System.Drawing.Size(29, 22);
            this.hIDToolStripLabel.Text = "HID:";
            // 
            // hIDToolStripTextBox
            // 
            this.hIDToolStripTextBox.Name = "hIDToolStripTextBox";
            this.hIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // yIDToolStripLabel
            // 
            this.yIDToolStripLabel.Name = "yIDToolStripLabel";
            this.yIDToolStripLabel.Size = new System.Drawing.Size(29, 22);
            this.yIDToolStripLabel.Text = "YID:";
            // 
            // yIDToolStripTextBox
            // 
            this.yIDToolStripTextBox.Name = "yIDToolStripTextBox";
            this.yIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(33, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // gridEX1
            // 
            this.gridEX1.DataSource = this.hpes_query_dataBindingSource;
            gridEX1_DesignTimeLayout.LayoutString = resources.GetString("gridEX1_DesignTimeLayout.LayoutString");
            this.gridEX1.DesignTimeLayout = gridEX1_DesignTimeLayout;
            this.gridEX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEX1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridEX1.GroupByBoxVisible = false;
            this.gridEX1.Location = new System.Drawing.Point(0, 0);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridEX1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEX1.Size = new System.Drawing.Size(474, 359);
            this.gridEX1.TabIndex = 2;
            this.gridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            // 
            // uiCommandManager1
            // 
            this.uiCommandManager1.AllowClose = Janus.Windows.UI.InheritableBoolean.False;
            this.uiCommandManager1.AllowCustomize = Janus.Windows.UI.InheritableBoolean.False;
            this.uiCommandManager1.BottomRebar = this.BottomRebar1;
            this.uiCommandManager1.CommandBars.AddRange(new Janus.Windows.UI.CommandBars.UICommandBar[] {
            this.uiCommandBar1});
            this.uiCommandManager1.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.Command0,
            this.Command1});
            this.uiCommandManager1.ContainerControl = this;
            // 
            // 
            // 
            this.uiCommandManager1.EditContextMenu.Key = "";
            this.uiCommandManager1.Id = new System.Guid("6ee6b2eb-64c0-4168-935c-e0ca29dd09f1");
            this.uiCommandManager1.ImageList = this.imageList1;
            this.uiCommandManager1.LeftRebar = this.LeftRebar1;
            this.uiCommandManager1.RightRebar = this.RightRebar1;
            this.uiCommandManager1.ShowAddRemoveButton = Janus.Windows.UI.InheritableBoolean.False;
            this.uiCommandManager1.ShowCustomizeButton = Janus.Windows.UI.InheritableBoolean.False;
            this.uiCommandManager1.ShowQuickCustomizeMenu = false;
            this.uiCommandManager1.TopRebar = this.TopRebar1;
            this.uiCommandManager1.View = Janus.Windows.UI.CommandBars.View.LargeIcons;
            this.uiCommandManager1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
            // 
            // TopRebar1
            // 
            this.TopRebar1.CommandManager = this.uiCommandManager1;
            this.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopRebar1.Location = new System.Drawing.Point(0, 0);
            this.TopRebar1.Name = "TopRebar1";
            this.TopRebar1.Size = new System.Drawing.Size(474, 0);
            // 
            // LeftRebar1
            // 
            this.LeftRebar1.CommandManager = this.uiCommandManager1;
            this.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftRebar1.Location = new System.Drawing.Point(0, 0);
            this.LeftRebar1.Name = "LeftRebar1";
            this.LeftRebar1.Size = new System.Drawing.Size(0, 359);
            // 
            // RightRebar1
            // 
            this.RightRebar1.CommandManager = this.uiCommandManager1;
            this.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightRebar1.Location = new System.Drawing.Point(474, 0);
            this.RightRebar1.Name = "RightRebar1";
            this.RightRebar1.Size = new System.Drawing.Size(0, 359);
            // 
            // BottomRebar1
            // 
            this.BottomRebar1.CommandBars.AddRange(new Janus.Windows.UI.CommandBars.UICommandBar[] {
            this.uiCommandBar1});
            this.BottomRebar1.CommandManager = this.uiCommandManager1;
            this.BottomRebar1.Controls.Add(this.uiCommandBar1);
            this.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomRebar1.Location = new System.Drawing.Point(0, 359);
            this.BottomRebar1.Name = "BottomRebar1";
            this.BottomRebar1.Size = new System.Drawing.Size(474, 32);
            // 
            // Command0
            // 
            this.Command0.ImageIndex = 0;
            this.Command0.Key = "Command0";
            this.Command0.Name = "Command0";
            this.Command0.Text = "确定";
            // 
            // Command1
            // 
            this.Command1.ImageIndex = 1;
            this.Command1.Key = "Command1";
            this.Command1.Name = "Command1";
            this.Command1.Text = "取消";
            // 
            // uiCommandBar1
            // 
            this.uiCommandBar1.AllowClose = Janus.Windows.UI.InheritableBoolean.False;
            this.uiCommandBar1.AllowCustomize = Janus.Windows.UI.InheritableBoolean.False;
            this.uiCommandBar1.AllowMerge = Janus.Windows.UI.InheritableBoolean.False;
            this.uiCommandBar1.CommandManager = this.uiCommandManager1;
            this.uiCommandBar1.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.Command01,
            this.Separator1,
            this.Command11});
            this.uiCommandBar1.CommandsStyle = Janus.Windows.UI.CommandBars.CommandStyle.TextImage;
            this.uiCommandBar1.DockStyle = Janus.Windows.UI.CommandBars.BarsDockStyle.Bottom;
            this.uiCommandBar1.FullRow = true;
            this.uiCommandBar1.ImageList = this.imageList1;
            this.uiCommandBar1.Key = "CommandBar1";
            this.uiCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.uiCommandBar1.LockCommandBar = Janus.Windows.UI.InheritableBoolean.True;
            this.uiCommandBar1.Name = "uiCommandBar1";
            this.uiCommandBar1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue;
            this.uiCommandBar1.RowIndex = 0;
            this.uiCommandBar1.Size = new System.Drawing.Size(474, 32);
            this.uiCommandBar1.Text = "CommandBar1";
            this.uiCommandBar1.View = Janus.Windows.UI.CommandBars.View.LargeIcons;
            this.uiCommandBar1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
            this.uiCommandBar1.CommandClick += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.uiCommandBar1_CommandClick);
            // 
            // Command01
            // 
            this.Command01.DefaultItem = Janus.Windows.UI.InheritableBoolean.True;
            this.Command01.Key = "Command0";
            this.Command01.Name = "Command01";
            this.Command01.Text = "确定(&O)";
            // 
            // Command11
            // 
            this.Command11.Key = "Command1";
            this.Command11.Name = "Command11";
            this.Command11.Text = "取消(&X)";
            // 
            // Separator1
            // 
            this.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator1.Key = "Separator";
            this.Separator1.Name = "Separator1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save.png");
            this.imageList1.Images.SetKeyName(1, "block.png");
            // 
            // frmQueryData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 391);
            this.Controls.Add(this.gridEX1);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.hpes_query_dataBindingNavigator);
            this.Controls.Add(this.LeftRebar1);
            this.Controls.Add(this.RightRebar1);
            this.Controls.Add(this.BottomRebar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQueryData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "请选择五个诊断名称";
            ((System.ComponentModel.ISupportInitialize)(this.dsQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpes_query_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpes_query_dataBindingNavigator)).EndInit();
            this.hpes_query_dataBindingNavigator.ResumeLayout(false);
            this.hpes_query_dataBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCommandManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).EndInit();
            this.BottomRebar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiCommandBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsQuery dsQuery;
        private System.Windows.Forms.BindingSource hpes_query_dataBindingSource;
        private HPES.dsQueryTableAdapters.hpes_query_dataTableAdapter hpes_query_dataTableAdapter;
        private HPES.dsQueryTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hpes_query_dataBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton hpes_query_dataBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel hIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox hIDToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel yIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox yIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private Janus.Windows.UI.CommandBars.UICommandManager uiCommandManager1;
        private Janus.Windows.UI.CommandBars.UIRebar BottomRebar1;
        private Janus.Windows.UI.CommandBars.UICommandBar uiCommandBar1;
        private Janus.Windows.UI.CommandBars.UICommand Command0;
        private Janus.Windows.UI.CommandBars.UICommand Command1;
        private Janus.Windows.UI.CommandBars.UIRebar LeftRebar1;
        private Janus.Windows.UI.CommandBars.UIRebar RightRebar1;
        private Janus.Windows.UI.CommandBars.UIRebar TopRebar1;
        private Janus.Windows.UI.CommandBars.UICommand Command01;
        private Janus.Windows.UI.CommandBars.UICommand Separator1;
        private Janus.Windows.UI.CommandBars.UICommand Command11;
        private System.Windows.Forms.ImageList imageList1;
        public Janus.Windows.GridEX.GridEX gridEX1;
    }
}