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
        public static string InputFileName { get; set; }
        public static string OutputFileName { get; set; }
        public static Control Control { get; set; }

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
                    if (Control != null) 
                    {
                        Controls.Remove(Control);
                    }
                    Controls.Add(wc);
                    Control = wc;
                    break;
                case 1:
                    PhrasesCountControl pc = new PhrasesCountControl();
                    if (Control != null)
                    {
                        Controls.Remove(Control);
                    }
                    Controls.Add(pc);
                    Control = pc;
                    break;
                case 2:
                    CharactersReplaceControl cr = new CharactersReplaceControl();
                    if (Control != null)
                    {
                        Controls.Remove(Control);
                    }
                    Controls.Add(cr);
                    Control = cr;
                    break;
                case 4:
                    CheckParenthesesControl cp = new CheckParenthesesControl();
                    if (Control != null)
                    {
                        Controls.Remove(Control);
                    }
                    Controls.Add(cp);
                    Control = cp;
                    break;
                default:
                    break;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FileDialog("input");
        }

        public bool ValidateInputFile()
        {
            if (!File.Exists(InputFileName) && string.IsNullOrEmpty(InputFileName))
            { 
                string message = "You did not provide a file name. Do you want to select a file?";
                string caption = "Error Detected in a file provided";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    FileDialog("input");
                }
                else
                {
                    return false;
                } 
            }

            if (File.Exists(InputFileName) && !string.IsNullOrEmpty(InputFileName))
            {
                return true;
            }

            return false;
        }

        public bool ValidateOutputFile()
        {
            if (!File.Exists(OutputFileName) && string.IsNullOrEmpty(OutputFileName))
            {
                string message = "You did not provide an output file name. Do you want to select a file?";
                string caption = "Error Detected in an output file provided";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    FileDialog("output");
                }
                else
                {
                    return false;
                }
            }

            if (File.Exists(OutputFileName) && !string.IsNullOrEmpty(OutputFileName))
            {
                return true;
            }

            return false;
        }

        public void FileDialog(string source) 
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (source.Equals("input"))
                    {
                        //Get the path of specified input file
                        labelFileName.Text = openFileDialog.FileName;
                        InputFileName = openFileDialog.FileName;
                    }
                    else if (source.Equals("output")) 
                    {
                        //Get the path of specified output file
                        //CharactersReplaceControl..Text = openFileDialog.FileName;
                        OutputFileName = openFileDialog.FileName;
                    }
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
