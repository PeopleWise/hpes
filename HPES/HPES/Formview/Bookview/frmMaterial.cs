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
    public partial class frmMaterial : Form
    {
        public frmMaterial()
        {
            InitializeComponent();
        }



        private void frmMaterial_Load(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)this.ParentForm;

            this.dsMaterial.hpes_material.HIDColumn.DefaultValue = (int)frm.cboHospital.ComboBox.SelectedValue;

            this.dsMaterial.hpes_material.YIDColumn.DefaultValue = (int)frm.cboYear.ComboBox.SelectedValue;

            this.hpes_materialTableAdapter.Fill(this.dsMaterial.hpes_material, (int)frm.cboHospital.ComboBox.SelectedValue, (int)frm.cboYear.ComboBox.SelectedValue);


        }

        private void hpes_materialBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.hpes_materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsMaterial);
        }






 
      



       
    }
}
