using System;
using System.IO;
using System.Linq;

namespace LinWin.terminal_apps.ls
{
    internal class Ls
    {
        public static void LsCommand(string[] args)
        {
            string directoryPath = "."; // Default to current directory
            bool showHidden = false;

            // Parse arguments
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "-a")
                {
                    showHidden = true;
                }
                else if (Directory.Exists(args[i]))
                {
                    directoryPath = args[i];
                }
            }

            string[] files = Directory.GetFiles(directoryPath);

            foreach (string file in files)
            {
                FileAttributes attributes = File.GetAttributes(file);
                if (!attributes.HasFlag(FileAttributes.System) || showHidden)
                {
                    Console.WriteLine(file);
                }
            }
        }
    }
}