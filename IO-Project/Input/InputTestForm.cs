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
using Console = System.Console;

namespace IO_Project.Input
{
    public partial class InputTestForm : Form
    {
        // string pathSource = @"C:\dev\mesfem\mesfem\FEM\UniversalElement.cs";

        private string rootPath;

        List<InputFile> inputFiles = new List<InputFile>();

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

            inputFiles.Add(newInputFile);
            listBox1.Items.Add(newInputFile.RelativePath);
        }

        private void SetRootPath(string path)
        {
            this.rootPath = path;
            textBox1.Text = path;
        }

        private string DetermineRootPath()
        {
            int k = inputFiles[0].AbsolutePath.Length;
            for (int i = 1; i < inputFiles.Count; i++)
            {
                k = Math.Min(k, inputFiles[i].AbsolutePath.Length);
                for (int j = 0; j < k; j++)
                    if (inputFiles[i].AbsolutePath[j] != inputFiles[0].AbsolutePath[j])
                    {
                        k = j;
                        break;
                    }
            }
            return inputFiles[0].AbsolutePath.Substring(0, k);
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
            if (listBox1.SelectedIndex != -1)
            {
                richTextBox1.Text = inputFiles[listBox1.SelectedIndex].Content;
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0) // unselected = -1
            {
                MessageBox.Show(inputFiles[listBox1.SelectedIndex].ToString(), "File Info");
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
            inputFiles.Clear();
            listBox1.Items.Clear();

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

            listBox1.Items.Clear();
            foreach (var file in inputFiles)
            {
                file.RelativePath = GetRelativePath(file.AbsolutePath, rootPath);
                listBox1.Items.Add(file.RelativePath);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            inputFiles.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
