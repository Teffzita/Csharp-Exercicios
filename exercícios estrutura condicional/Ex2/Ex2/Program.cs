using System;

namespace Ex2
{
    internal class Program {
        static void Main(string[] args) {
            int N;

            Console.Write("Digite um número: ");
            N=int.Parse(Console.ReadLine());

            if (N % 2 == 0) {
                Console.WriteLine("PAR");
            }
            else {
                Console.WriteLine("ÍMPAR");
            }
        }
    }
}