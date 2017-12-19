using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слова");
            string s = Console.ReadLine();
            char[] separator = { ' ' };
            string[] arr = s.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i < arr.Length; i++)
            {
                if (IsKeyWord(arr[i]) == true)
                {
                    Console.WriteLine(arr[i]);
                }

            }

            //s = String.Join(" ", arr);
            //Console.WriteLine(s);

        }

        static bool IsKeyWord(string word)
        {
            string[] arr = { "if", "bool", "else", "switch", "static", "using" };
            for (int i = 0; i < arr.Length; i ++)
            {
                if(String.Compare(word, arr[i]) == 0)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
