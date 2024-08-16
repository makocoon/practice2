namespace Control課題_1
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // _button
            // 
            this._button.BackColor = System.Drawing.Color.Red;
            this._button.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this._button.Location = new System.Drawing.Point(100, 79);
            this._button.Name = "_button";
            this._button.Size = new System.Drawing.Size(152, 41);
            this._button.TabIndex = 0;
            this._button.Text = "ボタン";
            this._button.UseVisualStyleBackColor = false;
            this._button.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 223);
            this.Controls.Add(this._button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _button;
    }
}

