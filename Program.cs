using System;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            var posicaoXadrez = new PosicaoXadrez('c', 7);

            Console.WriteLine(posicaoXadrez);
            Console.WriteLine(posicaoXadrez.toPosicao());

            Console.ReadLine();
        }

    }
}
