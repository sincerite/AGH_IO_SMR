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
using Console = System.Console;

namespace IO_Project.Input
{
    public partial class InputTestForm : Form
    {
        // string pathSource = @"C:\dev\mesfem\mesfem\FEM\UniversalElement.cs";

        private string rootPath;

        public List<InputFile> InputFiles = new List<InputFile>();

        public InputTestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select a valid C# class file";
            openFileDialog1.ShowDialog();
        }

        private void AddNewInputFile(string path)
        {
            var newInputFile = new InputFile();
            newInputFile.Filename = Path.GetFileName(path);
            newInputFile.AbsolutePath = path;
            newInputFile.RelativePath = GetRelativePath(path, rootPath);
            newInputFile.Content = File.ReadAllText(path);
            newInputFile.Size = 0;

            InputFiles.Add(newInputFile);
            lbInputFiles.Items.Add(newInputFile.RelativePath);
        }

        private void SetRootPath(string path)
        {
            this.rootPath = path;
            tbProjectPath.Text = path;
        }

        private string DetermineRootPath()
        {
            int k = InputFiles[0].AbsolutePath.Length;
            for (int i = 1; i < InputFiles.Count; i++)
            {
                k = Math.Min(k, InputFiles[i].AbsolutePath.Length);
                for (int j = 0; j < k; j++)
                    if (InputFiles[i].AbsolutePath[j] != InputFiles[0].AbsolutePath[j])
                    {
                        k = j;
                        break;
                    }
            }
            return InputFiles[0].AbsolutePath.Substring(0, k);
        }

        string GetRelativePath(string filespec, string folder)
        {
            Uri pathUri = new Uri(filespec);
            // Folders must end in a slash
            if (!folder.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                folder += Path.DirectorySeparatorChar;
            }
            Uri folderUri = new Uri(folder);
            return Uri.UnescapeDataString(folderUri.MakeRelativeUri(pathUri).ToString().Replace('/', Path.DirectorySeparatorChar));
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            AddNewInputFile(openFileDialog1.FileName);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbInputFiles.SelectedIndex != -1)
            {
                rtbFileContent.Text = InputFiles[lbInputFiles.SelectedIndex].Content;
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (lbInputFiles.SelectedIndex >= 0) // unselected = -1
            {
                MessageBox.Show(InputFiles[lbInputFiles.SelectedIndex].ToString(), "File Info");
            }
        }

        private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                SetRootPath(folderBrowserDialog1.SelectedPath);
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            InputFiles.Clear();
            lbInputFiles.Items.Clear();

            foreach (string filePath in Directory
                .EnumerateFiles(folderBrowserDialog1.SelectedPath, "*.*", SearchOption.AllDirectories)
                .Where(filePath => filePath.ToLower().EndsWith("cs")))
            {
                AddNewInputFile(filePath);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetRootPath(DetermineRootPath());

            lbInputFiles.Items.Clear();
            foreach (var file in InputFiles)
            {
                file.RelativePath = GetRelativePath(file.AbsolutePath, rootPath);
                lbInputFiles.Items.Add(file.RelativePath);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            InputFiles.RemoveAt(lbInputFiles.SelectedIndex);
            lbInputFiles.Items.RemoveAt(lbInputFiles.SelectedIndex);
        }

        private void BtAcceptFiles_Click(object sender, EventArgs e)
        {
            if (InputFiles.Count > 0) {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
