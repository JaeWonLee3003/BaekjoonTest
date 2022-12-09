using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            // A = (int.Parse(s[0])
            // B = (int.Parse(s[1])
            // C = (int.Parse(s[2])
            string[] s = Console.ReadLine().Split();

            Console.WriteLine((int.Parse(s[0]) + int.Parse(s[1])) % int.Parse(s[2]));
            Console.WriteLine(int.Parse(s[0]) % (int.Parse(s[2])) + int.Parse(s[1]) % (int.Parse(s[2])));
            Console.WriteLine((int.Parse(s[0]) * int.Parse(s[1])) % int.Parse(s[2]));
            Console.WriteLine(int.Parse(s[0]) % (int.Parse(s[2])) * int.Parse(s[1]) % (int.Parse(s[2])));

        }
    }
}