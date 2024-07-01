using System;

namespace Ex6
{
    internal class Program {
        static void Main(string[] args) {
            double A, B, C, atri, acir, atra, aqua, aret;

            Console.Write("Digite o valor 1: ");
            A=double.Parse(Console.ReadLine());
            Console.Write("Digite o valor 2: ");
            B = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor 1: ");
            C = double.Parse(Console.ReadLine());

            atri = (A * C) / 2;
            acir = 3.14159 * C * C;
            atra = (A + B) / 2 * C;
            aqua = B * B;
            aret = A * B;

            Console.WriteLine("Áreas:");
            Console.WriteLine("Triângulo: " + atri.ToString("F3"));
            Console.WriteLine("Círculo: " + acir.ToString("F3"));
            Console.WriteLine("Trapézio: " + atra.ToString("F3"));
            Console.WriteLine("Quadrado: " + aqua.ToString("F3"));
            Console.WriteLine("Retângulo: " + aret.ToString("F3"));
        }
    }
}