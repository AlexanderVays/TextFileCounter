using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextFileCounter.Forms;

namespace TextFileCounter.UserControls
{
    public partial class PhrasesCountControl : UserControl
    {
        IMainForm IMF = new MainForm();
        public PhrasesCountControl()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            char space = ' '; //trim a special character "space" as leading and trailing  
            List<string> inputList = new List<string> { textBox1.Text.Trim(space), textBox2.Text.Trim(space), textBox3.Text.Trim(space)};
            inputList.RemoveAll(item => item == null || item == "");
            bool caseSensitive = checkBoxCaseSensitive.Checked;
            if (IMF.ValidateInputFile())
            {
                Processor.ReadText();
                Processor.GetPhrasesCount(inputList, caseSensitive);
                CountSentencesResultForm resultForm = new CountSentencesResultForm();
                resultForm.ShowDialog();
            }
        }
    }
}
