using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinWin.terminal_apps.help
{
    internal class Help
    {
        public static void HelpCommand() 
        {
            Console.WriteLine("LinWin Help");
            Console.WriteLine("===========");
            Console.WriteLine("help - Shows this help screen.");
            Console.WriteLine("ls {PATH} {OPTIONS} - Displays the current directory.");
            Console.WriteLine("");
            Console.WriteLine("Windows Alternatives");
            Console.WriteLine("====================");
            Console.WriteLine("dir - Displays the current directory.");
            Console.WriteLine("help - Shows all Windows commands.");
        }
    }
}
