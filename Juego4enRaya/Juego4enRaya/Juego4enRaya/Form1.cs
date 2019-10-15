using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego4enRaya
{
    public partial class Form1 : Form
    {
        private Rectangle[] boardColumns;//vector de las columnas del tablero
        private int[,] board;//array bidimensional
        private int turn;//variable que controla el turno y hace el cambio de color de fichas

        public Form1()
        {
            InitializeComponent();
            this.boardColumns = new Rectangle[7];
            this.board = new int[6, 7];//6 filas y 7 columnas
            this.turn = 2;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Blue, 24, 24, 340, 300);

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == 0)
                    {
                        this.boardColumns[j] = new Rectangle(32 + 48 * j, 24, 32, 300);
                    }
                    e.Graphics.FillEllipse(Brushes.White, 32 + 48 * j, 32 + 48 * i, 32, 32);
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int columnIndex = this.ColumnNumber(e.Location);

            if (columnIndex != -1)
            {

                int rowIndex = this.Emptyrow(columnIndex);

                if (rowIndex != -1)
                {
                    

                    this.board[rowIndex, columnIndex] = this.turn;
                    if (this.turn == 1)
                    {

                        Graphics g = this.CreateGraphics();
                        g.FillEllipse(Brushes.Red, 32 + 48 * columnIndex, 32 + 48 * rowIndex, 32, 32);

                    }
                    else if (this.turn == 2)
                        {

                            Graphics g = this.CreateGraphics();
                            g.FillEllipse(Brushes.Yellow, 32 + 48 * columnIndex, 32 + 48 * rowIndex, 32, 32);

                        }

                    
                   int winner = this.WinnerPlayer(this.turn);

                    if (winner != -1)
                    {
                        string player1 = labelp1.Text;
                        string player2 = labelp2.Text;
                        // string player = (winner == 1) ? "Red" : "Green";
                        string player = (winner == 1) ? player1 : player2;
                        MessageBox.Show("Felicidades "+ player + " ganaste");
                       Application.Restart();
                    }
                    if (this.turn == 1)
                    {
                        this.turn = 2;
                        label.Text = labelp2.Text;
                    }
                    else
                    {
                        this.turn = 1;
                        label.Text = labelp1.Text;
                    }

                }

            }

        

    }

    private int ColumnNumber(Point mouse)//posición de la ficha en el tablero
        {
            for(int i = 0 ; i < this.boardColumns.Length ; i++)
            {
                if((mouse.X >= this.boardColumns[i].X) && (mouse.Y >= this.boardColumns[i].Y))
                {
                    if((mouse.X <= this.boardColumns[i].X + this.boardColumns[i].Width) && (mouse.Y <= this.boardColumns[i].Y + this.boardColumns[i].Height))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        private int Emptyrow(int col)//controlar que haya una ficha abajo antes de poner otra
        {
            for(int i = 5 ; i >= 0 ; i--)
            {
                if(this.board[i, col] == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        private int WinnerPlayer(int playerToCheck)
        {
            //vertical win check (!)
            for (int row = 0; row < this.board.GetLength(0) - 3; row++)
            {
                for (int col = 0; col < this.board.GetLength(1); col++)
                {
                    if (this.AllNumbersEqual(playerToCheck, this.board[row, col], this.board[row + 1, col], this.board[row + 2, col], this.board[row + 3, col]))
                    { return playerToCheck; }
                }

            }
            //horizontal win check (-)
            for (int row = 0; row < this.board.GetLength(0); row++)
            {
                for (int col = 0; col < this.board.GetLength(1) - 3; col++)
                {
                    if (this.AllNumbersEqual(playerToCheck, this.board[row, col], this.board[row, col + 1], this.board[row, col + 2], this.board[row, col + 3]))
                    { return playerToCheck; }
                }

            }
            //top-left diagonal win check (\)
            for (int row = 0; row < this.board.GetLength(0) - 3; row++)
            {
                for (int col = 0; col < this.board.GetLength(1) - 3; col++)
                {
                    if (this.AllNumbersEqual(playerToCheck, this.board[row, col], this.board[row + 1, col + 1], this.board[row + 2, col + 2], this.board[row + 3, col + 3]))
                    { return playerToCheck; }
                }

            }
            //top-rigth diagonal win check (/)
            for (int row = 0; row < this.board.GetLength(0) - 3; row++)
            {
                for (int col = 3; col < this.board.GetLength(1) ; col++)
                {
                   if (this.AllNumbersEqual(playerToCheck, this.board[row, col], this.board[row + 1, col - 1], this.board[row + 2, col - 2], this.board[row + 3, col - 3]))
                    { return playerToCheck; }
                }

            }

            return -1;
        }


        private bool AllNumbersEqual(int toCheck, params int[] numbers)
        {

            foreach (int num in numbers)
            {

                if (num != toCheck)
                {
                    return false;
                }

            }

            return true;

        }

        private void labelp1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer Player = new SoundPlayer();
            Player.SoundLocation = "A:/PABLO/UPB/CUARTO SEMESTRE/INGENIERIA DE SOFTWARE/PROYECTOSGIT/Sonar1.wav";
            Player.Play();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
