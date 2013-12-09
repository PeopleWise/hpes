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
            Janus.Windows.GridEX.GridEXLayout gridEX1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQueryData));
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.hpes_query_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQuery = new HPES.dsQuery();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.hpes_query_dataTableAdapter = new HPES.dsQueryTableAdapters.hpes_query_dataTableAdapter();
            this.tableAdapterManager = new HPES.dsQueryTableAdapters.TableAdapterManager();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpes_query_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEX1
            // 
            this.gridEX1.AlternatingColors = true;
            this.gridEX1.DataSource = this.hpes_query_dataBindingSource;
            gridEX1_DesignTimeLayout.LayoutString = resources.GetString("gridEX1_DesignTimeLayout.LayoutString");
            this.gridEX1.DesignTimeLayout = gridEX1_DesignTimeLayout;
            this.gridEX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEX1.DynamicFiltering = true;
            this.gridEX1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridEX1.GroupByBoxVisible = false;
            this.gridEX1.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridEX1.Location = new System.Drawing.Point(0, 0);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridEX1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEX1.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
            this.gridEX1.Size = new System.Drawing.Size(472, 389);
            this.gridEX1.TabIndex = 2;
            this.gridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            this.gridEX1.CellValueChanged += new Janus.Windows.GridEX.ColumnActionEventHandler(this.gridEX1_CellValueChanged);
            // 
            // hpes_query_dataBindingSource
            // 
            this.hpes_query_dataBindingSource.DataMember = "hpes_query_data";
            this.hpes_query_dataBindingSource.DataSource = this.dsQuery;
            // 
            // dsQuery
            // 
            this.dsQuery.DataSetName = "dsQuery";
            this.dsQuery.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save.png");
            this.imageList1.Images.SetKeyName(1, "block.png");
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
            // officeFormAdorner1
            // 
            this.officeFormAdorner1.Form = this;
            this.officeFormAdorner1.VisualStyle = Janus.Windows.Ribbon.VisualStyle.Office2010;
            // 
            // frmQueryData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 389);
            this.Controls.Add(this.gridEX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQueryData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "请选择五个诊断名称用来执行次均费用计算";
            this.Load += new System.EventHandler(this.frmQueryData_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQueryData_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpes_query_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private System.Windows.Forms.BindingSource hpes_query_dataBindingSource;
        private HPES.dsQueryTableAdapters.hpes_query_dataTableAdapter hpes_query_dataTableAdapter;
        private dsQuery dsQuery;
        private HPES.dsQueryTableAdapters.TableAdapterManager tableAdapterManager;
        public Janus.Windows.GridEX.GridEX gridEX1;
    }
}