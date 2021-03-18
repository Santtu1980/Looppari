using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Looppari
{
    public partial class MainForm : Form
    {
        private BackgroundWorker bgWorkerToLoopFiles = new BackgroundWorker();

        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Browse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog openFolderDialog = new FolderBrowserDialog())
            {
                openFolderDialog.SelectedPath = @"c:\";

                if (openFolderDialog.ShowDialog() == DialogResult.OK)
                    textBox_SourceRootFolder.Text = openFolderDialog.SelectedPath;
            }
        }

        private void numericUpDown_ShortFileMaxLimit_ValueChanged(object sender, EventArgs e)
        {
            label_heading_ShortFiles.Text = $"Alle {numericUpDown_ShortFileMaxLimit.Value} rivin tiedostoja:";
        }

        private void numericUpDown_MediumFileMaxLimit_ValueChanged(object sender, EventArgs e)
        {
            label_heading_MediumFiles.Text = $"Alle {numericUpDown_MediumFileMaxLimit.Value} rivin tiedostoja:";
            label_heading_LongFiles.Text = $"Yli {numericUpDown_MediumFileMaxLimit.Value} rivin tiedostoja:";
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (textBox_SourceRootFolder.Text.Equals(string.Empty) || textBox_SourceRootFolder.Text.Equals(@"C:\")|| !Directory.Exists(textBox_SourceRootFolder.Text))
            {
                MessageBox.Show("Valitse projektin juurihakemisto.");
                return;
            }

            SetUIRunningState();
            SetUIValues();

            var fileSearching = new SearchFiles();
            var pathToAllCSFiles = fileSearching.DirSearch(textBox_SourceRootFolder.Text, checkBox_IgnoreBin.Checked, checkBox_IgnoreObj.Checked, checkBox_IgnoreDesigner.Checked);
            var amountOfAllFiles = fileSearching.AllFilesFound;
            var amountOfFilesInObjFolder = fileSearching.AllObjFolderFilesIgnored;
            var amountOfFilesInBinFolder = fileSearching.AllBinFolderFilesIgnored;
            var amountOfDesignerFiles = fileSearching.AllDesignerFilesIgnored;
            label_SpecialFileCount.Text = $@"{Calculate.FormatNumber(pathToAllCSFiles.Count)} kpl";
            label_FileCount.Text = $@"{Calculate.FormatNumber(amountOfAllFiles)} kpl";
            label_SkippedFilesInObjFolder.Text = $@"{Calculate.FormatNumber(amountOfFilesInObjFolder)} kpl";
            label_SkippedFilesInBinFolder.Text = $@"{Calculate.FormatNumber(amountOfFilesInBinFolder)} kpl";
            label_SkippedDesignerFiles.Text = $@"{Calculate.FormatNumber(amountOfDesignerFiles)} kpl";

            var fileReader = new Reader();
            //start background worker to loop all files that found
            bgWorkerToLoopFiles.DoWork += new DoWorkEventHandler(fileReader.ReadFiles);
            bgWorkerToLoopFiles.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorkerToLoopFiles_RunWorkerCompleted);
            bgWorkerToLoopFiles.RunWorkerAsync(new object[] { pathToAllCSFiles, numericUpDown_ShortFileMaxLimit.Value, numericUpDown_MediumFileMaxLimit.Value });
        }

        private void bgWorkerToLoopFiles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SetUIStandByState();
            var result = (ResultValues)e.Result;
            SetUIValues(result);
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            // Cancel BackgroundWorker
            if (!bgWorkerToLoopFiles.IsBusy)
            {
                bgWorkerToLoopFiles.CancelAsync();
                SetUIStandByState();
            }
        }

        /// <summary>
        /// Set UI labels to start values
        /// </summary>
        /// <param name="resetSourcePath"></param>
        private void SetUIValues(ResultValues result = null, bool resetSourcePath = false)
        {
            if (resetSourcePath) textBox_SourceRootFolder.Text = @"C:\";
            if (result == null) label_SpecialFileCount.Text = "0";
            label_RowsSum.Text = (result == null) ? "0" : $@"{Calculate.FormatNumber(result.AmountOfAllRows)} kpl";
            label_CommentedRowsSum.Text = (result == null) 
                ? "0" 
                : $@"{Calculate.FormatResultAndPercentage(result.AmountOfAllCommentedRows, result.AmountOfAllRows)} kaikista riveistä.";
            label_DescriptionRowsSum.Text = (result == null) 
                ? "0" 
                : $@"{Calculate.FormatResultAndPercentage(result.AmountOfAllMethodDescriptionRows, result.AmountOfAllCommentedRows)} kaikista kommenttiriveistä.";
            label_CommentedCodeRowsSum.Text = (result == null) 
                ? "0" 
                : $@"{Calculate.FormatResultAndPercentage(result.AmountOfAllCommentedCodeRows, result.AmountOfAllCommentedRows)} kaikista kommenttiriveistä.";
            label_ShortFiles.Text = (result == null) 
                ? "0" 
                : $"{Calculate.FormatResultAndPercentage(result.AmountOfShortFiles, result.AmountOfFiles)}";
            label_MediumFiles.Text = (result == null) 
                ? "0" 
                : $"{Calculate.FormatResultAndPercentage(result.AmountOfMediumFiles, result.AmountOfFiles)}";
            label_LongFiles.Text = (result == null) 
                ? "0" 
                : $"{Calculate.FormatResultAndPercentage(result.AmountOfLongFiles, result.AmountOfFiles)}";
            label_RowsAveragePerFile.Text = (result == null)
                ? "0"
                : $"{result.AverageAmountOfRowsInFile} kpl.";
            label_Stats.Text = (result == null || result.MostRowsFileName == "") 
                ? "N/A" 
                : $@"Eniten rivejä yhdessä tiedostossa: ({Calculate.FormatNumber(result.MostRows)} kpl) {result.MostRowsFileName.Remove(0, textBox_SourceRootFolder.Text.Length)}";
        }

        private void SetUIRunningState()
        {
            SetUIStratOrEndState(false);
        }
        private void SetUIStandByState()
        {
            SetUIStratOrEndState(true);
        }
        private void SetUIStratOrEndState(bool standbyState)
        {
            button_start.Enabled = standbyState;
            button_stop.Enabled = !standbyState;
            button_Browse.Enabled = standbyState;
            label_runningInfo.Visible = !standbyState;
            textBox_SourceRootFolder.Enabled = standbyState;
            checkBox_IgnoreBin.Enabled = standbyState;
            checkBox_IgnoreObj.Enabled = standbyState;
            checkBox_IgnoreDesigner.Enabled = standbyState;
            numericUpDown_ShortFileMaxLimit.Enabled = standbyState;
            numericUpDown_MediumFileMaxLimit.Enabled = standbyState;
        }
    }
}
