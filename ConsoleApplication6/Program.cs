using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] separator = {' '};
            
            string[] arr = s.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            char[] symb = new char[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                symb = arr[i].ToCharArray();
                Array.Reverse(symb);
                Console.Write(arr[i] + " ");
                arr[i] = new string (symb);

            }
            s = String.Join(" ", arr);
            Console.WriteLine();
            Console.WriteLine(s);
            
        }
    }
}
