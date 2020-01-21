using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Project.Input
{
    class InputFile
    {
        public string filename;
        public string path;
        public string content;
        public long size;

        public override string ToString()
        {
            return $"Filename: {filename} \n" +
                   $"Full path: {path} \n" +
                   $"Size: {size} \n";
        }
    }
}
