using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO_Project.Core.Analysis.Models;
using Microsoft.Msagl.GraphViewerGdi;

namespace IO_Project.Graph
{
    class GraphDrawer
    {
        private GViewer _gViewer;

        public GraphDrawer(GViewer gViewer)
        {
            _gViewer = gViewer;
        }

        public void GenerateGraphForSourceAnalysis(SourceAnalysisModel model)
        { 
        
        }

    }
}
