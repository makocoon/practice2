namespace Control課題_6
{
    partial class MainForm
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
            this._button = new System.Windows.Forms.Button();
            this._textBox = new System.Windows.Forms.TextBox();
            this._listView = new System.Windows.Forms.ListView();
            this.columnHeaderDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderString = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // _button
            // 
            this._button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._button.Location = new System.Drawing.Point(328, 28);
            this._button.Name = "_button";
            this._button.Size = new System.Drawing.Size(75, 27);
            this._button.TabIndex = 0;
            this._button.Text = "登録";
            this._button.UseVisualStyleBackColor = true;
            this._button.Click += new System.EventHandler(this.buttonClick);
            // 
            // _textBox
            // 
            this._textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBox.Location = new System.Drawing.Point(31, 29);
            this._textBox.MaxLength = 8;
            this._textBox.Name = "_textBox";
            this._textBox.PasswordChar = '?';
            this._textBox.Size = new System.Drawing.Size(267, 22);
            this._textBox.TabIndex = 1;
            // 
            // _listView
            // 
            this._listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDay,
            this.columnHeaderString});
            this._listView.HideSelection = false;
            this._listView.Location = new System.Drawing.Point(31, 75);
            this._listView.Name = "_listView";
            this._listView.Size = new System.Drawing.Size(372, 178);
            this._listView.TabIndex = 2;
            this._listView.UseCompatibleStateImageBehavior = false;
            this._listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDay
            // 
            this.columnHeaderDay.Text = "日時";
            this.columnHeaderDay.Width = 150;
            // 
            // columnHeaderString
            // 
            this.columnHeaderString.Text = "入力文字列";
            this.columnHeaderString.Width = 200;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 282);
            this.Controls.Add(this._listView);
            this.Controls.Add(this._textBox);
            this.Controls.Add(this._button);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _button;
        private System.Windows.Forms.TextBox _textBox;
        private System.Windows.Forms.ListView _listView;
        private System.Windows.Forms.ColumnHeader columnHeaderDay;
        private System.Windows.Forms.ColumnHeader columnHeaderString;
    }
}

