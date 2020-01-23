using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IO_Project.Core;
using IO_Project.Core.Analysis;
using IO_Project.Graph;
using IO_Project.Input;
using IO_Project.Tools;

namespace IO_Project.UI
{
    public partial class MainForm : Form
    {
        private GraphDrawer _graphDrawer;
        private SourceSemanticAnalyzer _analyzer;
        private List<InputFile> _inputFiles;

        public MainForm()
        {
            InitializeComponent();
            gViewer1.CurrentLayoutMethod = LayoutMethod.MDS;
            _graphDrawer = new GraphDrawer(gViewer1);
            _analyzer = new SourceSemanticAnalyzer();
        }

        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            AnalyzeFiles();
        }


        private void BtShowGraphTestForm_Click(object sender, EventArgs e)
        {
            new GraphTestForm().Show();
        }

        private void BtShowCoreTestForm_Click(object sender, EventArgs e)
        {
            new CoreTestForm().Show();
        }

        private void BtShowInputTestForm_Click(object sender, EventArgs e)
        {
            new InputTestForm().Show();
        }

        private void BtShowToolsTestForm_Click(object sender, EventArgs e)
        {
            new ToolsTestForm().Show();
        }

        private void gViewer1_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void inButton_Click(object sender, EventArgs e)//load file button
        {

            using (var form = new InputTestForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _inputFiles = form.InputFiles;
                }
            }
            if (_inputFiles != null)
            {
                btAnalyze.Enabled = true;
                OnInputFileLoaded();
            }
        }

        private void OnInputFileLoaded()
        {
            label4.Text = "Project loaded successfully!\n" + "Source files count: " + _inputFiles.Count.ToString() + "\n"+ ShowGitCurrentComit("bubu")+ "\n"+ShowGitRepository(true);
        }

        private void AnalyzeFiles()
        {
            if (_inputFiles == null) return;
            var result = _analyzer.Analyze(_inputFiles);
            _graphDrawer.filesToFiles = chbFirstStory.Checked;
            _graphDrawer.methodsToMethods = chbSecondStory.Checked;
            _graphDrawer.methodsToNamespaces = chbThirdStory.Checked;
            _graphDrawer.methodsToFiles = chbSixthStory.Checked;

            _graphDrawer.GenerateGraphForSourceAnalysis(result);
        }

        private void chbFirstStory_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFirstStory.Checked)
            {
                _graphDrawer.filesToFiles = true;
                _graphDrawer.methodsToFiles = false;
                chbSecondStory.Checked = false;
                _graphDrawer.methodsToMethods = false;
                chbThirdStory.Checked = false;
                _graphDrawer.methodsToNamespaces = false;
                chbSixthStory.Checked = false;
            }
        }

        private void chbSecondStory_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSecondStory.Checked)
            {
                _graphDrawer.methodsToMethods = true;
                _graphDrawer.filesToFiles = false;
                chbFirstStory.Checked = false;
            }
        }

        private void chbThirdStory_CheckedChanged(object sender, EventArgs e)
        {
            if (chbThirdStory.Checked)
            {
                _graphDrawer.methodsToNamespaces = true;
                _graphDrawer.filesToFiles = false;
                chbFirstStory.Checked = false;
            }
        }

        private void chbSixthStory_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSixthStory.Checked)
            {
                _graphDrawer.methodsToFiles = true;
                _graphDrawer.filesToFiles = false;
                chbFirstStory.Checked = false;
            }
        }

        private string ShowGitCurrentComit(string data)
        {
            return "Git current commit: " + data;
        }
        private string ShowGitRepository(bool data)
        {
            string status;
            if (data)
            {
                status = "Found";
            }
            else status = "Not found";


            return "Git repository: " + status;
        }
            

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}