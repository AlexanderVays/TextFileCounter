using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextFileCounter.UserControls;

namespace TextFileCounter.Forms
{
    partial class MainForm : System.Windows.Forms.Form, IMainForm
    {
        public static string fileName { get; set; }
        public static Control control { get; set; }

        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void selectedIndexChanged(object sender, System.EventArgs e)
        {
            int selectedIndex = selectBox.SelectedIndex;
            Object selectedItem = selectBox.SelectedItem;
            switch (selectedIndex) 
            {
                case 0:
                    WordsCountControl wc = new WordsCountControl();
                    if (control != null) 
                    {
                        Controls.Remove(control);
                    }
                    Controls.Add(wc);
                    control = wc;
                    break;
                case 1:
                    PhrasesCountControl pc = new PhrasesCountControl();
                    if (control != null)
                    {
                        Controls.Remove(control);
                    }
                    Controls.Add(pc);
                    control = pc;
                    break;
                case 2:
                    CharactersReplaceControl cr = new CharactersReplaceControl();
                    if (control != null)
                    {
                        Controls.Remove(control);
                    }
                    Controls.Add(cr);
                    control = cr;
                    break;
                default:
                    break;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FileDialog();
        }

        public bool ValidateTextFile()
        {
            if (!File.Exists(fileName) && string.IsNullOrEmpty(fileName))
            { 
                string message = "You did not provide a file name. Do you want to select a file?";
                string caption = "Error Detected in a file provided";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    FileDialog();
                }
                else
                {
                    return false;
                } 
            }

            if (File.Exists(fileName) && !string.IsNullOrEmpty(fileName))
            {
                return true;
            }

            return false;
        }

        public void FileDialog() 
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    labelFileName.Text = openFileDialog.FileName;
                    fileName = openFileDialog.FileName;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(0);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            IntroForm introForm = new IntroForm();
            introForm.ShowDialog();
        }
    }
}
