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
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        public System.DateTime StartTime;
        public System.DateTime EndTime;
        public System.Windows.Forms.Timer Clock;
        public System.Data.DataTable NetRoster;
        public int CurrentCheckIns = 0;
        string netname = null;

        public FormMain(string NetName)
        {
            netname = NetName;
            Log.LogMessage(netname, "Program Launched");
            InitializeComponent();

            if (netname != null)
                labelNetName.Text = netname;
            else
                labelNetName.Text = "Welcome to Net Control Logger";

            Clock = new System.Windows.Forms.Timer();
            Clock.Interval = 1000;
            Clock.Tick += new EventHandler(Clock_Tick);
        }

        void Clock_Tick(object sender, EventArgs e)
        {
            System.DateTime currenttime = System.DateTime.Now;
            //Clock has ticked
            //tick++;
            //labelCurrentTime.Text = tick.ToString();
            labelCurrentDate.Text = currenttime.ToShortDateString();
            labelCurrentTime.Text = currenttime.ToLongTimeString();
            System.TimeSpan netuptime = currenttime.Subtract(StartTime);
            labelNetUptime.Text = netuptime.Hours.ToString("00") + ":" + netuptime.Minutes.ToString("00") + ":" + netuptime.Seconds.ToString("00");
            if (NetRoster != null)
            {
                labelCurrentCheckIns.Text = CurrentCheckIns.ToString();
                labelTotalCheckIns.Text = NetRoster.Rows.Count.ToString();
            }
        }

        #region "Setup Program Defaults"
        private void FormMain_Load(object sender, EventArgs e)
        {
            simpleButtonStartNet.Enabled = true;
            simpleButtonAddStation.Enabled = false;
            simpleButtonNetCondition.Enabled = false;
            gridControlCheckIns.Enabled = false;
        }
        #endregion

        #region "Quit the Program"
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close down the net?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                Log.LogMessage(netname, "User chose to shut down the net.  Program terminated");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
        #endregion

        #region "Start/Stop the Net"
        private void simpleButtonStartNet_Click(object sender, EventArgs e)
        {
            if (simpleButtonStartNet.Text == "&Start Net")
            {
                //Change button functionality
                simpleButtonStartNet.Appearance.BackColor = Color.LightSalmon;
                simpleButtonStartNet.Text = "&Stop Net";
                
                //Setup Running Net Defaults
                simpleButtonAddStation.Enabled = true;
                simpleButtonNetCondition.Enabled = true;
                StartTime = System.DateTime.Now;
                Clock.Enabled = true;
                labelCurrentCheckIns.Text = "0";
                labelTotalCheckIns.Text = "0";

                //New Net - Setup the Roster
                SetupNetRoster();
                Log.LogMessage(netname, "Net Started.");
                Log.LogMessage(netname, "No Net Condition Set");
                //Activate the Roster
                gridControlCheckIns.Enabled = true;
                simpleButtonNetCondition.Enabled = true;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to close down the net?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    simpleButtonStartNet.Text = "&Start Net";
                    simpleButtonStartNet.Appearance.BackColor = Color.LightGreen;
                    simpleButtonAddStation.Enabled = false;
                    Clock.Enabled = false;
                    EndTime = System.DateTime.Now;
                    simpleButtonNetCondition.Enabled = false;
                    Log.LogMessage(netname, "Net Stopped.");
                }
            }
        }
        #endregion

        #region "Setup Net Roster"
        public void SetupNetRoster()
        {
            NetRoster = new System.Data.DataTable("NetRoster");
            NetRoster.Columns.Add("CallSign", System.Type.GetType("System.String"));
            NetRoster.Columns.Add("TacticalCallSign", System.Type.GetType("System.String"));
            NetRoster.Columns.Add("Name", System.Type.GetType("System.String"));
            NetRoster.Columns.Add("Status", System.Type.GetType("System.String"));
            NetRoster.Columns.Add("Acknowledged", System.Type.GetType("System.Boolean"));
            NetRoster.Columns.Add("HasQuery", System.Type.GetType("System.Boolean"));
            NetRoster.Columns.Add("HasAnnouncement", System.Type.GetType("System.Boolean"));
            NetRoster.Columns.Add("WantsIF", System.Type.GetType("System.Boolean"));
            NetRoster.Columns.Add("Location", System.Type.GetType("System.String"));
            NetRoster.Columns.Add("Notes", System.Type.GetType("System.String"));
            NetRoster.PrimaryKey = new System.Data.DataColumn[] {NetRoster.Columns["CallSign"]};
            gridControlCheckIns.DataSource = NetRoster;
        }
        #endregion

        #region "Set Net Condition"
        private void simpleButtonNetCondition_Click(object sender, EventArgs e)
        {
            FormSetNetCondition SetNetCondition = new FormSetNetCondition();
            if (SetNetCondition.ShowDialog() == DialogResult.OK)
            {
                switch (SetNetCondition.NetCondition)
	            {
                    case "Open":
                    {
                        simpleButtonNetCondition.Appearance.BackColor = Color.White;
                        simpleButtonNetCondition.Text = "&Open Net";
                        Log.LogMessage(netname, "Open Net Condition Set");
                        break;
                    }
                    case "Green":
                    {
                        simpleButtonNetCondition.Appearance.BackColor = Color.Lime;
                        simpleButtonNetCondition.Text = "&Condition Green";
                        Log.LogMessage(netname, "Net Changed to Condition Green");
                        break;
                    }
                    case "Yellow":
                    {
                        simpleButtonNetCondition.Appearance.BackColor = Color.Yellow;
                        simpleButtonNetCondition.Text = "&Condition Yellow";
                        Log.LogMessage(netname, "Net Changed to Condition Yellow");
                        break;
                    }
                    case "Red":
                    {
                        simpleButtonNetCondition.Appearance.BackColor = Color.Red;
                        simpleButtonNetCondition.Text = "&Condition Red";
                        Log.LogMessage(netname, "Net Changed to Condition Red");
                        break;
                    }
                    default:
                    {
                        simpleButtonNetCondition.Appearance.BackColor = Color.SkyBlue;
                        simpleButtonNetCondition.Text = "No Net Condition Set";
                        Log.LogMessage(netname, "No Net Condition Set");
                        break;
                    }
	            }
            }
            SetNetCondition.Close();
            SetNetCondition.Dispose();
            SetNetCondition = null;
        }
        #endregion

        #region "Add New Station - First Time Seen"
        private void simpleButtonAddStation_Click(object sender, EventArgs e)
        {
            FormAddStation addstations = new FormAddStation(netname, ref NetRoster, false, false, false);
            addstations.ShowDialog();
            addstations.Close();
            addstations.Dispose();
            addstations = null;
        }
        #endregion

        #region "Modify Checked In Station"
        private void gridViewCheckIns_DoubleClick(object sender, EventArgs e)
        {
            System.Data.DataRow station = gridViewCheckIns.GetDataRow(gridViewCheckIns.FocusedRowHandle);
            FormAddStation fas = new FormAddStation(netname, ref station);
            if (fas.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridViewCheckIns.SetRowCellValue(gridViewCheckIns.FocusedRowHandle, "CallSign", station["CallSign"].ToString().ToUpper());
                gridViewCheckIns.SetRowCellValue(gridViewCheckIns.FocusedRowHandle, "TacticalCallSign", station["TacticalCallSign"].ToString().ToUpper());
                gridViewCheckIns.SetRowCellValue(gridViewCheckIns.FocusedRowHandle, "Name", station["Name"].ToString().ToUpper());
                gridViewCheckIns.SetRowCellValue(gridViewCheckIns.FocusedRowHandle, "Status", station["Status"].ToString().ToUpper());
                gridViewCheckIns.SetRowCellValue(gridViewCheckIns.FocusedRowHandle, "Location", station["Location"].ToString().ToUpper());
                gridViewCheckIns.SetRowCellValue(gridViewCheckIns.FocusedRowHandle, "Notes", station["Notes"].ToString().ToUpper());
                Log.LogMessage(netname, "Station " + station["CallSign"].ToString() + "Changed");
            }
            fas.Close();
            fas.Dispose();
            fas = null;
        }
        #endregion
    }
}