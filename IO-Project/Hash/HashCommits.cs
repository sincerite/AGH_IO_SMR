using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Project.Hash
{
    class HashCommits
    {
        public string acctualCommitHash;
        public string fileName = "C:/Program Files/Git/git-bash.exe";
        public string command = "git rev-parse Head";
        public string workingDir = "C:/Users/user/source/repos/Sincerite/AGH_IO_SMR";


        public static void ExecuteGitBashCommand(string fileName, string command, string workingDir)
        {

            ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName, "-c \" " + command + " \"")
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
        }
    }
}
