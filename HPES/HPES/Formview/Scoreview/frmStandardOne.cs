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
    public partial class frmStandardOne : Form
    {
        public frmStandardOne()
        {
            InitializeComponent();
        }

        private void hpes_standard_oneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hpes_standard_oneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsStandardOne);

        }

        private void frmStandardOne_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dsStandardOne.hpes_standard_one”中。您可以根据需要移动或移除它。
            this.hpes_standard_oneTableAdapter.Fill(this.dsStandardOne.hpes_standard_one);

        }
    }
}
