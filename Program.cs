using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            TicTacToe game = new TicTacToe();
            Board gameBoard = new Board();
        Nhap_lv:
            Console.WriteLine("Chon che do choi");
            Console.WriteLine("1. Choi voi may");
            Console.WriteLine("2. Choi voi nguoi");
            try
            {
                int level = int.Parse(Console.ReadLine());
                switch (level)
                {
                    case 1: game.isPvP = false; break;
                    case 2: game.isPvP = true; break;
                    default: break;
                }
            }
            catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.Blue;
                goto Nhap_lv;
            }

            gameBoard.clearBoard();
            game.play();

            Console.ReadKey();
        }
    }
}
