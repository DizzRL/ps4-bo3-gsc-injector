using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using MetroFramework.Forms;
using libdebug;
using TreyarchCompiler;
using TreyarchCompiler.Utilities;

namespace PS4_BO3_GSC
{
    public partial class MainWindow : MetroForm
    {
        public static Socket _psocket;
        public static bool pDConnected;
        private PS4DBG ps4;
        private Process attachedProcess;
        private Enums.GameVersion selectedGameVersion = Enums.GameVersion.OneThreeThree;
        private Enums.ConsoleVersion selectedConsoleVersion = Enums.ConsoleVersion.fiveOFive;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var ps4Ip = Properties.Settings.Default.ps4ip;
            var ps4Port = Properties.Settings.Default.ps4Port;
            ps4IpTextBox.Text = ps4Ip;
            ps4PortTextBox.Text = ps4Port;
            updateSelectedConsoleVersion();
        }

        private void updateSelectedConsoleVersion()
        {
            var savedVersion = (Enums.ConsoleVersion)Properties.Settings.Default.ps4Version;
            selectedConsoleVersion = savedVersion;
            if (savedVersion == Enums.ConsoleVersion.fiveOFive)
                fiveOFiveRadioButton.Checked = true;
            else if (savedVersion == Enums.ConsoleVersion.sixSevenTwo)
                sixSevenTwoRadioButton.Checked = true;
            else if (savedVersion == Enums.ConsoleVersion.sevenOTwo)
                sevenOTwoRadioButton.Checked = true;
            else
                sevenFiveFiveRadioButton.Checked = true;
        }

        private string getPayloadFileForVersion()
        {
            var payloadsDirectory = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "Payloads");
            var payloadFileName = "ps4debug.bin";
            switch (selectedConsoleVersion)
            {
                case Enums.ConsoleVersion.fiveOFive:
                    return $"{payloadsDirectory}\\5_05\\{payloadFileName}";
                case Enums.ConsoleVersion.sixSevenTwo:
                    return $"{payloadsDirectory}\\6_72\\{payloadFileName}";
                case Enums.ConsoleVersion.sevenOTwo:
                    return $"{payloadsDirectory}\\7_02\\{payloadFileName}";
                default:
                    return $"{payloadsDirectory}\\7_55\\{payloadFileName}";
            }
        }
        public static bool Connect2PS4(string ip, string port)
        {
            try
            {
                _psocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _psocket.ReceiveTimeout = 3000;
                _psocket.SendTimeout = 3000;
                _psocket.Connect(new IPEndPoint(IPAddress.Parse(ip), Int32.Parse(port)));
                pDConnected = true;
                return true;
            }
            catch (Exception ex)
            {
                pDConnected = false;
                return false;
            }
        }

        private void connectPS4Button_Click(object sender, EventArgs e)
        {
            var ps4Ip = Properties.Settings.Default.ps4ip;
            if (ps4Ip == "")
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Would you like to save your PS4 IP?", "Save PS4 IP?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Properties.Settings.Default.ps4ip = ps4IpTextBox.Text;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                if (ps4Ip != ps4IpTextBox.Text)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "The IP you entered is different from the one stored, would you like to update the stored IP?", "Update PS4 IP?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Properties.Settings.Default.ps4ip = ps4IpTextBox.Text;
                        Properties.Settings.Default.Save();
                    }
                }
            }
            try
            {
                if (Connect2PS4(ps4IpTextBox.Text, ps4PortTextBox.Text))
                {
                    _psocket.SendFile(getPayloadFileForVersion());
                    pDConnected = false;
                    _psocket.Close();
                }
            } catch (Exception err)
            {
                connectionStatusLabel.Text = "Connection Failed";
                connectionStatusLabel.ForeColor = Color.Red;
                return;
            }
            connectionStatusLabel.Text = "Payload Injected";
            connectionStatusLabel.ForeColor = Color.YellowGreen;
        }
        private void attachBo3Button_Click(object sender, EventArgs e)
        {
            try
            {
                ps4 = new PS4DBG(ps4IpTextBox.Text);
                ps4.Connect();
            }
            catch
            {
                connectionStatusLabel.Text = "Connection Failed";
                connectionStatusLabel.ForeColor = Color.Red;
                return;
            }
            if (!ps4.IsConnected)
            {
                connectionStatusLabel.Text = "Connection Failed";
                connectionStatusLabel.ForeColor = Color.Red;
                return;
            }
            bool foundProcess = false;
            foreach (libdebug.Process process in ps4.GetProcessList().processes)
            {
                if (process.name == "eboot.bin")
                {
                    attachedProcess = process;
                    foundProcess = true;
                    break;
                }
            }
            if (!foundProcess)
            {
                connectionStatusLabel.Text = "Process Not Found";
                connectionStatusLabel.ForeColor = Color.Red;
                return;
            }
            connectionStatusLabel.Text = "Connected + Attached";
            connectionStatusLabel.ForeColor = Color.Green;
            browseCompiledGscFileButton.Enabled = true;
            ps4.Notify(222, "Connected to DizzRL's BO3 GSC Injector!");
        }

        private void browseGscFolderButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    gscProjectFolderTextBox.Text = fbd.SelectedPath;
                }
            }
        }

        private void browseOutputPathButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Compiled GSC Files (*.gscc)|*.gscc";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                compiledGscFileOutputTextBox.Text = saveFileDialog.FileName;
            }
        }

        private void compileGscProjectButton_Click(object sender, EventArgs e)
        {
            if (gscProjectFolderTextBox.Text == "" || compiledGscOutputLabel.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please select a gsc project folder and a location to save the compiled GSC file.", "Fill Out All Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<string> conditionalSymbols = new List<string>();

            if (File.Exists("gsc.conf"))
            {
                foreach (string line in File.ReadAllLines("gsc.conf"))
                {
                    if (line.Trim().StartsWith("#")) continue;
                    var split = line.Trim().Split('=');
                    if (split.Length < 2) continue;
                    switch (split[0].ToLower().Trim())
                    {
                        case "symbols":
                            foreach (string token in split[1].Trim().Split(','))
                            {
                                conditionalSymbols.Add(token);
                            }
                            break;
                    }
                }
            }
            string source = "";
            CompiledCode code;
            List<SourceTokenDef> sourceTokens = new List<SourceTokenDef>();
            StringBuilder sb = new StringBuilder();
            int currentLineCount = 0;
            int currentCharCount = 0;
            foreach (string file in Directory.EnumerateFiles(gscProjectFolderTextBox.Text, "*.gsc", SearchOption.AllDirectories).Where(x => x.EndsWith(".gsc", StringComparison.CurrentCultureIgnoreCase)))
            {
                var CurrentSource = new SourceTokenDef();
                CurrentSource.FilePath = file.Replace(gscProjectFolderTextBox.Text, "").Substring(1).Replace("\\", "/");
                CurrentSource.LineStart = currentLineCount;
                CurrentSource.CharStart = currentCharCount;
                foreach (var line in File.ReadAllLines(file))
                {
                    CurrentSource.LineMappings[currentLineCount] = (currentCharCount, currentCharCount + line.Length + 1);
                    sb.Append(line);
                    sb.Append("\n");
                    currentLineCount += 1;
                    currentCharCount += line.Length + 1;
                }
                CurrentSource.LineEnd = currentLineCount;
                CurrentSource.CharEnd = currentCharCount;
                sourceTokens.Add(CurrentSource);
                sb.Append("\n");
            }
            source = sb.ToString();
            var ppc = new ConditionalBlocks();
            conditionalSymbols.Add("BO3");
            ppc.LoadConditionalTokens(conditionalSymbols);

            try
            {
                source = ppc.ParseSource(source);
            }
            catch (CBSyntaxException error)
            {
                int errorCharPos = error.ErrorPosition;
                int numLineBreaks = 0;
                foreach (var stok in sourceTokens)
                {
                    do
                    {
                        if (errorCharPos < stok.CharStart || errorCharPos > stok.CharEnd)
                        {
                            break;
                        }
                        errorCharPos -= numLineBreaks;
                        foreach (var line in stok.LineMappings)
                        {
                            var constraints = line.Value;
                            if (errorCharPos < constraints.CStart || errorCharPos > constraints.CEnd)
                            {
                                continue;
                            }
                            MetroFramework.MetroMessageBox.Show(this, $"There was an error compiling your GSC Project\n{error.Message} in scripts/{stok.FilePath} at line {line.Key - stok.LineStart}, position {errorCharPos - constraints.CStart}", "Compiler Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    while (false);
                    numLineBreaks++;
                }
                MetroFramework.MetroMessageBox.Show(this, "There was an error compiling your GSC Project.", "Compiler Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            code = Compiler.Compile(false, source);
            if (code.Error != null && code.Error.Length > 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "There was an error compiling your GSC Project.", "Compiler Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            File.WriteAllBytes(compiledGscFileOutputTextBox.Text, code.CompiledScript);
            MetroFramework.MetroMessageBox.Show(this, $"Your compiled gsc file has been exported to {compiledGscFileOutputTextBox.Text}! Enjoy :)", "Compile Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void browseCompiledGscFileButton_Click(object sender, EventArgs e)
        {
            using (var fd = new OpenFileDialog())
            {
                fd.Filter = "Compiled GSC FIles (*.gscc)|*.gscc";
                DialogResult result = fd.ShowDialog();
                compiledGscFileTextBox.Text = fd.FileName;
            }
        }

        private void injectGscButton_Click(object sender, EventArgs e)
        {
            if (ps4 == null || attachedProcess == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Make sure to connect your PS4 with Black Ops 3 running.", "Not Connected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (compiledGscFileTextBox.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please select a compiled GSC file to inject (.gscc)", "Select Compiled GSCC File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            byte[] buffer = null;
            try
            {
                buffer = File.ReadAllBytes(compiledGscFileTextBox.Text);
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "Could not read compiled gsc file, make sure it still exists.", "Couldn't Read File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ulong dupGscAddress = (ulong)selectedGameVersion;
            var filePointerAddress = ps4.ReadMemory<ulong>(attachedProcess.pid, dupGscAddress + 0x10);
            int checksum = ps4.ReadMemory<int>(attachedProcess.pid, filePointerAddress + 0x8);
            BitConverter.GetBytes(checksum).CopyTo(buffer, 0x8);
            var newGscFileAddress = ps4.AllocateMemory(attachedProcess.pid, buffer.Length);
            ps4.WriteMemory(attachedProcess.pid, newGscFileAddress, buffer);
            ps4.WriteMemory(attachedProcess.pid, dupGscAddress + 0x10, newGscFileAddress);
            ps4.Notify(222, "GSC Script injected!");
        }

        private void connectPS4Button_EnabledChanged(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(211, 211, 211);
        }

        private void oneThreeThreeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                selectedGameVersion = Enums.GameVersion.OneThreeThree;
            }
        }

        private void oneTwoSixRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                selectedGameVersion = Enums.GameVersion.OneTwoSix;
            }
        }

        private void fiveOFiveRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
                updateConsoleVersion(Enums.ConsoleVersion.fiveOFive);

        }

        private void sixSevenTwoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
                updateConsoleVersion(Enums.ConsoleVersion.sixSevenTwo);
        }

        private void sevenOTwoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
                updateConsoleVersion(Enums.ConsoleVersion.sevenOTwo);
        }

        private void sevenFiveFiveRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
                updateConsoleVersion(Enums.ConsoleVersion.sevenFiveFive);
        }

        private void updateConsoleVersion(Enums.ConsoleVersion consoleVersion)
        {
            Properties.Settings.Default.ps4Version = (int)consoleVersion;
            Properties.Settings.Default.Save();
            this.selectedConsoleVersion = consoleVersion;
        }
    }
}
