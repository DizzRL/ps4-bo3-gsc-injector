
namespace PS4_BO3_GSC
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.styleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.connectionGroupBox = new System.Windows.Forms.GroupBox();
            this.ps4PortTextBox = new MetroFramework.Controls.MetroTextBox();
            this.portLabel = new MetroFramework.Controls.MetroLabel();
            this.attachBo3Button = new System.Windows.Forms.Button();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.connectPS4Button = new System.Windows.Forms.Button();
            this.ps4IpTextBox = new MetroFramework.Controls.MetroTextBox();
            this.compilerGroupBox = new System.Windows.Forms.GroupBox();
            this.browseOutputPathButton = new System.Windows.Forms.Button();
            this.browseGscFolderButton = new System.Windows.Forms.Button();
            this.compileGscProjectButton = new System.Windows.Forms.Button();
            this.compiledGscOutputLabel = new MetroFramework.Controls.MetroLabel();
            this.compiledGscFileOutputTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.gscProjectFolderTextBox = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.injectGscButton = new System.Windows.Forms.Button();
            this.browseCompiledGscFileButton = new System.Windows.Forms.Button();
            this.compiledGscFileLabel = new MetroFramework.Controls.MetroLabel();
            this.compiledGscFileTextBox = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.connectionStatusLabel = new MetroFramework.Controls.MetroLabel();
            this.staticStatusLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.oneThreeThreeRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.oneTwoSixRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.gameVersionGroupBox = new System.Windows.Forms.GroupBox();
            this.consoleVersionGroupBox = new System.Windows.Forms.GroupBox();
            this.sevenFiveFiveRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.sevenOTwoRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.sixSevenTwoRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.fiveOFiveRadioButton = new MetroFramework.Controls.MetroRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).BeginInit();
            this.connectionGroupBox.SuspendLayout();
            this.compilerGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gameVersionGroupBox.SuspendLayout();
            this.consoleVersionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.Owner = this;
            this.styleManager.Style = MetroFramework.MetroColorStyle.Purple;
            this.styleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // connectionGroupBox
            // 
            this.connectionGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.connectionGroupBox.Controls.Add(this.ps4PortTextBox);
            this.connectionGroupBox.Controls.Add(this.portLabel);
            this.connectionGroupBox.Controls.Add(this.attachBo3Button);
            this.connectionGroupBox.Controls.Add(this.metroLabel2);
            this.connectionGroupBox.Controls.Add(this.connectPS4Button);
            this.connectionGroupBox.Controls.Add(this.ps4IpTextBox);
            this.connectionGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.connectionGroupBox.Location = new System.Drawing.Point(24, 64);
            this.connectionGroupBox.Name = "connectionGroupBox";
            this.connectionGroupBox.Size = new System.Drawing.Size(356, 82);
            this.connectionGroupBox.TabIndex = 0;
            this.connectionGroupBox.TabStop = false;
            this.connectionGroupBox.Text = "Connection";
            // 
            // ps4PortTextBox
            // 
            // 
            // 
            // 
            this.ps4PortTextBox.CustomButton.Image = null;
            this.ps4PortTextBox.CustomButton.Location = new System.Drawing.Point(40, 1);
            this.ps4PortTextBox.CustomButton.Name = "";
            this.ps4PortTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ps4PortTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ps4PortTextBox.CustomButton.TabIndex = 1;
            this.ps4PortTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ps4PortTextBox.CustomButton.UseSelectable = true;
            this.ps4PortTextBox.CustomButton.Visible = false;
            this.ps4PortTextBox.Lines = new string[0];
            this.ps4PortTextBox.Location = new System.Drawing.Point(288, 19);
            this.ps4PortTextBox.MaxLength = 32767;
            this.ps4PortTextBox.Name = "ps4PortTextBox";
            this.ps4PortTextBox.PasswordChar = '\0';
            this.ps4PortTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ps4PortTextBox.SelectedText = "";
            this.ps4PortTextBox.SelectionLength = 0;
            this.ps4PortTextBox.SelectionStart = 0;
            this.ps4PortTextBox.ShortcutsEnabled = true;
            this.ps4PortTextBox.Size = new System.Drawing.Size(62, 23);
            this.ps4PortTextBox.TabIndex = 12;
            this.ps4PortTextBox.UseSelectable = true;
            this.ps4PortTextBox.UseStyleColors = true;
            this.ps4PortTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ps4PortTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(245, 21);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(37, 19);
            this.portLabel.TabIndex = 11;
            this.portLabel.Text = "Port:";
            this.portLabel.UseStyleColors = true;
            // 
            // attachBo3Button
            // 
            this.attachBo3Button.BackColor = System.Drawing.Color.Black;
            this.attachBo3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attachBo3Button.Location = new System.Drawing.Point(178, 48);
            this.attachBo3Button.Name = "attachBo3Button";
            this.attachBo3Button.Size = new System.Drawing.Size(81, 23);
            this.attachBo3Button.TabIndex = 10;
            this.attachBo3Button.Text = "Attach BO3";
            this.attachBo3Button.UseVisualStyleBackColor = false;
            this.attachBo3Button.Click += new System.EventHandler(this.attachBo3Button_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 21);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(23, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "IP:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // connectPS4Button
            // 
            this.connectPS4Button.BackColor = System.Drawing.Color.Black;
            this.connectPS4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectPS4Button.Location = new System.Drawing.Point(91, 48);
            this.connectPS4Button.Name = "connectPS4Button";
            this.connectPS4Button.Size = new System.Drawing.Size(81, 23);
            this.connectPS4Button.TabIndex = 9;
            this.connectPS4Button.Text = "Connect PS4";
            this.connectPS4Button.UseVisualStyleBackColor = false;
            this.connectPS4Button.EnabledChanged += new System.EventHandler(this.connectPS4Button_EnabledChanged);
            this.connectPS4Button.Click += new System.EventHandler(this.connectPS4Button_Click);
            // 
            // ps4IpTextBox
            // 
            // 
            // 
            // 
            this.ps4IpTextBox.CustomButton.Image = null;
            this.ps4IpTextBox.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.ps4IpTextBox.CustomButton.Name = "";
            this.ps4IpTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ps4IpTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ps4IpTextBox.CustomButton.TabIndex = 1;
            this.ps4IpTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ps4IpTextBox.CustomButton.UseSelectable = true;
            this.ps4IpTextBox.CustomButton.Visible = false;
            this.ps4IpTextBox.Lines = new string[0];
            this.ps4IpTextBox.Location = new System.Drawing.Point(35, 19);
            this.ps4IpTextBox.MaxLength = 32767;
            this.ps4IpTextBox.Name = "ps4IpTextBox";
            this.ps4IpTextBox.PasswordChar = '\0';
            this.ps4IpTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ps4IpTextBox.SelectedText = "";
            this.ps4IpTextBox.SelectionLength = 0;
            this.ps4IpTextBox.SelectionStart = 0;
            this.ps4IpTextBox.ShortcutsEnabled = true;
            this.ps4IpTextBox.Size = new System.Drawing.Size(204, 23);
            this.ps4IpTextBox.TabIndex = 1;
            this.ps4IpTextBox.UseSelectable = true;
            this.ps4IpTextBox.UseStyleColors = true;
            this.ps4IpTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ps4IpTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // compilerGroupBox
            // 
            this.compilerGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.compilerGroupBox.Controls.Add(this.browseOutputPathButton);
            this.compilerGroupBox.Controls.Add(this.browseGscFolderButton);
            this.compilerGroupBox.Controls.Add(this.compileGscProjectButton);
            this.compilerGroupBox.Controls.Add(this.compiledGscOutputLabel);
            this.compilerGroupBox.Controls.Add(this.compiledGscFileOutputTextBox);
            this.compilerGroupBox.Controls.Add(this.metroLabel1);
            this.compilerGroupBox.Controls.Add(this.gscProjectFolderTextBox);
            this.compilerGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.compilerGroupBox.Location = new System.Drawing.Point(24, 155);
            this.compilerGroupBox.Name = "compilerGroupBox";
            this.compilerGroupBox.Size = new System.Drawing.Size(605, 124);
            this.compilerGroupBox.TabIndex = 1;
            this.compilerGroupBox.TabStop = false;
            this.compilerGroupBox.Text = "Compiler";
            // 
            // browseOutputPathButton
            // 
            this.browseOutputPathButton.BackColor = System.Drawing.Color.Black;
            this.browseOutputPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseOutputPathButton.Location = new System.Drawing.Point(524, 48);
            this.browseOutputPathButton.Name = "browseOutputPathButton";
            this.browseOutputPathButton.Size = new System.Drawing.Size(75, 23);
            this.browseOutputPathButton.TabIndex = 11;
            this.browseOutputPathButton.Text = "Browse";
            this.browseOutputPathButton.UseVisualStyleBackColor = false;
            this.browseOutputPathButton.Click += new System.EventHandler(this.browseOutputPathButton_Click);
            // 
            // browseGscFolderButton
            // 
            this.browseGscFolderButton.BackColor = System.Drawing.Color.Black;
            this.browseGscFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseGscFolderButton.Location = new System.Drawing.Point(524, 18);
            this.browseGscFolderButton.Name = "browseGscFolderButton";
            this.browseGscFolderButton.Size = new System.Drawing.Size(75, 23);
            this.browseGscFolderButton.TabIndex = 10;
            this.browseGscFolderButton.Text = "Browse";
            this.browseGscFolderButton.UseVisualStyleBackColor = false;
            this.browseGscFolderButton.Click += new System.EventHandler(this.browseGscFolderButton_Click);
            // 
            // compileGscProjectButton
            // 
            this.compileGscProjectButton.BackColor = System.Drawing.Color.Black;
            this.compileGscProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compileGscProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compileGscProjectButton.Location = new System.Drawing.Point(215, 80);
            this.compileGscProjectButton.Name = "compileGscProjectButton";
            this.compileGscProjectButton.Size = new System.Drawing.Size(175, 38);
            this.compileGscProjectButton.TabIndex = 8;
            this.compileGscProjectButton.Text = "Compile GSC Project";
            this.compileGscProjectButton.UseVisualStyleBackColor = false;
            this.compileGscProjectButton.Click += new System.EventHandler(this.compileGscProjectButton_Click);
            // 
            // compiledGscOutputLabel
            // 
            this.compiledGscOutputLabel.AutoSize = true;
            this.compiledGscOutputLabel.Location = new System.Drawing.Point(6, 48);
            this.compiledGscOutputLabel.Name = "compiledGscOutputLabel";
            this.compiledGscOutputLabel.Size = new System.Drawing.Size(82, 19);
            this.compiledGscOutputLabel.TabIndex = 7;
            this.compiledGscOutputLabel.Text = "Output Path:";
            this.compiledGscOutputLabel.UseStyleColors = true;
            // 
            // compiledGscFileOutputTextBox
            // 
            // 
            // 
            // 
            this.compiledGscFileOutputTextBox.CustomButton.Image = null;
            this.compiledGscFileOutputTextBox.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.compiledGscFileOutputTextBox.CustomButton.Name = "";
            this.compiledGscFileOutputTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.compiledGscFileOutputTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.compiledGscFileOutputTextBox.CustomButton.TabIndex = 1;
            this.compiledGscFileOutputTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.compiledGscFileOutputTextBox.CustomButton.UseSelectable = true;
            this.compiledGscFileOutputTextBox.CustomButton.Visible = false;
            this.compiledGscFileOutputTextBox.Enabled = false;
            this.compiledGscFileOutputTextBox.Lines = new string[0];
            this.compiledGscFileOutputTextBox.Location = new System.Drawing.Point(94, 47);
            this.compiledGscFileOutputTextBox.MaxLength = 32767;
            this.compiledGscFileOutputTextBox.Name = "compiledGscFileOutputTextBox";
            this.compiledGscFileOutputTextBox.PasswordChar = '\0';
            this.compiledGscFileOutputTextBox.ReadOnly = true;
            this.compiledGscFileOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.compiledGscFileOutputTextBox.SelectedText = "";
            this.compiledGscFileOutputTextBox.SelectionLength = 0;
            this.compiledGscFileOutputTextBox.SelectionStart = 0;
            this.compiledGscFileOutputTextBox.ShortcutsEnabled = true;
            this.compiledGscFileOutputTextBox.Size = new System.Drawing.Size(424, 23);
            this.compiledGscFileOutputTextBox.TabIndex = 6;
            this.compiledGscFileOutputTextBox.UseSelectable = true;
            this.compiledGscFileOutputTextBox.UseStyleColors = true;
            this.compiledGscFileOutputTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.compiledGscFileOutputTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "GSC Project:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // gscProjectFolderTextBox
            // 
            // 
            // 
            // 
            this.gscProjectFolderTextBox.CustomButton.Image = null;
            this.gscProjectFolderTextBox.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.gscProjectFolderTextBox.CustomButton.Name = "";
            this.gscProjectFolderTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.gscProjectFolderTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gscProjectFolderTextBox.CustomButton.TabIndex = 1;
            this.gscProjectFolderTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gscProjectFolderTextBox.CustomButton.UseSelectable = true;
            this.gscProjectFolderTextBox.CustomButton.Visible = false;
            this.gscProjectFolderTextBox.Enabled = false;
            this.gscProjectFolderTextBox.Lines = new string[0];
            this.gscProjectFolderTextBox.Location = new System.Drawing.Point(94, 18);
            this.gscProjectFolderTextBox.MaxLength = 32767;
            this.gscProjectFolderTextBox.Name = "gscProjectFolderTextBox";
            this.gscProjectFolderTextBox.PasswordChar = '\0';
            this.gscProjectFolderTextBox.ReadOnly = true;
            this.gscProjectFolderTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gscProjectFolderTextBox.SelectedText = "";
            this.gscProjectFolderTextBox.SelectionLength = 0;
            this.gscProjectFolderTextBox.SelectionStart = 0;
            this.gscProjectFolderTextBox.ShortcutsEnabled = true;
            this.gscProjectFolderTextBox.Size = new System.Drawing.Size(424, 23);
            this.gscProjectFolderTextBox.TabIndex = 3;
            this.gscProjectFolderTextBox.UseSelectable = true;
            this.gscProjectFolderTextBox.UseStyleColors = true;
            this.gscProjectFolderTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gscProjectFolderTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.injectGscButton);
            this.groupBox1.Controls.Add(this.browseCompiledGscFileButton);
            this.groupBox1.Controls.Add(this.compiledGscFileLabel);
            this.groupBox1.Controls.Add(this.compiledGscFileTextBox);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.groupBox1.Location = new System.Drawing.Point(24, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Injector";
            // 
            // injectGscButton
            // 
            this.injectGscButton.BackColor = System.Drawing.Color.Black;
            this.injectGscButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.injectGscButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.injectGscButton.Location = new System.Drawing.Point(215, 48);
            this.injectGscButton.Name = "injectGscButton";
            this.injectGscButton.Size = new System.Drawing.Size(175, 38);
            this.injectGscButton.TabIndex = 12;
            this.injectGscButton.Text = "Inject GSC";
            this.injectGscButton.UseVisualStyleBackColor = false;
            this.injectGscButton.Click += new System.EventHandler(this.injectGscButton_Click);
            // 
            // browseCompiledGscFileButton
            // 
            this.browseCompiledGscFileButton.BackColor = System.Drawing.Color.Black;
            this.browseCompiledGscFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseCompiledGscFileButton.Location = new System.Drawing.Point(524, 19);
            this.browseCompiledGscFileButton.Name = "browseCompiledGscFileButton";
            this.browseCompiledGscFileButton.Size = new System.Drawing.Size(75, 23);
            this.browseCompiledGscFileButton.TabIndex = 12;
            this.browseCompiledGscFileButton.Text = "Browse";
            this.browseCompiledGscFileButton.UseVisualStyleBackColor = false;
            this.browseCompiledGscFileButton.Click += new System.EventHandler(this.browseCompiledGscFileButton_Click);
            // 
            // compiledGscFileLabel
            // 
            this.compiledGscFileLabel.AutoSize = true;
            this.compiledGscFileLabel.Location = new System.Drawing.Point(6, 20);
            this.compiledGscFileLabel.Name = "compiledGscFileLabel";
            this.compiledGscFileLabel.Size = new System.Drawing.Size(123, 19);
            this.compiledGscFileLabel.TabIndex = 11;
            this.compiledGscFileLabel.Text = "Compiled GSC File:";
            this.compiledGscFileLabel.UseStyleColors = true;
            // 
            // compiledGscFileTextBox
            // 
            // 
            // 
            // 
            this.compiledGscFileTextBox.CustomButton.Image = null;
            this.compiledGscFileTextBox.CustomButton.Location = new System.Drawing.Point(361, 1);
            this.compiledGscFileTextBox.CustomButton.Name = "";
            this.compiledGscFileTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.compiledGscFileTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.compiledGscFileTextBox.CustomButton.TabIndex = 1;
            this.compiledGscFileTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.compiledGscFileTextBox.CustomButton.UseSelectable = true;
            this.compiledGscFileTextBox.CustomButton.Visible = false;
            this.compiledGscFileTextBox.Enabled = false;
            this.compiledGscFileTextBox.Lines = new string[0];
            this.compiledGscFileTextBox.Location = new System.Drawing.Point(135, 19);
            this.compiledGscFileTextBox.MaxLength = 32767;
            this.compiledGscFileTextBox.Name = "compiledGscFileTextBox";
            this.compiledGscFileTextBox.PasswordChar = '\0';
            this.compiledGscFileTextBox.ReadOnly = true;
            this.compiledGscFileTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.compiledGscFileTextBox.SelectedText = "";
            this.compiledGscFileTextBox.SelectionLength = 0;
            this.compiledGscFileTextBox.SelectionStart = 0;
            this.compiledGscFileTextBox.ShortcutsEnabled = true;
            this.compiledGscFileTextBox.Size = new System.Drawing.Size(383, 23);
            this.compiledGscFileTextBox.TabIndex = 10;
            this.compiledGscFileTextBox.UseSelectable = true;
            this.compiledGscFileTextBox.UseStyleColors = true;
            this.compiledGscFileTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.compiledGscFileTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.connectionStatusLabel);
            this.groupBox2.Controls.Add(this.staticStatusLabel);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.groupBox2.Location = new System.Drawing.Point(386, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 54);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection Status";
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.connectionStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.connectionStatusLabel.Location = new System.Drawing.Point(59, 17);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(127, 25);
            this.connectionStatusLabel.TabIndex = 1;
            this.connectionStatusLabel.Text = "Not Connected";
            this.connectionStatusLabel.UseCustomForeColor = true;
            this.connectionStatusLabel.UseStyleColors = true;
            // 
            // staticStatusLabel
            // 
            this.staticStatusLabel.AutoSize = true;
            this.staticStatusLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.staticStatusLabel.Location = new System.Drawing.Point(6, 17);
            this.staticStatusLabel.Name = "staticStatusLabel";
            this.staticStatusLabel.Size = new System.Drawing.Size(61, 25);
            this.staticStatusLabel.TabIndex = 0;
            this.staticStatusLabel.Text = "Status:";
            this.staticStatusLabel.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(564, 429);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "By DizzRL";
            this.metroLabel3.UseStyleColors = true;
            // 
            // oneThreeThreeRadioButton
            // 
            this.oneThreeThreeRadioButton.AutoSize = true;
            this.oneThreeThreeRadioButton.Checked = true;
            this.oneThreeThreeRadioButton.Location = new System.Drawing.Point(44, 28);
            this.oneThreeThreeRadioButton.Name = "oneThreeThreeRadioButton";
            this.oneThreeThreeRadioButton.Size = new System.Drawing.Size(44, 15);
            this.oneThreeThreeRadioButton.TabIndex = 5;
            this.oneThreeThreeRadioButton.TabStop = true;
            this.oneThreeThreeRadioButton.Text = "1.33";
            this.oneThreeThreeRadioButton.UseSelectable = true;
            this.oneThreeThreeRadioButton.UseStyleColors = true;
            this.oneThreeThreeRadioButton.CheckedChanged += new System.EventHandler(this.oneThreeThreeRadioButton_CheckedChanged);
            // 
            // oneTwoSixRadioButton
            // 
            this.oneTwoSixRadioButton.AutoSize = true;
            this.oneTwoSixRadioButton.Location = new System.Drawing.Point(94, 28);
            this.oneTwoSixRadioButton.Name = "oneTwoSixRadioButton";
            this.oneTwoSixRadioButton.Size = new System.Drawing.Size(44, 15);
            this.oneTwoSixRadioButton.TabIndex = 6;
            this.oneTwoSixRadioButton.Text = "1.26";
            this.oneTwoSixRadioButton.UseSelectable = true;
            this.oneTwoSixRadioButton.UseStyleColors = true;
            this.oneTwoSixRadioButton.CheckedChanged += new System.EventHandler(this.oneTwoSixRadioButton_CheckedChanged);
            // 
            // gameVersionGroupBox
            // 
            this.gameVersionGroupBox.Controls.Add(this.oneTwoSixRadioButton);
            this.gameVersionGroupBox.Controls.Add(this.oneThreeThreeRadioButton);
            this.gameVersionGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.gameVersionGroupBox.Location = new System.Drawing.Point(24, 385);
            this.gameVersionGroupBox.Name = "gameVersionGroupBox";
            this.gameVersionGroupBox.Size = new System.Drawing.Size(200, 63);
            this.gameVersionGroupBox.TabIndex = 7;
            this.gameVersionGroupBox.TabStop = false;
            this.gameVersionGroupBox.Text = "Game Version";
            // 
            // consoleVersionGroupBox
            // 
            this.consoleVersionGroupBox.Controls.Add(this.sevenFiveFiveRadioButton);
            this.consoleVersionGroupBox.Controls.Add(this.sevenOTwoRadioButton);
            this.consoleVersionGroupBox.Controls.Add(this.sixSevenTwoRadioButton);
            this.consoleVersionGroupBox.Controls.Add(this.fiveOFiveRadioButton);
            this.consoleVersionGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.consoleVersionGroupBox.Location = new System.Drawing.Point(230, 385);
            this.consoleVersionGroupBox.Name = "consoleVersionGroupBox";
            this.consoleVersionGroupBox.Size = new System.Drawing.Size(280, 63);
            this.consoleVersionGroupBox.TabIndex = 8;
            this.consoleVersionGroupBox.TabStop = false;
            this.consoleVersionGroupBox.Text = "Console Version";
            // 
            // sevenFiveFiveRadioButton
            // 
            this.sevenFiveFiveRadioButton.AutoSize = true;
            this.sevenFiveFiveRadioButton.Location = new System.Drawing.Point(194, 28);
            this.sevenFiveFiveRadioButton.Name = "sevenFiveFiveRadioButton";
            this.sevenFiveFiveRadioButton.Size = new System.Drawing.Size(44, 15);
            this.sevenFiveFiveRadioButton.TabIndex = 8;
            this.sevenFiveFiveRadioButton.Text = "7.55";
            this.sevenFiveFiveRadioButton.UseSelectable = true;
            this.sevenFiveFiveRadioButton.UseStyleColors = true;
            this.sevenFiveFiveRadioButton.CheckedChanged += new System.EventHandler(this.sevenFiveFiveRadioButton_CheckedChanged);
            // 
            // sevenOTwoRadioButton
            // 
            this.sevenOTwoRadioButton.AutoSize = true;
            this.sevenOTwoRadioButton.Location = new System.Drawing.Point(144, 28);
            this.sevenOTwoRadioButton.Name = "sevenOTwoRadioButton";
            this.sevenOTwoRadioButton.Size = new System.Drawing.Size(44, 15);
            this.sevenOTwoRadioButton.TabIndex = 7;
            this.sevenOTwoRadioButton.Text = "7.05";
            this.sevenOTwoRadioButton.UseSelectable = true;
            this.sevenOTwoRadioButton.UseStyleColors = true;
            this.sevenOTwoRadioButton.CheckedChanged += new System.EventHandler(this.sevenOTwoRadioButton_CheckedChanged);
            // 
            // sixSevenTwoRadioButton
            // 
            this.sixSevenTwoRadioButton.AutoSize = true;
            this.sixSevenTwoRadioButton.Location = new System.Drawing.Point(94, 28);
            this.sixSevenTwoRadioButton.Name = "sixSevenTwoRadioButton";
            this.sixSevenTwoRadioButton.Size = new System.Drawing.Size(44, 15);
            this.sixSevenTwoRadioButton.TabIndex = 6;
            this.sixSevenTwoRadioButton.Text = "6.72";
            this.sixSevenTwoRadioButton.UseSelectable = true;
            this.sixSevenTwoRadioButton.UseStyleColors = true;
            this.sixSevenTwoRadioButton.CheckedChanged += new System.EventHandler(this.sixSevenTwoRadioButton_CheckedChanged);
            // 
            // fiveOFiveRadioButton
            // 
            this.fiveOFiveRadioButton.AutoSize = true;
            this.fiveOFiveRadioButton.Checked = true;
            this.fiveOFiveRadioButton.Location = new System.Drawing.Point(44, 28);
            this.fiveOFiveRadioButton.Name = "fiveOFiveRadioButton";
            this.fiveOFiveRadioButton.Size = new System.Drawing.Size(44, 15);
            this.fiveOFiveRadioButton.TabIndex = 5;
            this.fiveOFiveRadioButton.TabStop = true;
            this.fiveOFiveRadioButton.Text = "5.05";
            this.fiveOFiveRadioButton.UseSelectable = true;
            this.fiveOFiveRadioButton.UseStyleColors = true;
            this.fiveOFiveRadioButton.CheckedChanged += new System.EventHandler(this.fiveOFiveRadioButton_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 455);
            this.Controls.Add(this.consoleVersionGroupBox);
            this.Controls.Add(this.gameVersionGroupBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.compilerGroupBox);
            this.Controls.Add(this.connectionGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "PS4 BO3 GSC";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).EndInit();
            this.connectionGroupBox.ResumeLayout(false);
            this.connectionGroupBox.PerformLayout();
            this.compilerGroupBox.ResumeLayout(false);
            this.compilerGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gameVersionGroupBox.ResumeLayout(false);
            this.gameVersionGroupBox.PerformLayout();
            this.consoleVersionGroupBox.ResumeLayout(false);
            this.consoleVersionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager styleManager;
        private System.Windows.Forms.GroupBox connectionGroupBox;
        private MetroFramework.Controls.MetroTextBox ps4IpTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox compilerGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel staticStatusLabel;
        private MetroFramework.Controls.MetroLabel connectionStatusLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox gscProjectFolderTextBox;
        private MetroFramework.Controls.MetroLabel compiledGscOutputLabel;
        private MetroFramework.Controls.MetroTextBox compiledGscFileOutputTextBox;
        private System.Windows.Forms.Button connectPS4Button;
        private System.Windows.Forms.Button compileGscProjectButton;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel compiledGscFileLabel;
        private MetroFramework.Controls.MetroTextBox compiledGscFileTextBox;
        private System.Windows.Forms.Button injectGscButton;
        private System.Windows.Forms.Button browseCompiledGscFileButton;
        private System.Windows.Forms.Button browseOutputPathButton;
        private System.Windows.Forms.Button browseGscFolderButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroRadioButton oneThreeThreeRadioButton;
        private MetroFramework.Controls.MetroRadioButton oneTwoSixRadioButton;
        private System.Windows.Forms.GroupBox consoleVersionGroupBox;
        private MetroFramework.Controls.MetroRadioButton sevenFiveFiveRadioButton;
        private MetroFramework.Controls.MetroRadioButton sevenOTwoRadioButton;
        private MetroFramework.Controls.MetroRadioButton sixSevenTwoRadioButton;
        private MetroFramework.Controls.MetroRadioButton fiveOFiveRadioButton;
        private System.Windows.Forms.GroupBox gameVersionGroupBox;
        private System.Windows.Forms.Button attachBo3Button;
        private MetroFramework.Controls.MetroTextBox ps4PortTextBox;
        private MetroFramework.Controls.MetroLabel portLabel;
    }
}

