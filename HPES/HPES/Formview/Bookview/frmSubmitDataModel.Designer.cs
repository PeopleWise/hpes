﻿namespace HPES.Formview.Bookview
{
    partial class frmSubmitDataModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubmitDataModel));
            Janus.Windows.GridEX.GridEXLayout gridEX1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.dsSubmitDictionary = new HPES.dsSubmitDictionary();
            this.hpes_submit_dictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hpes_submit_dictionaryTableAdapter = new HPES.dsSubmitDictionaryTableAdapters.hpes_submit_dictionaryTableAdapter();
            this.tableAdapterManager = new HPES.dsSubmitDictionaryTableAdapters.TableAdapterManager();
            this.hpes_submit_dictionaryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.hpes_submit_dictionaryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dsSubmitDictionary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpes_submit_dictionaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpes_submit_dictionaryBindingNavigator)).BeginInit();
            this.hpes_submit_dictionaryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSubmitDictionary
            // 
            this.dsSubmitDictionary.DataSetName = "dsSubmitDictionary";
            this.dsSubmitDictionary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hpes_submit_dictionaryBindingSource
            // 
            this.hpes_submit_dictionaryBindingSource.DataMember = "hpes_submit_dictionary";
            this.hpes_submit_dictionaryBindingSource.DataSource = this.dsSubmitDictionary;
            // 
            // hpes_submit_dictionaryTableAdapter
            // 
            this.hpes_submit_dictionaryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.hpes_submit_dictionaryTableAdapter = this.hpes_submit_dictionaryTableAdapter;
            this.tableAdapterManager.UpdateOrder = HPES.dsSubmitDictionaryTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hpes_submit_dictionaryBindingNavigator
            // 
            this.hpes_submit_dictionaryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hpes_submit_dictionaryBindingNavigator.BindingSource = this.hpes_submit_dictionaryBindingSource;
            this.hpes_submit_dictionaryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hpes_submit_dictionaryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hpes_submit_dictionaryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hpes_submit_dictionaryBindingNavigatorSaveItem});
            this.hpes_submit_dictionaryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hpes_submit_dictionaryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hpes_submit_dictionaryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hpes_submit_dictionaryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hpes_submit_dictionaryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hpes_submit_dictionaryBindingNavigator.Name = "hpes_submit_dictionaryBindingNavigator";
            this.hpes_submit_dictionaryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hpes_submit_dictionaryBindingNavigator.Size = new System.Drawing.Size(565, 25);
            this.hpes_submit_dictionaryBindingNavigator.TabIndex = 0;
            this.hpes_submit_dictionaryBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
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
            // gridEX1
            // 
            this.gridEX1.DataSource = this.hpes_submit_dictionaryBindingSource;
            gridEX1_DesignTimeLayout.LayoutString = resources.GetString("gridEX1_DesignTimeLayout.LayoutString");
            this.gridEX1.DesignTimeLayout = gridEX1_DesignTimeLayout;
            this.gridEX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEX1.GroupByBoxVisible = false;
            this.gridEX1.Location = new System.Drawing.Point(0, 25);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.Size = new System.Drawing.Size(565, 480);
            this.gridEX1.TabIndex = 1;
            // 
            // hpes_submit_dictionaryBindingNavigatorSaveItem
            // 
            this.hpes_submit_dictionaryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hpes_submit_dictionaryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hpes_submit_dictionaryBindingNavigatorSaveItem.Image")));
            this.hpes_submit_dictionaryBindingNavigatorSaveItem.Name = "hpes_submit_dictionaryBindingNavigatorSaveItem";
            this.hpes_submit_dictionaryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hpes_submit_dictionaryBindingNavigatorSaveItem.Text = "保存数据";
            this.hpes_submit_dictionaryBindingNavigatorSaveItem.Click += new System.EventHandler(this.hpes_submit_dictionaryBindingNavigatorSaveItem_Click_3);
            // 
            // frmSubmitDataModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 505);
            this.Controls.Add(this.gridEX1);
            this.Controls.Add(this.hpes_submit_dictionaryBindingNavigator);
            this.Name = "frmSubmitDataModel";
            this.Text = "基础数据模板";
            this.Load += new System.EventHandler(this.frmSubmitDataModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSubmitDictionary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpes_submit_dictionaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpes_submit_dictionaryBindingNavigator)).EndInit();
            this.hpes_submit_dictionaryBindingNavigator.ResumeLayout(false);
            this.hpes_submit_dictionaryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsSubmitDictionary dsSubmitDictionary;
        private System.Windows.Forms.BindingSource hpes_submit_dictionaryBindingSource;
        private HPES.dsSubmitDictionaryTableAdapters.hpes_submit_dictionaryTableAdapter hpes_submit_dictionaryTableAdapter;
        private HPES.dsSubmitDictionaryTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hpes_submit_dictionaryBindingNavigator;
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
        private Janus.Windows.GridEX.GridEX gridEX1;
        private System.Windows.Forms.ToolStripButton hpes_submit_dictionaryBindingNavigatorSaveItem;





    }
}