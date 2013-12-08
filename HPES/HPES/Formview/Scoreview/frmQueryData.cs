using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HPES.Formview.Scoreview
{
    public partial class frmQueryData : Form
    {
        public frmQueryData()
        {
            InitializeComponent();
        }

        private void hpes_query_dataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hpes_query_dataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsQuery);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.hpes_query_dataTableAdapter.Fill(this.dsQuery.hpes_query_data, ((int)(System.Convert.ChangeType(hIDToolStripTextBox.Text, typeof(int)))), ((int)(System.Convert.ChangeType(yIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void uiCommandBar1_CommandClick(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            if (MessageBox.Show("您确定要放弃选择诊断名称吗？\n放弃选择将使用默认的前五种诊断名称进行单病种次均费用比计算。", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)==DialogResult.OK)
            {

            }
        }
    }
}
