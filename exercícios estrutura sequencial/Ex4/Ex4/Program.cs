using System;

namespace Ex4
{
    internal class Program {
        static void Main(string[] args) {
            double Nro, HrsT, VlrH, Sal;

            Console.Write("Digite o número do funcionário: ");
            Nro = double.Parse(Console.ReadLine());
            Console.Write("Digite o número de horas trabalhadas: ");
            HrsT = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da hora trabalhada: $");
            VlrH = double.Parse(Console.ReadLine());

            Sal = HrsT * VlrH;

            Console.WriteLine("Número: " + Nro);
            Console.WriteLine("Salário: $" + Sal.ToString("F2"));
        }
    }
}