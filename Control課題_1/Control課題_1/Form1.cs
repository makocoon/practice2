/*
 * 課題１
 * 　以下の仕様に合致したサンプルアプリを作成してください。
 * 
 * 動作仕様：
 * 　１、赤色に塗られたボタンがある。
 * 　２、ボタン押すとカラーダイアログが表示される。
 * 　３、色を選んでOKを押すと、その色がボタンに反映される。
 * 　４、再度ボタンを押すと、３で選んだ色が表示された形でダイアログが起動する。
 * 　
 * 制限事項：
 * 　・カラーダイアログはカスタムカラー編集不可とし、標準のカラーセットのみを使えるようにすること。
 */


using System;
using System.Drawing;
using System.Windows.Forms;

namespace Control課題_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            {
                Color color = this._button.BackColor;
                colorDialog.AllowFullOpen = false;
            };

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this._button.BackColor = colorDialog.Color;
            }

        }
    }
}
