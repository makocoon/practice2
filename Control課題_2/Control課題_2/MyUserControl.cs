using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control課題_2
{
    public partial class MyUserControl : UserControl
    {
        private readonly string[] _list = { "さかな", "たまご", "めろん" };
        public MyUserControl()
        {
            InitializeComponent();
            _comboBox.DataSource = _list;
            _comboBox.SelectedIndex = 1;
        }

        // SelectionEnabled プロパティの公開
        [Category("カスタムプロパティ")]
        [Description("ボタンとコンボボックスの有効無効を同時に切り替え")]
        public bool SelectionEnabled
        {
            get { return _button.Enabled && _comboBox.Enabled; }
            set
            {
                _button.Enabled = value;
                _comboBox.Enabled = value;
            }
        }

        // BackColor プロパティの非公開
        [Browsable(false)]
        public new Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }
    }
}
