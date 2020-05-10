using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileCounter.Forms
{
    public partial class IntroForm : Form
    {
        public static bool acceptedRules = false;
        public IntroForm()
        {
            InitializeComponent();
            LoadData();
            this.CenterToScreen();
        }

        private void LoadData()
        {
            label2.Text = "Terms & Conditions and Privacy Policy";
            textBoxRules.Text = "\r\n1. This application is built to help users modify text documents. \r\n" +
                "2. Please find the list of tasks which this application can perform: \r\n" +
                "2a. Count specific words or quotes with a maximum length of 30 characters. The sample can be written as a word or a quote (few words) in any user convenient way and the application will search and count.\r\n" +
                "If the number of characters is bigger than 30 characters, please see 2b \r\n" +
                "2b. Count phrases and sentenses with a maximum of 300 characters.  \r\n" +
                "\r\nI have read and accept the Terms and Conditions of use, Privacy Policy and consent to receiving information from this application in relation to this request. " +
                "We values the privacy of your personal details and we will not share or otherwise distribute your Personal Data to third parties.";
            label3.Text = $"Copyright © 2020 by Alexander Vays";
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            acceptedRules = true;
            this.Close();
        }

        private void BtnReject_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(0);
        }

        private void IntroForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!acceptedRules) 
            {
                e.Cancel = true;
            }
        }
    }

    
}
