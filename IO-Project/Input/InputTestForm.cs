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
        string pathSource = @"C:\dev\mesfem\mesfem\FEM\UniversalElement.cs";

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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);

            var newInputFile = new InputFile();
            newInputFile.filename = Path.GetFileName(openFileDialog1.FileName);
            newInputFile.path = openFileDialog1.FileName;
            newInputFile.content = File.ReadAllText(openFileDialog1.FileName);
            newInputFile.size = 0;
            inputFiles.Add(newInputFile);

            listBox1.Items.Add(newInputFile.path);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = inputFiles[listBox1.SelectedIndex].content;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0) // unselected = -1
            {
                MessageBox.Show(inputFiles[listBox1.SelectedIndex].ToString(), "File Info");
            }
        }
    }
}
