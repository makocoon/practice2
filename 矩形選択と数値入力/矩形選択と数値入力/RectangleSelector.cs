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
    public partial class RectangleSelector : Form
    {
        private bool _isDragging = false;
        private Point _startPoint;
        NumericRectangleControl _numericRectangleControl;
        private Rectangle _currentRectangle;

        public RectangleSelector()
        {
            InitializeComponent();
            _numericRectangleControl = new NumericRectangleControl();
            _numericRectangleControl.Show();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            _numericRectangleControl._topNumericUpDown.Value = 0;
            _numericRectangleControl._downNumericUpDown.Value = 0;
            _numericRectangleControl._rightNumericUpDown.Value = 0;
            _numericRectangleControl._leftNumericUpDown.Value = 0;
        }

        private void panelMouseDown(object sender, MouseEventArgs e)
        {
            _isDragging = true;
            _startPoint = e.Location;
            _currentRectangle =  new Rectangle(e.X, e.Y,0,0);
        }

        private void panelMouseMove(object sender, MouseEventArgs e)
        {
            if(_isDragging)
            {
                _currentRectangle.Width = e.X - _startPoint.X;
                _currentRectangle.Height = e.Y - _startPoint.Y;
                _panel.Invalidate();
            }
        }

        private void panelMouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
            UpdateNumericUpDownValue();
        }

        private void UpdateNumericUpDownValue()
        {
            _numericRectangleControl._topNumericUpDown.Value = _currentRectangle.Top;
            _numericRectangleControl._downNumericUpDown.Value = _currentRectangle.Bottom;
            _numericRectangleControl._rightNumericUpDown.Value = _currentRectangle.Right;
            _numericRectangleControl._leftNumericUpDown.Value = _currentRectangle.Left;
        }

        private void panelPaint(object sender, PaintEventArgs e)
        {
            if( _currentRectangle.Width > 0 && _currentRectangle.Height > 0 )
            {
                e.Graphics.DrawRectangle(Pens.Black, _currentRectangle);
            }
        }
    }
}
