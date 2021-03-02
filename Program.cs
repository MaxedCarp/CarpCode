using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpCode
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            CarpCode cc = new CarpCode();
            Console.WriteLine("Please type the command the the right arguments:\n" +
                "(\"KeyEncode <code> <key>\" / \"RNDEncode <code>\" / \"KeyEncode+ <code> <key>\")\n" +
                "Note: the key is a string combined from the letters t (text), a (ASCII) and b (basic)\n " +
                "and is as long as your code. KeyEncode+ will copy the result.");
            cc.App(Console.ReadLine());
            Console.WriteLine("Press any key to close the window!");
            Console.ReadKey();
        }
    }
}
