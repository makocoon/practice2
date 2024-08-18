using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control課題_7
{
    public partial class MainForn : Form
    {
        public MainForn()
        {
            InitializeComponent();
            StripMenuItemCopy.ShortcutKeys = Keys.Control | Keys.C;
            StripMenuItemPaste.ShortcutKeys = Keys.Control | Keys.V;
            this.ContextMenuStrip = _contextMenuStrip;
        }

        private void StripMenuItemClickCopy(object sender, EventArgs e)
        {
            _richTextBox.SelectAll();
            _richTextBox.Copy();
            _richTextBox.DeselectAll();
        }

        private void StripMenuItemClickPaste(object sender, EventArgs e)
        {
            _richTextBox.Paste();
        }

        private void StripMenuIte_ClickFont(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.Font = _richTextBox.Font;
                if(fontDialog.ShowDialog() == DialogResult.OK)
                {
                    _richTextBox.Font = fontDialog.Font;
                }
            }   
        }

        private void ContextMenuItemClickCopy(object sender, EventArgs e)
        {
            _richTextBox.SelectAll();
            _richTextBox.Copy();
            _richTextBox.DeselectAll();
        }

        private void ContextMenuItemClickPaste(object sender, EventArgs e)
        {
            _richTextBox.Paste();
        }
    }
}
