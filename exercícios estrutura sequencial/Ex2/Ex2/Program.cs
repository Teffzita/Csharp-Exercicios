using System;

namespace Ex2
{
    internal class Program {
        static void Main(string[] args) {
            
            double R, A, pi = 3.14159;

            R = double.Parse(Console.ReadLine());

            A = pi * R * R;

            Console.WriteLine("A="+A.ToString("F4"));
        }
    }
}