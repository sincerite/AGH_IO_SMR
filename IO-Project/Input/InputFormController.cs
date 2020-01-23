using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Project.Input
{
    public class InputFormController
    {
        public string rootPath;

        public List<InputFile> InputFiles = new List<InputFile>();


        public string DetermineRootPath()
        {
            int k = InputFiles[0].AbsolutePath.Length;
            for (int i = 1; i < InputFiles.Count; i++)
            {
                k = Math.Min(k, InputFiles[i].AbsolutePath.Length);
                for (int j = 0; j < k; j++)
                    if (InputFiles[i].AbsolutePath[j] != InputFiles[0].AbsolutePath[j])
                    {
                        k = j;
                        break;
                    }
            }
            return InputFiles[0].AbsolutePath.Substring(0, k);
        }
    }
}
