namespace NetControlLogger
{
    partial class FormSetNetCondition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.simpleButtonOpenNet = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonNetConditionGreen = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonNetConditionYellow = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonNetConditionRed = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // simpleButtonOpenNet
            // 
            this.simpleButtonOpenNet.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButtonOpenNet.Appearance.Options.UseBackColor = true;
            this.simpleButtonOpenNet.Location = new System.Drawing.Point(12, 24);
            this.simpleButtonOpenNet.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButtonOpenNet.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonOpenNet.Name = "simpleButtonOpenNet";
            this.simpleButtonOpenNet.Size = new System.Drawing.Size(260, 23);
            this.simpleButtonOpenNet.TabIndex = 0;
            this.simpleButtonOpenNet.Text = "&Open Net";
            this.simpleButtonOpenNet.Click += new System.EventHandler(this.simpleButtonOpenNet_Click);
            // 
            // simpleButtonNetConditionGreen
            // 
            this.simpleButtonNetConditionGreen.Appearance.BackColor = System.Drawing.Color.Lime;
            this.simpleButtonNetConditionGreen.Appearance.Options.UseBackColor = true;
            this.simpleButtonNetConditionGreen.Location = new System.Drawing.Point(12, 84);
            this.simpleButtonNetConditionGreen.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButtonNetConditionGreen.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonNetConditionGreen.Name = "simpleButtonNetConditionGreen";
            this.simpleButtonNetConditionGreen.Size = new System.Drawing.Size(260, 23);
            this.simpleButtonNetConditionGreen.TabIndex = 1;
            this.simpleButtonNetConditionGreen.Text = "&Directed Net - Condition Green";
            this.simpleButtonNetConditionGreen.Click += new System.EventHandler(this.simpleButtonNetConditionGreen_Click);
            // 
            // simpleButtonNetConditionYellow
            // 
            this.simpleButtonNetConditionYellow.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.simpleButtonNetConditionYellow.Appearance.Options.UseBackColor = true;
            this.simpleButtonNetConditionYellow.Location = new System.Drawing.Point(12, 113);
            this.simpleButtonNetConditionYellow.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButtonNetConditionYellow.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonNetConditionYellow.Name = "simpleButtonNetConditionYellow";
            this.simpleButtonNetConditionYellow.Size = new System.Drawing.Size(260, 23);
            this.simpleButtonNetConditionYellow.TabIndex = 2;
            this.simpleButtonNetConditionYellow.Text = "&Directed Net - Condition Yellow";
            this.simpleButtonNetConditionYellow.Click += new System.EventHandler(this.simpleButtonNetConditionYellow_Click);
            // 
            // simpleButtonNetConditionRed
            // 
            this.simpleButtonNetConditionRed.Appearance.BackColor = System.Drawing.Color.Red;
            this.simpleButtonNetConditionRed.Appearance.Options.UseBackColor = true;
            this.simpleButtonNetConditionRed.Location = new System.Drawing.Point(12, 142);
            this.simpleButtonNetConditionRed.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButtonNetConditionRed.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonNetConditionRed.Name = "simpleButtonNetConditionRed";
            this.simpleButtonNetConditionRed.Size = new System.Drawing.Size(260, 23);
            this.simpleButtonNetConditionRed.TabIndex = 3;
            this.simpleButtonNetConditionRed.Text = "&Directed Net - Condition Red";
            this.simpleButtonNetConditionRed.Click += new System.EventHandler(this.simpleButtonNetConditionRed_Click);
            // 
            // FormSetNetCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 187);
            this.ControlBox = false;
            this.Controls.Add(this.simpleButtonNetConditionRed);
            this.Controls.Add(this.simpleButtonNetConditionYellow);
            this.Controls.Add(this.simpleButtonNetConditionGreen);
            this.Controls.Add(this.simpleButtonOpenNet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetNetCondition";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Net Condition";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonOpenNet;
        private DevExpress.XtraEditors.SimpleButton simpleButtonNetConditionGreen;
        private DevExpress.XtraEditors.SimpleButton simpleButtonNetConditionYellow;
        private DevExpress.XtraEditors.SimpleButton simpleButtonNetConditionRed;
    }
}
