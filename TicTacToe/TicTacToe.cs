using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class TicTacToe
    {
        char [] board = new char[9];
        char current_winner = 'N';


        public TicTacToe() 
        {
            for (int i = 0; i < board.Length; i++)
            {
                this.board[i] = ' ';
            }
            this.current_winner = 'N';
        }

        

    }
}
