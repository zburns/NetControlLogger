using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NetControlLogger
{
    static class Program
    {
        static public string LogoLocation = "Logo.jpg";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Show Splash Screen
            FormSplash newFormSplash;
            if (System.IO.File.Exists(LogoLocation))
                newFormSplash = new FormSplash(5000, LogoLocation);
            else
                newFormSplash = new FormSplash(5000, null);
            newFormSplash.ShowDialog();
            newFormSplash.Close();
            newFormSplash.Dispose();
            newFormSplash = null;

            string net = null;
            FormSelectANet san = new FormSelectANet();
            if (san.ShowDialog() == DialogResult.OK)
                net = san.listBoxControlNets.SelectedValue.ToString();
            else
                net = null;
            san.Close();
            san.Dispose();
            san = null;

            //Start the Main Application
            Application.Run(new FormMain(net));
        }
    }
}
