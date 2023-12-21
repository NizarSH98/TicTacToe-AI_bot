using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using TicTacToe;
using System.Diagnostics.Eventing.Reader;
using System.Data;

namespace TicTacToe
{

    internal class Player
    {
        
        string letter = "N";
        Random random = new Random();

        public Player(string letter)
        {
            this.letter = letter;
        }
        public string GetLetter() { return letter; }



        public virtual int GetValidMove()
        {
            return 0;
        }

        public class Computer : Player
        {
            public Computer(string letter) : base(letter)
            {
                // Additional initialization for Computer class, if needed
            }

            public int GetValidMove(string[] gamearray, int turn)
            {
                string player = (turn == 1) ? "X" : "O";
                string opponent = (player == "X") ? "O" : "X";

                int bestMove = -1;
                int bestScore = int.MinValue;

                for (int i = 0; i < gamearray.Length; i++)
                {
                    
                    if (gamearray[i] == "")
                    {
                        
                        gamearray[i] = player;
                        
                        int score = Minimax(gamearray, 0, false, player, opponent);
                        gamearray[i] = ""; //undo the move

                        if (score > bestScore)
                        {
                            bestScore = score;
                            bestMove = i;
                        }
                    }
                }

                return bestMove;
            }

            private static int Minimax(string[] board, int depth, bool isMaximizing, string player, string opponent)
            {
                int score = Evaluate(board, player, opponent);

                if (score == 10 ||  score == -10)
                    return score;

                if (!board.Contains(""))
                    return -1; //tie

                if (isMaximizing)
                {
                    int best = int.MinValue;
                    for (int i = 0;i < board.Length;i++)
                    {
                        if (board[i] == "")
                        {
                            board[i] = player;
                            best = Math.Max(best, Minimax(board, depth + 1, !isMaximizing, player, opponent));
                            board[i] = "";     //undo Move
                        }
                    }
                    return best;
                }
                else
                {
                    int best = int.MaxValue;

                    for (int i = 0; i < board.Length;i++)
                    {
                        if (board[i] == "")
                        {
                            board[i] = opponent;
                            best = Math.Min(best, Minimax(board,depth + 1, !isMaximizing,player, opponent));
                            board[i] = ""; // undo Move
                        }
                    }
                    return best;
                }
            }

            private static int Evaluate(string[] board, string player, string opponent)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (board[i * 3] == board[i * 3 + 1] && board[i * 3 +1] == board[i * 3 + 2])
                    {
                        if (board[i * 3] == player)
                            return 10;
                        else if (board[i * 3] == opponent)
                            return -10;
                    }

                    if (board[i] == board[i + 3] && board[i + 3] == board[i + 6])
                    {
                        if (board[i] == player)
                            return 10;
                        else if (board[i] == opponent)
                            return -10;
                    }
                }

                if (board[0] == board[4] && board[4] == board[8])
                {
                    if (board[0] == player)
                        return 10;
                    else if (board[0] == opponent)
                        return -10;
                }

                if (board[2] == board[4] && board[4] == board[6])
                {
                    if (board[2] == player)
                        return 10;
                    else if (board[2] == opponent)
                        return -10;
                }

                return 0;
            }
        }
    

        public class RandomPlayer : Player
        {
            public RandomPlayer(string letter) : base(letter)
            {
                // Additional initialization for RandomPlayer class, if needed
            }
            public int GetValidMove(string[] S)
            {
                int n = 0;
                int[] validmoves = new int[S.Length];
                for (int i = 0; i < S.Length; i++)
                {
                    validmoves[i] = i;
                }
                for (int i = 0;i<S.Length;i++) {
                    if (S[i] == "")
                        validmoves[i] = i;
                    else
                        validmoves[i] = -1;
                    Console.Write(validmoves[i]);
                    
                }
                
                n = random.Next(validmoves.Length);
                 while (validmoves[n] == -1)
                {
                    int c = 0;
                    for (int i = 0; i <validmoves.Length; i++)
                    {
                        
                        if (validmoves[i] == -1)
                        {
                            c++;
                        }
                        if (c == 9)
                        {
                            return -1;
                        }
                    }
                    n = random.Next(validmoves.Length);
                    
                }
                
                return validmoves[n];
            }
        }
    }

}
