using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RARJoiner{

    public partial class rarBinder : Form {

        string rarFileName = null;
        string baseFileName = null;

        public rarBinder() {
            InitializeComponent();
        }

        private void rarJoiner_Load(object sender, EventArgs e) {

        }

        private void buttonRarFile_Click(object sender, EventArgs e) {
            rarFileDialog.Filter = "Rar Files (*.rar) | *.rar";
            rarFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            rarFileDialog.FileName = "";
            DialogResult result = rarFileDialog.ShowDialog();
            if (result == DialogResult.OK) {
                rarFileName = rarFileDialog.FileName;
                textBoxRarLoc.Text = rarFileName;
            }
        }

        private void buttonBaseFile_Click(object sender, EventArgs e) {
            baseFileDialog.Filter = "All Files (*.*) | *.*";
            baseFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            baseFileDialog.FileName = "";
            DialogResult result = baseFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                baseFileName = baseFileDialog.FileName;
                textBoxBaseLoc.Text = baseFileName;
            }
        }

        private void buttonGo_Click(object sender, EventArgs e){
            System.Diagnostics.Process cmdProcess = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo cmdProcessInfo = new System.Diagnostics.ProcessStartInfo();
            cmdProcessInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            cmdProcessInfo.FileName = "cmd.exe";

            string resultFileLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + textBoxResultLoc.Text;
            string arguments = "/C Copy /b [baseFile] + [rarFile] [resultFile]".Replace("[baseFile]", baseFileName).Replace("[rarFile]", rarFileName).Replace("[newFile]", resultFileLocation);
            cmdProcessInfo.Arguments = arguments;
            cmdProcess.StartInfo = cmdProcessInfo;
            cmdProcess.Start();

            MessageBox.Show("Result file saved to " + resultFileLocation + "!", "RARBinder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void githubOpen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/XeliteXirish/RARBinder");
        }
    }
}
