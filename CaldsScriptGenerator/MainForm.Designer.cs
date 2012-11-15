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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.calValTextBox = new System.Windows.Forms.TextBox();
            this.calOffsetTextBox = new System.Windows.Forms.TextBox();
            this.calNameTextBox = new System.Windows.Forms.TextBox();
            this.partNumSrcTextBox = new System.Windows.Forms.TextBox();
            this.partNumDestTextBox = new System.Windows.Forms.TextBox();
            this.offsetGroupBox = new System.Windows.Forms.GroupBox();
            this.autoFillCheckBox = new System.Windows.Forms.CheckBox();
            this.valueGroupBox = new System.Windows.Forms.GroupBox();
            this.engRadioButton = new System.Windows.Forms.RadioButton();
            this.hexRadioButton = new System.Windows.Forms.RadioButton();
            this.calGroupBox = new System.Windows.Forms.GroupBox();
            this.singleRadioButton = new System.Windows.Forms.RadioButton();
            this.normalRadioButton = new System.Windows.Forms.RadioButton();
            this.clearCalsButton = new System.Windows.Forms.Button();
            this.engScriptOpenButton = new System.Windows.Forms.Button();
            this.srcPartsGroupBox = new System.Windows.Forms.GroupBox();
            this.srcClearButton = new System.Windows.Forms.Button();
            this.partsListOpenButton = new System.Windows.Forms.Button();
            this.dstGroupBox = new System.Windows.Forms.GroupBox();
            this.clrDstButton = new System.Windows.Forms.Button();
            this.partsListDestButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.mkcopyCheckBox = new System.Windows.Forms.CheckBox();
            this.batchCaleditCheckBox = new System.Windows.Forms.CheckBox();
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
            this.calSupportToolsSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.unixFormatCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.revokeCheckBox = new System.Windows.Forms.CheckBox();
            this.checkinCopyRadioButton = new System.Windows.Forms.RadioButton();
            this.updateStatusRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.offsetGroupBox.SuspendLayout();
            this.valueGroupBox.SuspendLayout();
            this.calGroupBox.SuspendLayout();
            this.srcPartsGroupBox.SuspendLayout();
            this.dstGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.calValTextBox, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.calOffsetTextBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.calNameTextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.partNumSrcTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.partNumDestTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.offsetGroupBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.valueGroupBox, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.calGroupBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.srcPartsGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dstGroupBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 640F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(803, 711);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // calValTextBox
            // 
            this.calValTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                                    | System.Windows.Forms.AnchorStyles.Left) 
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.calValTextBox.Location = new System.Drawing.Point(718, 74);
            this.calValTextBox.MaxLength = 2147483647;
            this.calValTextBox.Multiline = true;
            this.calValTextBox.Name = "calValTextBox";
            this.calValTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.calValTextBox.Size = new System.Drawing.Size(82, 634);
            this.calValTextBox.TabIndex = 9;
            this.calValTextBox.WordWrap = false;
            // 
            // calOffsetTextBox
            // 
            this.calOffsetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                                    | System.Windows.Forms.AnchorStyles.Left) 
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.calOffsetTextBox.Location = new System.Drawing.Point(635, 74);
            this.calOffsetTextBox.MaxLength = 2147483647;
            this.calOffsetTextBox.Multiline = true;
            this.calOffsetTextBox.Name = "calOffsetTextBox";
            this.calOffsetTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.calOffsetTextBox.Size = new System.Drawing.Size(77, 634);
            this.calOffsetTextBox.TabIndex = 7;
            this.calOffsetTextBox.WordWrap = false;
            this.calOffsetTextBox.DoubleClick += new System.EventHandler(this.CalOffsetTextBoxDoubleClick);
            // 
            // calNameTextBox
            // 
            this.calNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                                    | System.Windows.Forms.AnchorStyles.Left) 
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.calNameTextBox.Location = new System.Drawing.Point(227, 74);
            this.calNameTextBox.MaxLength = 2147483647;
            this.calNameTextBox.Multiline = true;
            this.calNameTextBox.Name = "calNameTextBox";
            this.calNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.calNameTextBox.Size = new System.Drawing.Size(402, 634);
            this.calNameTextBox.TabIndex = 5;
            this.calNameTextBox.WordWrap = false;
            this.calNameTextBox.TextChanged += new System.EventHandler(this.CalNameTextBoxTextChanged);
            // 
            // partNumSrcTextBox
            // 
            this.partNumSrcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                                    | System.Windows.Forms.AnchorStyles.Left) 
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.partNumSrcTextBox.Location = new System.Drawing.Point(3, 74);
            this.partNumSrcTextBox.Multiline = true;
            this.partNumSrcTextBox.Name = "partNumSrcTextBox";
            this.partNumSrcTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.partNumSrcTextBox.Size = new System.Drawing.Size(105, 634);
            this.partNumSrcTextBox.TabIndex = 1;
            this.partNumSrcTextBox.WordWrap = false;
            // 
            // partNumDestTextBox
            // 
            this.partNumDestTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                                    | System.Windows.Forms.AnchorStyles.Left) 
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.partNumDestTextBox.Location = new System.Drawing.Point(114, 74);
            this.partNumDestTextBox.Multiline = true;
            this.partNumDestTextBox.Name = "partNumDestTextBox";
            this.partNumDestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.partNumDestTextBox.Size = new System.Drawing.Size(107, 634);
            this.partNumDestTextBox.TabIndex = 3;
            this.partNumDestTextBox.WordWrap = false;
            // 
            // offsetGroupBox
            // 
            this.offsetGroupBox.Controls.Add(this.autoFillCheckBox);
            this.offsetGroupBox.Location = new System.Drawing.Point(635, 3);
            this.offsetGroupBox.Name = "offsetGroupBox";
            this.offsetGroupBox.Size = new System.Drawing.Size(77, 65);
            this.offsetGroupBox.TabIndex = 6;
            this.offsetGroupBox.TabStop = false;
            this.offsetGroupBox.Text = "Offset";
            // 
            // autoFillCheckBox
            // 
            this.autoFillCheckBox.Location = new System.Drawing.Point(7, 20);
            this.autoFillCheckBox.Name = "autoFillCheckBox";
            this.autoFillCheckBox.Size = new System.Drawing.Size(63, 24);
            this.autoFillCheckBox.TabIndex = 0;
            this.autoFillCheckBox.Text = "Auto Fill";
            this.autoFillCheckBox.UseVisualStyleBackColor = true;
            this.autoFillCheckBox.CheckedChanged += new System.EventHandler(this.AutoFillCheckBoxCheckedChanged);
            // 
            // valueGroupBox
            // 
            this.valueGroupBox.Controls.Add(this.engRadioButton);
            this.valueGroupBox.Controls.Add(this.hexRadioButton);
            this.valueGroupBox.Location = new System.Drawing.Point(718, 3);
            this.valueGroupBox.Name = "valueGroupBox";
            this.valueGroupBox.Size = new System.Drawing.Size(82, 65);
            this.valueGroupBox.TabIndex = 8;
            this.valueGroupBox.TabStop = false;
            this.valueGroupBox.Text = "Value";
            // 
            // engRadioButton
            // 
            this.engRadioButton.Enabled = false;
            this.engRadioButton.Location = new System.Drawing.Point(6, 37);
            this.engRadioButton.Name = "engRadioButton";
            this.engRadioButton.Size = new System.Drawing.Size(59, 17);
            this.engRadioButton.TabIndex = 1;
            this.engRadioButton.Text = "Eng";
            this.engRadioButton.UseVisualStyleBackColor = true;
            // 
            // hexRadioButton
            // 
            this.hexRadioButton.Checked = true;
            this.hexRadioButton.Location = new System.Drawing.Point(6, 14);
            this.hexRadioButton.Name = "hexRadioButton";
            this.hexRadioButton.Size = new System.Drawing.Size(59, 17);
            this.hexRadioButton.TabIndex = 0;
            this.hexRadioButton.TabStop = true;
            this.hexRadioButton.Text = "Hex";
            this.hexRadioButton.UseVisualStyleBackColor = true;
            // 
            // calGroupBox
            // 
            this.calGroupBox.Controls.Add(this.singleRadioButton);
            this.calGroupBox.Controls.Add(this.normalRadioButton);
            this.calGroupBox.Controls.Add(this.clearCalsButton);
            this.calGroupBox.Controls.Add(this.engScriptOpenButton);
            this.calGroupBox.Location = new System.Drawing.Point(227, 3);
            this.calGroupBox.Name = "calGroupBox";
            this.calGroupBox.Size = new System.Drawing.Size(402, 65);
            this.calGroupBox.TabIndex = 4;
            this.calGroupBox.TabStop = false;
            this.calGroupBox.Text = "Calibrations";
            // 
            // singleRadioButton
            // 
            this.singleRadioButton.Enabled = false;
            this.singleRadioButton.Location = new System.Drawing.Point(184, 16);
            this.singleRadioButton.Name = "singleRadioButton";
            this.singleRadioButton.Size = new System.Drawing.Size(73, 18);
            this.singleRadioButton.TabIndex = 3;
            this.singleRadioButton.Text = "Single";
            this.singleRadioButton.UseVisualStyleBackColor = true;
            // 
            // normalRadioButton
            // 
            this.normalRadioButton.Checked = true;
            this.normalRadioButton.Location = new System.Drawing.Point(117, 16);
            this.normalRadioButton.Name = "normalRadioButton";
            this.normalRadioButton.Size = new System.Drawing.Size(73, 18);
            this.normalRadioButton.TabIndex = 2;
            this.normalRadioButton.TabStop = true;
            this.normalRadioButton.Text = "Normal";
            this.normalRadioButton.UseVisualStyleBackColor = true;
            // 
            // clearCalsButton
            // 
            this.clearCalsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearCalsButton.Location = new System.Drawing.Point(52, 14);
            this.clearCalsButton.Name = "clearCalsButton";
            this.clearCalsButton.Size = new System.Drawing.Size(40, 20);
            this.clearCalsButton.TabIndex = 1;
            this.clearCalsButton.Text = "Clear";
            this.clearCalsButton.UseVisualStyleBackColor = true;
            this.clearCalsButton.Click += new System.EventHandler(this.ClearCalsButtonClick);
            // 
            // engScriptOpenButton
            // 
            this.engScriptOpenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.engScriptOpenButton.Location = new System.Drawing.Point(6, 14);
            this.engScriptOpenButton.Name = "engScriptOpenButton";
            this.engScriptOpenButton.Size = new System.Drawing.Size(40, 20);
            this.engScriptOpenButton.TabIndex = 0;
            this.engScriptOpenButton.Text = "Add";
            this.engScriptOpenButton.UseVisualStyleBackColor = true;
            this.engScriptOpenButton.Click += new System.EventHandler(this.EngScriptOpenButtonClick);
            // 
            // srcPartsGroupBox
            // 
            this.srcPartsGroupBox.Controls.Add(this.srcClearButton);
            this.srcPartsGroupBox.Controls.Add(this.partsListOpenButton);
            this.srcPartsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.srcPartsGroupBox.Name = "srcPartsGroupBox";
            this.srcPartsGroupBox.Size = new System.Drawing.Size(105, 65);
            this.srcPartsGroupBox.TabIndex = 0;
            this.srcPartsGroupBox.TabStop = false;
            this.srcPartsGroupBox.Text = "Source Parts";
            // 
            // srcClearButton
            // 
            this.srcClearButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.srcClearButton.Location = new System.Drawing.Point(52, 14);
            this.srcClearButton.Name = "srcClearButton";
            this.srcClearButton.Size = new System.Drawing.Size(40, 20);
            this.srcClearButton.TabIndex = 1;
            this.srcClearButton.Text = "Clear";
            this.srcClearButton.UseVisualStyleBackColor = true;
            this.srcClearButton.Click += new System.EventHandler(this.SrcClearButtonClick);
            // 
            // partsListOpenButton
            // 
            this.partsListOpenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.partsListOpenButton.Location = new System.Drawing.Point(6, 14);
            this.partsListOpenButton.Name = "partsListOpenButton";
            this.partsListOpenButton.Size = new System.Drawing.Size(40, 20);
            this.partsListOpenButton.TabIndex = 0;
            this.partsListOpenButton.Text = "Add";
            this.partsListOpenButton.UseVisualStyleBackColor = true;
            this.partsListOpenButton.Click += new System.EventHandler(this.PartsListSrcButtonClick);
            // 
            // dstGroupBox
            // 
            this.dstGroupBox.Controls.Add(this.clrDstButton);
            this.dstGroupBox.Controls.Add(this.partsListDestButton);
            this.dstGroupBox.Location = new System.Drawing.Point(114, 3);
            this.dstGroupBox.Name = "dstGroupBox";
            this.dstGroupBox.Size = new System.Drawing.Size(107, 65);
            this.dstGroupBox.TabIndex = 2;
            this.dstGroupBox.TabStop = false;
            this.dstGroupBox.Text = "Destination Parts";
            // 
            // clrDstButton
            // 
            this.clrDstButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clrDstButton.Location = new System.Drawing.Point(52, 14);
            this.clrDstButton.Name = "clrDstButton";
            this.clrDstButton.Size = new System.Drawing.Size(40, 20);
            this.clrDstButton.TabIndex = 1;
            this.clrDstButton.Text = "Clear";
            this.clrDstButton.UseVisualStyleBackColor = true;
            this.clrDstButton.Click += new System.EventHandler(this.ClrDstButtonClick);
            // 
            // partsListDestButton
            // 
            this.partsListDestButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.partsListDestButton.Location = new System.Drawing.Point(6, 14);
            this.partsListDestButton.Name = "partsListDestButton";
            this.partsListDestButton.Size = new System.Drawing.Size(40, 20);
            this.partsListDestButton.TabIndex = 0;
            this.partsListDestButton.Text = "Add";
            this.partsListDestButton.UseVisualStyleBackColor = true;
            this.partsListDestButton.Click += new System.EventHandler(this.PartsListDestButtonClick);
            // 
            // mkcopyCheckBox
            // 
            this.mkcopyCheckBox.AutoSize = true;
            this.mkcopyCheckBox.Location = new System.Drawing.Point(827, 207);
            this.mkcopyCheckBox.Name = "mkcopyCheckBox";
            this.mkcopyCheckBox.Size = new System.Drawing.Size(80, 17);
            this.mkcopyCheckBox.TabIndex = 13;
            this.mkcopyCheckBox.Text = "Make Copy";
            this.mkcopyCheckBox.UseVisualStyleBackColor = true;
            // 
            // batchCaleditCheckBox
            // 
            this.batchCaleditCheckBox.AutoSize = true;
            this.batchCaleditCheckBox.Location = new System.Drawing.Point(827, 371);
            this.batchCaleditCheckBox.Name = "batchCaleditCheckBox";
            this.batchCaleditCheckBox.Size = new System.Drawing.Size(93, 17);
            this.batchCaleditCheckBox.TabIndex = 21;
            this.batchCaleditCheckBox.Text = "Batch Cal Edit";
            this.batchCaleditCheckBox.UseVisualStyleBackColor = true;
            this.batchCaleditCheckBox.CheckedChanged += new System.EventHandler(this.BatchCaleditCheckBoxCheckedChanged);
            // 
            // logMessageTextBox
            // 
            this.logMessageTextBox.Enabled = false;
            this.logMessageTextBox.Location = new System.Drawing.Point(18, 188);
            this.logMessageTextBox.Name = "logMessageTextBox";
            this.logMessageTextBox.Size = new System.Drawing.Size(100, 20);
            this.logMessageTextBox.TabIndex = 2;
            // 
            // revNameTextBox
            // 
            this.revNameTextBox.Enabled = false;
            this.revNameTextBox.Location = new System.Drawing.Point(18, 214);
            this.revNameTextBox.Name = "revNameTextBox";
            this.revNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.revNameTextBox.TabIndex = 4;
            // 
            // createClass2CheckBox
            // 
            this.createClass2CheckBox.AutoSize = true;
            this.createClass2CheckBox.Location = new System.Drawing.Point(827, 642);
            this.createClass2CheckBox.Name = "createClass2CheckBox";
            this.createClass2CheckBox.Size = new System.Drawing.Size(94, 17);
            this.createClass2CheckBox.TabIndex = 23;
            this.createClass2CheckBox.Text = "Create Class 2";
            this.createClass2CheckBox.UseVisualStyleBackColor = true;
            // 
            // calplotCheckBox
            // 
            this.calplotCheckBox.AutoSize = true;
            this.calplotCheckBox.Location = new System.Drawing.Point(827, 665);
            this.calplotCheckBox.Name = "calplotCheckBox";
            this.calplotCheckBox.Size = new System.Drawing.Size(58, 17);
            this.calplotCheckBox.TabIndex = 24;
            this.calplotCheckBox.Text = "Calplot";
            this.calplotCheckBox.UseVisualStyleBackColor = true;
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Location = new System.Drawing.Point(845, 688);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(100, 20);
            this.prefixTextBox.TabIndex = 25;
            this.prefixTextBox.Text = "cp_";
            // 
            // extTextBox
            // 
            this.extTextBox.Location = new System.Drawing.Point(845, 714);
            this.extTextBox.Name = "extTextBox";
            this.extTextBox.Size = new System.Drawing.Size(100, 20);
            this.extTextBox.TabIndex = 27;
            this.extTextBox.Text = "txt";
            // 
            // activateCheckBox
            // 
            this.activateCheckBox.AutoSize = true;
            this.activateCheckBox.Location = new System.Drawing.Point(827, 161);
            this.activateCheckBox.Name = "activateCheckBox";
            this.activateCheckBox.Size = new System.Drawing.Size(87, 17);
            this.activateCheckBox.TabIndex = 11;
            this.activateCheckBox.Text = "Activate Part";
            this.activateCheckBox.UseVisualStyleBackColor = true;
            // 
            // chcalcopyCheckBox
            // 
            this.chcalcopyCheckBox.AutoSize = true;
            this.chcalcopyCheckBox.Location = new System.Drawing.Point(827, 230);
            this.chcalcopyCheckBox.Name = "chcalcopyCheckBox";
            this.chcalcopyCheckBox.Size = new System.Drawing.Size(108, 17);
            this.chcalcopyCheckBox.TabIndex = 14;
            this.chcalcopyCheckBox.Text = "Change Cal Copy";
            this.chcalcopyCheckBox.UseVisualStyleBackColor = true;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(990, 739);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 30;
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(799, 29);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // outputFolderButton
            // 
            this.outputFolderButton.AutoSize = true;
            this.outputFolderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.outputFolderButton.Location = new System.Drawing.Point(770, 3);
            this.outputFolderButton.Name = "outputFolderButton";
            this.outputFolderButton.Size = new System.Drawing.Size(26, 23);
            this.outputFolderButton.TabIndex = 2;
            this.outputFolderButton.Text = "...";
            this.outputFolderButton.UseVisualStyleBackColor = true;
            this.outputFolderButton.Click += new System.EventHandler(this.OutputFolderButtonClick);
            // 
            // outputFolderTextBox
            // 
            this.outputFolderTextBox.Location = new System.Drawing.Point(80, 3);
            this.outputFolderTextBox.Name = "outputFolderTextBox";
            this.outputFolderTextBox.Size = new System.Drawing.Size(684, 20);
            this.outputFolderTextBox.TabIndex = 1;
            // 
            // outputFolderLabel
            // 
            this.outputFolderLabel.Location = new System.Drawing.Point(3, 0);
            this.outputFolderLabel.Name = "outputFolderLabel";
            this.outputFolderLabel.Size = new System.Drawing.Size(71, 21);
            this.outputFolderLabel.TabIndex = 0;
            this.outputFolderLabel.Text = "Output Folder";
            this.outputFolderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chcalcopySwPartTextBox
            // 
            this.chcalcopySwPartTextBox.Location = new System.Drawing.Point(845, 253);
            this.chcalcopySwPartTextBox.Name = "chcalcopySwPartTextBox";
            this.chcalcopySwPartTextBox.Size = new System.Drawing.Size(100, 20);
            this.chcalcopySwPartTextBox.TabIndex = 15;
            // 
            // swPartLabel
            // 
            this.swPartLabel.Location = new System.Drawing.Point(951, 252);
            this.swPartLabel.Name = "swPartLabel";
            this.swPartLabel.Size = new System.Drawing.Size(52, 21);
            this.swPartLabel.TabIndex = 16;
            this.swPartLabel.Text = "SW Part";
            this.swPartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logMessageLlabel
            // 
            this.logMessageLlabel.Location = new System.Drawing.Point(124, 186);
            this.logMessageLlabel.Name = "logMessageLlabel";
            this.logMessageLlabel.Size = new System.Drawing.Size(74, 23);
            this.logMessageLlabel.TabIndex = 3;
            this.logMessageLlabel.Text = "Log Message";
            this.logMessageLlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // revNameLabel
            // 
            this.revNameLabel.Location = new System.Drawing.Point(124, 212);
            this.revNameLabel.Name = "revNameLabel";
            this.revNameLabel.Size = new System.Drawing.Size(74, 23);
            this.revNameLabel.TabIndex = 5;
            this.revNameLabel.Text = "Rev Name";
            this.revNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prefixLabel
            // 
            this.prefixLabel.Location = new System.Drawing.Point(951, 686);
            this.prefixLabel.Name = "prefixLabel";
            this.prefixLabel.Size = new System.Drawing.Size(74, 23);
            this.prefixLabel.TabIndex = 26;
            this.prefixLabel.Text = "Prefix";
            this.prefixLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // extLabel
            // 
            this.extLabel.Location = new System.Drawing.Point(951, 712);
            this.extLabel.Name = "extLabel";
            this.extLabel.Size = new System.Drawing.Size(74, 23);
            this.extLabel.TabIndex = 28;
            this.extLabel.Text = "Extension";
            this.extLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // intendedCheckBox
            // 
            this.intendedCheckBox.AutoSize = true;
            this.intendedCheckBox.Location = new System.Drawing.Point(845, 184);
            this.intendedCheckBox.Name = "intendedCheckBox";
            this.intendedCheckBox.Size = new System.Drawing.Size(220, 17);
            this.intendedCheckBox.TabIndex = 12;
            this.intendedCheckBox.Text = "Intended For Vehicle Assembly Plant Use";
            this.intendedCheckBox.UseVisualStyleBackColor = true;
            // 
            // copyBenchCheckBox
            // 
            this.copyBenchCheckBox.AutoSize = true;
            this.copyBenchCheckBox.Location = new System.Drawing.Point(827, 279);
            this.copyBenchCheckBox.Name = "copyBenchCheckBox";
            this.copyBenchCheckBox.Size = new System.Drawing.Size(119, 17);
            this.copyBenchCheckBox.TabIndex = 17;
            this.copyBenchCheckBox.Text = "Copy Bench Values";
            this.copyBenchCheckBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.usersGuideToolStripMenuItem1,
                                    this.calSupportToolsSiteToolStripMenuItem,
                                    this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // usersGuideToolStripMenuItem1
            // 
            this.usersGuideToolStripMenuItem1.Name = "usersGuideToolStripMenuItem1";
            this.usersGuideToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.usersGuideToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.usersGuideToolStripMenuItem1.Text = "User\'s Guide";
            this.usersGuideToolStripMenuItem1.Click += new System.EventHandler(this.UsersGuideToolStripMenuItemClick);
            // 
            // calSupportToolsSiteToolStripMenuItem
            // 
            this.calSupportToolsSiteToolStripMenuItem.Name = "calSupportToolsSiteToolStripMenuItem";
            this.calSupportToolsSiteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.calSupportToolsSiteToolStripMenuItem.Text = "Cal Support Tools Site";
            this.calSupportToolsSiteToolStripMenuItem.Click += new System.EventHandler(this.CalSupportToolsSiteToolStripMenuItemClick);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 793);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1080, 22);
            this.statusStrip1.TabIndex = 31;
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
            this.waDefaultCheckBox.Location = new System.Drawing.Point(827, 37);
            this.waDefaultCheckBox.Name = "waDefaultCheckBox";
            this.waDefaultCheckBox.Size = new System.Drawing.Size(114, 17);
            this.waDefaultCheckBox.TabIndex = 3;
            this.waDefaultCheckBox.Text = "Work Area Default";
            this.waDefaultCheckBox.UseVisualStyleBackColor = true;
            // 
            // waDefSwPartTextBox
            // 
            this.waDefSwPartTextBox.Location = new System.Drawing.Point(845, 60);
            this.waDefSwPartTextBox.Name = "waDefSwPartTextBox";
            this.waDefSwPartTextBox.Size = new System.Drawing.Size(100, 20);
            this.waDefSwPartTextBox.TabIndex = 4;
            // 
            // waDefSwPartLabel
            // 
            this.waDefSwPartLabel.Location = new System.Drawing.Point(951, 59);
            this.waDefSwPartLabel.Name = "waDefSwPartLabel";
            this.waDefSwPartLabel.Size = new System.Drawing.Size(52, 21);
            this.waDefSwPartLabel.TabIndex = 5;
            this.waDefSwPartLabel.Text = "SW Part";
            this.waDefSwPartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // waDefLibTextBox
            // 
            this.waDefLibTextBox.Location = new System.Drawing.Point(845, 86);
            this.waDefLibTextBox.Name = "waDefLibTextBox";
            this.waDefLibTextBox.Size = new System.Drawing.Size(100, 20);
            this.waDefLibTextBox.TabIndex = 6;
            // 
            // waDefLibLabel
            // 
            this.waDefLibLabel.Location = new System.Drawing.Point(951, 85);
            this.waDefLibLabel.Name = "waDefLibLabel";
            this.waDefLibLabel.Size = new System.Drawing.Size(52, 21);
            this.waDefLibLabel.TabIndex = 7;
            this.waDefLibLabel.Text = "Library";
            this.waDefLibLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mkHandleCheckBox
            // 
            this.mkHandleCheckBox.AutoSize = true;
            this.mkHandleCheckBox.Location = new System.Drawing.Point(827, 112);
            this.mkHandleCheckBox.Name = "mkHandleCheckBox";
            this.mkHandleCheckBox.Size = new System.Drawing.Size(90, 17);
            this.mkHandleCheckBox.TabIndex = 8;
            this.mkHandleCheckBox.Text = "Make Handle";
            this.mkHandleCheckBox.UseVisualStyleBackColor = true;
            // 
            // mkHandleSwPartTextBox
            // 
            this.mkHandleSwPartTextBox.Location = new System.Drawing.Point(845, 135);
            this.mkHandleSwPartTextBox.Name = "mkHandleSwPartTextBox";
            this.mkHandleSwPartTextBox.Size = new System.Drawing.Size(100, 20);
            this.mkHandleSwPartTextBox.TabIndex = 9;
            // 
            // mkHandleSwPartLabel
            // 
            this.mkHandleSwPartLabel.Location = new System.Drawing.Point(951, 134);
            this.mkHandleSwPartLabel.Name = "mkHandleSwPartLabel";
            this.mkHandleSwPartLabel.Size = new System.Drawing.Size(52, 21);
            this.mkHandleSwPartLabel.TabIndex = 10;
            this.mkHandleSwPartLabel.Text = "SW Part";
            this.mkHandleSwPartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transferCheckBox
            // 
            this.transferCheckBox.AutoSize = true;
            this.transferCheckBox.Location = new System.Drawing.Point(827, 302);
            this.transferCheckBox.Name = "transferCheckBox";
            this.transferCheckBox.Size = new System.Drawing.Size(65, 17);
            this.transferCheckBox.TabIndex = 18;
            this.transferCheckBox.Text = "Transfer";
            this.transferCheckBox.UseVisualStyleBackColor = true;
            // 
            // bldImageCheckBox
            // 
            this.bldImageCheckBox.AutoSize = true;
            this.bldImageCheckBox.Location = new System.Drawing.Point(827, 325);
            this.bldImageCheckBox.Name = "bldImageCheckBox";
            this.bldImageCheckBox.Size = new System.Drawing.Size(81, 17);
            this.bldImageCheckBox.TabIndex = 19;
            this.bldImageCheckBox.Text = "Build Image";
            this.bldImageCheckBox.UseVisualStyleBackColor = true;
            // 
            // uploadCheckBox
            // 
            this.uploadCheckBox.AutoSize = true;
            this.uploadCheckBox.Location = new System.Drawing.Point(827, 348);
            this.uploadCheckBox.Name = "uploadCheckBox";
            this.uploadCheckBox.Size = new System.Drawing.Size(60, 17);
            this.uploadCheckBox.TabIndex = 20;
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
            this.devRelRadioButton.Enabled = false;
            this.devRelRadioButton.Location = new System.Drawing.Point(6, 39);
            this.devRelRadioButton.Name = "devRelRadioButton";
            this.devRelRadioButton.Size = new System.Drawing.Size(130, 23);
            this.devRelRadioButton.TabIndex = 1;
            this.devRelRadioButton.TabStop = true;
            this.devRelRadioButton.Text = "Development Release";
            this.devRelRadioButton.UseVisualStyleBackColor = true;
            // 
            // ppvRelRadioButton
            // 
            this.ppvRelRadioButton.Enabled = false;
            this.ppvRelRadioButton.Location = new System.Drawing.Point(6, 68);
            this.ppvRelRadioButton.Name = "ppvRelRadioButton";
            this.ppvRelRadioButton.Size = new System.Drawing.Size(104, 24);
            this.ppvRelRadioButton.TabIndex = 2;
            this.ppvRelRadioButton.Text = "PPV Release";
            this.ppvRelRadioButton.UseVisualStyleBackColor = true;
            // 
            // valRelRadioButton
            // 
            this.valRelRadioButton.Enabled = false;
            this.valRelRadioButton.Location = new System.Drawing.Point(6, 98);
            this.valRelRadioButton.Name = "valRelRadioButton";
            this.valRelRadioButton.Size = new System.Drawing.Size(115, 24);
            this.valRelRadioButton.TabIndex = 3;
            this.valRelRadioButton.Text = "Validation Release";
            this.valRelRadioButton.UseVisualStyleBackColor = true;
            // 
            // unixFormatCheckBox
            // 
            this.unixFormatCheckBox.Location = new System.Drawing.Point(827, 741);
            this.unixFormatCheckBox.Name = "unixFormatCheckBox";
            this.unixFormatCheckBox.Size = new System.Drawing.Size(104, 24);
            this.unixFormatCheckBox.TabIndex = 29;
            this.unixFormatCheckBox.Text = "Unix Format";
            this.unixFormatCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.revokeCheckBox);
            this.groupBox3.Controls.Add(this.devRelRadioButton);
            this.groupBox3.Controls.Add(this.ppvRelRadioButton);
            this.groupBox3.Controls.Add(this.valRelRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(18, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 126);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // revokeCheckBox
            // 
            this.revokeCheckBox.AutoSize = true;
            this.revokeCheckBox.Enabled = false;
            this.revokeCheckBox.Location = new System.Drawing.Point(6, 16);
            this.revokeCheckBox.Name = "revokeCheckBox";
            this.revokeCheckBox.Size = new System.Drawing.Size(64, 17);
            this.revokeCheckBox.TabIndex = 0;
            this.revokeCheckBox.Text = "Revoke";
            this.revokeCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkinCopyRadioButton
            // 
            this.checkinCopyRadioButton.AutoCheck = false;
            this.checkinCopyRadioButton.Location = new System.Drawing.Point(6, 16);
            this.checkinCopyRadioButton.Name = "checkinCopyRadioButton";
            this.checkinCopyRadioButton.Size = new System.Drawing.Size(93, 24);
            this.checkinCopyRadioButton.TabIndex = 0;
            this.checkinCopyRadioButton.TabStop = true;
            this.checkinCopyRadioButton.Text = "Checkin Copy";
            this.checkinCopyRadioButton.UseVisualStyleBackColor = true;
            this.checkinCopyRadioButton.Click += new System.EventHandler(this.CheckinCopyRadioButtonClick);
            // 
            // updateStatusRadioButton
            // 
            this.updateStatusRadioButton.AutoCheck = false;
            this.updateStatusRadioButton.Location = new System.Drawing.Point(105, 16);
            this.updateStatusRadioButton.Name = "updateStatusRadioButton";
            this.updateStatusRadioButton.Size = new System.Drawing.Size(93, 24);
            this.updateStatusRadioButton.TabIndex = 1;
            this.updateStatusRadioButton.TabStop = true;
            this.updateStatusRadioButton.Text = "Update Status";
            this.updateStatusRadioButton.UseVisualStyleBackColor = true;
            this.updateStatusRadioButton.Click += new System.EventHandler(this.UpdateStatusRadioButtonClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkinCopyRadioButton);
            this.groupBox2.Controls.Add(this.updateStatusRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(6, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 46);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.logMessageTextBox);
            this.groupBox1.Controls.Add(this.logMessageLlabel);
            this.groupBox1.Controls.Add(this.revNameTextBox);
            this.groupBox1.Controls.Add(this.revNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(827, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 242);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "offsetContextMenuStrip";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 26);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1080, 815);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mkHandleCheckBox);
            this.Controls.Add(this.uploadCheckBox);
            this.Controls.Add(this.unixFormatCheckBox);
            this.Controls.Add(this.bldImageCheckBox);
            this.Controls.Add(this.transferCheckBox);
            this.Controls.Add(this.mkHandleSwPartLabel);
            this.Controls.Add(this.mkHandleSwPartTextBox);
            this.Controls.Add(this.waDefLibLabel);
            this.Controls.Add(this.waDefLibTextBox);
            this.Controls.Add(this.extLabel);
            this.Controls.Add(this.waDefSwPartLabel);
            this.Controls.Add(this.waDefSwPartTextBox);
            this.Controls.Add(this.waDefaultCheckBox);
            this.Controls.Add(this.copyBenchCheckBox);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.intendedCheckBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.swPartLabel);
            this.Controls.Add(this.prefixLabel);
            this.Controls.Add(this.extTextBox);
            this.Controls.Add(this.prefixTextBox);
            this.Controls.Add(this.calplotCheckBox);
            this.Controls.Add(this.createClass2CheckBox);
            this.Controls.Add(this.chcalcopySwPartTextBox);
            this.Controls.Add(this.mkcopyCheckBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chcalcopyCheckBox);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.batchCaleditCheckBox);
            this.Controls.Add(this.activateCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calds Script Generator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.offsetGroupBox.ResumeLayout(false);
            this.valueGroupBox.ResumeLayout(false);
            this.calGroupBox.ResumeLayout(false);
            this.srcPartsGroupBox.ResumeLayout(false);
            this.dstGroupBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.Button clrDstButton;
        private System.Windows.Forms.GroupBox dstGroupBox;
        private System.Windows.Forms.Button srcClearButton;
        private System.Windows.Forms.GroupBox srcPartsGroupBox;
        private System.Windows.Forms.Button clearCalsButton;
        private System.Windows.Forms.RadioButton normalRadioButton;
        private System.Windows.Forms.RadioButton singleRadioButton;
        private System.Windows.Forms.GroupBox calGroupBox;
        private System.Windows.Forms.RadioButton hexRadioButton;
        private System.Windows.Forms.RadioButton engRadioButton;
        private System.Windows.Forms.GroupBox valueGroupBox;
        private System.Windows.Forms.CheckBox autoFillCheckBox;
        private System.Windows.Forms.GroupBox offsetGroupBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calSupportToolsSiteToolStripMenuItem;
        private System.Windows.Forms.CheckBox revokeCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton updateStatusRadioButton;
        private System.Windows.Forms.RadioButton checkinCopyRadioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox unixFormatCheckBox;
        private System.Windows.Forms.RadioButton valRelRadioButton;
        private System.Windows.Forms.RadioButton ppvRelRadioButton;
        private System.Windows.Forms.RadioButton devRelRadioButton;
        private System.Windows.Forms.TextBox calOffsetTextBox;
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
        private System.Windows.Forms.Button partsListOpenButton;
        private System.Windows.Forms.Button engScriptOpenButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
