using System;

namespace Ex3
{
    internal class Program {
        static void Main(string[] args) {
            int A, B;

            Console.WriteLine("Digite 2 números:");
            A=int.Parse(Console.ReadLine());
            B=int.Parse(Console.ReadLine());

            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("São múltiplos.");
            }
            else {
                Console.WriteLine("Não são múltiplos.");
            }
        }
    }
}