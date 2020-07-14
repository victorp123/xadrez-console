namespace tabuleiro {
    abstract class Peca {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        //Construtor da peça
        public Peca(Tabuleiro tab, Cor cor) {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qtdMovimentos = 0;
        }

        public void incrementarQteMovimentos() {
            qtdMovimentos++;
        }

        public void decrementarQteMovimentos() {
            qtdMovimentos--;
        }

        //Metodo para validar se a peça está bloqueada de movimento ou se há movimentos possíveis
        public bool existeMovimentosPossiveis() {
            bool[,] mat = movimentosPossiveis();

            for (int i = 0; i < tab.linhas; i++) {
                for (int j = 0; j < tab.colunas; j++) {
                    if (mat[i, j]) {
                        return true;
                    }
                }
            }
            return false;
        }

        // Metodo para verificar se a peça pode ser movida para determinada posição
        public bool movimentoPossivel(Posicao pos) {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();

    }
}
