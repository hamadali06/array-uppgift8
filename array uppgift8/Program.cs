using System;

namespace Inlamning
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = { 1234, 5678, 9101, 1121, 3141 };
            foreach (int t in tal)
            {
                string strTal = t.ToString();
                foreach (char c in strTal)
                {
                    Console.WriteLine(c);
                    Thread.Sleep(500);
                }
                Thread.Sleep(1000);
            }
        }
    }
}
