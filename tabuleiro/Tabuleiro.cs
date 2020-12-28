using System;

namespace tabuleiro
{
    public class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }
        public Peca SelecionarPeca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }
        public Peca SelecionarPeca(Posicao pos)
        {
            return Pecas[pos.Linha, pos.Coluna];
        }

        public void MoverPeca(Peca p, Posicao pos)
        {
            p.Posicao = pos;
            Pecas[pos.Linha, pos.Coluna] = p;
        }

        public void InserirPeca(Peca p, Posicao pos)
        {
            if (ExistePecaNaPosicao(pos)) throw new Exception($"Já existe uma peça na linha {pos.Linha} coluna {pos.Coluna}");

            p.Posicao = pos;
            Pecas[pos.Linha, pos.Coluna] = p;
        }

        public void PosicaoValida(Posicao pos)
        {
            if (pos.Coluna < 0 || pos.Coluna >= Colunas || pos.Linha < 0 || pos.Linha >= Linhas)
                throw new ArgumentException($"Posição inválida! Escolha posições entre 0:0 e {--Linhas}:{--Colunas}");
        }

        public bool ExistePecaNaPosicao(Posicao pos)
        {
            PosicaoValida(pos);

            return SelecionarPeca(pos) != null;
        }
    }
}