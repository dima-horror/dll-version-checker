using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DllChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0 || String.IsNullOrEmpty(args[0]))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please, pass path to dll as parameter");
                Console.ResetColor();
                return;
            }
            Assembly assembly = Assembly.LoadFrom(args[0]);
            Version ver = assembly.GetName().Version;
            Console.WriteLine(ver?.ToString());
        }
    }
}
