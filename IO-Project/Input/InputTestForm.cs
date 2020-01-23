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
using IO_Project.Core.Analysis;
using IO_Project.Utils;
using Console = System.Console;

namespace IO_Project.Input
{
    public partial class InputTestForm : Form
    {
        public InputFormController formController;

        public InputTestForm()
        {
            formController = new InputFormController();

            InitializeComponent();
        }

        private void AddNewInputFile(string path)
        {
            var newInputFile = new InputFile();
            newInputFile.Filename = Path.GetFileName(path);
            newInputFile.AbsolutePath = path;
            newInputFile.RelativePath = Util.GetRelativePath(path, formController.rootPath);
            newInputFile.Content = File.ReadAllText(path);
            newInputFile.Size = new System.IO.FileInfo(path).Length;

            formController.InputFiles.Add(newInputFile);
            lbInputFiles.Items.Add(newInputFile.RelativePath);
        }

        private void SetRootPath(string path)
        {
            formController.rootPath = path;
            tbProjectPath.Text = path;
        }

        private void SetPath(string path)
        {
            SetRootPath(path);
            ClearForm();

            foreach (string filePath in Directory
                .EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
                .Where(filePath => filePath.ToLower().EndsWith("cs")))
            {
                AddNewInputFile(filePath);
            }

            if (formController.InputFiles.Count > 0)
            {
                btAcceptFiles.Enabled = true;
            }
        }

        private void ClearForm()
        {
            formController.InputFiles.Clear();
            lbInputFiles.Items.Clear();
        }

        private void btAddSingleFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select a valid C# class file";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            AddNewInputFile(openFileDialog1.FileName);
        }

        private void lbInputFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbInputFiles.SelectedIndex != -1)
            {
                rtbFileContent.Text = formController.InputFiles[lbInputFiles.SelectedIndex].Content;
            }
        }

        private void lbInputFiles_DoubleClick(object sender, EventArgs e)
        {
            if (lbInputFiles.SelectedIndex >= 0) // unselected = -1
            {
                MessageBox.Show(formController.InputFiles[lbInputFiles.SelectedIndex].ToString(), "File Info");
            }
        }

        private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btOpenFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                SetRootPath(folderBrowserDialog1.SelectedPath);
                SetPath(folderBrowserDialog1.SelectedPath);
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btSethPath_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(tbProjectPath.Text))
            {
                Console.WriteLine("true");

                SetPath(tbProjectPath.Text);
            }
        }

        private void btDetermineRootPath_Click(object sender, EventArgs e)
        {
            SetRootPath(formController.DetermineRootPath());

            lbInputFiles.Items.Clear();
            foreach (var file in formController.InputFiles)
            {
                file.RelativePath = Util.GetRelativePath(file.AbsolutePath, formController.rootPath);
                lbInputFiles.Items.Add(file.RelativePath);
            }
        }

        private void btRemoveFile_Click(object sender, EventArgs e)
        {
            formController.InputFiles.RemoveAt(lbInputFiles.SelectedIndex);
            lbInputFiles.Items.RemoveAt(lbInputFiles.SelectedIndex);
        }


        private void BtAcceptFiles_Click(object sender, EventArgs e)
        {
            if (formController.InputFiles.Count > 0) {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
