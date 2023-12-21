using System;
using System.Linq;

namespace ConsoleApplication1
{
    internal class Program
    {
       
        public static void Main(string[] args)
        {
            Hello hello = new Hello();
            String input = "gufytfy,cfty,cfnycfybtydr";
            while (input!="exit")
            {
                Console.WriteLine(hello.getHelloMessage());
                input = Console.ReadLine();
            }
            Console.WriteLine("ORVOIR !");
        }
    }
}