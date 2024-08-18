namespace Control課題_2
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
            this._switchButton = new System.Windows.Forms.Button();
            this.myUserControl1 = new Control課題_2.MyUserControl();
            this.SuspendLayout();
            // 
            // _switchButton
            // 
            this._switchButton.Location = new System.Drawing.Point(67, 71);
            this._switchButton.Name = "_switchButton";
            this._switchButton.Size = new System.Drawing.Size(69, 86);
            this._switchButton.TabIndex = 0;
            this._switchButton.Text = "切り替えスイッチ";
            this._switchButton.UseVisualStyleBackColor = true;
            this._switchButton.Click += new System.EventHandler(this.SwitchButtonClick);
            // 
            // myUserControl1
            // 
            this.myUserControl1.Location = new System.Drawing.Point(191, 62);
            this.myUserControl1.Name = "myUserControl1";
            this.myUserControl1.SelectionEnabled = true;
            this.myUserControl1.Size = new System.Drawing.Size(150, 150);
            this.myUserControl1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 284);
            this.Controls.Add(this.myUserControl1);
            this.Controls.Add(this._switchButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _switchButton;
        private MyUserControl myUserControl1;
    }
}

