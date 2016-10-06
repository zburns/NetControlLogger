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
    public partial class FormSetNetCondition : DevExpress.XtraEditors.XtraForm
    {
        public string NetCondition = "Open";

        public FormSetNetCondition()
        {
            InitializeComponent();
        }

        private void simpleButtonOpenNet_Click(object sender, EventArgs e)
        {
            NetCondition = "Open";
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void simpleButtonNetConditionGreen_Click(object sender, EventArgs e)
        {
            NetCondition = "Green";
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void simpleButtonNetConditionYellow_Click(object sender, EventArgs e)
        {
            NetCondition = "Yellow";
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void simpleButtonNetConditionRed_Click(object sender, EventArgs e)
        {
            NetCondition = "Red";
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
