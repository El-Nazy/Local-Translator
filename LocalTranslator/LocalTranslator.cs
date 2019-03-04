using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace LocalTranslator
{
    public partial class LocalTranslator : Form
    {
        WebBrowser translatingBrowser = new WebBrowser();
        string currentTextTag;

        public LocalTranslator()
        {
            InitializeComponent();
            networkNotifier.Text = String.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //if (!NetworkInterface.GetIsNetworkAvailable())
            //{
            //    networkNotifier.Text = "Not connected to a network";
            //}
            //else
            //{
            //    networkNotifier.Text = "Checking for internet connection";
            //    progressBar.Visible = true;

            //    //Start a background worker that'll check if we are connected to internet
            //}

            //networkNotifier.Text = "Connected to internet";

            igboUnselected.Visible = false;
            translatingBrowser.ScriptErrorsSuppressed = true;
            translatingBrowser.Navigate("https://translate.google.com/#en/ig/");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                translatingBrowser.Document.GetElementById("Source").InnerText = inputText.Text;
                outputText.Text = translatingBrowser.Document.GetElementById("Result_Box").InnerText;
            }
            catch
            {
            }
        }

        void ChangeTargetLanguge(string newLanguage)
        {
            translatingBrowser.Navigate("https://translate.google.com/#en/" + newLanguage + "/");
        }

        private void DisableAll()
        {
            igboUnselected.Visible = true;
            hausaUnselected.Visible = true;
            yorubaUnselected.Visible = true;
        }

        private void igboUnselected_Click(object sender, EventArgs e)
        {
            DisableAll();
            igboUnselected.Visible = false;
            ChangeTargetLanguge("ig");
        }

        private void hausaUnselected_Click(object sender, EventArgs e)
        {
            DisableAll();
            hausaUnselected.Visible = false;
            ChangeTargetLanguge("ha");
        }

        private void yorubaUnselected_Click(object sender, EventArgs e)
        {
            DisableAll();
            yorubaUnselected.Visible = false;
            ChangeTargetLanguge("yo");
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            WebBrowser browser = new WebBrowser();
            CheckInternetConnection(browser); 
        }

        void CheckInternetConnection(WebBrowser browser)
        {

        }
    }
}