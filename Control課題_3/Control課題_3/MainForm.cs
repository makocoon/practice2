using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Control課題_3
{
    public partial class MainForm : Form
    {
        private int _counter = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonClicked(object sender, EventArgs e)
        {
            _timer.Start();
            _trackBar.Value = 0;
        }

        private void timerTick(object sender, EventArgs e)
        {
            _button.Enabled = false;
            if(_trackBar.Value < _trackBar.Maximum)
            {
                _trackBar.Value += 1;
            }
            else
            {
                _timer.Stop();
                _button.Enabled = true;
            }
        }
    }
}
