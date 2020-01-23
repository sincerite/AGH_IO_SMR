using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace IO_Project.Hash
{
    class GraphChange
    {
        public static string gitParams = "diff --name-only HEAD~1 HEAD";

        public static List<string> GraphChanges(string workingDir)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("git", "diff --name-only HEAD~1 HEAD")
            {
                WorkingDirectory = workingDir,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            var process = Process.Start(processStartInfo);
            process.WaitForExit();
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            var exitCode = process.ExitCode;
            process.Close();

            string[] pathToChanges = output.Split('\n');
            List<string> lst = pathToChanges.OfType<string>().ToList();

            return lst;
        }


    }
}
