namespace Control課題_4
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
            this._numericUpDown = new System.Windows.Forms.NumericUpDown();
            this._textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _numericUpDown
            // 
            this._numericUpDown.DecimalPlaces = 1;
            this._numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this._numericUpDown.Location = new System.Drawing.Point(86, 85);
            this._numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this._numericUpDown.Name = "_numericUpDown";
            this._numericUpDown.Size = new System.Drawing.Size(120, 22);
            this._numericUpDown.TabIndex = 0;
            this._numericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // _textBox
            // 
            this._textBox.Location = new System.Drawing.Point(86, 149);
            this._textBox.Name = "_textBox";
            this._textBox.Size = new System.Drawing.Size(120, 22);
            this._textBox.TabIndex = 1;
            this._textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 257);
            this.Controls.Add(this._textBox);
            this.Controls.Add(this._numericUpDown);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown _numericUpDown;
        private System.Windows.Forms.TextBox _textBox;
    }
}

