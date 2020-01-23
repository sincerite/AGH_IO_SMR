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
            foreach (var file in _mainModel.Files.Values)
            {
                foreach (var method in file.Methods)
                {
                    DrawingNode tmpNode = new DrawingNode(method.Name);
                    //tmpNode.LabelText = ;   //DODAC LABEL
                    graph2.AddNode(tmpNode);
                }
            }
            if (methodsToNamespaces)
            {
                foreach (var namesp in _mainModel.Namespaces.Values)
                {
                    DrawingNode tmpNode = new DrawingNode(namesp.FullName);
                    tmpNode.LabelText = namesp.Files.Count + "";
                    graph2.AddNode(tmpNode);
                }
            }
            if (methodsToFiles)
            {
                foreach (var file in _mainModel.Files.Values)
                {
                    DrawingNode tmpNode = new DrawingNode(file.Filename);
                    tmpNode.LabelText = file.Size + "";
                    graph2.AddNode(tmpNode);
                }
            }
            foreach (var file in _mainModel.Files.Values)
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


                    if (methodsToNamespaces)
                    {
                        foreach (var namesp in _mainModel.Namespaces.Values)
                        {
                            foreach (var rNamesp in namesp.NamespacesRelationsByMethodReferences)
                            {
                                graph2.AddEdge(method.Name, rNamesp.ReferencesCount + "", rNamesp.Reference.FullName);
                            }
                        }
                    }
                    if (methodsToFiles)
                    {
                        graph2.AddEdge(method.Name, null, file.Filename);
                    }

                }
            }
            _gViewer.Graph = graph2;
        }
        public void GenerateFilesGraph()
        {
            graph1 = new Microsoft.Msagl.Drawing.Graph();
            foreach (var file in _mainModel.Files.Values)
            {
                DrawingNode tmpNode = new DrawingNode(file.Filename);
                tmpNode.LabelText = file.Filename + " " + file.Size;
                graph1.AddNode(tmpNode);
                foreach (var rFile in file.FileRelationsByClassReferences.Values)
                {
                    //DrawingEdge tmpEdge = new DrawingEdge(tmpNode.Id, rFile.ReferencesCount+"", rFile.Reference.Filename);
                    graph1.AddEdge(tmpNode.Id, rFile.ReferencesCount + "", rFile.Reference.Filename);
                }
            }
            _gViewer.Graph = graph1;
        }
    }
}