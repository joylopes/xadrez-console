using System;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    public class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.SelecionarPeca(i, j) == null)
                    {
                        Console.Write("- ");
                        continue;
                    }

                    Console.Write($"{tab.SelecionarPeca(i, j)} ");
                }

                Console.WriteLine();
            }
        }
    }
}
