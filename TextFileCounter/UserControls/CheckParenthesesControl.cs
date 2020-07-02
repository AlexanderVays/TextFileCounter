using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileCounter.UserControls
{
    public partial class CheckParenthesesControl : UserControl
    {
        public CheckParenthesesControl()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            bool correct = Processor.CheckParentheses(textBox.Text);
            string message = "The text been checked for parentheses and found:";
            if (correct)
            {
                MessageBox.Show($"{message} Correct");
            }
            else 
            {
                MessageBox.Show($"{message} Correction is needed");
            }
        }
    }
}
