namespace Control課題_7
{
    partial class MainForn
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.書式OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォントFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._richTextBox = new System.Windows.Forms.RichTextBox();
            this._contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.コピーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ペーストToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._menuStrip.SuspendLayout();
            this._contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _menuStrip
            // 
            this._menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.編集EToolStripMenuItem,
            this.書式OToolStripMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(438, 28);
            this._menuStrip.TabIndex = 0;
            this._menuStrip.Text = "menuStrip1";
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuItemCopy,
            this.StripMenuItemPaste});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            // 
            // StripMenuItemCopy
            // 
            this.StripMenuItemCopy.Name = "StripMenuItemCopy";
            this.StripMenuItemCopy.Size = new System.Drawing.Size(154, 26);
            this.StripMenuItemCopy.Text = "コピー(&C)";
            this.StripMenuItemCopy.Click += new System.EventHandler(this.StripMenuItemClickCopy);
            // 
            // StripMenuItemPaste
            // 
            this.StripMenuItemPaste.Name = "StripMenuItemPaste";
            this.StripMenuItemPaste.Size = new System.Drawing.Size(154, 26);
            this.StripMenuItemPaste.Text = "ペースト(&V)";
            this.StripMenuItemPaste.Click += new System.EventHandler(this.StripMenuItemClickPaste);
            // 
            // 書式OToolStripMenuItem
            // 
            this.書式OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.フォントFToolStripMenuItem});
            this.書式OToolStripMenuItem.Name = "書式OToolStripMenuItem";
            this.書式OToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.書式OToolStripMenuItem.Text = "書式(&O)";
            // 
            // フォントFToolStripMenuItem
            // 
            this.フォントFToolStripMenuItem.Name = "フォントFToolStripMenuItem";
            this.フォントFToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.フォントFToolStripMenuItem.Text = "フォント...(&F)";
            this.フォントFToolStripMenuItem.Click += new System.EventHandler(this.StripMenuIte_ClickFont);
            // 
            // _richTextBox
            // 
            this._richTextBox.Location = new System.Drawing.Point(29, 92);
            this._richTextBox.Name = "_richTextBox";
            this._richTextBox.Size = new System.Drawing.Size(100, 96);
            this._richTextBox.TabIndex = 1;
            this._richTextBox.Text = "";
            // 
            // _contextMenuStrip
            // 
            this._contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.コピーToolStripMenuItem,
            this.ペーストToolStripMenuItem});
            this._contextMenuStrip.Name = "contextMenuStrip1";
            this._contextMenuStrip.Size = new System.Drawing.Size(122, 52);
            // 
            // コピーToolStripMenuItem
            // 
            this.コピーToolStripMenuItem.Name = "コピーToolStripMenuItem";
            this.コピーToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.コピーToolStripMenuItem.Text = "コピー";
            this.コピーToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuItemClickCopy);
            // 
            // ペーストToolStripMenuItem
            // 
            this.ペーストToolStripMenuItem.Name = "ペーストToolStripMenuItem";
            this.ペーストToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.ペーストToolStripMenuItem.Text = "ペースト";
            this.ペーストToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuItemClickPaste);
            // 
            // MainForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 285);
            this.Controls.Add(this._richTextBox);
            this.Controls.Add(this._menuStrip);
            this.MainMenuStrip = this._menuStrip;
            this.Name = "MainForn";
            this.Text = "Form1";
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this._contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.RichTextBox _richTextBox;
        private System.Windows.Forms.ContextMenuStrip _contextMenuStrip;
        //private System.Windows.Forms.FontDialog _fontDialog;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemPaste;
        private System.Windows.Forms.ToolStripMenuItem 書式OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォントFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem コピーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ペーストToolStripMenuItem;
    }
}

