using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetControlLogger
{
    public partial class FormSplash : Form
    {
        int splashtime = 100;
        System.Windows.Forms.Timer closeTimer = new System.Windows.Forms.Timer();

        public FormSplash(int SplashTime, string LogoLocation)
        {
            splashtime = SplashTime;
            InitializeComponent();
            labelCopyright.Text = "Net Control Logger - Copyright (c) 1998-" + System.DateTime.Now.Year + " Zachary Burns (N8ZAK)";
            labelCopyright.LinkClicked += new LinkLabelLinkClickedEventHandler(labelCopyright_LinkClicked);
            if (LogoLocation != null)
            {
                pictureBoxLogo.ImageLocation = LogoLocation;
            }
            else
            {
                //show default logo
            }

            closeTimer.Interval = splashtime;
            closeTimer.Tick += new EventHandler(closeTimer_Tick);
            closeTimer.Start();
        }

        void labelCopyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.n8zak.com");
        }

        void closeTimer_Tick(object sender, EventArgs e)
        {
            closeTimer.Stop();
            Close();
        }
    }
}
