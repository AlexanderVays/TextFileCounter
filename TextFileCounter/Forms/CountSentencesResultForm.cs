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
    public partial class CountSentencesResultForm : Form
    {
        public CountSentencesResultForm()
        {
            InitializeComponent();
            LoadData();
            this.CenterToScreen();
        }

        public void LoadData() 
        {
            textBox1.Text = Processor.resultDictionary.Count > 0 ? Processor.resultDictionary.Keys.ElementAt(0) : "";
            result1.Text = Processor.resultDictionary.Count > 0 ? Processor.resultDictionary[Processor.resultDictionary.Keys.ElementAt(0)].ToString() : "";
            textBox2.Text = Processor.resultDictionary.Count > 1 ? Processor.resultDictionary.Keys.ElementAt(1) : "";
            result2.Text = Processor.resultDictionary.Count > 1 ? Processor.resultDictionary[Processor.resultDictionary.Keys.ElementAt(1)].ToString() : "";
            textBox3.Text = Processor.resultDictionary.Count > 2 ? Processor.resultDictionary.Keys.ElementAt(2) : "";
            result3.Text = Processor.resultDictionary.Count > 2 ? Processor.resultDictionary[Processor.resultDictionary.Keys.ElementAt(2)].ToString() : "";
            Processor.resultDictionary.Clear();
        }

        private void buttonOkResult_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
