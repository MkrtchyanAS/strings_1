using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] separator = { ' ' };
            string[] arr = s.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            char[] symb = new char[arr.Length];
            Array.Sort(arr);
            s = String.Join(" ", arr);
            Console.WriteLine(s);
        }
    }
}
