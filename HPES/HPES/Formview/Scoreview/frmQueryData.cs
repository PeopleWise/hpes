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

        private void uiCommandBar1_CommandClick(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            if (e.Command.Text.IndexOf("确定")>0)
            {
                this.Hide();
            }
            else if (MessageBox.Show("您确定要放弃选择诊断名称吗？\n放弃选择将使用默认的前五种诊断名称进行单病种次均费用比计算。", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)==DialogResult.OK)
            {
                this.Hide();
            }
        }

        private void frmQueryData_Load(object sender, EventArgs e)
        {
            frmSubjectEval frmTemp = (frmSubjectEval)this.Owner;
            try
            {
                this.hpes_query_dataTableAdapter.Fill(this.dsQuery.hpes_query_data, frmTemp.hid, frmTemp.yid);
                this.dsQuery.hpes_query.DefaultView.RowFilter = "QID = 5";
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void frmQueryData_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmSubjectEval frmTemp = (frmSubjectEval)this.Owner;
            GridEXRow[] datarows = this.gridEX1.GetRows();
            foreach (GridEXRow datarow in datarows)
            {
                if ((Boolean)datarow.Cells[0].Value)
                {
                    frmTemp.sDIAGCODES += "'" + datarow.Cells[5].Value.ToString() + "', ";
                }
            }
        }
    }
}
