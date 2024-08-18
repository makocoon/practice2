using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Control課題_6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            string currentDateTime = DateTime.Now.ToString();
            string inputText = _textBox.Text;
            ListViewItem item = new ListViewItem(currentDateTime);
            item.SubItems.Add(inputText);
            _listView.Items.Add(item);

            _listView.Items[_listView.Items.Count - 1].EnsureVisible();
            _textBox.Clear();
            _textBox.Focus();
        }
    }
}
