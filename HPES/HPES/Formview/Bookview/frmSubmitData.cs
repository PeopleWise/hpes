﻿using System;
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
    public partial class frmSubmitData : Form
    {
        public frmSubmitData()
        {
            InitializeComponent();
        }

        private void hpes_submit_dataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hpes_submit_dataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsSubmitData);

        }

        private void frmSubmitData_Load(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)this.ParentForm;
            // TODO: 这行代码将数据加载到表“dsSubmitData.hpes_submit_data”中。您可以根据需要移动或移除它。
            //Console.Write((int)frm.cboHospital.ComboBox.SelectedValue + (int)frm.cboYear.ComboBox.SelectedValue);

            this.dsSubmitData.hpes_submit_data.HIDColumn.DefaultValue = frmMain.hid;

            this.dsSubmitData.hpes_submit_data.YIDColumn.DefaultValue = frmMain.yid;

            this.hpes_submit_dataTableAdapter.Fill(this.dsSubmitData.hpes_submit_data, frmMain.hid, frmMain.yid);

        }

        private void hpes_submit_dataBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.hpes_submit_dataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsSubmitData);

        }

 

       
    }
}
