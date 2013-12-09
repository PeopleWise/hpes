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
    public partial class frmStandardPoint : Form
    {
        public frmStandardPoint()
        {
            InitializeComponent();
        }

        private void hpes_standard_pointBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hpes_standard_pointBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsStandardPoint);

        }

        private void frmStandardPoint_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dsStandardPoint.hpes_standard_point”中。您可以根据需要移动或移除它。
            this.hpes_standard_pointTableAdapter.Fill(this.dsStandardPoint.hpes_standard_point);

        }
    }
}
