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
        public static string acctualCommitHash;
        public static string gitParams = "rev-parse Head";
        
        public static string ExecuteGitBashCommand(string workingDir)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("git", "rev-parse Head")
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

            acctualCommitHash = output;

            return acctualCommitHash;
        }
    }
}