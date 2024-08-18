namespace Control課題_8
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
            this._progressBar = new System.Windows.Forms.ProgressBar();
            this._listBox = new System.Windows.Forms.ListBox();
            this._backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this._folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // _button
            // 
            this._button.Location = new System.Drawing.Point(53, 29);
            this._button.Name = "_button";
            this._button.Size = new System.Drawing.Size(130, 32);
            this._button.TabIndex = 0;
            this._button.Text = "フォルダ選択";
            this._button.UseVisualStyleBackColor = true;
            this._button.Click += new System.EventHandler(this.buttonClick);
            // 
            // _progressBar
            // 
            this._progressBar.Location = new System.Drawing.Point(53, 295);
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(380, 23);
            this._progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this._progressBar.TabIndex = 1;
            // 
            // _listBox
            // 
            this._listBox.FormattingEnabled = true;
            this._listBox.ItemHeight = 15;
            this._listBox.Location = new System.Drawing.Point(53, 84);
            this._listBox.Name = "_listBox";
            this._listBox.Size = new System.Drawing.Size(380, 184);
            this._listBox.TabIndex = 2;
            // 
            // _backgroundWorker
            // 
            this._backgroundWorker.WorkerReportsProgress = true;
            this._backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerDoWork);
            this._backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerProgressChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 355);
            this.Controls.Add(this._listBox);
            this.Controls.Add(this._progressBar);
            this.Controls.Add(this._button);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _button;
        private System.Windows.Forms.ProgressBar _progressBar;
        private System.Windows.Forms.ListBox _listBox;
        private System.ComponentModel.BackgroundWorker _backgroundWorker;
        private System.Windows.Forms.FolderBrowserDialog _folderBrowserDialog;
    }
}

