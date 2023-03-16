using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Try/Catch
            //try
            //{
            //    Tabuleiro tab = new Tabuleiro(8, 8);

            //    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            //    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            //    tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
            //    tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 7));

            //    Tela.imprimirTabuleiro(tab);
            //} 
            //catch (TabuleiroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);
            Console.WriteLine(pos.ToPosicao());

            Console.ReadLine();
        }
    }
}
