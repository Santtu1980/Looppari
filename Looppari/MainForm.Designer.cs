
namespace Looppari
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.textBox_SourceRootFolder = new System.Windows.Forms.TextBox();
            this.label_heading_SourceRootFolde = new System.Windows.Forms.Label();
            this.button_Browse = new System.Windows.Forms.Button();
            this.label_heading = new System.Windows.Forms.Label();
            this.label_runningInfo = new System.Windows.Forms.Label();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.checkBox_IgnoreBin = new System.Windows.Forms.CheckBox();
            this.checkBox_IgnoreObj = new System.Windows.Forms.CheckBox();
            this.label_heading_Results = new System.Windows.Forms.Label();
            this.label_Stats = new System.Windows.Forms.Label();
            this.label_DescriptionRowsSum = new System.Windows.Forms.Label();
            this.label_heading_DescriptionRowsSum = new System.Windows.Forms.Label();
            this.label_CommentedCodeRowsSum = new System.Windows.Forms.Label();
            this.label_CommentedRowsSum = new System.Windows.Forms.Label();
            this.label_heading_CommentedCodeRowsSum = new System.Windows.Forms.Label();
            this.label_heading_CommentedRowsSum = new System.Windows.Forms.Label();
            this.label_RowsSum = new System.Windows.Forms.Label();
            this.label_heading_RowsSum = new System.Windows.Forms.Label();
            this.label_SpecialFileCount = new System.Windows.Forms.Label();
            this.label_heading_SpecialFileCount = new System.Windows.Forms.Label();
            this.panel_Selections = new System.Windows.Forms.Panel();
            this.numericUpDown_MediumFileMaxLimit = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_ShortFileMaxLimit = new System.Windows.Forms.NumericUpDown();
            this.checkBox_IgnoreDesigner = new System.Windows.Forms.CheckBox();
            this.label_heading_MediumFilesMaxRowsSelection = new System.Windows.Forms.Label();
            this.label_heading_ShortFilesMaxRowsSelection = new System.Windows.Forms.Label();
            this.label_heading_ShortFiles = new System.Windows.Forms.Label();
            this.label_heading_MediumFiles = new System.Windows.Forms.Label();
            this.label_heading_LongFiles = new System.Windows.Forms.Label();
            this.label_ShortFiles = new System.Windows.Forms.Label();
            this.label_MediumFiles = new System.Windows.Forms.Label();
            this.label_LongFiles = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label_heading_FileCount = new System.Windows.Forms.Label();
            this.label_FileCount = new System.Windows.Forms.Label();
            this.label_heading_RowsAveragePerFile = new System.Windows.Forms.Label();
            this.label_RowsAveragePerFile = new System.Windows.Forms.Label();
            this.label_heading_SkippedFilesInObjFolder = new System.Windows.Forms.Label();
            this.label_SkippedFilesInObjFolder = new System.Windows.Forms.Label();
            this.label_SkippedFilesInBinFolder = new System.Windows.Forms.Label();
            this.label_heading_SkippedFilesInBinFolder = new System.Windows.Forms.Label();
            this.label_SkippedDesignerFiles = new System.Windows.Forms.Label();
            this.label_heading_SkippedDesignerFiles = new System.Windows.Forms.Label();
            this.panel_Selections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MediumFileMaxLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ShortFileMaxLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_SourceRootFolder
            // 
            this.textBox_SourceRootFolder.Location = new System.Drawing.Point(4, 28);
            this.textBox_SourceRootFolder.Name = "textBox_SourceRootFolder";
            this.textBox_SourceRootFolder.Size = new System.Drawing.Size(335, 20);
            this.textBox_SourceRootFolder.TabIndex = 0;
            this.textBox_SourceRootFolder.Text = "C:\\";
            this.toolTip.SetToolTip(this.textBox_SourceRootFolder, "Anna projektin juurihakemisto.");
            // 
            // label_heading_SourceRootFolde
            // 
            this.label_heading_SourceRootFolde.AutoSize = true;
            this.label_heading_SourceRootFolde.Location = new System.Drawing.Point(4, 9);
            this.label_heading_SourceRootFolde.Name = "label_heading_SourceRootFolde";
            this.label_heading_SourceRootFolde.Size = new System.Drawing.Size(143, 13);
            this.label_heading_SourceRootFolde.TabIndex = 2;
            this.label_heading_SourceRootFolde.Text = "Valitse koodin juurihakemisto";
            // 
            // button_Browse
            // 
            this.button_Browse.Location = new System.Drawing.Point(345, 26);
            this.button_Browse.Name = "button_Browse";
            this.button_Browse.Size = new System.Drawing.Size(75, 23);
            this.button_Browse.TabIndex = 3;
            this.button_Browse.Text = "Selaa...";
            this.toolTip.SetToolTip(this.button_Browse, "Hae projektin juurihakemisto.");
            this.button_Browse.UseVisualStyleBackColor = true;
            this.button_Browse.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // label_heading
            // 
            this.label_heading.AutoSize = true;
            this.label_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_heading.Location = new System.Drawing.Point(13, 13);
            this.label_heading.Name = "label_heading";
            this.label_heading.Size = new System.Drawing.Size(127, 31);
            this.label_heading.TabIndex = 4;
            this.label_heading.Text = "Looppari";
            // 
            // label_runningInfo
            // 
            this.label_runningInfo.AutoSize = true;
            this.label_runningInfo.BackColor = System.Drawing.Color.Bisque;
            this.label_runningInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_runningInfo.Location = new System.Drawing.Point(178, 13);
            this.label_runningInfo.Name = "label_runningInfo";
            this.label_runningInfo.Size = new System.Drawing.Size(268, 31);
            this.label_runningInfo.TabIndex = 12;
            this.label_runningInfo.Text = "Luetaan tiedostoja....";
            this.label_runningInfo.Visible = false;
            // 
            // button_stop
            // 
            this.button_stop.BackColor = System.Drawing.Color.OrangeRed;
            this.button_stop.Location = new System.Drawing.Point(263, 133);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 48);
            this.button_stop.TabIndex = 13;
            this.button_stop.Text = "Stop";
            this.toolTip.SetToolTip(this.button_stop, "Pysäytä ajo.");
            this.button_stop.UseVisualStyleBackColor = false;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.YellowGreen;
            this.button_start.Location = new System.Drawing.Point(345, 133);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 48);
            this.button_start.TabIndex = 14;
            this.button_start.Text = "Start";
            this.toolTip.SetToolTip(this.button_start, "Käynnistä ajo.");
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // checkBox_IgnoreBin
            // 
            this.checkBox_IgnoreBin.AutoSize = true;
            this.checkBox_IgnoreBin.Checked = true;
            this.checkBox_IgnoreBin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_IgnoreBin.Location = new System.Drawing.Point(4, 118);
            this.checkBox_IgnoreBin.Name = "checkBox_IgnoreBin";
            this.checkBox_IgnoreBin.Size = new System.Drawing.Size(116, 17);
            this.checkBox_IgnoreBin.TabIndex = 17;
            this.checkBox_IgnoreBin.Text = "Ohita \"BIN\" kansio";
            this.toolTip.SetToolTip(this.checkBox_IgnoreBin, "Valitse, jos haluat ettei bin-hakemiston tiedostoja käydä läpi.");
            this.checkBox_IgnoreBin.UseVisualStyleBackColor = true;
            // 
            // checkBox_IgnoreObj
            // 
            this.checkBox_IgnoreObj.AutoSize = true;
            this.checkBox_IgnoreObj.Checked = true;
            this.checkBox_IgnoreObj.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_IgnoreObj.Location = new System.Drawing.Point(4, 141);
            this.checkBox_IgnoreObj.Name = "checkBox_IgnoreObj";
            this.checkBox_IgnoreObj.Size = new System.Drawing.Size(118, 17);
            this.checkBox_IgnoreObj.TabIndex = 18;
            this.checkBox_IgnoreObj.Text = "Ohita \"OBJ\" kansio";
            this.toolTip.SetToolTip(this.checkBox_IgnoreObj, "Valitse, jos haluat ettei obj-hakemiston tiedostoja käydä läpi.");
            this.checkBox_IgnoreObj.UseVisualStyleBackColor = true;
            // 
            // label_heading_Results
            // 
            this.label_heading_Results.AutoSize = true;
            this.label_heading_Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_heading_Results.Location = new System.Drawing.Point(14, 255);
            this.label_heading_Results.Name = "label_heading_Results";
            this.label_heading_Results.Size = new System.Drawing.Size(68, 16);
            this.label_heading_Results.TabIndex = 19;
            this.label_heading_Results.Text = "Tulokset";
            // 
            // label_Stats
            // 
            this.label_Stats.AutoSize = true;
            this.label_Stats.Location = new System.Drawing.Point(14, 539);
            this.label_Stats.Name = "label_Stats";
            this.label_Stats.Size = new System.Drawing.Size(27, 13);
            this.label_Stats.TabIndex = 30;
            this.label_Stats.Text = "N/A";
            // 
            // label_DescriptionRowsSum
            // 
            this.label_DescriptionRowsSum.AutoSize = true;
            this.label_DescriptionRowsSum.Location = new System.Drawing.Point(224, 471);
            this.label_DescriptionRowsSum.Name = "label_DescriptionRowsSum";
            this.label_DescriptionRowsSum.Size = new System.Drawing.Size(27, 13);
            this.label_DescriptionRowsSum.TabIndex = 29;
            this.label_DescriptionRowsSum.Text = "N/A";
            // 
            // label_heading_DescriptionRowsSum
            // 
            this.label_heading_DescriptionRowsSum.AutoSize = true;
            this.label_heading_DescriptionRowsSum.Location = new System.Drawing.Point(14, 471);
            this.label_heading_DescriptionRowsSum.Name = "label_heading_DescriptionRowsSum";
            this.label_heading_DescriptionRowsSum.Size = new System.Drawing.Size(170, 13);
            this.label_heading_DescriptionRowsSum.TabIndex = 28;
            this.label_heading_DescriptionRowsSum.Text = "Kommenttirivejä, jotka alkaa \"///\":";
            // 
            // label_CommentedCodeRowsSum
            // 
            this.label_CommentedCodeRowsSum.AutoSize = true;
            this.label_CommentedCodeRowsSum.Location = new System.Drawing.Point(224, 450);
            this.label_CommentedCodeRowsSum.Name = "label_CommentedCodeRowsSum";
            this.label_CommentedCodeRowsSum.Size = new System.Drawing.Size(27, 13);
            this.label_CommentedCodeRowsSum.TabIndex = 26;
            this.label_CommentedCodeRowsSum.Text = "N/A";
            // 
            // label_CommentedRowsSum
            // 
            this.label_CommentedRowsSum.AutoSize = true;
            this.label_CommentedRowsSum.Location = new System.Drawing.Point(224, 429);
            this.label_CommentedRowsSum.Name = "label_CommentedRowsSum";
            this.label_CommentedRowsSum.Size = new System.Drawing.Size(27, 13);
            this.label_CommentedRowsSum.TabIndex = 27;
            this.label_CommentedRowsSum.Text = "N/A";
            // 
            // label_heading_CommentedCodeRowsSum
            // 
            this.label_heading_CommentedCodeRowsSum.AutoSize = true;
            this.label_heading_CommentedCodeRowsSum.Location = new System.Drawing.Point(14, 450);
            this.label_heading_CommentedCodeRowsSum.Name = "label_heading_CommentedCodeRowsSum";
            this.label_heading_CommentedCodeRowsSum.Size = new System.Drawing.Size(164, 13);
            this.label_heading_CommentedCodeRowsSum.TabIndex = 24;
            this.label_heading_CommentedCodeRowsSum.Text = "Kommenttirivejä, jotka loppuu \";\":";
            // 
            // label_heading_CommentedRowsSum
            // 
            this.label_heading_CommentedRowsSum.AutoSize = true;
            this.label_heading_CommentedRowsSum.Location = new System.Drawing.Point(14, 429);
            this.label_heading_CommentedRowsSum.Name = "label_heading_CommentedRowsSum";
            this.label_heading_CommentedRowsSum.Size = new System.Drawing.Size(84, 13);
            this.label_heading_CommentedRowsSum.TabIndex = 25;
            this.label_heading_CommentedRowsSum.Text = "Kommenttirivejä:";
            // 
            // label_RowsSum
            // 
            this.label_RowsSum.AutoSize = true;
            this.label_RowsSum.Location = new System.Drawing.Point(224, 387);
            this.label_RowsSum.Name = "label_RowsSum";
            this.label_RowsSum.Size = new System.Drawing.Size(27, 13);
            this.label_RowsSum.TabIndex = 23;
            this.label_RowsSum.Text = "N/A";
            // 
            // label_heading_RowsSum
            // 
            this.label_heading_RowsSum.AutoSize = true;
            this.label_heading_RowsSum.Location = new System.Drawing.Point(14, 387);
            this.label_heading_RowsSum.Name = "label_heading_RowsSum";
            this.label_heading_RowsSum.Size = new System.Drawing.Size(115, 13);
            this.label_heading_RowsSum.TabIndex = 22;
            this.label_heading_RowsSum.Text = "Rivejä .cs-tiedostoissa:";
            // 
            // label_SpecialFileCount
            // 
            this.label_SpecialFileCount.AutoSize = true;
            this.label_SpecialFileCount.Location = new System.Drawing.Point(224, 298);
            this.label_SpecialFileCount.Name = "label_SpecialFileCount";
            this.label_SpecialFileCount.Size = new System.Drawing.Size(27, 13);
            this.label_SpecialFileCount.TabIndex = 21;
            this.label_SpecialFileCount.Text = "N/A";
            // 
            // label_heading_SpecialFileCount
            // 
            this.label_heading_SpecialFileCount.AutoSize = true;
            this.label_heading_SpecialFileCount.Location = new System.Drawing.Point(14, 298);
            this.label_heading_SpecialFileCount.Name = "label_heading_SpecialFileCount";
            this.label_heading_SpecialFileCount.Size = new System.Drawing.Size(150, 13);
            this.label_heading_SpecialFileCount.TabIndex = 20;
            this.label_heading_SpecialFileCount.Text = "Tiedostoja, joiden pääte \".cs\":";
            // 
            // panel_Selections
            // 
            this.panel_Selections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Selections.Controls.Add(this.numericUpDown_MediumFileMaxLimit);
            this.panel_Selections.Controls.Add(this.numericUpDown_ShortFileMaxLimit);
            this.panel_Selections.Controls.Add(this.label_heading_SourceRootFolde);
            this.panel_Selections.Controls.Add(this.textBox_SourceRootFolder);
            this.panel_Selections.Controls.Add(this.button_Browse);
            this.panel_Selections.Controls.Add(this.button_start);
            this.panel_Selections.Controls.Add(this.button_stop);
            this.panel_Selections.Controls.Add(this.checkBox_IgnoreDesigner);
            this.panel_Selections.Controls.Add(this.checkBox_IgnoreObj);
            this.panel_Selections.Controls.Add(this.checkBox_IgnoreBin);
            this.panel_Selections.Controls.Add(this.label_heading_MediumFilesMaxRowsSelection);
            this.panel_Selections.Controls.Add(this.label_heading_ShortFilesMaxRowsSelection);
            this.panel_Selections.Location = new System.Drawing.Point(12, 58);
            this.panel_Selections.Name = "panel_Selections";
            this.panel_Selections.Size = new System.Drawing.Size(434, 189);
            this.panel_Selections.TabIndex = 31;
            // 
            // numericUpDown_MediumFileMaxLimit
            // 
            this.numericUpDown_MediumFileMaxLimit.Location = new System.Drawing.Point(177, 86);
            this.numericUpDown_MediumFileMaxLimit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_MediumFileMaxLimit.Name = "numericUpDown_MediumFileMaxLimit";
            this.numericUpDown_MediumFileMaxLimit.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown_MediumFileMaxLimit.TabIndex = 19;
            this.numericUpDown_MediumFileMaxLimit.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.numericUpDown_MediumFileMaxLimit.ValueChanged += new System.EventHandler(this.numericUpDown_MediumFileMaxLimit_ValueChanged);
            // 
            // numericUpDown_ShortFileMaxLimit
            // 
            this.numericUpDown_ShortFileMaxLimit.Location = new System.Drawing.Point(177, 60);
            this.numericUpDown_ShortFileMaxLimit.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.numericUpDown_ShortFileMaxLimit.Name = "numericUpDown_ShortFileMaxLimit";
            this.numericUpDown_ShortFileMaxLimit.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown_ShortFileMaxLimit.TabIndex = 19;
            this.numericUpDown_ShortFileMaxLimit.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown_ShortFileMaxLimit.ValueChanged += new System.EventHandler(this.numericUpDown_ShortFileMaxLimit_ValueChanged);
            // 
            // checkBox_IgnoreDesigner
            // 
            this.checkBox_IgnoreDesigner.AutoSize = true;
            this.checkBox_IgnoreDesigner.Checked = true;
            this.checkBox_IgnoreDesigner.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_IgnoreDesigner.Location = new System.Drawing.Point(4, 164);
            this.checkBox_IgnoreDesigner.Name = "checkBox_IgnoreDesigner";
            this.checkBox_IgnoreDesigner.Size = new System.Drawing.Size(152, 17);
            this.checkBox_IgnoreDesigner.TabIndex = 18;
            this.checkBox_IgnoreDesigner.Text = "Ohita \"Designer\" -tiedostot";
            this.checkBox_IgnoreDesigner.UseVisualStyleBackColor = true;
            // 
            // label_heading_MediumFilesMaxRowsSelection
            // 
            this.label_heading_MediumFilesMaxRowsSelection.AutoSize = true;
            this.label_heading_MediumFilesMaxRowsSelection.Location = new System.Drawing.Point(4, 88);
            this.label_heading_MediumFilesMaxRowsSelection.Name = "label_heading_MediumFilesMaxRowsSelection";
            this.label_heading_MediumFilesMaxRowsSelection.Size = new System.Drawing.Size(153, 13);
            this.label_heading_MediumFilesMaxRowsSelection.TabIndex = 20;
            this.label_heading_MediumFilesMaxRowsSelection.Text = "Pitkän tiedoston min. rivimäärä:";
            // 
            // label_heading_ShortFilesMaxRowsSelection
            // 
            this.label_heading_ShortFilesMaxRowsSelection.AutoSize = true;
            this.label_heading_ShortFilesMaxRowsSelection.Location = new System.Drawing.Point(4, 62);
            this.label_heading_ShortFilesMaxRowsSelection.Name = "label_heading_ShortFilesMaxRowsSelection";
            this.label_heading_ShortFilesMaxRowsSelection.Size = new System.Drawing.Size(160, 13);
            this.label_heading_ShortFilesMaxRowsSelection.TabIndex = 20;
            this.label_heading_ShortFilesMaxRowsSelection.Text = "Lyhyen tiedoston max. rivimäärä:";
            // 
            // label_heading_ShortFiles
            // 
            this.label_heading_ShortFiles.AutoSize = true;
            this.label_heading_ShortFiles.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_heading_ShortFiles.Location = new System.Drawing.Point(14, 495);
            this.label_heading_ShortFiles.Name = "label_heading_ShortFiles";
            this.label_heading_ShortFiles.Size = new System.Drawing.Size(115, 13);
            this.label_heading_ShortFiles.TabIndex = 32;
            this.label_heading_ShortFiles.Text = "Alle 300 rivin tiedostoja";
            // 
            // label_heading_MediumFiles
            // 
            this.label_heading_MediumFiles.AutoSize = true;
            this.label_heading_MediumFiles.ForeColor = System.Drawing.Color.Orange;
            this.label_heading_MediumFiles.Location = new System.Drawing.Point(168, 495);
            this.label_heading_MediumFiles.Name = "label_heading_MediumFiles";
            this.label_heading_MediumFiles.Size = new System.Drawing.Size(115, 13);
            this.label_heading_MediumFiles.TabIndex = 32;
            this.label_heading_MediumFiles.Text = "Alle 700 rivin tiedostoja";
            // 
            // label_heading_LongFiles
            // 
            this.label_heading_LongFiles.AutoSize = true;
            this.label_heading_LongFiles.ForeColor = System.Drawing.Color.Red;
            this.label_heading_LongFiles.Location = new System.Drawing.Point(324, 495);
            this.label_heading_LongFiles.Name = "label_heading_LongFiles";
            this.label_heading_LongFiles.Size = new System.Drawing.Size(109, 13);
            this.label_heading_LongFiles.TabIndex = 32;
            this.label_heading_LongFiles.Text = "Yli 700 rivin tiedostoja";
            // 
            // label_ShortFiles
            // 
            this.label_ShortFiles.AutoSize = true;
            this.label_ShortFiles.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_ShortFiles.Location = new System.Drawing.Point(14, 513);
            this.label_ShortFiles.Name = "label_ShortFiles";
            this.label_ShortFiles.Size = new System.Drawing.Size(27, 13);
            this.label_ShortFiles.TabIndex = 32;
            this.label_ShortFiles.Text = "N/A";
            // 
            // label_MediumFiles
            // 
            this.label_MediumFiles.AutoSize = true;
            this.label_MediumFiles.ForeColor = System.Drawing.Color.Orange;
            this.label_MediumFiles.Location = new System.Drawing.Point(168, 513);
            this.label_MediumFiles.Name = "label_MediumFiles";
            this.label_MediumFiles.Size = new System.Drawing.Size(27, 13);
            this.label_MediumFiles.TabIndex = 32;
            this.label_MediumFiles.Text = "N/A";
            // 
            // label_LongFiles
            // 
            this.label_LongFiles.AutoSize = true;
            this.label_LongFiles.ForeColor = System.Drawing.Color.Red;
            this.label_LongFiles.Location = new System.Drawing.Point(324, 513);
            this.label_LongFiles.Name = "label_LongFiles";
            this.label_LongFiles.Size = new System.Drawing.Size(27, 13);
            this.label_LongFiles.TabIndex = 32;
            this.label_LongFiles.Text = "N/A";
            // 
            // label_heading_FileCount
            // 
            this.label_heading_FileCount.AutoSize = true;
            this.label_heading_FileCount.Location = new System.Drawing.Point(14, 278);
            this.label_heading_FileCount.Name = "label_heading_FileCount";
            this.label_heading_FileCount.Size = new System.Drawing.Size(105, 13);
            this.label_heading_FileCount.TabIndex = 33;
            this.label_heading_FileCount.Text = "Tiedostoja yhteensä:";
            // 
            // label_FileCount
            // 
            this.label_FileCount.AutoSize = true;
            this.label_FileCount.Location = new System.Drawing.Point(224, 278);
            this.label_FileCount.Name = "label_FileCount";
            this.label_FileCount.Size = new System.Drawing.Size(27, 13);
            this.label_FileCount.TabIndex = 34;
            this.label_FileCount.Text = "N/A";
            // 
            // label_heading_RowsAveragePerFile
            // 
            this.label_heading_RowsAveragePerFile.AutoSize = true;
            this.label_heading_RowsAveragePerFile.Location = new System.Drawing.Point(14, 408);
            this.label_heading_RowsAveragePerFile.Name = "label_heading_RowsAveragePerFile";
            this.label_heading_RowsAveragePerFile.Size = new System.Drawing.Size(214, 13);
            this.label_heading_RowsAveragePerFile.TabIndex = 22;
            this.label_heading_RowsAveragePerFile.Text = "Rivejä keskimäärin yhdessä .cs-tiedostossa:";
            // 
            // label_RowsAveragePerFile
            // 
            this.label_RowsAveragePerFile.AutoSize = true;
            this.label_RowsAveragePerFile.Location = new System.Drawing.Point(224, 408);
            this.label_RowsAveragePerFile.Name = "label_RowsAveragePerFile";
            this.label_RowsAveragePerFile.Size = new System.Drawing.Size(27, 13);
            this.label_RowsAveragePerFile.TabIndex = 23;
            this.label_RowsAveragePerFile.Text = "N/A";
            // 
            // label_heading_SkippedFilesInObjFolder
            // 
            this.label_heading_SkippedFilesInObjFolder.AutoSize = true;
            this.label_heading_SkippedFilesInObjFolder.Location = new System.Drawing.Point(14, 341);
            this.label_heading_SkippedFilesInObjFolder.Name = "label_heading_SkippedFilesInObjFolder";
            this.label_heading_SkippedFilesInObjFolder.Size = new System.Drawing.Size(159, 13);
            this.label_heading_SkippedFilesInObjFolder.TabIndex = 22;
            this.label_heading_SkippedFilesInObjFolder.Text = "Ohitetut tiedostot obj-kansioissa:";
            // 
            // label_SkippedFilesInObjFolder
            // 
            this.label_SkippedFilesInObjFolder.AutoSize = true;
            this.label_SkippedFilesInObjFolder.Location = new System.Drawing.Point(224, 341);
            this.label_SkippedFilesInObjFolder.Name = "label_SkippedFilesInObjFolder";
            this.label_SkippedFilesInObjFolder.Size = new System.Drawing.Size(27, 13);
            this.label_SkippedFilesInObjFolder.TabIndex = 23;
            this.label_SkippedFilesInObjFolder.Text = "N/A";
            // 
            // label_SkippedFilesInBinFolder
            // 
            this.label_SkippedFilesInBinFolder.AutoSize = true;
            this.label_SkippedFilesInBinFolder.Location = new System.Drawing.Point(224, 321);
            this.label_SkippedFilesInBinFolder.Name = "label_SkippedFilesInBinFolder";
            this.label_SkippedFilesInBinFolder.Size = new System.Drawing.Size(27, 13);
            this.label_SkippedFilesInBinFolder.TabIndex = 36;
            this.label_SkippedFilesInBinFolder.Text = "N/A";
            // 
            // label_heading_SkippedFilesInBinFolder
            // 
            this.label_heading_SkippedFilesInBinFolder.AutoSize = true;
            this.label_heading_SkippedFilesInBinFolder.Location = new System.Drawing.Point(14, 321);
            this.label_heading_SkippedFilesInBinFolder.Name = "label_heading_SkippedFilesInBinFolder";
            this.label_heading_SkippedFilesInBinFolder.Size = new System.Drawing.Size(159, 13);
            this.label_heading_SkippedFilesInBinFolder.TabIndex = 35;
            this.label_heading_SkippedFilesInBinFolder.Text = "Ohitetut tiedostot bin-kansioissa:";
            // 
            // label_SkippedDesignerFiles
            // 
            this.label_SkippedDesignerFiles.AutoSize = true;
            this.label_SkippedDesignerFiles.Location = new System.Drawing.Point(224, 361);
            this.label_SkippedDesignerFiles.Name = "label_SkippedDesignerFiles";
            this.label_SkippedDesignerFiles.Size = new System.Drawing.Size(27, 13);
            this.label_SkippedDesignerFiles.TabIndex = 38;
            this.label_SkippedDesignerFiles.Text = "N/A";
            // 
            // label_heading_SkippedDesignerFiles
            // 
            this.label_heading_SkippedDesignerFiles.AutoSize = true;
            this.label_heading_SkippedDesignerFiles.Location = new System.Drawing.Point(14, 361);
            this.label_heading_SkippedDesignerFiles.Name = "label_heading_SkippedDesignerFiles";
            this.label_heading_SkippedDesignerFiles.Size = new System.Drawing.Size(152, 13);
            this.label_heading_SkippedDesignerFiles.TabIndex = 37;
            this.label_heading_SkippedDesignerFiles.Text = "Ohitetut .Designer.cs-tiedostot:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 561);
            this.Controls.Add(this.label_SkippedDesignerFiles);
            this.Controls.Add(this.label_heading_SkippedDesignerFiles);
            this.Controls.Add(this.label_SkippedFilesInBinFolder);
            this.Controls.Add(this.label_heading_SkippedFilesInBinFolder);
            this.Controls.Add(this.label_FileCount);
            this.Controls.Add(this.label_heading_FileCount);
            this.Controls.Add(this.label_LongFiles);
            this.Controls.Add(this.label_heading_LongFiles);
            this.Controls.Add(this.label_MediumFiles);
            this.Controls.Add(this.label_heading_MediumFiles);
            this.Controls.Add(this.label_ShortFiles);
            this.Controls.Add(this.label_heading_ShortFiles);
            this.Controls.Add(this.panel_Selections);
            this.Controls.Add(this.label_Stats);
            this.Controls.Add(this.label_DescriptionRowsSum);
            this.Controls.Add(this.label_heading_DescriptionRowsSum);
            this.Controls.Add(this.label_CommentedCodeRowsSum);
            this.Controls.Add(this.label_CommentedRowsSum);
            this.Controls.Add(this.label_heading_CommentedCodeRowsSum);
            this.Controls.Add(this.label_heading_CommentedRowsSum);
            this.Controls.Add(this.label_RowsAveragePerFile);
            this.Controls.Add(this.label_SkippedFilesInObjFolder);
            this.Controls.Add(this.label_RowsSum);
            this.Controls.Add(this.label_heading_RowsAveragePerFile);
            this.Controls.Add(this.label_heading_SkippedFilesInObjFolder);
            this.Controls.Add(this.label_heading_RowsSum);
            this.Controls.Add(this.label_SpecialFileCount);
            this.Controls.Add(this.label_heading_SpecialFileCount);
            this.Controls.Add(this.label_heading_Results);
            this.Controls.Add(this.label_runningInfo);
            this.Controls.Add(this.label_heading);
            this.MaximumSize = new System.Drawing.Size(474, 600);
            this.MinimumSize = new System.Drawing.Size(474, 600);
            this.Name = "MainForm";
            this.Text = "Looppari";
            this.panel_Selections.ResumeLayout(false);
            this.panel_Selections.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MediumFileMaxLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ShortFileMaxLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_SourceRootFolder;
        private System.Windows.Forms.Label label_heading_SourceRootFolde;
        private System.Windows.Forms.Button button_Browse;
        private System.Windows.Forms.Label label_heading;
        private System.Windows.Forms.Label label_runningInfo;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.CheckBox checkBox_IgnoreBin;
        private System.Windows.Forms.CheckBox checkBox_IgnoreObj;
        private System.Windows.Forms.Label label_heading_Results;
        private System.Windows.Forms.Label label_Stats;
        private System.Windows.Forms.Label label_DescriptionRowsSum;
        private System.Windows.Forms.Label label_heading_DescriptionRowsSum;
        private System.Windows.Forms.Label label_CommentedCodeRowsSum;
        private System.Windows.Forms.Label label_CommentedRowsSum;
        private System.Windows.Forms.Label label_heading_CommentedCodeRowsSum;
        private System.Windows.Forms.Label label_heading_CommentedRowsSum;
        private System.Windows.Forms.Label label_RowsSum;
        private System.Windows.Forms.Label label_heading_RowsSum;
        private System.Windows.Forms.Label label_SpecialFileCount;
        private System.Windows.Forms.Label label_heading_SpecialFileCount;
        private System.Windows.Forms.Panel panel_Selections;
        private System.Windows.Forms.Label label_heading_ShortFiles;
        private System.Windows.Forms.Label label_heading_MediumFiles;
        private System.Windows.Forms.Label label_heading_LongFiles;
        private System.Windows.Forms.Label label_ShortFiles;
        private System.Windows.Forms.Label label_MediumFiles;
        private System.Windows.Forms.Label label_LongFiles;
        private System.Windows.Forms.NumericUpDown numericUpDown_MediumFileMaxLimit;
        private System.Windows.Forms.NumericUpDown numericUpDown_ShortFileMaxLimit;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label_heading_MediumFilesMaxRowsSelection;
        private System.Windows.Forms.Label label_heading_ShortFilesMaxRowsSelection;
        private System.Windows.Forms.Label label_heading_FileCount;
        private System.Windows.Forms.Label label_FileCount;
        private System.Windows.Forms.Label label_heading_RowsAveragePerFile;
        private System.Windows.Forms.Label label_RowsAveragePerFile;
        private System.Windows.Forms.CheckBox checkBox_IgnoreDesigner;
        private System.Windows.Forms.Label label_heading_SkippedFilesInObjFolder;
        private System.Windows.Forms.Label label_SkippedFilesInObjFolder;
        private System.Windows.Forms.Label label_SkippedFilesInBinFolder;
        private System.Windows.Forms.Label label_heading_SkippedFilesInBinFolder;
        private System.Windows.Forms.Label label_SkippedDesignerFiles;
        private System.Windows.Forms.Label label_heading_SkippedDesignerFiles;
    }
}

