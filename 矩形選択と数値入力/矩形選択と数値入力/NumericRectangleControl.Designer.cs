namespace 矩形選択と数値入力
{
    partial class NumericRectangleControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._topLabel = new System.Windows.Forms.Label();
            this._RightLabel = new System.Windows.Forms.Label();
            this._leftLabel = new System.Windows.Forms.Label();
            this._downLabel = new System.Windows.Forms.Label();
            this._topNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._downNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._leftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._rightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this._topNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._downNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._leftNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._rightNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _topLabel
            // 
            this._topLabel.AutoSize = true;
            this._topLabel.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._topLabel.Location = new System.Drawing.Point(227, 49);
            this._topLabel.Name = "_topLabel";
            this._topLabel.Size = new System.Drawing.Size(25, 17);
            this._topLabel.TabIndex = 0;
            this._topLabel.Text = "上";
            // 
            // _RightLabel
            // 
            this._RightLabel.AutoSize = true;
            this._RightLabel.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._RightLabel.Location = new System.Drawing.Point(419, 154);
            this._RightLabel.Name = "_RightLabel";
            this._RightLabel.Size = new System.Drawing.Size(25, 17);
            this._RightLabel.TabIndex = 1;
            this._RightLabel.Text = "右";
            // 
            // _leftLabel
            // 
            this._leftLabel.AutoSize = true;
            this._leftLabel.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._leftLabel.Location = new System.Drawing.Point(34, 154);
            this._leftLabel.Name = "_leftLabel";
            this._leftLabel.Size = new System.Drawing.Size(25, 17);
            this._leftLabel.TabIndex = 3;
            this._leftLabel.Text = "左";
            // 
            // _downLabel
            // 
            this._downLabel.AutoSize = true;
            this._downLabel.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._downLabel.Location = new System.Drawing.Point(227, 268);
            this._downLabel.Name = "_downLabel";
            this._downLabel.Size = new System.Drawing.Size(25, 17);
            this._downLabel.TabIndex = 2;
            this._downLabel.Text = "下";
            // 
            // _topNumericUpDown
            // 
            this._topNumericUpDown.Location = new System.Drawing.Point(179, 83);
            this._topNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._topNumericUpDown.Name = "_topNumericUpDown";
            this._topNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this._topNumericUpDown.TabIndex = 4;
            // 
            // _downNumericUpDown
            // 
            this._downNumericUpDown.Location = new System.Drawing.Point(179, 227);
            this._downNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._downNumericUpDown.Name = "_downNumericUpDown";
            this._downNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this._downNumericUpDown.TabIndex = 5;
            // 
            // _leftNumericUpDown
            // 
            this._leftNumericUpDown.Location = new System.Drawing.Point(78, 154);
            this._leftNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._leftNumericUpDown.Name = "_leftNumericUpDown";
            this._leftNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this._leftNumericUpDown.TabIndex = 6;
            // 
            // _rightNumericUpDown
            // 
            this._rightNumericUpDown.Location = new System.Drawing.Point(277, 154);
            this._rightNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._rightNumericUpDown.Name = "_rightNumericUpDown";
            this._rightNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this._rightNumericUpDown.TabIndex = 7;
            // 
            // NumericRectangleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 349);
            this.Controls.Add(this._rightNumericUpDown);
            this.Controls.Add(this._leftNumericUpDown);
            this.Controls.Add(this._downNumericUpDown);
            this.Controls.Add(this._topNumericUpDown);
            this.Controls.Add(this._leftLabel);
            this.Controls.Add(this._downLabel);
            this.Controls.Add(this._RightLabel);
            this.Controls.Add(this._topLabel);
            this.Name = "NumericRectangleControl";
            this.Text = "NumericRectangleControlInputForm";
            ((System.ComponentModel.ISupportInitialize)(this._topNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._downNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._leftNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._rightNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _topLabel;
        private System.Windows.Forms.Label _RightLabel;
        private System.Windows.Forms.Label _leftLabel;
        private System.Windows.Forms.Label _downLabel;
        internal System.Windows.Forms.NumericUpDown _topNumericUpDown;
        internal System.Windows.Forms.NumericUpDown _downNumericUpDown;
        internal System.Windows.Forms.NumericUpDown _leftNumericUpDown;
        internal System.Windows.Forms.NumericUpDown _rightNumericUpDown;
    }
}