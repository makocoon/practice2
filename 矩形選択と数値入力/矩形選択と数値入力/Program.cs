/*
 * 矩形選択と数値入力で、相互に表示/設定可能というものです。
 * 概略
 * 　以下のことができるダイアログをつくること。
 * 　　・ドラッグでの矩形選択
 * 　　・数値による矩形座標入力
 * 　　・画面表示
 * 　　・矩形座標の数値表示
 * 　　
 * 動作
 * 　メイン画面
 * 　　画面ドラッグ
 * 　　　矩形がない部分をドラッグした場合
 * 　　　　新規矩形作成を行う
 * 　　　　マウスが押された点を始点、マウスが離れた点を終点とする。
 * 　　　　同時に数値表示も更新されること。
 * 　　　　
 * 　　　矩形がある部分をドラッグした場合
 * 　　　　矩形が移動する。
 * 　　　　同時に数値表示も更新されること。
 * 　　　　
 * 　　　クリア
 * 　　　　矩形がなくなる。座標は上下左右ともに０になる。
 * 　　　　
 * 　　数値座標コントロール
 * 　　　表示
 * 　　　　現在メイン画面上に表示されている矩形の上下左右の座標が表示されること。
 * 　　　　
 * 　　　数値入力
 * 　　　　数値が入力されるとメイン画面上に表示されている矩形の座標がかわること。
 * 　　　　
 * ヒント
 * 　デザインパターン
 * 　　Observerパターン（C＃の機能を使用）
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 矩形選択と数値入力
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RectangleSelector());
        }
    }
}
