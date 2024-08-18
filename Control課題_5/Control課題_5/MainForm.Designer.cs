namespace Control課題_5
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
            this._JapanesLabel = new System.Windows.Forms.Label();
            this._EnglishLabel = new System.Windows.Forms.Label();
            this._GermanyLabel = new System.Windows.Forms.Label();
            this._numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _JapanesLabel
            // 
            this._JapanesLabel.AutoSize = true;
            this._JapanesLabel.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this._JapanesLabel.Location = new System.Drawing.Point(158, 97);
            this._JapanesLabel.Name = "_JapanesLabel";
            this._JapanesLabel.Size = new System.Drawing.Size(0, 25);
            this._JapanesLabel.TabIndex = 0;
            // 
            // _EnglishLabel
            // 
            this._EnglishLabel.AutoSize = true;
            this._EnglishLabel.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this._EnglishLabel.Location = new System.Drawing.Point(158, 140);
            this._EnglishLabel.Name = "_EnglishLabel";
            this._EnglishLabel.Size = new System.Drawing.Size(0, 25);
            this._EnglishLabel.TabIndex = 1;
            // 
            // _GermanyLabel
            // 
            this._GermanyLabel.AutoSize = true;
            this._GermanyLabel.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this._GermanyLabel.Location = new System.Drawing.Point(158, 185);
            this._GermanyLabel.Name = "_GermanyLabel";
            this._GermanyLabel.Size = new System.Drawing.Size(0, 25);
            this._GermanyLabel.TabIndex = 2;
            // 
            // _numericUpDown
            // 
            this._numericUpDown.AutoSize = true;
            this._numericUpDown.DecimalPlaces = 3;
            this._numericUpDown.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this._numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this._numericUpDown.Location = new System.Drawing.Point(81, 38);
            this._numericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._numericUpDown.Name = "_numericUpDown";
            this._numericUpDown.Size = new System.Drawing.Size(135, 33);
            this._numericUpDown.TabIndex = 3;
            this._numericUpDown.ValueChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.label1.Location = new System.Drawing.Point(39, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "日本";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.label2.Location = new System.Drawing.Point(39, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "アメリカ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.label3.Location = new System.Drawing.Point(39, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "ドイツ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._numericUpDown);
            this.Controls.Add(this._GermanyLabel);
            this.Controls.Add(this._EnglishLabel);
            this.Controls.Add(this._JapanesLabel);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _JapanesLabel;
        private System.Windows.Forms.Label _EnglishLabel;
        private System.Windows.Forms.Label _GermanyLabel;
        private System.Windows.Forms.NumericUpDown _numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

