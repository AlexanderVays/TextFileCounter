using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TextFileCounter.Forms;

namespace TextFileCounter.UserControls
{
    public partial class WordsCountControl : UserControl
    {
        private IMainForm IMF = new MainForm();
        public WordsCountControl()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            char space = ' ';
            List<string> wordsList = new List<string> { textBox1.Text.Trim(space), textBox2.Text.Trim(space), textBox3.Text.Trim(space), textBox4.Text.Trim(space), textBox5.Text.Trim(space), textBox6.Text.Trim(space) };
            wordsList.RemoveAll(item => item == null || item == "");
            bool caseSensitive = checkBoxCaseSensitive.Checked;
            if (IMF.ValidateTextFile())
            {
                Processor.ReadText();
                Processor.GetWordsCount(wordsList, caseSensitive);
                CountWordsResultForm resultForm = new CountWordsResultForm();
                resultForm.ShowDialog();
            }
        } 
    }
}
