using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Control課題_8
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = @"C:\Program Files (x86)";
                folderBrowserDialog.ShowNewFolderButton = false;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    _listBox.Items.Clear(); // リストボックスをクリア
                    _backgroundWorker.RunWorkerAsync(selectedPath);
                }
            }
        }

        //private void SetListBox(string path)
        private void backgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string path = e.Argument.ToString();
                string[] directories = Directory.GetDirectories(path);
                for (int i = 0; i < directories.Length; i++)
                {
                    _backgroundWorker.ReportProgress((i + 1) * 100 / directories.Length, directories[i]);
                    _listBox.Items.Add(directories[i]);
                    Thread.Sleep(200);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("エラーが発生しました: " + ex.Message);
            }
        }

        private void backgroundWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _progressBar.Value = e.ProgressPercentage;
        }
    }
}
