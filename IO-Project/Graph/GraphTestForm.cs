using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = Microsoft.Msagl.Drawing.Color;

namespace IO_Project.Graph
{
    public partial class GraphTestForm : Form
    {
        public GraphTestForm()
        {
            InitializeComponent();
            Microsoft.Msagl.Drawing.Graph g1 = new Microsoft.Msagl.Drawing.Graph("g1");

            g1.AddNode("elo");
            g1.AddNode("gitara");
            g1.AddNode("siema");
            g1.AddEdge("elo", "0", "gitara");
            g1.AddEdge("gitara", "0", "siema");
            Microsoft.Msagl.Drawing.Node n = g1.FindNode("siema");
            n.Attr.FillColor = Color.Blue;

            Microsoft.Msagl.Drawing.Graph g2 = new Microsoft.Msagl.Drawing.Graph("g2");
            foreach (var node in g1.Nodes) g2.AddNode(node);

            gViewer1.Graph = g2;
        }

        private void GraphTestForm_Load(object sender, EventArgs e)
        {

        }

        private void gViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
