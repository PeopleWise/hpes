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
    public partial class frmStandardTwo : Form
    {
        public frmStandardTwo()
        {
            InitializeComponent();
        }

        private void hpes_standard_twoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hpes_standard_twoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsStandardTwo);

        }

        private void frmStandardTwo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dsStandardTwo.hpes_standard_two”中。您可以根据需要移动或移除它。
            this.hpes_standard_twoTableAdapter.Fill(this.dsStandardTwo.hpes_standard_two);
            this.hpes_standard_oneTableAdapter.Fill(this.dsStandardOne.hpes_standard_one);
            this.gridEX1.DropDowns[0].DataSource = this.dsStandardOne.hpes_standard_one;
            this.gridEX1.DropDowns[0].Refetch();

        }
    }
}
