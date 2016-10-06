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
    public partial class FormAddStation : DevExpress.XtraEditors.XtraForm
    {
        string netname = null;
        System.Data.DataTable netroster;
        bool nc = false;
        bool anc = false;
        bool usetactical = false;

        //Station (for editing)
        System.Data.DataRow station;

        public FormAddStation(string NetName, ref System.Data.DataTable NetRoster, bool NetControlStation, bool AlternateNetControlStation, bool UseTacticalCalls)
        {
            netname = NetName;
            //adding a new station to the list
            netroster = NetRoster;
            nc = NetControlStation;
            anc = AlternateNetControlStation;
            usetactical = UseTacticalCalls;

            InitializeComponent();

            this.Text = "Add Station";
            simpleButtonAddStation.Text = "&Add Station to Roster";

            if (!usetactical)
            {
                textEditTacticalCallSign.Enabled = false;
                textEditTacticalCallSign.TabStop = false;
            }
            else
            {
                textEditTacticalCallSign.Enabled = true;
                textEditTacticalCallSign.TabStop = true;
            }
        }

        public FormAddStation(string NetName, ref System.Data.DataRow Station)
        {
            netname = NetName;

            station = Station;

            InitializeComponent();
            
            this.Text = "Modify Station";
            simpleButtonAddStation.Text = "&Modify Station on Roster";

            //Editing this station
            textEditCallSign.Text = station["CallSign"].ToString().ToUpper();
            textEditTacticalCallSign.Text = station["TacticalCallSign"].ToString().ToUpper();
            textEditName.Text = station["Name"].ToString();
            switch (station["Status"].ToString().ToUpper())
            {
                case "FIXED":
                    {
                        radioGroupStatus.SelectedIndex = 0;
                        break;
                    }
                case "PORTABLE":
                    {
                        radioGroupStatus.SelectedIndex = 1;
                        break;
                    }
                case "MOBILE":
                    {
                        radioGroupStatus.SelectedIndex = 2;
                        break;
                    }
                default:
                    {
                        radioGroupStatus.SelectedIndex = 0;
                        break;
                    }
            }
            
            radioGroupStatus.Text = station["Status"].ToString().ToUpper();
            textEditLocation.Text = station["Location"].ToString();
            memoEditNotes.Text = station["Notes"].ToString();
            Log.LogMessage(netname, "Station " + textEditCallSign.Text + " Modified");
        }

        private void textEditCallSign_Validating(object sender, CancelEventArgs e)
        {
            string nameindatabase = null;
            string nameonline = null;

            if (textEditCallSign.Text.Length > 0)
            {
                nameindatabase = LocalDatabase.LookupInDatabase(textEditCallSign.Text);
                if (nameindatabase == null)
                {
                    Log.LogMessage(netname, "Station " + textEditCallSign.Text + " Not Found Locally");
                    nameonline = OnlineDatabase.LookupInDatabase(textEditCallSign.Text);
                    {
                        if (nameonline != null)
                        {
                            Log.LogMessage(netname, "Station " + textEditCallSign.Text + " Found Online");
                            textEditName.Text = nameonline;
                            textEditName.Focus();
                        }
                        else
                        {
                            Log.LogMessage(netname, "Station " + textEditCallSign.Text + " Not Found Online");
                            //don't know name - ask for it
                            textEditName.SelectAll();
                            textEditName.Focus();
                        }
                    }
                }
            }
        }

        private void simpleButtonAddStation_Click(object sender, EventArgs e)
        {
            if (station == null) //new entry
            {
                if (netroster != null)
                {
                    if (textEditCallSign.Text.Length > 0)
                    {
                        try
                        {
                            System.Data.DataRow newrow = netroster.NewRow();
                            newrow["CallSign"] = textEditCallSign.Text.ToUpper();
                            newrow["TacticalCallSign"] = textEditTacticalCallSign.Text.ToUpper();
                            newrow["Name"] = textEditName.Text;
                            newrow["Status"] = (radioGroupStatus.Text.Length == 0 ? "Fixed" : radioGroupStatus.Text);  //assume fixed
                            newrow["Acknowledged"] = false;
                            newrow["HasQuery"] = false;
                            newrow["HasAnnouncement"] = false;
                            newrow["WantsIF"] = false;
                            newrow["Location"] = textEditLocation.Text;
                            newrow["Notes"] = memoEditNotes.Text;
                            netroster.Rows.Add(newrow);
                            Log.LogMessage(netname, "Station " + textEditCallSign.Text + " Checked In");
                        }
                        catch (System.Data.ConstraintException ex)
                        {
                            MessageBox.Show("Already Checked In");
                        }
                    }
                    else
                    {
                        //nothing entered - done entering names
                        this.Close();
                    }
                }
            }
            else
            {
                //Modify Existing Station
                station["CallSign"] = textEditCallSign.Text.ToUpper();
                station["TacticalCallSign"] = textEditTacticalCallSign.Text.ToUpper();
                station["Name"] = textEditName.Text;
                station["Status"] = (radioGroupStatus.Text.Length == 0 ? "Fixed" : radioGroupStatus.Text);  //assume fixed
                station["Location"] = textEditLocation.Text;
                station["Notes"] = memoEditNotes.Text;
            }
        }
    }
}