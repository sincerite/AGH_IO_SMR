using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO_Project.Core.Analysis.Models;
using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.GraphViewerGdi;
using DrawingEdge = Microsoft.Msagl.Drawing.Edge;
using DrawingNode = Microsoft.Msagl.Drawing.Node;
namespace IO_Project.Graph
{
    class GraphDrawer
    {
        private GViewer _gViewer;
        private SourceAnalysisModel _mainModel;
        public bool methodsToMethods, methodsToNamespaces, methodsToFiles, filesToFiles;
        private Microsoft.Msagl.Drawing.Graph graph1, graph2;
        public GraphDrawer(GViewer gViewer)
        {
            _gViewer = gViewer;
        }
        public void GenerateGraphForSourceAnalysis(SourceAnalysisModel model)
        {
            _mainModel = model;
            if (filesToFiles == true) GenerateFilesGraph();
            else if (methodsToMethods || methodsToNamespaces || methodsToFiles) GenerateMethodsGraph();
        }
        public void GenerateMethodsGraph()
        {
            foreach (var file in _mainModel.Files)
            {
                foreach (var method in file.Methods)
                {
                    DrawingNode tmpNode = new DrawingNode(method.Name);
                    tmpNode.LabelText = ;   //DODAC LABEL
                    graph2.AddNode(tmpNode);
                }
            }

            foreach (var file in _mainModel.Files)
            {
                foreach (var method in file.Methods)
                {
                    if (methodsToMethods)
                    {
                        foreach (var rMethod in method.MethodRelationsByMethodInvocations)
                        {
                            graph2.AddEdge(method.Name, rMethod.ReferencesCount + "", rMethod.Reference.Name);
                        }
                    }

                  


                }
            }
        }
        public void GenerateFilesGraph()
        {
            graph1 = new Microsoft.Msagl.Drawing.Graph();
            foreach (var file in _mainModel.Files)
            {
                DrawingNode tmpNode = new DrawingNode(file.Filename);
                tmpNode.LabelText = file.Filename + " " + file.Size;
                graph1.AddNode(tmpNode);
                foreach (var rFile in file.FileRelationsByClassReferences)
                {
                    //DrawingEdge tmpEdge = new DrawingEdge(tmpNode.Id, rFile.ReferencesCount+"", rFile.Reference.Filename);
                    graph1.AddEdge(tmpNode.Id, rFile.ReferencesCount + "", rFile.Reference.Filename);
                }
            }
            _gViewer.Graph = graph1;
        }
    }
}