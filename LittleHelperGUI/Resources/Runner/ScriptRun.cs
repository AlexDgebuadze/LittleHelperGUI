using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace LittleHelperGUI.Runner
{
    public abstract class ScriptRun
    {
        public static void ExecuteCommand(string command)
        {
            ProcessStartInfo ProcessInfo;
            Process Process;
            ProcessInfo = new ProcessStartInfo("cmd.exe", "/K " + command);
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = true;
            ProcessInfo.Verb = "runas";
            Process = Process.Start(ProcessInfo);

            Process.WaitForExit();
            
        }
        public static void RunMyScriptFile(string file)
        {
            System.Diagnostics.Process.Start(@file);
        }


    }
}
