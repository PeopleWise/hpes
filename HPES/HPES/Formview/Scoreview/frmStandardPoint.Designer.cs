namespace HPES.Formview.Scoreview
{
    partial class frmStandardPoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStandardPoint));
            Janus.Windows.GridEX.GridEXLayout gridEX1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.dsStandardPoint = new HPES.dsStandardPoint();
            this.hpes_standard_pointBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hpes_standard_pointTableAdapter = new HPES.dsStandardPointTableAdapters.hpes_standard_pointTableAdapter();
            this.tableAdapterManager = new HPES.dsStandardPointTableAdapters.TableAdapterManager();
            this.hpes_standard_pointBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.hpes_standard_pointBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsStandardPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpes_standard_pointBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpes_standard_pointBindingNavigator)).BeginInit();
            this.hpes_standard_pointBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsStandardPoint
            // 
            this.dsStandardPoint.DataSetName = "dsStandardPoint";
            this.dsStandardPoint.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hpes_standard_pointBindingSource
            // 
            this.hpes_standard_pointBindingSource.DataMember = "hpes_standard_point";
            this.hpes_standard_pointBindingSource.DataSource = this.dsStandardPoint;
            // 
            // hpes_standard_pointTableAdapter
            // 
            this.hpes_standard_pointTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.hpes_standard_oneTableAdapter = null;
            this.tableAdapterManager.hpes_standard_pointTableAdapter = this.hpes_standard_pointTableAdapter;
            this.tableAdapterManager.hpes_standard_twoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HPES.dsStandardPointTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hpes_standard_pointBindingNavigator
            // 
            this.hpes_standard_pointBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hpes_standard_pointBindingNavigator.BindingSource = this.hpes_standard_pointBindingSource;
            this.hpes_standard_pointBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hpes_standard_pointBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hpes_standard_pointBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hpes_standard_pointBindingNavigatorSaveItem});
            this.hpes_standard_pointBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hpes_standard_pointBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hpes_standard_pointBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hpes_standard_pointBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hpes_standard_pointBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hpes_standard_pointBindingNavigator.Name = "hpes_standard_pointBindingNavigator";
            this.hpes_standard_pointBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hpes_standard_pointBindingNavigator.Size = new System.Drawing.Size(927, 25);
            this.hpes_standard_pointBindingNavigator.TabIndex = 0;
            this.hpes_standard_pointBindingNavigator.Text = "bindingNavigator1";
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
            // hpes_standard_pointBindingNavigatorSaveItem
            // 
            this.hpes_standard_pointBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hpes_standard_pointBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hpes_standard_pointBindingNavigatorSaveItem.Image")));
            this.hpes_standard_pointBindingNavigatorSaveItem.Name = "hpes_standard_pointBindingNavigatorSaveItem";
            this.hpes_standard_pointBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hpes_standard_pointBindingNavigatorSaveItem.Text = "保存数据";
            this.hpes_standard_pointBindingNavigatorSaveItem.Click += new System.EventHandler(this.hpes_standard_pointBindingNavigatorSaveItem_Click);
            // 
            // gridEX1
            // 
            this.gridEX1.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEX1.AlternatingColors = true;
            this.gridEX1.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>拖动一列到这" +
                "里进行汇总显示</GroupByBoxInfo></LocalizableData>";
            this.gridEX1.ColumnAutoResize = true;
            this.gridEX1.DataSource = this.hpes_standard_pointBindingSource;
            gridEX1_DesignTimeLayout.LayoutString = resources.GetString("gridEX1_DesignTimeLayout.LayoutString");
            this.gridEX1.DesignTimeLayout = gridEX1_DesignTimeLayout;
            this.gridEX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEX1.GroupByBoxVisible = false;
            this.gridEX1.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.UseRowStyle;
            this.gridEX1.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;
            this.gridEX1.Hierarchical = true;
            this.gridEX1.Location = new System.Drawing.Point(0, 25);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.Size = new System.Drawing.Size(927, 393);
            this.gridEX1.TabIndex = 2;
            this.gridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            // 
            // officeFormAdorner1
            // 
            this.officeFormAdorner1.Form = this;
            this.officeFormAdorner1.VisualStyle = Janus.Windows.Ribbon.VisualStyle.Office2010;
            // 
            // frmStandardPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 418);
            this.Controls.Add(this.gridEX1);
            this.Controls.Add(this.hpes_standard_pointBindingNavigator);
            this.Name = "frmStandardPoint";
            this.Text = "评价标准维护";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStandardPoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsStandardPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpes_standard_pointBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpes_standard_pointBindingNavigator)).EndInit();
            this.hpes_standard_pointBindingNavigator.ResumeLayout(false);
            this.hpes_standard_pointBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsStandardPoint dsStandardPoint;
        private System.Windows.Forms.BindingSource hpes_standard_pointBindingSource;
        private HPES.dsStandardPointTableAdapters.hpes_standard_pointTableAdapter hpes_standard_pointTableAdapter;
        private HPES.dsStandardPointTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hpes_standard_pointBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hpes_standard_pointBindingNavigatorSaveItem;
        private Janus.Windows.GridEX.GridEX gridEX1;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
    }
}