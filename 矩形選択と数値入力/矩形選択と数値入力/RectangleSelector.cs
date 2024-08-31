using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace 矩形選択と数値入力
{
    public partial class RectangleSelector : Form, ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private bool _isDragging = false;
        private Point _startPoint;
        NumericRectangleControl _numericRectangleControl = new NumericRectangleControl();
        private Rectangle _currentRectangle;

        public RectangleSelector()
        {
            InitializeComponent();
            _observers.Add(_numericRectangleControl); //Observerに追加
            _numericRectangleControl.Show(this); 
            _numericRectangleControl.RectangleValueChanged += ValueChanged; //イベントハンドラを登録
        }

        // 変更を通知
        public void Notify(Rectangle rectangle)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(rectangle);
            }
        }
        // NumericRectangleControl の値が変更されたとき
        private void ValueChanged(object sender, EventArgs e)
        {
            _currentRectangle = _numericRectangleControl.GetRectangle();
            _panel.Invalidate(); 
        }

        private void panelMouseDown(object sender, MouseEventArgs e)
        {
            _isDragging = true;
            _startPoint = e.Location;
            _currentRectangle = new Rectangle(e.X, e.Y, 0, 0);
        }

        private void panelMouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                _currentRectangle.X = Math.Min(e.X , _startPoint.X);
                _currentRectangle.Y = Math.Min(e.Y , _startPoint.Y);
                _currentRectangle.Width = Math.Abs(e.X - _startPoint.X);
                _currentRectangle.Height = Math.Abs(e.Y - _startPoint.Y);
                _panel.Invalidate();
            }
        }

        private void panelMouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
            Notify(_currentRectangle);
        }

        private void buttonClick(object sender, EventArgs e)
        {
            _currentRectangle = Rectangle.Empty;
            _panel.Invalidate();
            Notify(_currentRectangle);
        }

        private void panelPaint(object sender, PaintEventArgs e)
        {
            if (_currentRectangle.Width > 0 && _currentRectangle.Height > 0)
            {
                e.Graphics.FillRectangle(Brushes.Blue, _currentRectangle);
            }
        }
    }
}
