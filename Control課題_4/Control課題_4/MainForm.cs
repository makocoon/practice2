using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control課題_4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (decimal.TryParse(_textBox.Text, out decimal inputValue))
                    {
                        _numericUpDown.Value += inputValue;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("正しい値を入力ください");
            }
        }
    }
}
