using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HPES.Formview.Main;

namespace HPES.Formview.Bookview
{
    public partial class frmSubmitDataModel : Form
    {
        public frmSubmitDataModel()
        {
            InitializeComponent();
        }

       

        private void frmSubmitDataModel_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dsSubmitDictionary.hpes_submit_dictionary”中。您可以根据需要移动或移除它。
            this.hpes_submit_dictionaryTableAdapter.Fill(this.dsSubmitDictionary.hpes_submit_dictionary);
            // TODO: 这行代码将数据加载到表“dsSubmitDictionary.hpes_submit_dictionary”中。您可以根据需要移动或移除它。
            this.hpes_submit_dictionaryTableAdapter.Fill(this.dsSubmitDictionary.hpes_submit_dictionary);
            // TODO: 这行代码将数据加载到表“dsSubmitDictionary.hpes_submit_dictionary”中。您可以根据需要移动或移除它。
            this.hpes_submit_dictionaryTableAdapter.Fill(this.dsSubmitDictionary.hpes_submit_dictionary);
            // TODO: 这行代码将数据加载到表“dsSubmitDictionary.hpes_submit_dictionary”中。您可以根据需要移动或移除它。
            this.hpes_submit_dictionaryTableAdapter.Fill(this.dsSubmitDictionary.hpes_submit_dictionary);
            // TODO: 这行代码将数据加载到表“dsSubmitDictionary.hpes_submit_dictionary”中。您可以根据需要移动或移除它。
            this.hpes_submit_dictionaryTableAdapter.Fill(this.dsSubmitDictionary.hpes_submit_dictionary);
            // TODO: 这行代码将数据加载到表“dsSubmitData.hpes_submit_data”中。您可以根据需要移动或移除它。
            frmMain frm = (frmMain)this.ParentForm;
            
        }

     

        private void hpes_submit_dictionaryBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.hpes_submit_dictionaryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsSubmitDictionary);

        }

        private void hpes_submit_dictionaryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hpes_submit_dictionaryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsSubmitDictionary);

        }

        private void hpes_submit_dictionaryBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.hpes_submit_dictionaryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsSubmitDictionary);

        }

        private void hpes_submit_dictionaryBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.hpes_submit_dictionaryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsSubmitDictionary);

        }
    }
}
