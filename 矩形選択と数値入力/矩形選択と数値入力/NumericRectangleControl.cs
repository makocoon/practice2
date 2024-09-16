using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 矩形選択と数値入力
{
    public partial class NumericRectangleControl : Form,IObserver
    {
        public event EventHandler RectangleValueChanged = delegate { };
        public NumericRectangleControl()
        {
            InitializeComponent();
        }
        public void Update(Rectangle rectangle)
        {
            _topNumericUpDown.Value = rectangle.Top;
            _downNumericUpDown.Value = rectangle.Bottom;
            _rightNumericUpDown.Value = rectangle.Right;
            _leftNumericUpDown.Value = rectangle.Left;
        }

        internal void NumericUpDownValueChanged(object sender, EventArgs e)
        {
            RectangleValueChanged(this, EventArgs.Empty);
        }
        internal Rectangle GetRectangle()
        {
            var rectangle = 
                new Rectangle(
                    (int)_leftNumericUpDown.Value,
                    (int)_topNumericUpDown.Value,
                    (int)(_rightNumericUpDown.Value - _leftNumericUpDown.Value),
                    (int)(_downNumericUpDown.Value - _topNumericUpDown.Value));
            return rectangle;
        }
    }
}
