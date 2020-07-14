using System;
using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();


                //Inicio da partida
                while (!partida.terminada) {

                    try {
                        //Imprimindo o tabuleiro
                        Console.Clear();
                        Tela.imprimirPartida(partida);

                        //Solicitando a Origem
                        Console.WriteLine();
                        Console.Write("Origem (coluna e linha): ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                        partida.validarPosicaoDeOrigem(origem);
                        //Mostrando ao jogador os possiveis movimentos
                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        //Solicitando o destino
                        Console.WriteLine();
                        Console.Write("Destino (coluna e linha): ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);


                    } catch (TabuleiroException e) {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }

                }

                Console.Clear();
                Tela.imprimirPartida(partida);
                Console.ReadLine();

            } catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
        }
    }
}
