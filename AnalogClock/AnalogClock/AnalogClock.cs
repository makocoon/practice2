using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class AnalogClock : UserControl
    {
        private int _centerX;
        private int _centerY;
        private int _radius;

        //定数を定義
        private const int ClockFaceNumber = 12; //文字盤のMAX値
        private const int FullCircleDegrees = 360; //1周 360度
        private double AngleBetweenNumbers = FullCircleDegrees / ClockFaceNumber;

        public AnalogClock()
        {
            InitializeComponent();
        }

        private void analogClockLoad(object sender, EventArgs e)
        {
            _timer = new Timer();
            _timer.Interval = 1000; // 1秒ごとに更新
            _timer.Start(); // Timerをスタート
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //時計の中心の計算
            _centerX = Width / 2;
            _centerY = Height / 2;
            int offset = 20;
            _radius = Width / 2 - offset;

            //文字盤の数字を書く
            for (int i = 1; i <= ClockFaceNumber; i++)
            {
                double angle = Math.PI * (AngleBetweenNumbers * i) / 180.0;
                int dialX = (int)(_centerX + _radius * Math.Sin(angle));
                int dialY = (int)(_centerY - _radius * Math.Cos(angle));
                g.DrawString(i.ToString(), new Font("Arial", 12), Brushes.White, dialX, dialY);
            }
        }

        private void AnalogClockPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //針を描く
            DateTime nowTime = DateTime.Now;

            //針の中心を調節
            int offsetX = 10;
            int offsetY = 5;
            int centerX = _centerX + offsetX;
            int centerY = _centerY + offsetY;

            //針を描くペンの色を設定
            Pen HourHandColor = new Pen(Color.Red, 3);
            Pen MinuteHandColor = new Pen(Color.Green, 3);
            Pen SecondHandColor = new Pen(Color.Blue, 2);

            //針の長さを設定
            int offsetHourHand = 40;
            int offsetMintuteHand = 10;
            int offsetSecondHand = 5;
            int hourHandLength = _radius - offsetHourHand;
            int minuteHandLength = _radius - offsetMintuteHand;
            int secondHandLength = _radius - offsetSecondHand;

            //定数を設定
            const double anglePerHour = 30.0 / 60.0; //1分あたりに短針が進む角度
            const double anglePerMinute = 360.0 / 60.0; //1分あたりに長針が進む角度
            const double anglePerSecond = 360.0 / 60.0; //1秒あたりに秒針が進む角度

            //長針の先端の座標を計算
            double hourAngle = Math.PI * (nowTime.Hour * AngleBetweenNumbers + nowTime.Minute * anglePerHour) / 180.0;
            float hourHandX = (float)(centerX + hourHandLength * Math.Sin(hourAngle));
            float hourHandY = (float)(centerY - hourHandLength * Math.Cos(hourAngle));

            //分針の先端の座標を計算
            double minuteAngle = Math.PI * (nowTime.Minute * anglePerMinute) / 180.0;
            float minuteHandX = (float)(centerX + minuteHandLength * Math.Sin(minuteAngle));
            float minuteHandY = (float)(centerY - minuteHandLength * Math.Cos(minuteAngle));

            //秒針の先端の座標を計算
            double secondAngle = Math.PI * (nowTime.Second * anglePerSecond) / 180.0;
            float secondHandX = (float)(centerX + secondHandLength * Math.Sin(secondAngle));
            float secondHandY = (float)(centerY - secondHandLength * Math.Cos(secondAngle));

            // 線を描画 (開始点と終了点を指定)
            g.DrawLine(HourHandColor, centerX, centerY, hourHandX, hourHandY);
            g.DrawLine(MinuteHandColor, centerX, centerY, minuteHandX, minuteHandY);
            g.DrawLine(SecondHandColor, centerX, centerY, secondHandX, secondHandY);
        }

        private void timerTick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
