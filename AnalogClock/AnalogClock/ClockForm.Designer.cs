namespace Clock
{
    partial class ClockForm
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
            this._analogClock = new Clock.AnalogClock();
            this.SuspendLayout();
            // 
            // _analogClock
            // 
            this._analogClock.Location = new System.Drawing.Point(1, -8);
            this._analogClock.Name = "_analogClock";
            this._analogClock.Size = new System.Drawing.Size(326, 326);
            this._analogClock.TabIndex = 0;
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(350, 335);
            this.Controls.Add(this._analogClock);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClockForm";
            this.Text = "アナログ時計";
            this.ResumeLayout(false);

        }

        #endregion

        private AnalogClock _analogClock;
    }
}

