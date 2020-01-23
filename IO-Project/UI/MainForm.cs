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

namespace IO_Project.UI {
    public partial class MainForm : Form {
        private GraphDrawer _graphDrawer;
        private SourceSemanticAnalyzer _analyzer;
        private List<InputFile> _inputFiles;

        public MainForm() {
            InitializeComponent();
            _graphDrawer = new GraphDrawer(gViewer1);
            _analyzer = new SourceSemanticAnalyzer();
        }

        private void Button1_Click(object sender, EventArgs e) {
            AnalyzeFiles();
        }

        private void BtShowGraphTestForm_Click(object sender, EventArgs e) {
            new GraphTestForm().Show();
        }

        private void BtShowCoreTestForm_Click(object sender, EventArgs e) {
            new CoreTestForm().Show();
        }

        private void BtShowInputTestForm_Click(object sender, EventArgs e) {
            new InputTestForm().Show();
        }

        private void BtShowToolsTestForm_Click(object sender, EventArgs e) {
            new ToolsTestForm().Show();
        }

        private void gViewer1_Load(object sender, EventArgs e) {
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {
        }

        private void label1_Click(object sender, EventArgs e) {
        }

        private void inButton_Click(object sender, EventArgs e) {
            using (var form = new InputTestForm()) {
                var result = form.ShowDialog();
                if (result == DialogResult.OK) {
                    _inputFiles = form.InputFiles;
                    OnInputFileLoaded();
                }
            }
        }

        private void OnInputFileLoaded() {
            //...
        }

        private void AnalyzeFiles() {
            if(_inputFiles == null) return;
            var result = _analyzer.Analyze(_inputFiles);
            _graphDrawer.filesToFiles = true; //todo: checkboxy!
            _graphDrawer.GenerateGraphForSourceAnalysis(result);
        }
    }
}