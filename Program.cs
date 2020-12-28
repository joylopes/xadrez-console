using System;
using xadrez;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                tabuleiro.InserirPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
                tabuleiro.InserirPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 7));
                tabuleiro.InserirPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(2, 4));


                Tela.ImprimirTabuleiro(tabuleiro);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        } 

    }
}
