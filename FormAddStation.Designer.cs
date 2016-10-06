namespace NetControlLogger
{
    partial class FormAddStation
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
            this.simpleButtonAddStation = new DevExpress.XtraEditors.SimpleButton();
            this.textEditCallSign = new DevExpress.XtraEditors.TextEdit();
            this.textEditTacticalCallSign = new DevExpress.XtraEditors.TextEdit();
            this.radioGroupStatus = new DevExpress.XtraEditors.RadioGroup();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.memoEditNotes = new DevExpress.XtraEditors.MemoEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.textEditLocation = new DevExpress.XtraEditors.TextEdit();
            this.labelLocation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCallSign.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTacticalCallSign.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLocation.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonAddStation
            // 
            this.simpleButtonAddStation.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.simpleButtonAddStation.Location = new System.Drawing.Point(12, 223);
            this.simpleButtonAddStation.Name = "simpleButtonAddStation";
            this.simpleButtonAddStation.Size = new System.Drawing.Size(355, 23);
            this.simpleButtonAddStation.TabIndex = 2;
            this.simpleButtonAddStation.Text = "&Add Station";
            this.simpleButtonAddStation.Click += new System.EventHandler(this.simpleButtonAddStation_Click);
            // 
            // textEditCallSign
            // 
            this.textEditCallSign.EditValue = "";
            this.textEditCallSign.EnterMoveNextControl = true;
            this.textEditCallSign.Location = new System.Drawing.Point(87, 12);
            this.textEditCallSign.Name = "textEditCallSign";
            this.textEditCallSign.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.textEditCallSign.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditCallSign.Properties.Appearance.Options.UseFont = true;
            this.textEditCallSign.Properties.ValidateOnEnterKey = true;
            this.textEditCallSign.Size = new System.Drawing.Size(104, 26);
            this.textEditCallSign.TabIndex = 0;
            this.textEditCallSign.Validating += new System.ComponentModel.CancelEventHandler(this.textEditCallSign_Validating);
            // 
            // textEditTacticalCallSign
            // 
            this.textEditTacticalCallSign.EnterMoveNextControl = true;
            this.textEditTacticalCallSign.Location = new System.Drawing.Point(87, 44);
            this.textEditTacticalCallSign.Name = "textEditTacticalCallSign";
            this.textEditTacticalCallSign.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditTacticalCallSign.Properties.Appearance.Options.UseFont = true;
            this.textEditTacticalCallSign.Size = new System.Drawing.Size(104, 26);
            this.textEditTacticalCallSign.TabIndex = 4;
            // 
            // radioGroupStatus
            // 
            this.radioGroupStatus.Location = new System.Drawing.Point(219, 12);
            this.radioGroupStatus.Name = "radioGroupStatus";
            this.radioGroupStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Fixed", "Fixed"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Portable", "Portable"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Mobile", "Mobile")});
            this.radioGroupStatus.Size = new System.Drawing.Size(148, 58);
            this.radioGroupStatus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Call Sign:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tactical Call:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name:";
            // 
            // textEditName
            // 
            this.textEditName.EnterMoveNextControl = true;
            this.textEditName.Location = new System.Drawing.Point(87, 79);
            this.textEditName.Name = "textEditName";
            this.textEditName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditName.Properties.Appearance.Options.UseFont = true;
            this.textEditName.Size = new System.Drawing.Size(280, 26);
            this.textEditName.TabIndex = 1;
            // 
            // memoEditNotes
            // 
            this.memoEditNotes.EnterMoveNextControl = true;
            this.memoEditNotes.Location = new System.Drawing.Point(87, 143);
            this.memoEditNotes.Name = "memoEditNotes";
            this.memoEditNotes.Size = new System.Drawing.Size(280, 72);
            this.memoEditNotes.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Notes:";
            // 
            // textEditLocation
            // 
            this.textEditLocation.EnterMoveNextControl = true;
            this.textEditLocation.Location = new System.Drawing.Point(87, 111);
            this.textEditLocation.Name = "textEditLocation";
            this.textEditLocation.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditLocation.Properties.Appearance.Options.UseFont = true;
            this.textEditLocation.Size = new System.Drawing.Size(280, 26);
            this.textEditLocation.TabIndex = 13;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(12, 119);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(51, 13);
            this.labelLocation.TabIndex = 14;
            this.labelLocation.Text = "Location:";
            // 
            // FormAddStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 257);
            this.Controls.Add(this.textEditLocation);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.memoEditNotes);
            this.Controls.Add(this.textEditName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioGroupStatus);
            this.Controls.Add(this.textEditTacticalCallSign);
            this.Controls.Add(this.textEditCallSign);
            this.Controls.Add(this.simpleButtonAddStation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddStation";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Station/CheckIn";
            ((System.ComponentModel.ISupportInitialize)(this.textEditCallSign.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTacticalCallSign.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLocation.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonAddStation;
        private DevExpress.XtraEditors.TextEdit textEditCallSign;
        private DevExpress.XtraEditors.TextEdit textEditTacticalCallSign;
        private DevExpress.XtraEditors.RadioGroup radioGroupStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.MemoEdit memoEditNotes;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit textEditLocation;
        private System.Windows.Forms.Label labelLocation;
    }
}