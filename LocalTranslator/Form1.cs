using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LocalTranslator
{
    public partial class Form1 : Form
    {
        WebBrowser translatingBrowser = new WebBrowser();

        bool browserNavigated = false;

        string currentTargetTag = "igbo";
        string currentLangUrl = "https://translate.google.com/#en/ig/";

        string enToIg = "https://translate.google.com/#en/ig/";
        string enToHa = "https://translate.google.com/#en/ha/";
        string enToYo = "https://translate.google.com/#en/yo/";
        private object currentBrowser;

        public Form1()
        {
            InitializeComponent();
        }

        void CheckNetworkAvailability()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            appStatusLabel.Text = "";
            translatingBrowser.ScriptErrorsSuppressed = true;
            translatingBrowser.Navigate("https://translate.google.com/#en/ig/");
        }

        private bool IsConnectedToInternet()
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                bool connected = false;
                using (Ping ping = new Ping())
                {
                    try
                    {
                        if (ping.Send("google.com", 2000).Status == IPStatus.Success)
                        {
                            connected = true;
                        }
                    }
                    catch (PingException)
                    {
                        connected = false;
                    }
                }
                //string address = "http://www.google.com";
                //try
                //{
                //    WebRequest webRequest = WebRequest.Create(address);
                //    WebResponse webResponse = webRequest.GetResponse();
                //}
                //catch (Exception)
                //{
                //    return false;
                //}
                return true; 
            }
            else
                return false;
        }

        //private void translateButton_Click(object sender, EventArgs e)
        //{
        //    if (englishText.Text == "" || englishText.Text == " ")
        //    {
        //        MessageBox.Show("No text was entered", "Empty Request", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    appStatusLabel.Text = "Translating, Please Wait";
        //    translateProgress.Visible = true;

        //    englishText.Enabled = false;
        //    translateButton.Enabled = false;

        //    //translatingBrowser.Navigate("https://translate.google.com/#en/ig/Hello, how are you");
        //    timer1.Enabled = true;

        //    //backgroundWorker1.RunWorkerAsync(translatingBrowser);

        //    //backgroundWorker1.RunWorkerAsync(currentLangUrl + englishText.Text);


        //    //translatingBrowser.Navigate(currentLangUrl + englishText.Text);
        //    //browserNavigated = true;

        //    //if (igboText.Tag == currentTargetTag)
        //    //{
        //    //while (true)
        //    //{
        //    //    try
        //    //    {
        //    //        Thread.Sleep(0);
        //    //        igboText.Text = translatingBrowser.Document.GetElementById("Result_Box").InnerText;
        //    //    }
        //    //    catch
        //    //    {
        //    //        continue;
        //    //    }
        //    //    break;
        //    //}
        //    //}
        //    //if (hausaText.Tag == currentTargetTag)
        //    //{

        //    //}
        //    //if (yorubaText.Tag == currentTargetTag)
        //    //{

        //    //}
        //}

        void CheckForTranslation ()
        {

        }

        //string GetTranslation(translatingBrowser browser, BackgroundWorker worker, DoWorkEventArgs e)
        //{

        //    browser.Navigate("https://translate.google.com/#en/ig/Hello, how are you");
        //    timer1.Enabled = true;
        //    //browserNavigated = true;
        //    //browser.DocumentCompleted += IgboBrowser_DocumentCompleted;

        //    //string result = string.Empty;
        //    //while (browser.ReadyState.ToString() != "Complete")
        //    //{
        //    //    while (true)
        //    //    {
        //    //        try
        //    //        {
        //    //            result = "Result was sent";
        //    //            //if (browser.Document.GetElementById("Source").InnerHtml != "Hello, how are you"
        //    //            //    || browser.Document.GetElementById("Result_Box").InnerText == string.Empty)
        //    //            //    continue;
        //    //            //result = browser.Document.GetElementById("Result_Box").InnerText;
        //    //        }
        //    //        catch
        //    //        {
        //    //            continue;
        //    //        }
        //    //        break;
        //    //    }
        //    //}

        //    return "Translating...";

        //    //if (translatingBrowser.ReadyState == translatingBrowserReadyState.Loaded)
        //    //{
        //    //    translatingBrowser.Document.GetElementById("Source").InnerText = englishText.Text;
        //    //    igboText.Text = translatingBrowser.Document.GetElementById("Result_Box").InnerText;
        //    //}

        //    //if (hausaBrowser.ReadyState == translatingBrowserReadyState.Loaded)
        //    //{
        //    //    hausaText.Text = hausaBrowser.Document.GetElementById("Result_Box").InnerText;
        //    //}
        //    //if (yorubaBrowser.ReadyState == translatingBrowserReadyState.Loaded)
        //    //{
        //    //    yorubaText.Text = yorubaBrowser.Document.GetElementById("Result_Box").InnerText;
        //    //}
        //}

        private void ChangeCurrentLang(object sender, EventArgs e)
        {
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //if (IsConnectedToInternet())
            //{
            //    //Do nothing
            //}
            //else
            //{
            //    MessageBox.Show("                           There is no internet access\n" +
            //        "Please connect to the internet before requesting translation",
            //        "No internet access!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void englishText_Enter(object sender, EventArgs e)
        {
            //try
            //{
            //    translatingBrowser.Document.GetElementById("Source").InnerText = englishText.Text;
            //}
            //catch
            //{

            //}
        }

        //private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    BackgroundWorker worker = sender as BackgroundWorker;
            
        //    e.Result = GetTranslation((translatingBrowser)e.Argument, worker, e);
        //}

        //private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{

        //}

        //private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    igboText.Text = e.Result.ToString();
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                translatingBrowser.Document.GetElementById("Source").InnerText = englishText.Text;
                igboText.Text = translatingBrowser.Document.GetElementById("Result_Box").InnerText;
            }
            catch
            {

            }
        }
    }
}
