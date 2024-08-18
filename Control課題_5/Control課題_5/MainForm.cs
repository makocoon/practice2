using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control課題_5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InputValueChanged(object sender, EventArgs e)
        {
            string valueJPN = String.Format(new CultureInfo("ja-JP"), "{0:N3}", _numericUpDown.Value);
            _JapanesLabel.Text = valueJPN;
            string valueENG = String.Format(new CultureInfo("en-EN"), "{0:N3}", _numericUpDown.Value);
            _EnglishLabel.Text = valueENG;
            string valueDEU = String.Format(new CultureInfo("de-DE"), "{0:N3}", _numericUpDown.Value);
            _GermanyLabel.Text = valueDEU;
        }
    }
}
