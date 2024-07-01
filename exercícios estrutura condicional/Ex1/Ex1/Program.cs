using System;

namespace Ex1
{
    internal class Program {
        static void Main(string[] args) {
            int N;

            Console.Write("Digite um número: ");
            N=int.Parse(Console.ReadLine());

            if (N >= 0) {
                Console.WriteLine("NÃO NEGATIVO");
            }
            else {
                Console.WriteLine("NEGATIVO");
            }
        }
    }
}