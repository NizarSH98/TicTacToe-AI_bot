using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public int Player1 = -1;
        public int Player2 = -1;
        public int turn = 1;
        public bool start = false;
        public string[] game = new string[9];


        Player player;
        Player.RandomPlayer Rx = new Player.RandomPlayer("X");
        Player.RandomPlayer Ro = new Player.RandomPlayer("O");
        Player.Computer Cx = new Player.Computer("X");
        Player.Computer Co = new Player.Computer("O");




        public Form1()
        {
            InitializeComponent();
            progressBar1.Visible = false;
            progressBar2.Visible = false;
            progressBar3.Visible = false;
            progressBar4.Visible = false;
            progressBar5.Visible = false;
            progressBar6.Visible = false;

            for (int i = 0; i < game.Length; i++)
            {
                game[i] = "";
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (button1.Text == "" & start)
            {
                if (turn == 1 & Player1 == 2)
                {
                    game[0] = "X";
                    turn = 2;

                    
                }
                else if (turn == 2 & Player2 == 2)
                {
                    game[0] = "O";
                    turn = 1;
                }
                Draw();
                Play();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "" & start)
            {
                if (turn == 1 & Player1 == 2)
                {
                    game[1] = "X";
                    turn = 2;
                }
                else if (turn == 2 & Player2 == 2)
                {
                    game[1] = "O";
                    turn = 1;
                }
                Draw();
                Play();
            }
            



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "" & start)
            {
                if (turn == 1 & Player1 == 2)
                {
                    game[2] = "X";
                    turn = 2;
                }
                else if (turn == 2 & Player2 == 2)
                {
                    game[2] = "O";
                    turn = 1;
                }
                Draw();
                Play();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "" & start)
            {
                if (turn == 1 & Player1 == 2)
                {
                    game[3] = "X";
                    turn = 2;
                }
                else if (turn == 2 & Player2 == 2)
                {
                    game[3] = "O";
                    turn = 1;
                }
                Draw();
                Play();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "" & start)
            {
                if (turn == 1 & Player1 == 2)
                {
                    game[4] = "X";
                    turn = 2;
                }
                else if (turn == 2 & Player2 == 2)
                {
                    game[4] = "O";
                    turn = 1;
                }
                Draw();
                Play();
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "" & start)
            {
                if (turn == 1 & Player1 == 2)
                {
                    game[5] = "X";
                    turn = 2;
                }
                else if (turn == 2 & Player2 == 2)
                {
                    game[5] = "O";
                    turn = 1;
                }
                Draw();
                Play();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "" & start)
            {
                if (turn == 1 & Player1 == 2)
                {
                    game[6] = "X";
                    turn = 2;
                }
                else if (turn == 2 & Player2 == 2)
                {
                    game[6] = "O";
                    turn = 1;
                }
                Draw();
                Play();
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "" & start)
            {
                if (turn == 1 & Player1 == 2)
                {
                    game[7] = "X";
                    turn = 2;
                }
                else if (turn == 2 & Player2 == 2)
                {
                    game[7] = "O";
                    turn = 1;
                }
                Draw();
                Play();
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "" & start)
            {
                if (turn == 1 & Player1 == 2)
                {
                    game[8] = "X";
                    turn = 2;
                }
                else if (turn == 2 & Player2 == 2)
                {
                    game[8] = "O";
                    turn = 1;
                }
                Draw();
                Play();
            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Computer")
            {
                Player1 = 0;
            }
            if (comboBox1.Text == "Random")
            {
                Player1 = 1;
            }
            if (comboBox1.Text == "User")
            {
                Player1 = 2;
                
            }
            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Computer")
            {
                Player2 = 0;
            }
            if (comboBox2.Text == "Random")
            {
                Player2 = 1;
            }
            if (comboBox2.Text == "User")
            {
                Player2 = 2;
            }
        }

        private void button10_Click(object sender, EventArgs e) //start button
        {
            start = true;
            label3.Text = "";
            progressBar1.Visible = false;
            progressBar2.Visible = false;
            progressBar3.Visible = false;
            progressBar4.Visible = false;
            progressBar5.Visible = false;
            progressBar6.Visible = false;

            for (int i = 0; i < game.Length; i++)
            {
                game[i] = "";
               
            }
            
            Draw();
            Play();
            
        }

        public void Place(int x, string y)  //places a letter on the grid x for position y is for either X or O 
        {
            if (start)
            {
                game[x] = y;
                Draw();

            }

        }

        public void Draw()  //updates the grid with the values from the game array
        {
            button1.Text = game[0];
            button2.Text = game[1];
            button3.Text = game[2];
            button4.Text = game[3];
            button5.Text = game[4];
            button6.Text = game[5];
            button7.Text = game[6];
            button8.Text = game[7];
            button9.Text = game[8];
            Drawline();
            
        }



        public Tuple<string, int> CheckForWinner()
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (game[i * 3] == game[i * 3 + 1] && game[i * 3 + 1] == game[i * 3 + 2] && game[i * 3] != "")
                    return new Tuple<string, int>(game[i * 3], i + 1);
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (game[i] == game[i + 3] && game[i + 3] == game[i + 6] && game[i] != "")
                    return new Tuple<string, int>(game[i], i + 4);
            }

            // Check diagonals
            if (game[0] == game[4] && game[4] == game[8] && game[0] != "")
                return new Tuple<string, int>(game[0], 7);     //diagonal from top-left to bottom-right

            if (game[2] == game[4] && game[4] == game[6] && game[2] != "")
                return new Tuple<string, int>(game[2], 8);     //diagonal from top-right to bottom-left

            // No winner
            return new Tuple<string, int>("", -1);
        }

        public async void Play()
        {
            if (start)
            {
                if (Player1 == 1)
                {
                    if (turn == 1)
                    {
                        int x = Rx.GetValidMove(game);
                        if (x == -1)
                        {
                            start = false;
                            Drawline();
                            return;
                        }
                        Place(x , "X");
                        turn = 2;
                        await Task.Delay(500);
                        Play();


                    }
                    
                }
                if (Player2 == 1)
                {
                    
                    if (turn == 2)
                    {
                        int x = Ro.GetValidMove(game);
                        if (x == -1)
                        {
                            start = false;
                            Drawline();
                            return;
                        }
                        Place(x, "O");
                        turn = 1;
                        await Task.Delay(500);
                        Play();
                    }
                }

                if (Player1 == 0 & turn == 1)
                {
                    
                    int x = Cx.GetValidMove(game , turn);
                    if (x == -1)
                    {
                        start = false;
                        Drawline();
                        return;
                    }
                    Place(x, "X");
                    turn = 2;
                    await Task.Delay(500);
                    Play();
                }
                if (Player2 == 0 & turn == 2)
                {
                    
                    int x = Co.GetValidMove(game, turn);
                    if (x == -1)
                    {
                        start = false;
                        Drawline();
                        return;
                    }
                    Place(x, "O");
                    turn = 1;
                    await Task.Delay(500);
                    Play();
                }
            }
        }
        


        public void Drawline()
        {
            
            switch (CheckForWinner().Item2)
            {
                case 1:
                    progressBar1.Visible = true;
                    start = false;
                    break;
                case 2:
                    progressBar2.Visible = true;
                    start = false;
                    break;
                case 3:
                    progressBar3.Visible = true;
                    start = false;
                    break;
                case 4:
                    progressBar4.Visible = true;
                    start = false;
                    break;
                case 5:
                    progressBar5.Visible = true;
                    start = false;
                    break;
                case 6:
                    progressBar6.Visible = true;
                    start = false;
                    break;
                case 7:
                    start = false;
                    break;
                case 8:
                    start = false;
                    break;
                default:
                    break;
            }
            if (CheckForWinner().Item1 == "X")
            {
                label3.Text = "Player1 Wins";
            }
            else if (CheckForWinner().Item1 == "O")
            {
                label3.Text = "Player2 Wins";
            }
            else if (start == false && CheckForWinner().Item1 == "")
            {
                label3.Text = "Draw";
            }

            
        }

     

      
    }
}
