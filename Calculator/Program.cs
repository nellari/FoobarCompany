using Calculator.Operations;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shows usage instructions in case of no parameters
            if (args.Length == 0 || String.IsNullOrEmpty(args[0]))
            {
                Console.WriteLine("Please use 'Interactive' parameter to launch the calculator interactive console or " +
                " a txt file name containing 'arg1' + newline + 'arg2' + newline + 'operator symbol' (valid symbols are )");
            }
            else
            {
                try
                {
                    Console.WriteLine("Result: " + new CalcFactoryImpl().GetCalculator(args[0]).Compute());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
#if DEBUG
            Console.WriteLine("Press any key to exit . . .");
            Console.ReadLine();
#endif 
        }
    }
}
