﻿namespace AMSExplorer
{
    partial class MediaAnalyticsFaceDetection
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
            this.label3 = new System.Windows.Forms.Label();
            this.textboxoutputassetname = new System.Windows.Forms.TextBox();
            this.labelProcessorVersion = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelAssetName = new System.Windows.Forms.Label();
            this.textBoxJobName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelProcessorName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.moreinfoprofilelink = new System.Windows.Forms.LinkLabel();
            this.labelPreview = new System.Windows.Forms.Label();
            this.groupBoxAggregateSettings = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownAggregateInterval = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAggregateWindow = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.radioButtonFaceDetection = new System.Windows.Forms.RadioButton();
            this.radioButtonAggregateEmotionDetection = new System.Windows.Forms.RadioButton();
            this.radioButtonPerFaceEmotion = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonJobOptions = new AMSExplorer.ButtonJobOptions();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.labelWarningJSON = new System.Windows.Forms.Label();
            this.textBoxConfiguration = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBoxAggregateSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAggregateInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAggregateWindow)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Output asset name :";
            // 
            // textboxoutputassetname
            // 
            this.textboxoutputassetname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxoutputassetname.Location = new System.Drawing.Point(17, 378);
            this.textboxoutputassetname.Name = "textboxoutputassetname";
            this.textboxoutputassetname.Size = new System.Drawing.Size(418, 23);
            this.textboxoutputassetname.TabIndex = 21;
            // 
            // labelProcessorVersion
            // 
            this.labelProcessorVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProcessorVersion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelProcessorVersion.Location = new System.Drawing.Point(245, 59);
            this.labelProcessorVersion.Name = "labelProcessorVersion";
            this.labelProcessorVersion.Size = new System.Drawing.Size(382, 20);
            this.labelProcessorVersion.TabIndex = 20;
            this.labelProcessorVersion.Text = "Version {0}";
            this.labelProcessorVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(506, 15);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(115, 27);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelAssetName
            // 
            this.labelAssetName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAssetName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssetName.Location = new System.Drawing.Point(277, 111);
            this.labelAssetName.Name = "labelAssetName";
            this.labelAssetName.Size = new System.Drawing.Size(350, 35);
            this.labelAssetName.TabIndex = 50;
            this.labelAssetName.Text = "assetname";
            // 
            // textBoxJobName
            // 
            this.textBoxJobName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxJobName.Location = new System.Drawing.Point(17, 322);
            this.textBoxJobName.Name = "textBoxJobName";
            this.textBoxJobName.Size = new System.Drawing.Size(418, 23);
            this.textBoxJobName.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 53;
            this.label5.Text = "Job name :";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Image = global::AMSExplorer.Bitmaps.hyperlapse;
            this.buttonOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOk.Location = new System.Drawing.Point(329, 15);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(170, 27);
            this.buttonOk.TabIndex = 17;
            this.buttonOk.Text = "Launch processing";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // labelProcessorName
            // 
            this.labelProcessorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProcessorName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelProcessorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(128)))), ((int)(((byte)(171)))));
            this.labelProcessorName.Location = new System.Drawing.Point(131, 14);
            this.labelProcessorName.Name = "labelProcessorName";
            this.labelProcessorName.Size = new System.Drawing.Size(496, 25);
            this.labelProcessorName.TabIndex = 65;
            this.labelProcessorName.Text = "Processor Name";
            this.labelProcessorName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonOk);
            this.panel1.Location = new System.Drawing.Point(-2, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 55);
            this.panel1.TabIndex = 66;
            // 
            // moreinfoprofilelink
            // 
            this.moreinfoprofilelink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moreinfoprofilelink.AutoSize = true;
            this.moreinfoprofilelink.Location = new System.Drawing.Point(526, 83);
            this.moreinfoprofilelink.Name = "moreinfoprofilelink";
            this.moreinfoprofilelink.Size = new System.Drawing.Size(101, 15);
            this.moreinfoprofilelink.TabIndex = 70;
            this.moreinfoprofilelink.TabStop = true;
            this.moreinfoprofilelink.Text = "More information";
            this.moreinfoprofilelink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.moreinfoprofilelink_LinkClicked);
            // 
            // labelPreview
            // 
            this.labelPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPreview.AutoSize = true;
            this.labelPreview.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(128)))), ((int)(((byte)(171)))));
            this.labelPreview.Location = new System.Drawing.Point(568, 39);
            this.labelPreview.Name = "labelPreview";
            this.labelPreview.Size = new System.Drawing.Size(59, 20);
            this.labelPreview.TabIndex = 73;
            this.labelPreview.Text = "Preview";
            this.labelPreview.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBoxAggregateSettings
            // 
            this.groupBoxAggregateSettings.Controls.Add(this.label4);
            this.groupBoxAggregateSettings.Controls.Add(this.label2);
            this.groupBoxAggregateSettings.Controls.Add(this.numericUpDownAggregateInterval);
            this.groupBoxAggregateSettings.Controls.Add(this.numericUpDownAggregateWindow);
            this.groupBoxAggregateSettings.Enabled = false;
            this.groupBoxAggregateSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAggregateSettings.Location = new System.Drawing.Point(285, 25);
            this.groupBoxAggregateSettings.Name = "groupBoxAggregateSettings";
            this.groupBoxAggregateSettings.Size = new System.Drawing.Size(281, 109);
            this.groupBoxAggregateSettings.TabIndex = 76;
            this.groupBoxAggregateSettings.TabStop = false;
            this.groupBoxAggregateSettings.Text = "Aggregate mode settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(138, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 85;
            this.label4.Text = "Interval (ms) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(17, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 77;
            this.label2.Text = "Window (ms) :";
            // 
            // numericUpDownAggregateInterval
            // 
            this.numericUpDownAggregateInterval.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDownAggregateInterval.Location = new System.Drawing.Point(141, 51);
            this.numericUpDownAggregateInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownAggregateInterval.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDownAggregateInterval.Name = "numericUpDownAggregateInterval";
            this.numericUpDownAggregateInterval.Size = new System.Drawing.Size(91, 23);
            this.numericUpDownAggregateInterval.TabIndex = 1;
            this.toolTip1.SetToolTip(this.numericUpDownAggregateInterval, "How frequently to produce aggregate results");
            this.numericUpDownAggregateInterval.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownAggregateInterval.ValueChanged += new System.EventHandler(this.control_changed);
            // 
            // numericUpDownAggregateWindow
            // 
            this.numericUpDownAggregateWindow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDownAggregateWindow.Location = new System.Drawing.Point(20, 51);
            this.numericUpDownAggregateWindow.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownAggregateWindow.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDownAggregateWindow.Name = "numericUpDownAggregateWindow";
            this.numericUpDownAggregateWindow.Size = new System.Drawing.Size(91, 23);
            this.numericUpDownAggregateWindow.TabIndex = 0;
            this.toolTip1.SetToolTip(this.numericUpDownAggregateWindow, "The length of video used to produce each aggregate result");
            this.numericUpDownAggregateWindow.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownAggregateWindow.ValueChanged += new System.EventHandler(this.control_changed);
            // 
            // radioButtonFaceDetection
            // 
            this.radioButtonFaceDetection.AutoSize = true;
            this.radioButtonFaceDetection.Checked = true;
            this.radioButtonFaceDetection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFaceDetection.Location = new System.Drawing.Point(17, 29);
            this.radioButtonFaceDetection.Name = "radioButtonFaceDetection";
            this.radioButtonFaceDetection.Size = new System.Drawing.Size(102, 19);
            this.radioButtonFaceDetection.TabIndex = 77;
            this.radioButtonFaceDetection.TabStop = true;
            this.radioButtonFaceDetection.Text = "Face detection";
            this.toolTip1.SetToolTip(this.radioButtonFaceDetection, "Only face detection");
            this.radioButtonFaceDetection.UseVisualStyleBackColor = true;
            this.radioButtonFaceDetection.CheckedChanged += new System.EventHandler(this.radioButtonDetectionMode_CheckedChanged);
            // 
            // radioButtonAggregateEmotionDetection
            // 
            this.radioButtonAggregateEmotionDetection.AutoSize = true;
            this.radioButtonAggregateEmotionDetection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAggregateEmotionDetection.Location = new System.Drawing.Point(17, 55);
            this.radioButtonAggregateEmotionDetection.Name = "radioButtonAggregateEmotionDetection";
            this.radioButtonAggregateEmotionDetection.Size = new System.Drawing.Size(187, 19);
            this.radioButtonAggregateEmotionDetection.TabIndex = 79;
            this.radioButtonAggregateEmotionDetection.Text = "Emotion detection (aggregate)";
            this.toolTip1.SetToolTip(this.radioButtonAggregateEmotionDetection, "Return average emotion values for all faces in frame");
            this.radioButtonAggregateEmotionDetection.UseVisualStyleBackColor = true;
            this.radioButtonAggregateEmotionDetection.CheckedChanged += new System.EventHandler(this.radioButtonDetectionMode_CheckedChanged);
            // 
            // radioButtonPerFaceEmotion
            // 
            this.radioButtonPerFaceEmotion.AutoSize = true;
            this.radioButtonPerFaceEmotion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPerFaceEmotion.Location = new System.Drawing.Point(17, 80);
            this.radioButtonPerFaceEmotion.Name = "radioButtonPerFaceEmotion";
            this.radioButtonPerFaceEmotion.Size = new System.Drawing.Size(115, 19);
            this.radioButtonPerFaceEmotion.TabIndex = 80;
            this.radioButtonPerFaceEmotion.Text = "Per face emotion";
            this.radioButtonPerFaceEmotion.UseVisualStyleBackColor = true;
            this.radioButtonPerFaceEmotion.CheckedChanged += new System.EventHandler(this.radioButtonDetectionMode_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPerFaceEmotion);
            this.groupBox1.Controls.Add(this.radioButtonFaceDetection);
            this.groupBox1.Controls.Add(this.radioButtonAggregateEmotionDetection);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 109);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // buttonJobOptions
            // 
            this.buttonJobOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonJobOptions.Location = new System.Drawing.Point(467, 322);
            this.buttonJobOptions.Name = "buttonJobOptions";
            this.buttonJobOptions.Size = new System.Drawing.Size(160, 27);
            this.buttonJobOptions.TabIndex = 72;
            this.buttonJobOptions.Text = "Job options...";
            this.buttonJobOptions.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Key";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AMSExplorer.Bitmaps._04_face_detection;
            this.pictureBox1.Location = new System.Drawing.Point(14, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageConfig);
            this.tabControl1.Location = new System.Drawing.Point(17, 111);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 185);
            this.tabControl1.TabIndex = 108;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBoxAggregateSettings);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(601, 157);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.Controls.Add(this.labelWarningJSON);
            this.tabPageConfig.Controls.Add(this.textBoxConfiguration);
            this.tabPageConfig.Controls.Add(this.label9);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 24);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfig.Size = new System.Drawing.Size(601, 157);
            this.tabPageConfig.TabIndex = 1;
            this.tabPageConfig.Text = "Generated JSON configuration";
            this.tabPageConfig.UseVisualStyleBackColor = true;
            this.tabPageConfig.Enter += new System.EventHandler(this.control_changed);
            // 
            // labelWarningJSON
            // 
            this.labelWarningJSON.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWarningJSON.ForeColor = System.Drawing.Color.Red;
            this.labelWarningJSON.Location = new System.Drawing.Point(143, 7);
            this.labelWarningJSON.Name = "labelWarningJSON";
            this.labelWarningJSON.Size = new System.Drawing.Size(452, 19);
            this.labelWarningJSON.TabIndex = 80;
            this.labelWarningJSON.Tag = "JSON Syntax error. {0}";
            this.labelWarningJSON.Text = "JSON Syntax error. {0}";
            this.labelWarningJSON.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelWarningJSON.Visible = false;
            // 
            // textBoxConfiguration
            // 
            this.textBoxConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConfiguration.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfiguration.Location = new System.Drawing.Point(6, 29);
            this.textBoxConfiguration.Multiline = true;
            this.textBoxConfiguration.Name = "textBoxConfiguration";
            this.textBoxConfiguration.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxConfiguration.Size = new System.Drawing.Size(589, 122);
            this.textBoxConfiguration.TabIndex = 78;
            this.textBoxConfiguration.TextChanged += new System.EventHandler(this.textBoxConfiguration_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 15);
            this.label9.TabIndex = 79;
            this.label9.Text = "JSON or XML (editable) :";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(625, 423);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 42);
            this.panel2.TabIndex = 109;
            // 
            // MediaAnalyticsFaceDetection
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(645, 479);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelPreview);
            this.Controls.Add(this.buttonJobOptions);
            this.Controls.Add(this.moreinfoprofilelink);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelProcessorName);
            this.Controls.Add(this.textBoxJobName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelAssetName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxoutputassetname);
            this.Controls.Add(this.labelProcessorVersion);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "MediaAnalyticsFaceDetection";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Processor";
            this.Load += new System.EventHandler(this.MediaAnalyticsFaceDetection_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxAggregateSettings.ResumeLayout(false);
            this.groupBoxAggregateSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAggregateInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAggregateWindow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPageConfig.ResumeLayout(false);
            this.tabPageConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textboxoutputassetname;
        private System.Windows.Forms.Label labelProcessorVersion;
        public System.Windows.Forms.Button buttonOk;
        public System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.Label labelAssetName;
        public System.Windows.Forms.TextBox textBoxJobName;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public System.Windows.Forms.Label labelProcessorName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel moreinfoprofilelink;
        private ButtonJobOptions buttonJobOptions;
        public System.Windows.Forms.Label labelPreview;
        private System.Windows.Forms.GroupBox groupBoxAggregateSettings;
        private System.Windows.Forms.NumericUpDown numericUpDownAggregateInterval;
        private System.Windows.Forms.NumericUpDown numericUpDownAggregateWindow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFaceDetection;
        private System.Windows.Forms.RadioButton radioButtonAggregateEmotionDetection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageConfig;
        private System.Windows.Forms.Label labelWarningJSON;
        private System.Windows.Forms.TextBox textBoxConfiguration;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonPerFaceEmotion;
    }
}