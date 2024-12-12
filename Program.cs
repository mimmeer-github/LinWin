using System;
using System.Diagnostics;
using LinWin.terminal_apps.ls;
using LinWin.terminal_apps.help;

namespace LinWinTerminal
{
    class LinWin
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command;

                if (args.Length > 0)
                {
                    command = args[0];
                    args = args.Skip(1).ToArray(); // Remove the first argument
                }
                else
                {
                    Console.Write("> ");
                    command = Console.ReadLine();
                }

                string[] parts = command.Split(' ');
                string commandName = parts[0];
                string[] commandArgs = parts.Skip(1).ToArray();

                if (commandName == "exit")
                {
                    break;
                }
                else if (commandName == "ls")
                {
                    Ls.LsCommand(commandArgs);
                }
                else if (commandName == "help")
                {
                    Help.HelpCommand();
                }
                else if (commandName == "argtest")
                {
                    foreach (string arg in commandArgs)
                    {
                        Console.WriteLine(arg);
                    }
                }
                else
                {
                    Console.WriteLine("Unknown command.");
                }
            }
        }
    }
}