using IO_Project.Core.Analysis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Project.Tests
{
    class DataForTest
    {
        public static SourceAnalysisModel CreateAnalysisMock() {
            var model = new SourceAnalysisModel();
            var ns1 = new SourceNamespace
            {
                FullName = "ns1"
            };
            var ns2 = new SourceNamespace
            {
                FullName = "ns2"
            }; 
            var f1 = new SourceFile
            {
                Filename = "filename1",
                Size = 200L,
                Namespace = ns1
            };
            var f2 = new SourceFile
            {
                Filename = "filename2",
                Size = 300L,
                Namespace = ns2
            }; 
            var m1 = new SourceMethod
            {
                Name = "method1",
                ParentFile = f1
            }; 
            var m2 = new SourceMethod
            {
                Name = "method2",
                ParentFile = f2
            }; 
            var r1 = new SourceRelation<SourceFile>();
            r1.Reference = f2;
            r1.ReferencesCount = 3;
            SourceRelation<SourceFile>[] relations = { r1 };
//            f1.FileRelationsByClassReferences = relations.ToList();
            
            
            SourceFile[] files1 = { f1 }; ns1.Files = files1.ToList(); 
            SourceFile[] files2 = { f2 }; ns2.Files = files2.ToList(); SourceFile[] files3 = { f1, f2 }; 
//            model.Files = files3.ToList();
            return model;
        }
    }
}
