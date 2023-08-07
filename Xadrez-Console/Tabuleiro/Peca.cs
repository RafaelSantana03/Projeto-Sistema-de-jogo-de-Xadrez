﻿namespace tabuleiro
{
   class Peca
   {
        public Posicao posicao { get; set; }   
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0; //Se inicia com zero pq a peça não mexeu ainda
        }

        public void incrementarQtemovimentos()
        {
            qteMovimentos++;
        }

    }
}
