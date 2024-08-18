namespace Control課題_3
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
            this.components = new System.ComponentModel.Container();
            this._button = new System.Windows.Forms.Button();
            this._startLabel = new System.Windows.Forms.Label();
            this._endLabel = new System.Windows.Forms.Label();
            this._trackBar = new System.Windows.Forms.TrackBar();
            this._timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // _button
            // 
            this._button.Location = new System.Drawing.Point(31, 31);
            this._button.Name = "_button";
            this._button.Size = new System.Drawing.Size(75, 23);
            this._button.TabIndex = 0;
            this._button.Text = "Start";
            this._button.UseVisualStyleBackColor = true;
            this._button.Click += new System.EventHandler(this.buttonClicked);
            // 
            // _startLabel
            // 
            this._startLabel.AutoSize = true;
            this._startLabel.Location = new System.Drawing.Point(201, 225);
            this._startLabel.Name = "_startLabel";
            this._startLabel.Size = new System.Drawing.Size(53, 30);
            this._startLabel.TabIndex = 1;
            this._startLabel.Text = "0秒\n（開始）";
            // 
            // _endLabel
            // 
            this._endLabel.AutoSize = true;
            this._endLabel.Location = new System.Drawing.Point(201, 47);
            this._endLabel.Name = "_endLabel";
            this._endLabel.Size = new System.Drawing.Size(53, 30);
            this._endLabel.TabIndex = 2;
            this._endLabel.Text = "10秒\n（終了）";
            // 
            // _trackBar
            // 
            this._trackBar.Location = new System.Drawing.Point(139, 43);
            this._trackBar.Maximum = 100;
            this._trackBar.Name = "_trackBar";
            this._trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this._trackBar.Size = new System.Drawing.Size(56, 212);
            this._trackBar.TabIndex = 3;
            this._trackBar.TickFrequency = 10;
            this._trackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // _timer
            // 
            this._timer.Tick += new System.EventHandler(this.timerTick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 294);
            this.Controls.Add(this._trackBar);
            this.Controls.Add(this._endLabel);
            this.Controls.Add(this._startLabel);
            this.Controls.Add(this._button);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _button;
        private System.Windows.Forms.Label _startLabel;
        private System.Windows.Forms.Label _endLabel;
        private System.Windows.Forms.TrackBar _trackBar;
        private System.Windows.Forms.Timer _timer;
    }
}

