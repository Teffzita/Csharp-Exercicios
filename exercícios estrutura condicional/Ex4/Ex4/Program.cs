using System;

namespace Ex4
{
    internal class Program {
        static void Main(string[] args) {
            int hIni, hFin, dur;

            Console.Write("Digite a Hora inicial: ");
            hIni=int.Parse(Console.ReadLine());
            Console.Write("Digite a Hora final: ");
            hFin = int.Parse(Console.ReadLine());

            if (hIni < hFin) {
                dur = hFin - hIni;
            }
            else {
                dur = 24 - hIni + hFin;
            }

            Console.WriteLine("O jogo durou " + dur + " Hora(s).");
        }
    }
}