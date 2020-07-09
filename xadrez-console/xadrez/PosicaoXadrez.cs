
using tabuleiro;

namespace xadrez {
    class PosicaoXadrez {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha) {
            this.coluna = coluna;
            this.linha = linha;
        }

        // Transformando o valor de um tabuleiro de xadrez original (1 até 8 / a até h) para os valores da matriz
        public Posicao toPosicao() {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString() {
            return "" + coluna + linha;
        }
    }
}
