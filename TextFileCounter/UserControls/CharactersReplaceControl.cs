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
    public partial class CharactersReplaceControl : UserControl
    {
        public CharactersReplaceControl()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Dictionary<char, char> charDictionary = new Dictionary<char, char>();
            StringBuilder sb = new StringBuilder("");
            if (!string.IsNullOrEmpty(textBox1.Text)) 
            {
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    sb.Append($"The new character which will replace the '{textBox1.Text}' character was not indicated.\r\n");
                }
                else if(!charDictionary.ContainsKey(char.Parse(textBox1.Text)))
                {
                    charDictionary.Add(char.Parse(textBox1.Text), char.Parse(textBox2.Text));
                }
            }

            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                if (string.IsNullOrEmpty(textBox4.Text))
                {
                    sb.Append($"The new character which will replace the '{textBox3.Text}' character was not indicated.\r\n");
                }
                else if (!charDictionary.ContainsKey(char.Parse(textBox1.Text)))
                {
                    charDictionary.Add(char.Parse(textBox3.Text), char.Parse(textBox4.Text));
                }
            }

            if (!string.IsNullOrEmpty(textBox5.Text))
            {
                if (string.IsNullOrEmpty(textBox6.Text))
                {
                    sb.Append($"The new character which will replace the '{textBox5.Text}' character was not indicated.\r\n");
                }
                else if (!charDictionary.ContainsKey(char.Parse(textBox5.Text)))
                {
                    charDictionary.Add(char.Parse(textBox5.Text), char.Parse(textBox6.Text));
                }
            }

            if (sb.Length > 0) 
            {
                MessageBox.Show(sb.ToString());
            }
        }
    }
}
