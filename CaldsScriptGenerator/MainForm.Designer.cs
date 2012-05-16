/*
 * Created by SharpDevelop.
 * User: GZNDQ9
 * Date: 3/2/2012
 * Time: 4:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CaldsScriptGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calValTextBox = new System.Windows.Forms.TextBox();
            this.calIndexTextBox = new System.Windows.Forms.TextBox();
            this.calNameTextBox = new System.Windows.Forms.TextBox();
            this.partNumSrcTextBox = new System.Windows.Forms.TextBox();
            this.partsListDestButton = new System.Windows.Forms.Button();
            this.partNumDestTextBox = new System.Windows.Forms.TextBox();
            this.partsListOpenButton = new System.Windows.Forms.Button();
            this.engScriptOpenButton = new System.Windows.Forms.Button();
            this.CalVScrollBar = new System.Windows.Forms.VScrollBar();
            this.textBox99 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.mkcopyCheckBox = new System.Windows.Forms.CheckBox();
            this.batchCaleditCheckBox = new System.Windows.Forms.CheckBox();
            this.checkincopyCheckBox = new System.Windows.Forms.CheckBox();
            this.logMessageTextBox = new System.Windows.Forms.TextBox();
            this.revNameTextBox = new System.Windows.Forms.TextBox();
            this.createClass2CheckBox = new System.Windows.Forms.CheckBox();
            this.calplotCheckBox = new System.Windows.Forms.CheckBox();
            this.prefixTextBox = new System.Windows.Forms.TextBox();
            this.extTextBox = new System.Windows.Forms.TextBox();
            this.activateCheckBox = new System.Windows.Forms.CheckBox();
            this.chcalcopyCheckBox = new System.Windows.Forms.CheckBox();
            this.goButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.outputFolderButton = new System.Windows.Forms.Button();
            this.outputFolderTextBox = new System.Windows.Forms.TextBox();
            this.outputFolderLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chcalcopySwPartTextBox = new System.Windows.Forms.TextBox();
            this.swPartLabel = new System.Windows.Forms.Label();
            this.logMessageLlabel = new System.Windows.Forms.Label();
            this.revNameLabel = new System.Windows.Forms.Label();
            this.prefixLabel = new System.Windows.Forms.Label();
            this.extLabel = new System.Windows.Forms.Label();
            this.intendedCheckBox = new System.Windows.Forms.CheckBox();
            this.copyBenchCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersGuideToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.waDefaultCheckBox = new System.Windows.Forms.CheckBox();
            this.waDefSwPartTextBox = new System.Windows.Forms.TextBox();
            this.waDefSwPartLabel = new System.Windows.Forms.Label();
            this.waDefLibTextBox = new System.Windows.Forms.TextBox();
            this.waDefLibLabel = new System.Windows.Forms.Label();
            this.mkHandleCheckBox = new System.Windows.Forms.CheckBox();
            this.mkHandleSwPartTextBox = new System.Windows.Forms.TextBox();
            this.mkHandleSwPartLabel = new System.Windows.Forms.Label();
            this.transferCheckBox = new System.Windows.Forms.CheckBox();
            this.bldImageCheckBox = new System.Windows.Forms.CheckBox();
            this.uploadCheckBox = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.devRelRadioButton = new System.Windows.Forms.RadioButton();
            this.ppvRelRadioButton = new System.Windows.Forms.RadioButton();
            this.valRelRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.calValTextBox, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.calIndexTextBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.calNameTextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.partNumSrcTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.partsListDestButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.partNumDestTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.partsListOpenButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.engScriptOpenButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CalVScrollBar, 5, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 540F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(686, 582);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(582, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "Value";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(524, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Offset";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // calValTextBox
            // 
            this.calValTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                                    | System.Windows.Forms.AnchorStyles.Left) 
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.calValTextBox.Location = new System.Drawing.Point(582, 45);
            this.calValTextBox.Multiline = true;
            this.calValTextBox.Name = "calValTextBox";
            this.calValTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.calValTextBox.Size = new System.Drawing.Size(81, 534);
            this.calValTextBox.TabIndex = 48;
            this.calValTextBox.WordWrap = false;
            // 
            // calIndexTextBox
            // 
            this.calIndexTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                                    | System.Windows.Forms.AnchorStyles.Left) 
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.calIndexTextBox.Location = new System.Drawing.Point(524, 45);
            this.calIndexTextBox.Multiline = true;
            this.calIndexTextBox.Name = "calIndexTextBox";
            this.calIndexTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.calIndexTextBox.Size = new System.Drawing.Size(52, 534);
            this.calIndexTextBox.TabIndex = 47;
            this.calIndexTextBox.WordWrap = false;
            // 
            // calNameTextBox
            // 
            this.calNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                                    | System.Windows.Forms.AnchorStyles.Left) 
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.calNameTextBox.Location = new System.Drawing.Point(215, 45);
            this.calNameTextBox.Multiline = true;
            this.calNameTextBox.Name = "calNameTextBox";
            this.calNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.calNameTextBox.Size = new System.Drawing.Size(303, 534);
            this.calNameTextBox.TabIndex = 47;
            this.calNameTextBox.WordWrap = false;
            // 
            // partNumSrcTextBox
            // 
            this.partNumSrcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                                    | System.Windows.Forms.AnchorStyles.Left) 
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.partNumSrcTextBox.Location = new System.Drawing.Point(3, 45);
            this.partNumSrcTextBox.Multiline = true;
            this.partNumSrcTextBox.Name = "partNumSrcTextBox";
            this.partNumSrcTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.partNumSrcTextBox.Size = new System.Drawing.Size(99, 534);
            this.partNumSrcTextBox.TabIndex = 47;
            this.partNumSrcTextBox.WordWrap = false;
            // 
            // partsListDestButton
            // 
            this.partsListDestButton.AutoSize = true;
            this.partsListDestButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.partsListDestButton.Location = new System.Drawing.Point(108, 3);
            this.partsListDestButton.Name = "partsListDestButton";
            this.partsListDestButton.Size = new System.Drawing.Size(55, 36);
            this.partsListDestButton.TabIndex = 43;
            this.partsListDestButton.Text = "Add Dst\r\nParts";
            this.partsListDestButton.UseVisualStyleBackColor = true;
            this.partsListDestButton.Click += new System.EventHandler(this.PartsListDestButtonClick);
            // 
            // partNumDestTextBox
            // 
            this.partNumDestTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                                    | System.Windows.Forms.AnchorStyles.Left) 
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.partNumDestTextBox.Location = new System.Drawing.Point(108, 45);
            this.partNumDestTextBox.Multiline = true;
            this.partNumDestTextBox.Name = "partNumDestTextBox";
            this.partNumDestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.partNumDestTextBox.Size = new System.Drawing.Size(101, 534);
            this.partNumDestTextBox.TabIndex = 46;
            this.partNumDestTextBox.WordWrap = false;
            // 
            // partsListOpenButton
            // 
            this.partsListOpenButton.AutoSize = true;
            this.partsListOpenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.partsListOpenButton.Location = new System.Drawing.Point(3, 3);
            this.partsListOpenButton.Name = "partsListOpenButton";
            this.partsListOpenButton.Size = new System.Drawing.Size(58, 36);
            this.partsListOpenButton.TabIndex = 4;
            this.partsListOpenButton.Text = "Add Src \r\nParts";
            this.partsListOpenButton.UseVisualStyleBackColor = true;
            this.partsListOpenButton.Click += new System.EventHandler(this.PartsListSrcButtonClick);
            // 
            // engScriptOpenButton
            // 
            this.engScriptOpenButton.AutoSize = true;
            this.engScriptOpenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.engScriptOpenButton.Location = new System.Drawing.Point(215, 3);
            this.engScriptOpenButton.Name = "engScriptOpenButton";
            this.engScriptOpenButton.Size = new System.Drawing.Size(59, 23);
            this.engScriptOpenButton.TabIndex = 2;
            this.engScriptOpenButton.Text = "Add Cals";
            this.engScriptOpenButton.UseVisualStyleBackColor = true;
            this.engScriptOpenButton.Click += new System.EventHandler(this.EngScriptOpenButtonClick);
            // 
            // CalVScrollBar
            // 
            this.CalVScrollBar.Location = new System.Drawing.Point(666, 42);
            this.CalVScrollBar.Name = "CalVScrollBar";
            this.CalVScrollBar.Size = new System.Drawing.Size(17, 517);
            this.CalVScrollBar.TabIndex = 49;
            this.CalVScrollBar.Visible = false;
            this.CalVScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.CalVScrollBarScroll);
            // 
            // textBox99
            // 
            this.textBox99.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                                    | System.Windows.Forms.AnchorStyles.Left) 
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox99.Location = new System.Drawing.Point(3, 33);
            this.textBox99.Multiline = true;
            this.textBox99.Name = "textBox99";
            this.textBox99.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox99.Size = new System.Drawing.Size(71, 274);
            this.textBox99.TabIndex = 13;
            this.textBox99.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PartNumbersTextBoxMouseDoubleClick);
            // 
            // mkcopyCheckBox
            // 
            this.mkcopyCheckBox.AutoSize = true;
            this.mkcopyCheckBox.Location = new System.Drawing.Point(718, 206);
            this.mkcopyCheckBox.Name = "mkcopyCheckBox";
            this.mkcopyCheckBox.Size = new System.Drawing.Size(80, 17);
            this.mkcopyCheckBox.TabIndex = 7;
            this.mkcopyCheckBox.Text = "Make Copy";
            this.mkcopyCheckBox.UseVisualStyleBackColor = true;
            // 
            // batchCaleditCheckBox
            // 
            this.batchCaleditCheckBox.AutoSize = true;
            this.batchCaleditCheckBox.Location = new System.Drawing.Point(718, 370);
            this.batchCaleditCheckBox.Name = "batchCaleditCheckBox";
            this.batchCaleditCheckBox.Size = new System.Drawing.Size(93, 17);
            this.batchCaleditCheckBox.TabIndex = 8;
            this.batchCaleditCheckBox.Text = "Batch Cal Edit";
            this.batchCaleditCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkincopyCheckBox
            // 
            this.checkincopyCheckBox.AutoSize = true;
            this.checkincopyCheckBox.Location = new System.Drawing.Point(718, 394);
            this.checkincopyCheckBox.Name = "checkincopyCheckBox";
            this.checkincopyCheckBox.Size = new System.Drawing.Size(92, 17);
            this.checkincopyCheckBox.TabIndex = 9;
            this.checkincopyCheckBox.Text = "Checkin Copy";
            this.checkincopyCheckBox.UseVisualStyleBackColor = true;
            // 
            // logMessageTextBox
            // 
            this.logMessageTextBox.Location = new System.Drawing.Point(736, 491);
            this.logMessageTextBox.Name = "logMessageTextBox";
            this.logMessageTextBox.Size = new System.Drawing.Size(100, 20);
            this.logMessageTextBox.TabIndex = 16;
            // 
            // revNameTextBox
            // 
            this.revNameTextBox.Location = new System.Drawing.Point(736, 517);
            this.revNameTextBox.Name = "revNameTextBox";
            this.revNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.revNameTextBox.TabIndex = 17;
            // 
            // createClass2CheckBox
            // 
            this.createClass2CheckBox.AutoSize = true;
            this.createClass2CheckBox.Location = new System.Drawing.Point(718, 543);
            this.createClass2CheckBox.Name = "createClass2CheckBox";
            this.createClass2CheckBox.Size = new System.Drawing.Size(94, 17);
            this.createClass2CheckBox.TabIndex = 18;
            this.createClass2CheckBox.Text = "Create Class 2";
            this.createClass2CheckBox.UseVisualStyleBackColor = true;
            // 
            // calplotCheckBox
            // 
            this.calplotCheckBox.AutoSize = true;
            this.calplotCheckBox.Location = new System.Drawing.Point(718, 566);
            this.calplotCheckBox.Name = "calplotCheckBox";
            this.calplotCheckBox.Size = new System.Drawing.Size(58, 17);
            this.calplotCheckBox.TabIndex = 19;
            this.calplotCheckBox.Text = "Calplot";
            this.calplotCheckBox.UseVisualStyleBackColor = true;
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Location = new System.Drawing.Point(736, 589);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(100, 20);
            this.prefixTextBox.TabIndex = 20;
            this.prefixTextBox.Text = "cp_";
            // 
            // extTextBox
            // 
            this.extTextBox.Location = new System.Drawing.Point(736, 615);
            this.extTextBox.Name = "extTextBox";
            this.extTextBox.Size = new System.Drawing.Size(100, 20);
            this.extTextBox.TabIndex = 21;
            this.extTextBox.Text = "txt";
            // 
            // activateCheckBox
            // 
            this.activateCheckBox.AutoSize = true;
            this.activateCheckBox.Location = new System.Drawing.Point(718, 160);
            this.activateCheckBox.Name = "activateCheckBox";
            this.activateCheckBox.Size = new System.Drawing.Size(87, 17);
            this.activateCheckBox.TabIndex = 23;
            this.activateCheckBox.Text = "Activate Part";
            this.activateCheckBox.UseVisualStyleBackColor = true;
            // 
            // chcalcopyCheckBox
            // 
            this.chcalcopyCheckBox.AutoSize = true;
            this.chcalcopyCheckBox.Location = new System.Drawing.Point(718, 229);
            this.chcalcopyCheckBox.Name = "chcalcopyCheckBox";
            this.chcalcopyCheckBox.Size = new System.Drawing.Size(108, 17);
            this.chcalcopyCheckBox.TabIndex = 22;
            this.chcalcopyCheckBox.Text = "Change Cal Copy";
            this.chcalcopyCheckBox.UseVisualStyleBackColor = true;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(881, 640);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.GoButtonClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.outputFolderButton, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.outputFolderTextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.outputFolderLabel, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 36);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(689, 29);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // outputFolderButton
            // 
            this.outputFolderButton.AutoSize = true;
            this.outputFolderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.outputFolderButton.Location = new System.Drawing.Point(660, 3);
            this.outputFolderButton.Name = "outputFolderButton";
            this.outputFolderButton.Size = new System.Drawing.Size(26, 23);
            this.outputFolderButton.TabIndex = 5;
            this.outputFolderButton.Text = "...";
            this.outputFolderButton.UseVisualStyleBackColor = true;
            this.outputFolderButton.Click += new System.EventHandler(this.OutputFolderButtonClick);
            // 
            // outputFolderTextBox
            // 
            this.outputFolderTextBox.Location = new System.Drawing.Point(80, 3);
            this.outputFolderTextBox.Name = "outputFolderTextBox";
            this.outputFolderTextBox.Size = new System.Drawing.Size(574, 20);
            this.outputFolderTextBox.TabIndex = 11;
            // 
            // outputFolderLabel
            // 
            this.outputFolderLabel.Location = new System.Drawing.Point(3, 0);
            this.outputFolderLabel.Name = "outputFolderLabel";
            this.outputFolderLabel.Size = new System.Drawing.Size(71, 21);
            this.outputFolderLabel.TabIndex = 4;
            this.outputFolderLabel.Text = "Output Folder";
            this.outputFolderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chcalcopySwPartTextBox
            // 
            this.chcalcopySwPartTextBox.Location = new System.Drawing.Point(736, 252);
            this.chcalcopySwPartTextBox.Name = "chcalcopySwPartTextBox";
            this.chcalcopySwPartTextBox.Size = new System.Drawing.Size(100, 20);
            this.chcalcopySwPartTextBox.TabIndex = 24;
            // 
            // swPartLabel
            // 
            this.swPartLabel.Location = new System.Drawing.Point(842, 251);
            this.swPartLabel.Name = "swPartLabel";
            this.swPartLabel.Size = new System.Drawing.Size(52, 21);
            this.swPartLabel.TabIndex = 25;
            this.swPartLabel.Text = "SW Part";
            this.swPartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logMessageLlabel
            // 
            this.logMessageLlabel.Location = new System.Drawing.Point(842, 489);
            this.logMessageLlabel.Name = "logMessageLlabel";
            this.logMessageLlabel.Size = new System.Drawing.Size(74, 23);
            this.logMessageLlabel.TabIndex = 26;
            this.logMessageLlabel.Text = "Log Message";
            this.logMessageLlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // revNameLabel
            // 
            this.revNameLabel.Location = new System.Drawing.Point(842, 515);
            this.revNameLabel.Name = "revNameLabel";
            this.revNameLabel.Size = new System.Drawing.Size(74, 23);
            this.revNameLabel.TabIndex = 27;
            this.revNameLabel.Text = "Rev Name";
            this.revNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prefixLabel
            // 
            this.prefixLabel.Location = new System.Drawing.Point(842, 587);
            this.prefixLabel.Name = "prefixLabel";
            this.prefixLabel.Size = new System.Drawing.Size(74, 23);
            this.prefixLabel.TabIndex = 28;
            this.prefixLabel.Text = "Prefix";
            this.prefixLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // extLabel
            // 
            this.extLabel.Location = new System.Drawing.Point(842, 613);
            this.extLabel.Name = "extLabel";
            this.extLabel.Size = new System.Drawing.Size(74, 23);
            this.extLabel.TabIndex = 29;
            this.extLabel.Text = "Extension";
            this.extLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // intendedCheckBox
            // 
            this.intendedCheckBox.AutoSize = true;
            this.intendedCheckBox.Location = new System.Drawing.Point(736, 183);
            this.intendedCheckBox.Name = "intendedCheckBox";
            this.intendedCheckBox.Size = new System.Drawing.Size(220, 17);
            this.intendedCheckBox.TabIndex = 30;
            this.intendedCheckBox.Text = "Intended For Vehicle Assembly Plant Use";
            this.intendedCheckBox.UseVisualStyleBackColor = true;
            // 
            // copyBenchCheckBox
            // 
            this.copyBenchCheckBox.AutoSize = true;
            this.copyBenchCheckBox.Location = new System.Drawing.Point(718, 278);
            this.copyBenchCheckBox.Name = "copyBenchCheckBox";
            this.copyBenchCheckBox.Size = new System.Drawing.Size(119, 17);
            this.copyBenchCheckBox.TabIndex = 32;
            this.copyBenchCheckBox.Text = "Copy Bench Values";
            this.copyBenchCheckBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.usersGuideToolStripMenuItem1,
                                    this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // usersGuideToolStripMenuItem1
            // 
            this.usersGuideToolStripMenuItem1.Name = "usersGuideToolStripMenuItem1";
            this.usersGuideToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.usersGuideToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.usersGuideToolStripMenuItem1.Text = "User\'s Guide";
            this.usersGuideToolStripMenuItem1.Click += new System.EventHandler(this.UsersGuideToolStripMenuItem1Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 671);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(992, 22);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel1.Text = "  ";
            // 
            // waDefaultCheckBox
            // 
            this.waDefaultCheckBox.AutoSize = true;
            this.waDefaultCheckBox.Location = new System.Drawing.Point(718, 36);
            this.waDefaultCheckBox.Name = "waDefaultCheckBox";
            this.waDefaultCheckBox.Size = new System.Drawing.Size(114, 17);
            this.waDefaultCheckBox.TabIndex = 35;
            this.waDefaultCheckBox.Text = "Work Area Default";
            this.waDefaultCheckBox.UseVisualStyleBackColor = true;
            // 
            // waDefSwPartTextBox
            // 
            this.waDefSwPartTextBox.Location = new System.Drawing.Point(736, 59);
            this.waDefSwPartTextBox.Name = "waDefSwPartTextBox";
            this.waDefSwPartTextBox.Size = new System.Drawing.Size(100, 20);
            this.waDefSwPartTextBox.TabIndex = 36;
            // 
            // waDefSwPartLabel
            // 
            this.waDefSwPartLabel.Location = new System.Drawing.Point(842, 58);
            this.waDefSwPartLabel.Name = "waDefSwPartLabel";
            this.waDefSwPartLabel.Size = new System.Drawing.Size(52, 21);
            this.waDefSwPartLabel.TabIndex = 37;
            this.waDefSwPartLabel.Text = "SW Part";
            this.waDefSwPartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // waDefLibTextBox
            // 
            this.waDefLibTextBox.Location = new System.Drawing.Point(736, 85);
            this.waDefLibTextBox.Name = "waDefLibTextBox";
            this.waDefLibTextBox.Size = new System.Drawing.Size(100, 20);
            this.waDefLibTextBox.TabIndex = 38;
            // 
            // waDefLibLabel
            // 
            this.waDefLibLabel.Location = new System.Drawing.Point(842, 84);
            this.waDefLibLabel.Name = "waDefLibLabel";
            this.waDefLibLabel.Size = new System.Drawing.Size(52, 21);
            this.waDefLibLabel.TabIndex = 39;
            this.waDefLibLabel.Text = "Library";
            this.waDefLibLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mkHandleCheckBox
            // 
            this.mkHandleCheckBox.AutoSize = true;
            this.mkHandleCheckBox.Location = new System.Drawing.Point(718, 111);
            this.mkHandleCheckBox.Name = "mkHandleCheckBox";
            this.mkHandleCheckBox.Size = new System.Drawing.Size(90, 17);
            this.mkHandleCheckBox.TabIndex = 40;
            this.mkHandleCheckBox.Text = "Make Handle";
            this.mkHandleCheckBox.UseVisualStyleBackColor = true;
            // 
            // mkHandleSwPartTextBox
            // 
            this.mkHandleSwPartTextBox.Location = new System.Drawing.Point(736, 134);
            this.mkHandleSwPartTextBox.Name = "mkHandleSwPartTextBox";
            this.mkHandleSwPartTextBox.Size = new System.Drawing.Size(100, 20);
            this.mkHandleSwPartTextBox.TabIndex = 41;
            // 
            // mkHandleSwPartLabel
            // 
            this.mkHandleSwPartLabel.Location = new System.Drawing.Point(842, 133);
            this.mkHandleSwPartLabel.Name = "mkHandleSwPartLabel";
            this.mkHandleSwPartLabel.Size = new System.Drawing.Size(52, 21);
            this.mkHandleSwPartLabel.TabIndex = 42;
            this.mkHandleSwPartLabel.Text = "SW Part";
            this.mkHandleSwPartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transferCheckBox
            // 
            this.transferCheckBox.AutoSize = true;
            this.transferCheckBox.Location = new System.Drawing.Point(718, 301);
            this.transferCheckBox.Name = "transferCheckBox";
            this.transferCheckBox.Size = new System.Drawing.Size(65, 17);
            this.transferCheckBox.TabIndex = 43;
            this.transferCheckBox.Text = "Transfer";
            this.transferCheckBox.UseVisualStyleBackColor = true;
            // 
            // bldImageCheckBox
            // 
            this.bldImageCheckBox.AutoSize = true;
            this.bldImageCheckBox.Location = new System.Drawing.Point(718, 324);
            this.bldImageCheckBox.Name = "bldImageCheckBox";
            this.bldImageCheckBox.Size = new System.Drawing.Size(81, 17);
            this.bldImageCheckBox.TabIndex = 44;
            this.bldImageCheckBox.Text = "Build Image";
            this.bldImageCheckBox.UseVisualStyleBackColor = true;
            // 
            // uploadCheckBox
            // 
            this.uploadCheckBox.AutoSize = true;
            this.uploadCheckBox.Location = new System.Drawing.Point(718, 347);
            this.uploadCheckBox.Name = "uploadCheckBox";
            this.uploadCheckBox.Size = new System.Drawing.Size(60, 17);
            this.uploadCheckBox.TabIndex = 45;
            this.uploadCheckBox.Text = "Upload";
            this.uploadCheckBox.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Part files|*.txt";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Eng script files|*.txt;*.cds";
            // 
            // devRelRadioButton
            // 
            this.devRelRadioButton.Checked = true;
            this.devRelRadioButton.Location = new System.Drawing.Point(736, 417);
            this.devRelRadioButton.Name = "devRelRadioButton";
            this.devRelRadioButton.Size = new System.Drawing.Size(130, 24);
            this.devRelRadioButton.TabIndex = 46;
            this.devRelRadioButton.TabStop = true;
            this.devRelRadioButton.Text = "Development Release";
            this.devRelRadioButton.UseVisualStyleBackColor = true;
            // 
            // ppvRelRadioButton
            // 
            this.ppvRelRadioButton.Location = new System.Drawing.Point(736, 438);
            this.ppvRelRadioButton.Name = "ppvRelRadioButton";
            this.ppvRelRadioButton.Size = new System.Drawing.Size(104, 24);
            this.ppvRelRadioButton.TabIndex = 47;
            this.ppvRelRadioButton.Text = "PPV Release";
            this.ppvRelRadioButton.UseVisualStyleBackColor = true;
            // 
            // valRelRadioButton
            // 
            this.valRelRadioButton.Location = new System.Drawing.Point(736, 461);
            this.valRelRadioButton.Name = "valRelRadioButton";
            this.valRelRadioButton.Size = new System.Drawing.Size(115, 24);
            this.valRelRadioButton.TabIndex = 48;
            this.valRelRadioButton.Text = "Validation Release";
            this.valRelRadioButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(992, 693);
            this.Controls.Add(this.valRelRadioButton);
            this.Controls.Add(this.ppvRelRadioButton);
            this.Controls.Add(this.devRelRadioButton);
            this.Controls.Add(this.uploadCheckBox);
            this.Controls.Add(this.bldImageCheckBox);
            this.Controls.Add(this.transferCheckBox);
            this.Controls.Add(this.mkHandleSwPartLabel);
            this.Controls.Add(this.mkHandleSwPartTextBox);
            this.Controls.Add(this.mkHandleCheckBox);
            this.Controls.Add(this.waDefLibLabel);
            this.Controls.Add(this.waDefLibTextBox);
            this.Controls.Add(this.waDefSwPartLabel);
            this.Controls.Add(this.waDefSwPartTextBox);
            this.Controls.Add(this.waDefaultCheckBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.copyBenchCheckBox);
            this.Controls.Add(this.intendedCheckBox);
            this.Controls.Add(this.extLabel);
            this.Controls.Add(this.prefixLabel);
            this.Controls.Add(this.revNameLabel);
            this.Controls.Add(this.logMessageLlabel);
            this.Controls.Add(this.extTextBox);
            this.Controls.Add(this.prefixTextBox);
            this.Controls.Add(this.calplotCheckBox);
            this.Controls.Add(this.createClass2CheckBox);
            this.Controls.Add(this.swPartLabel);
            this.Controls.Add(this.chcalcopySwPartTextBox);
            this.Controls.Add(this.mkcopyCheckBox);
            this.Controls.Add(this.revNameTextBox);
            this.Controls.Add(this.logMessageTextBox);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.checkincopyCheckBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.batchCaleditCheckBox);
            this.Controls.Add(this.activateCheckBox);
            this.Controls.Add(this.chcalcopyCheckBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Calds Process Script Generator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.RadioButton valRelRadioButton;
        private System.Windows.Forms.RadioButton ppvRelRadioButton;
        private System.Windows.Forms.RadioButton devRelRadioButton;
        private System.Windows.Forms.VScrollBar CalVScrollBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox calIndexTextBox;
        private System.Windows.Forms.TextBox calValTextBox;
        private System.Windows.Forms.TextBox calNameTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox partNumSrcTextBox;
        private System.Windows.Forms.TextBox partNumDestTextBox;
        private System.Windows.Forms.CheckBox uploadCheckBox;
        private System.Windows.Forms.CheckBox bldImageCheckBox;
        private System.Windows.Forms.CheckBox transferCheckBox;
        private System.Windows.Forms.Button partsListDestButton;
        private System.Windows.Forms.Label mkHandleSwPartLabel;
        private System.Windows.Forms.TextBox mkHandleSwPartTextBox;
        private System.Windows.Forms.CheckBox mkHandleCheckBox;
        private System.Windows.Forms.Label waDefLibLabel;
        private System.Windows.Forms.TextBox waDefLibTextBox;
        private System.Windows.Forms.Label waDefSwPartLabel;
        private System.Windows.Forms.TextBox waDefSwPartTextBox;
        private System.Windows.Forms.CheckBox waDefaultCheckBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersGuideToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.CheckBox copyBenchCheckBox;
        private System.Windows.Forms.CheckBox intendedCheckBox;
        private System.Windows.Forms.Label extLabel;
        private System.Windows.Forms.Label prefixLabel;
        private System.Windows.Forms.TextBox prefixTextBox;
        private System.Windows.Forms.TextBox extTextBox;
        private System.Windows.Forms.CheckBox chcalcopyCheckBox;
        private System.Windows.Forms.Label revNameLabel;
        private System.Windows.Forms.Label logMessageLlabel;
        private System.Windows.Forms.TextBox revNameTextBox;
        private System.Windows.Forms.CheckBox createClass2CheckBox;
        private System.Windows.Forms.CheckBox checkincopyCheckBox;
        private System.Windows.Forms.Label swPartLabel;
        private System.Windows.Forms.TextBox chcalcopySwPartTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox outputFolderTextBox;
        private System.Windows.Forms.Button outputFolderButton;
        private System.Windows.Forms.Label outputFolderLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.CheckBox activateCheckBox;
        private System.Windows.Forms.CheckBox calplotCheckBox;
        private System.Windows.Forms.TextBox logMessageTextBox;
        private System.Windows.Forms.CheckBox batchCaleditCheckBox;
        private System.Windows.Forms.CheckBox mkcopyCheckBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        //private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox99;
        //private System.Windows.Forms.TextBox textBox4;
        //private System.Windows.Forms.TextBox textBox3;
        //private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button partsListOpenButton;
        private System.Windows.Forms.Button engScriptOpenButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
