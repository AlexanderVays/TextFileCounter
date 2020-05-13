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
    public partial class CountWordsResultForm : Form
    {
        public CountWordsResultForm()
        {
            InitializeComponent();
            LoadData();
            this.CenterToScreen();
        }

        public void LoadData() 
        {
            text1.Text = Processor.resultDictionary.Count > 0 ? Processor.resultDictionary.Keys.ElementAt(0) : "";
            result1.Text = Processor.resultDictionary.Count > 0 ? Processor.resultDictionary[Processor.resultDictionary.Keys.ElementAt(0)].ToString() : "";
            text2.Text = Processor.resultDictionary.Count > 1 ? Processor.resultDictionary.Keys.ElementAt(1) : "";
            result2.Text = Processor.resultDictionary.Count > 1 ? Processor.resultDictionary[Processor.resultDictionary.Keys.ElementAt(1)].ToString() : "";
            text3.Text = Processor.resultDictionary.Count > 2 ? Processor.resultDictionary.Keys.ElementAt(2) : "";
            result3.Text = Processor.resultDictionary.Count > 2 ? Processor.resultDictionary[Processor.resultDictionary.Keys.ElementAt(2)].ToString() : "";
            text4.Text = Processor.resultDictionary.Count > 3 ? Processor.resultDictionary.Keys.ElementAt(3) : "";
            result4.Text = Processor.resultDictionary.Count > 3 ? Processor.resultDictionary[Processor.resultDictionary.Keys.ElementAt(3)].ToString() : "";
            text5.Text = Processor.resultDictionary.Count > 4 ? Processor.resultDictionary.Keys.ElementAt(4) : "";
            result5.Text = Processor.resultDictionary.Count > 4 ? Processor.resultDictionary[Processor.resultDictionary.Keys.ElementAt(4)].ToString() : "";
            text6.Text = Processor.resultDictionary.Count > 5 ? Processor.resultDictionary.Keys.ElementAt(5) : "";
            result6.Text = Processor.resultDictionary.Count > 5 ? Processor.resultDictionary[Processor.resultDictionary.Keys.ElementAt(5)].ToString() : "";
            Processor.resultDictionary.Clear();
        }

        private void buttonOkResult_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
