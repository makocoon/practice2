namespace 矩形選択と数値入力
{
    partial class RectangleSelector
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
            this._panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // _button
            // 
            this._button.Font = new System.Drawing.Font("Meiryo UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._button.Location = new System.Drawing.Point(12, 12);
            this._button.Name = "_button";
            this._button.Size = new System.Drawing.Size(79, 38);
            this._button.TabIndex = 0;
            this._button.Text = "クリア";
            this._button.UseVisualStyleBackColor = true;
            this._button.Click += new System.EventHandler(this.buttonClick);
            // 
            // _panel
            // 
            this._panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._panel.Location = new System.Drawing.Point(1, 56);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(523, 316);
            this._panel.TabIndex = 1;
            this._panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPaint);
            this._panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMouseDown);
            this._panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMouseMove);
            this._panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMouseUp);
            // 
            // RectangleSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 374);
            this.Controls.Add(this._panel);
            this.Controls.Add(this._button);
            this.Name = "RectangleSelector";
            this.Text = "RectangleSelector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _button;
        private System.Windows.Forms.Panel _panel;
    }
}

