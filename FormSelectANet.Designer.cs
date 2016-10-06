namespace NetControlLogger
{
    partial class FormSelectANet
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
            this.listBoxControlNets = new DevExpress.XtraEditors.ListBoxControl();
            this.labelNetTitle = new System.Windows.Forms.Label();
            this.simpleButtonGoToNetControl = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlNets)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxControlNets
            // 
            this.listBoxControlNets.Location = new System.Drawing.Point(12, 37);
            this.listBoxControlNets.Name = "listBoxControlNets";
            this.listBoxControlNets.Size = new System.Drawing.Size(260, 189);
            this.listBoxControlNets.TabIndex = 0;
            // 
            // labelNetTitle
            // 
            this.labelNetTitle.Location = new System.Drawing.Point(12, 9);
            this.labelNetTitle.Name = "labelNetTitle";
            this.labelNetTitle.Size = new System.Drawing.Size(260, 25);
            this.labelNetTitle.TabIndex = 1;
            this.labelNetTitle.Text = "Select A Net";
            this.labelNetTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // simpleButtonGoToNetControl
            // 
            this.simpleButtonGoToNetControl.Location = new System.Drawing.Point(12, 232);
            this.simpleButtonGoToNetControl.Name = "simpleButtonGoToNetControl";
            this.simpleButtonGoToNetControl.Size = new System.Drawing.Size(260, 23);
            this.simpleButtonGoToNetControl.TabIndex = 2;
            this.simpleButtonGoToNetControl.Text = "Open Selected Net and Go to Net Control";
            this.simpleButtonGoToNetControl.Click += new System.EventHandler(this.simpleButtonGoToNetControl_Click);
            // 
            // FormSelectANet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.simpleButtonGoToNetControl);
            this.Controls.Add(this.labelNetTitle);
            this.Controls.Add(this.listBoxControlNets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectANet";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select A Net";
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlNets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNetTitle;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGoToNetControl;
        public DevExpress.XtraEditors.ListBoxControl listBoxControlNets;
    }
}