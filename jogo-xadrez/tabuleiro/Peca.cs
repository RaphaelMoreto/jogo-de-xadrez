using System;

namespace tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tabuleiro = tab;
            this.qtdMovimentos = 0;
        }
    }
}
