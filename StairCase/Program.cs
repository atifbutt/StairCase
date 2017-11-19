using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StairCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            BuildStair(input);

            Console.ReadKey();
        }

        private static void BuildStair(int input)
        {
                string spaceString = "";
                string hashString = "#";
                string[] Stairs = new string[input];

                for (int i = input - 1; i > 0; i--)
                {
                    spaceString += " ";
                }

            for (int i = 0; i < input; i++)
            {
                Stairs[i] = string.Concat(spaceString, hashString);
                if (spaceString.Length > 0) spaceString = spaceString.Remove(spaceString.Length - 1);

                hashString += "#";
            }

            foreach (var s in Stairs) Console.WriteLine(s);
        }
    }
}
