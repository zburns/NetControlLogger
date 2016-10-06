using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NetControlLogger
{
    public partial class FormSelectANet : DevExpress.XtraEditors.XtraForm
    {
        public FormSelectANet()
        {
            InitializeComponent();
        }

        private void simpleButtonGoToNetControl_Click(object sender, EventArgs e)
        {
            if (listBoxControlNets.SelectedItem != null)
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}