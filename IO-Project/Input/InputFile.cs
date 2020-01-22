using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Project.Input
{
    public class InputFile
    {
        public string Filename;
        public string AbsolutePath;
        public string RelativePath;
        public string Content;
        public long Size;

        public override string ToString()
        {
            return $"Filename: {Filename} \n" +
                   $"Absolute path: {AbsolutePath} \n" +
                   $"Relative path: {RelativePath} \n" +
                   $"Size: {Size} \n";
        }
    }
}
