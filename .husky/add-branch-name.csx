using System.Diagnostics;
using Internal;

var proc = new Process
{
    StartInfo = new ProcessStartInfo
    {
        FileName = "git",
        Arguments = "symbolic-ref --short HEAD",
        UseShellExecute = false,
        RedirectStandardOutput = true,
        CreateNoWindow = true
    }
};

proc.Start();
proc.WaitForExit();
if (proc.ExitCode != 0)
{
    return proc.ExitCode.ToString();
}
var branch = proc.StandardOutput.ReadToEnd();
var file = Args[0];

if (File.Exists(file))
{
    var content = File.ReadAllText(file);
    File.WriteAllText(file, $"{branch.Trim()} " + content );
}