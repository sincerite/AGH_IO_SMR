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
using IO_Project.Hash;
using IO_Project.Input;
using IO_Project.Tools;
using Microsoft.Msagl.GraphViewerGdi;

namespace IO_Project.UI
{
    public partial class MainForm : Form
    {
        private GraphDrawer _graphDrawer;
        private SourceSemanticAnalyzer _analyzer;
        private List<InputFile> _inputFiles;
        private HashCommits hashCommits;
        private InputFile inputFile;
        private string projectRoot;
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
                    _inputFiles = form.formController.InputFiles;
                    projectRoot= form.formController.rootPath;
                    if (_inputFiles != null)
                    {
                        btAnalyze.Enabled = true;
                        OnInputFileLoaded();
                    }
                }
            }
            
        }

        private void OnInputFileLoaded()
        {
            
            string commit = HashCommits.ExecuteGitBashCommand(projectRoot);
            string status;
            if (string.IsNullOrEmpty(commit))
            {
                status = "Not found";
                commit = "Unknown";
            }
            else
            {
                status = "Found";
            }
            label4.Text = "Project loaded successfully!\n" + "Source files count: " 
                          + _inputFiles.Count.ToString() + "\n" + "Git current commit: " 
                          + commit + "\n" + "Git repository: " + status;
        }

        private void AnalyzeFiles()
        {
            if (_inputFiles == null) return;
            try {
                var changedFilesPaths = GraphChange.GraphChanges(projectRoot);
                var result = _analyzer.Analyze(_inputFiles, changedFilesPaths);
                _graphDrawer.filesToFiles = chbFirstStory.Checked;
                _graphDrawer.methodsToMethods = chbSecondStory.Checked;
                _graphDrawer.methodsToNamespaces = chbThirdStory.Checked;
                _graphDrawer.methodsToFiles = chbSixthStory.Checked;

                _graphDrawer.GenerateGraphForSourceAnalysis(result);
            } catch (Exception e) {
                MessageBox.Show("Parsing error");
            }
            
        }

        private void chbFirstStory_CheckedChanged(object sender, EventArgs e)
        {
                _graphDrawer.filesToFiles = chbFirstStory.Checked; 
                _graphDrawer.RefreshGraph();
        }

        private void chbSecondStory_CheckedChanged(object sender, EventArgs e)
        {
                _graphDrawer.methodsToMethods = chbSecondStory.Checked;
                _graphDrawer.RefreshGraph();
        }

        private void chbThirdStory_CheckedChanged(object sender, EventArgs e)
        {
                _graphDrawer.methodsToNamespaces = chbThirdStory.Checked;
                _graphDrawer.RefreshGraph();
        }

        private void chbSixthStory_CheckedChanged(object sender, EventArgs e)
        {
                _graphDrawer.methodsToFiles = chbSixthStory.Checked;
                _graphDrawer.RefreshGraph();
        }
            

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}