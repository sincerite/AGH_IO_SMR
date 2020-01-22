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
using IO_Project.Graph;
using IO_Project.Input;
using IO_Project.Tools;

namespace IO_Project.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hejo hejo :>");
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
    }
}
