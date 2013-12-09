using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HPES.Formview.Main;
using Janus.Windows.GridEX;

namespace HPES.Formview.Scoreview
{
    public partial class frmQueryData : Form
    {
        public frmQueryData()
        {
            InitializeComponent();
        }

       
        private void frmQueryData_Load(object sender, EventArgs e)
        {
            frmSubjectEval frmTemp = (frmSubjectEval)this.Owner;
            try
            {
                this.hpes_query_dataTableAdapter.Fill(this.dsQuery.hpes_query_data, frmTemp.hid, frmTemp.yid);
                this.hpes_query_dataBindingSource.Filter = "QID = 5";
                //this.dsQuery.hpes_query.DefaultView.RowFilter = "QID = 5";
                GridEXRow[] rows=this.gridEX1.GetRows();
                if (this.gridEX1.RecordCount >= 5)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        rows[i].CheckState = RowCheckState.Checked;
                        rows[i].BeginEdit();
                        rows[i].Cells[0].Value = true;
                        rows[i].EndEdit();
                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void frmQueryData_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmSubjectEval frmTemp = (frmSubjectEval)this.Owner;
            GridEXRow[] datarows = this.gridEX1.GetCheckedRows();
            foreach (GridEXRow datarow in datarows)
            {
                frmTemp.sDIAGCODES += "'" + datarow.Cells[5].Value.ToString() + "', ";
            }
            frmTemp.sDIAGCODES = frmTemp.sDIAGCODES.Substring(0, frmTemp.sDIAGCODES.Length - 2);
        }

        private void gridEX1_CellValueChanged(object sender, ColumnActionEventArgs e)
        {
            if (e.Column.Caption == "选择")
            {
                GridEXRow row = this.gridEX1.CurrentRow;
                if (row.Cells[0].Value != null)
                {
                    if ((Boolean)row.Cells[0].Value)
                    {
                        row.CheckState = RowCheckState.Checked;
                    }
                    else
                    {
                        row.CheckState = RowCheckState.Unchecked;
                    }
                }
            }
        }
    }
}
