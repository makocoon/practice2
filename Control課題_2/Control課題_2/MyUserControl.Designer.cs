namespace Control課題_2
{
    partial class MyUserControl
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this._button = new System.Windows.Forms.Button();
            this._comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _button
            // 
            this._button.Location = new System.Drawing.Point(36, 27);
            this._button.Name = "_button";
            this._button.Size = new System.Drawing.Size(75, 31);
            this._button.TabIndex = 0;
            this._button.Text = "ボタン";
            this._button.UseVisualStyleBackColor = true;
            // 
            // _comboBox
            // 
            this._comboBox.FormattingEnabled = true;
            this._comboBox.Location = new System.Drawing.Point(16, 88);
            this._comboBox.Name = "_comboBox";
            this._comboBox.Size = new System.Drawing.Size(121, 23);
            this._comboBox.TabIndex = 1;
            // 
            // MyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._comboBox);
            this.Controls.Add(this._button);
            this.Name = "MyUserControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _button;
        private System.Windows.Forms.ComboBox _comboBox;
    }
}
