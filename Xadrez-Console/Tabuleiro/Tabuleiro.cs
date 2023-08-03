namespace tabuleiro
{
    class Tabuleiro
    {
        public int linha { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas; //Só o tabuleiro tem acesso

        public Tabuleiro(int linha, int colunas)
        {
            this.linha = linha;
            this.colunas = colunas;
            pecas = new Peca[linha, colunas];
        }
    }
}
