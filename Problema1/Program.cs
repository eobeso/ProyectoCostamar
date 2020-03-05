using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problema 1");

            string s = Console.ReadLine();
            //string s = args[0];
            Console.WriteLine(new clsCadenasRepertidas().build(s));
            Console.ReadKey();
        }
    }
}
