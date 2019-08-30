﻿namespace Foreign_Alphabet
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbCharacterDisplay = new System.Windows.Forms.RichTextBox();
            this.gboAlphabet = new System.Windows.Forms.GroupBox();
            this.tblDescription = new System.Windows.Forms.TableLayoutPanel();
            this.chkReading = new System.Windows.Forms.CheckBox();
            this.chkMeaning = new System.Windows.Forms.CheckBox();
            this.lboReading = new System.Windows.Forms.ListBox();
            this.lboMeaning = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.gboConfig = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.trvAlphabetGroups = new System.Windows.Forms.TreeView();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.ofdAlphabetFileDialogue = new System.Windows.Forms.OpenFileDialog();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.codBGColor = new System.Windows.Forms.ColorDialog();
            this.codTextColor = new System.Windows.Forms.ColorDialog();
            this.cboSelectionMethod = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.gboAlphabet.SuspendLayout();
            this.tblDescription.SuspendLayout();
            this.gboConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(651, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.fontColourToolStripMenuItem,
            this.backgroundColourToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // fontColourToolStripMenuItem
            // 
            this.fontColourToolStripMenuItem.Name = "fontColourToolStripMenuItem";
            this.fontColourToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.fontColourToolStripMenuItem.Text = "Font Colour";
            this.fontColourToolStripMenuItem.Click += new System.EventHandler(this.FontColourToolStripMenuItem_Click);
            // 
            // backgroundColourToolStripMenuItem
            // 
            this.backgroundColourToolStripMenuItem.Name = "backgroundColourToolStripMenuItem";
            this.backgroundColourToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.backgroundColourToolStripMenuItem.Text = "Background Colour";
            this.backgroundColourToolStripMenuItem.Click += new System.EventHandler(this.BackgroundColourToolStripMenuItem_Click);
            // 
            // rtbCharacterDisplay
            // 
            this.rtbCharacterDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCharacterDisplay.Location = new System.Drawing.Point(6, 19);
            this.rtbCharacterDisplay.Name = "rtbCharacterDisplay";
            this.rtbCharacterDisplay.ReadOnly = true;
            this.rtbCharacterDisplay.Size = new System.Drawing.Size(357, 216);
            this.rtbCharacterDisplay.TabIndex = 0;
            this.rtbCharacterDisplay.Text = "";
            // 
            // gboAlphabet
            // 
            this.gboAlphabet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboAlphabet.Controls.Add(this.tblDescription);
            this.gboAlphabet.Controls.Add(this.btnNext);
            this.gboAlphabet.Controls.Add(this.rtbCharacterDisplay);
            this.gboAlphabet.Location = new System.Drawing.Point(12, 27);
            this.gboAlphabet.Name = "gboAlphabet";
            this.gboAlphabet.Size = new System.Drawing.Size(369, 482);
            this.gboAlphabet.TabIndex = 0;
            this.gboAlphabet.TabStop = false;
            // 
            // tblDescription
            // 
            this.tblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblDescription.ColumnCount = 2;
            this.tblDescription.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.84874F));
            this.tblDescription.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.15126F));
            this.tblDescription.Controls.Add(this.chkReading, 0, 0);
            this.tblDescription.Controls.Add(this.chkMeaning, 0, 1);
            this.tblDescription.Controls.Add(this.lboReading, 1, 0);
            this.tblDescription.Controls.Add(this.lboMeaning, 1, 1);
            this.tblDescription.Location = new System.Drawing.Point(6, 242);
            this.tblDescription.Name = "tblDescription";
            this.tblDescription.RowCount = 2;
            this.tblDescription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDescription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDescription.Size = new System.Drawing.Size(357, 181);
            this.tblDescription.TabIndex = 6;
            // 
            // chkReading
            // 
            this.chkReading.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkReading.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkReading.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkReading.Enabled = false;
            this.chkReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReading.Location = new System.Drawing.Point(3, 3);
            this.chkReading.Name = "chkReading";
            this.chkReading.Size = new System.Drawing.Size(72, 50);
            this.chkReading.TabIndex = 1;
            this.chkReading.Text = "Show Reading";
            this.chkReading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkReading.UseVisualStyleBackColor = true;
            this.chkReading.CheckedChanged += new System.EventHandler(this.ChkDescription_CheckedChanged);
            // 
            // chkMeaning
            // 
            this.chkMeaning.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkMeaning.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMeaning.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkMeaning.Enabled = false;
            this.chkMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMeaning.Location = new System.Drawing.Point(3, 93);
            this.chkMeaning.Name = "chkMeaning";
            this.chkMeaning.Size = new System.Drawing.Size(72, 50);
            this.chkMeaning.TabIndex = 6;
            this.chkMeaning.Text = "Show Meaning";
            this.chkMeaning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkMeaning.UseVisualStyleBackColor = true;
            this.chkMeaning.CheckedChanged += new System.EventHandler(this.ChkReading_CheckedChanged);
            // 
            // lboReading
            // 
            this.lboReading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboReading.Enabled = false;
            this.lboReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboReading.FormattingEnabled = true;
            this.lboReading.ItemHeight = 24;
            this.lboReading.Location = new System.Drawing.Point(81, 3);
            this.lboReading.Name = "lboReading";
            this.lboReading.Size = new System.Drawing.Size(273, 84);
            this.lboReading.TabIndex = 2;
            this.lboReading.Visible = false;
            // 
            // lboMeaning
            // 
            this.lboMeaning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboMeaning.Enabled = false;
            this.lboMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboMeaning.FormattingEnabled = true;
            this.lboMeaning.ItemHeight = 24;
            this.lboMeaning.Location = new System.Drawing.Point(81, 93);
            this.lboMeaning.Name = "lboMeaning";
            this.lboMeaning.Size = new System.Drawing.Size(273, 85);
            this.lboMeaning.TabIndex = 5;
            this.lboMeaning.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(6, 437);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(357, 39);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // gboConfig
            // 
            this.gboConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboConfig.Controls.Add(this.cboSelectionMethod);
            this.gboConfig.Controls.Add(this.btnClear);
            this.gboConfig.Controls.Add(this.trvAlphabetGroups);
            this.gboConfig.Controls.Add(this.btnLoadFile);
            this.gboConfig.Controls.Add(this.txtFile);
            this.gboConfig.Location = new System.Drawing.Point(387, 27);
            this.gboConfig.Name = "gboConfig";
            this.gboConfig.Size = new System.Drawing.Size(252, 431);
            this.gboConfig.TabIndex = 1;
            this.gboConfig.TabStop = false;
            this.gboConfig.Text = "Configuration";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(171, 48);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // trvAlphabetGroups
            // 
            this.trvAlphabetGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvAlphabetGroups.CheckBoxes = true;
            this.trvAlphabetGroups.Location = new System.Drawing.Point(6, 77);
            this.trvAlphabetGroups.Name = "trvAlphabetGroups";
            this.trvAlphabetGroups.Size = new System.Drawing.Size(240, 346);
            this.trvAlphabetGroups.TabIndex = 2;
            this.trvAlphabetGroups.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.TrvAlphabetGroups_AfterCheck);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFile.Location = new System.Drawing.Point(171, 19);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 1;
            this.btnLoadFile.Text = "Load...";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.BtnLoadFile_Click);
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.Location = new System.Drawing.Point(6, 21);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(159, 20);
            this.txtFile.TabIndex = 0;
            // 
            // ofdAlphabetFileDialogue
            // 
            this.ofdAlphabetFileDialogue.DefaultExt = "xml";
            this.ofdAlphabetFileDialogue.Title = "Open Alphabet File";
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalytics.Enabled = false;
            this.btnAnalytics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalytics.Location = new System.Drawing.Point(519, 464);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(120, 39);
            this.btnAnalytics.TabIndex = 3;
            this.btnAnalytics.Text = "Averages";
            this.btnAnalytics.UseVisualStyleBackColor = true;
            this.btnAnalytics.Click += new System.EventHandler(this.BtnAnalytics_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(387, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 39);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // fontDialog
            // 
            this.fontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // codBGColor
            // 
            this.codBGColor.AnyColor = true;
            this.codBGColor.Color = System.Drawing.Color.LightGray;
            this.codBGColor.FullOpen = true;
            this.codBGColor.SolidColorOnly = true;
            // 
            // codTextColor
            // 
            this.codTextColor.AnyColor = true;
            this.codTextColor.FullOpen = true;
            this.codTextColor.SolidColorOnly = true;
            // 
            // cboSelectionMethod
            // 
            this.cboSelectionMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSelectionMethod.FormattingEnabled = true;
            this.cboSelectionMethod.Items.AddRange(new object[] {
            "Random",
            "Sequential"});
            this.cboSelectionMethod.Location = new System.Drawing.Point(6, 47);
            this.cboSelectionMethod.Name = "cboSelectionMethod";
            this.cboSelectionMethod.Size = new System.Drawing.Size(159, 21);
            this.cboSelectionMethod.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 521);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAnalytics);
            this.Controls.Add(this.gboConfig);
            this.Controls.Add(this.gboAlphabet);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(667, 450);
            this.Name = "Form1";
            this.Text = "Foreign Alphabet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gboAlphabet.ResumeLayout(false);
            this.tblDescription.ResumeLayout(false);
            this.gboConfig.ResumeLayout(false);
            this.gboConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbCharacterDisplay;
        private System.Windows.Forms.GroupBox gboAlphabet;
        private System.Windows.Forms.GroupBox gboConfig;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.OpenFileDialog ofdAlphabetFileDialogue;
        private System.Windows.Forms.TreeView trvAlphabetGroups;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox chkReading;
        private System.Windows.Forms.ListBox lboReading;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog codBGColor;
        private System.Windows.Forms.ColorDialog codTextColor;
        private System.Windows.Forms.ToolStripMenuItem fontColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColourToolStripMenuItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TableLayoutPanel tblDescription;
        private System.Windows.Forms.ListBox lboMeaning;
        private System.Windows.Forms.CheckBox chkMeaning;
        private System.Windows.Forms.ComboBox cboSelectionMethod;
    }
}

