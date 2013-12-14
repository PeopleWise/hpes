namespace HPES.Formview.Bookview
{
    partial class frmSubmitData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubmitData));
            Janus.Windows.GridEX.GridEXLayout gridEX1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.hpes_submit_dataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hpes_submit_dataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.hpes_submit_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSubmitData = new HPES.dsSubmitData();
            this.hpes_submit_dataTableAdapter = new HPES.dsSubmitDataTableAdapters.hpes_submit_dataTableAdapter();
            this.tableAdapterManager = new HPES.dsSubmitDataTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.hpes_submit_dataBindingNavigator)).BeginInit();
            this.hpes_submit_dataBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpes_submit_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSubmitData)).BeginInit();
            this.SuspendLayout();
            // 
            // hpes_submit_dataBindingNavigator
            // 
            this.hpes_submit_dataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hpes_submit_dataBindingNavigator.BindingSource = this.hpes_submit_dataBindingSource;
            this.hpes_submit_dataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hpes_submit_dataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hpes_submit_dataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hpes_submit_dataBindingNavigatorSaveItem});
            this.hpes_submit_dataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hpes_submit_dataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hpes_submit_dataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hpes_submit_dataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hpes_submit_dataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hpes_submit_dataBindingNavigator.Name = "hpes_submit_dataBindingNavigator";
            this.hpes_submit_dataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hpes_submit_dataBindingNavigator.Size = new System.Drawing.Size(443, 25);
            this.hpes_submit_dataBindingNavigator.TabIndex = 0;
            this.hpes_submit_dataBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // hpes_submit_dataBindingNavigatorSaveItem
            // 
            this.hpes_submit_dataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hpes_submit_dataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hpes_submit_dataBindingNavigatorSaveItem.Image")));
            this.hpes_submit_dataBindingNavigatorSaveItem.Name = "hpes_submit_dataBindingNavigatorSaveItem";
            this.hpes_submit_dataBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hpes_submit_dataBindingNavigatorSaveItem.Text = "保存数据";
            this.hpes_submit_dataBindingNavigatorSaveItem.Click += new System.EventHandler(this.hpes_submit_dataBindingNavigatorSaveItem_Click_1);
            // 
            // gridEX1
            // 
            this.gridEX1.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEX1.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEX1.AlternatingColors = true;
            this.gridEX1.ColumnAutoResize = true;
            this.gridEX1.DataSource = this.hpes_submit_dataBindingSource;
            gridEX1_DesignTimeLayout.LayoutString = resources.GetString("gridEX1_DesignTimeLayout.LayoutString");
            this.gridEX1.DesignTimeLayout = gridEX1_DesignTimeLayout;
            this.gridEX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEX1.GroupByBoxVisible = false;
            this.gridEX1.Location = new System.Drawing.Point(0, 25);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.Size = new System.Drawing.Size(443, 269);
            this.gridEX1.TabIndex = 1;
            this.gridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            //this.gridEX1.AddingRecord += new System.ComponentModel.CancelEventHandler(this.gridEX1_AddingRecord);
            // 
            // hpes_submit_dataBindingSource
            // 
            this.hpes_submit_dataBindingSource.DataMember = "hpes_submit_data";
            this.hpes_submit_dataBindingSource.DataSource = this.dsSubmitData;
            // 
            // dsSubmitData
            // 
            this.dsSubmitData.DataSetName = "dsSubmitData";
            this.dsSubmitData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hpes_submit_dataTableAdapter
            // 
            this.hpes_submit_dataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.hpes_submit_dataTableAdapter = this.hpes_submit_dataTableAdapter;
            this.tableAdapterManager.UpdateOrder = HPES.dsSubmitDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmSubmitData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 294);
            this.Controls.Add(this.gridEX1);
            this.Controls.Add(this.hpes_submit_dataBindingNavigator);
            this.Name = "frmSubmitData";
            this.Text = "基础数据";
            this.Load += new System.EventHandler(this.frmSubmitData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hpes_submit_dataBindingNavigator)).EndInit();
            this.hpes_submit_dataBindingNavigator.ResumeLayout(false);
            this.hpes_submit_dataBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpes_submit_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSubmitData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsSubmitData dsSubmitData;
        private System.Windows.Forms.BindingSource hpes_submit_dataBindingSource;
        private HPES.dsSubmitDataTableAdapters.hpes_submit_dataTableAdapter hpes_submit_dataTableAdapter;
        private HPES.dsSubmitDataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hpes_submit_dataBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hpes_submit_dataBindingNavigatorSaveItem;
        private Janus.Windows.GridEX.GridEX gridEX1;

    }
}