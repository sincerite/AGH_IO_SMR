using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO_Project.Core.Analysis.Models;
using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using DrawingEdge = Microsoft.Msagl.Drawing.Edge;
using DrawingNode = Microsoft.Msagl.Drawing.Node;

namespace IO_Project.Graph {
    class GraphDrawer {
        private GViewer _gViewer;
        private SourceAnalysisModel _mainModel;
        public bool methodsToMethods, methodsToNamespaces, methodsToFiles, filesToFiles;
        private Microsoft.Msagl.Drawing.Graph graph;
        private Random rnd = new Random();

        public GraphDrawer(GViewer gViewer) {
            _gViewer = gViewer;
        }

        public void GenerateGraphForSourceAnalysis(SourceAnalysisModel model) {
            _mainModel = model;
            DrawGraph();
        }

        public void RefreshGraph() {
            DrawGraph();
        }

        private void DrawGraph() {
            graph = new Microsoft.Msagl.Drawing.Graph();
            if (filesToFiles) GenerateFilesGraph();
            if (methodsToMethods || methodsToNamespaces || methodsToFiles) GenerateMethodsGraph();
            showGraph();
        }

        private void GenerateMethodsGraph() {
            foreach (var file in _mainModel.Files.Values) {
                Color tmpColor=Color.White;
                if (methodsToFiles)
                {
                    DrawingNode tmpNode = new DrawingNode(file.Filename);
                    tmpNode.LabelText = file.RelativePath;
                    tmpNode.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Box;
                    Color newColor = generateColor(tmpNode.Attr.Color);
                    tmpColor = newColor;
                    tmpNode.Attr.FillColor = tmpColor;
                    graph.AddNode(tmpNode);
                }
                foreach (var method in file.Methods)
                {
                    DrawingNode tmpNode = new DrawingNode(method.Name);
                    tmpNode.LabelText = method.Name;
                    tmpNode.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;
                    if (!methodsToFiles && method == file.Methods[0])
                    {
                        Color newColor = generateColor(tmpNode.Attr.Color);
                        tmpColor = newColor;
                    }
                    tmpNode.Attr.FillColor = tmpColor;
                    graph.AddNode(tmpNode);
                }

            }

            if (methodsToNamespaces) {
                foreach (var namesp in _mainModel.Namespaces.Values) {
                    DrawingNode tmpNode = new DrawingNode(namesp.FullName);
                    tmpNode.LabelText = namesp.Files.Count + "";
                    tmpNode.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
                    Color newColor = generateColor(tmpNode.Attr.Color);
                    tmpNode.Attr.FillColor = newColor;
                    graph.AddNode(tmpNode);
                }
            }

            foreach (var file in _mainModel.Files.Values) {
                foreach (var method in file.Methods)
                {
                    if (methodsToMethods)
                    {
                        foreach (var rMethod in method.MethodRelationsByMethodInvocations.Values)
                        {
                            graph.AddEdge(method.Name, rMethod.ReferencesCount + "", rMethod.Reference.Name);
                        }
                    }


                    if (methodsToNamespaces)
                    {
                        foreach (var namesp in _mainModel.Namespaces.Values)
                        {
                            foreach (var rNamesp in namesp.NamespacesRelationsByMethodReferences.Values)
                            {
                                graph.AddEdge(method.Name, rNamesp.ReferencesCount + "",
                                rNamesp.Reference.FullName);
                            }
                        }
                    }

                    if (methodsToFiles)
                    {
                        graph.AddEdge(method.Name, null, file.Filename);
                    }
                }
            }
        }

        private void GenerateFilesGraph() {
            foreach (var file in _mainModel.Files.Values) {
                DrawingNode tmpNode = new DrawingNode(file.Filename);
                tmpNode.LabelText = file.Filename + "\n" + file.Size;
                tmpNode.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Box;
                Color newColor = generateColor(tmpNode.Attr.Color);
                tmpNode.Attr.FillColor = newColor;
                graph.AddNode(tmpNode);
            }

            foreach (var file in _mainModel.Files.Values) {
                    foreach (var rFile in file.FileRelationsByClassReferences.Values)
                    {
                        graph.AddEdge(file.Filename, rFile.ReferencesCount + "", rFile.Reference.Filename);
                    }
            }
        }

        /*public void MergeGraphs(Microsoft.Msagl.Drawing.Graph g1, Microsoft.Msagl.Drawing.Graph g2)
        {
            graph = new Microsoft.Msagl.Drawing.Graph();
            foreach (var node1 in g1.Nodes)
            {
                graph.AddNode(node1);
            }
            foreach (var node2 in g2.Nodes)
            {
                graph.AddNode(node2);
            }
        }*/

        private void showGraph() {
            _gViewer.Graph = graph;
        }
        
        private Color generateColor(Color colorNode)
        {
            int beg = 100;
            int end = 255;
            colorNode.R = byte.Parse(rnd.Next(beg, end) + "");
            colorNode.G = byte.Parse(rnd.Next(beg, end) + "");
            colorNode.B = byte.Parse(rnd.Next(beg, end) + "");
            return colorNode;
        }

    }
}