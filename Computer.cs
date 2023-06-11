using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Computer: Player
    {
        List<int> lstNumber;

        public Computer(char playerSign = 'O'): base(playerSign)
        {
            lstNumber = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }

        public void removeCell (int k)
        {
            lstNumber.Remove(k);
        }
        public override int takeTurn()
        {
            Random rd = new Random();
            int k = rd.Next(0, lstNumber.Count);
            return lstNumber[k];
        }
    }
}
