using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;



namespace Tic_Tac_Toe_Game
{
    public partial class GameScreen : Form
    {

        char[,] ArrCells = new char[3, 3];
            int CountCell;
        Random RandNumber = new Random();
        public struct Player
        {

            public string PlayerName;
            public int RoundNumber;
            public int Number_Of_wins;
            public bool IsPlayerWinRound;
            public Label CellUndo;
            public bool IsRoundEnded;
            public Player(string playerName, int roundNumber, int numberOfWins, bool isPlayerWinRound,Label CellUndo,bool IsRoundEnded)
            {
                PlayerName = playerName;
                RoundNumber = roundNumber;
                Number_Of_wins = numberOfWins;
                IsPlayerWinRound = isPlayerWinRound;
                this.CellUndo = CellUndo;
                this.IsRoundEnded = IsRoundEnded;
            }
        }
       
        Player Player_1;
        Player Player_2;
        Player CurrentPlayer;
       
        public GameScreen()
        {
            InitializeComponent();
        }



        public bool IsRoundDraw()
        {
            return CountCell == 9 ? true : false;


        }
        private void GameScreen_Load(object sender, EventArgs e)
        {
            Player_1 = new Player("Player_1", 0, 0, false, null, false);
            Player_2 = new Player("Player_2", 0, 0, false, null, false);
            CurrentPlayer = Player_1;
            LabelPlayerName.Text = CurrentPlayer.PlayerName;
            CountCell = 0;
        }

        private bool CheckIfRoundEnded() 
        {

           for(int i= 0;i < 2; i++) 
            {
                for (int j = 0; j < 2; j++)
                {
                    if (ArrCells[i, j] == 'W')
                    {
                        return true;
                    }
                }

            }

            return false;
        }
        private void ResetGame() 
        {


            if (CurrentPlayer.IsRoundEnded == false && !CheckIfRoundEnded() && !IsRoundDraw()) return;



            ArrCells = new char[3, 3];
            CurrentPlayer.IsRoundEnded = false;
           // WhoWinGame(false);
            LabelShowWhoIsWinGame.Text = "In Progress";
           
            
            Cell_1_1.Image = Resources.question_mark_96;
            Cell_1_2.Image = Resources.question_mark_96;
            Cell_1_3.Image = Resources.question_mark_96;
            Cell_2_1.Image = Resources.question_mark_96;
            Cell_2_2.Image = Resources.question_mark_96;
            Cell_2_3.Image = Resources.question_mark_96;
            Cell_3_1.Image = Resources.question_mark_96;
            Cell_3_2.Image = Resources.question_mark_96;
            Cell_3_3.Image = Resources.question_mark_96;
           
            Cell_1_1.BackColor = Color.Transparent;
            Cell_1_2.BackColor = Color.Transparent;
            Cell_1_3.BackColor = Color.Transparent;
            Cell_2_1.BackColor = Color.Transparent;
            Cell_2_2.BackColor = Color.Transparent;
            Cell_2_3.BackColor = Color.Transparent;
            Cell_3_1.BackColor = Color.Transparent;
            Cell_3_2.BackColor = Color.Transparent;
            Cell_3_3.BackColor = Color.Transparent;

            Cell_1_1.Enabled = true;
            Cell_1_2.Enabled = true;
            Cell_1_3.Enabled = true;
            Cell_2_1.Enabled = true;
            Cell_2_2.Enabled = true;
            Cell_2_3.Enabled = true;
            Cell_3_1.Enabled = true;
            Cell_3_2.Enabled = true;
            Cell_3_3.Enabled = true;



            Cell_1_1.Tag = true;
            Cell_1_2.Tag = true;
            Cell_1_3.Tag = true;
            Cell_2_1.Tag = true;
            Cell_2_2.Tag = true;
            Cell_2_3.Tag = true;
            Cell_3_1.Tag = true;
            Cell_3_2.Tag = true;
            Cell_3_3.Tag = true;

        }
        private void AddToArray(byte Column,byte Row,char Charcter)
        {

            ArrCells[Column,Row] = Charcter;
            
        }
        private void ChangeColorCellToGreen(bool IsCellsEqual) 
        {

            if (ArrCells[0,0]== 'W')
            {
                Cell_1_1.BackColor = Color.DarkGreen;
            }
            ;

            if(ArrCells[0,1] == 'W')
            {
                Cell_1_2.BackColor = Color.DarkGreen;
            }
            ;

            if(ArrCells[0,2] == 'W')
            {
                Cell_1_3.BackColor = Color.DarkGreen;
            }
            ;

            if(ArrCells[1,0] == 'W')
            {
                Cell_2_1.BackColor = Color.DarkGreen;
            }
            ;

            if(ArrCells[1,1] == 'W')
            {
                Cell_2_2.BackColor = Color.DarkGreen;
            }
            ;

            if(ArrCells[1,2] == 'W')
            {
                Cell_2_3.BackColor = Color.DarkGreen;
            }
            ;

            if(ArrCells[2,0] == 'W')
            {
                Cell_3_1.BackColor = Color.DarkGreen;
            }
            ;

            if(ArrCells[2,1] == 'W')
            {
                Cell_3_2.BackColor = Color.DarkGreen;
            }

           if (ArrCells[2,2] == 'W')
            {
                Cell_3_3.BackColor = Color.DarkGreen;
            }
            
           


                  
        }
        private bool CalculateTheAnotherCornerFromLeftUpper(char MarksOrSymbols)
        {

            bool IsCellsEqual = (ArrCells[0, 0] == MarksOrSymbols && ArrCells[1, 1] == MarksOrSymbols && ArrCells[2, 2] == MarksOrSymbols);
            if (IsCellsEqual == false) return IsCellsEqual;
            AddToArray(0, 0, 'W');
            AddToArray(1, 1, 'W');
            AddToArray(2, 2, 'W');
            ChangeColorCellToGreen(IsCellsEqual);

            return IsCellsEqual;

            
        }
        private bool CalculateTheAnotherCornerFromRightUpper(char MarksOrSymbols)
        {

            bool IsCellsEqual = (ArrCells[0, 2] == MarksOrSymbols && ArrCells[1, 1] == MarksOrSymbols && ArrCells[2, 0] == MarksOrSymbols);
            if (IsCellsEqual == false) return IsCellsEqual;
            AddToArray(0, 2, 'W');
            AddToArray(1, 1, 'W');
            AddToArray(2, 0, 'W');
            ChangeColorCellToGreen(IsCellsEqual);


            return IsCellsEqual;


        }
        private bool CalculateRow(byte Column,char MarksOrSymbols) 
        {

            bool IsCellsEqual = (ArrCells[Column, 0] == MarksOrSymbols && ArrCells[Column, 1] == MarksOrSymbols && ArrCells[Column, 2] == MarksOrSymbols);
            if (IsCellsEqual == false) return IsCellsEqual;
            AddToArray(Column,0, 'W');
            AddToArray(Column,1 , 'W');
            AddToArray(Column,2 , 'W');



            ChangeColorCellToGreen(IsCellsEqual);



            return IsCellsEqual;

        }
        private bool CalculateColumn(byte Row,char MarksOrSymbols) 
        {

            bool IsCellsEqual = (ArrCells[0, Row] == MarksOrSymbols && ArrCells[1, Row] == MarksOrSymbols && ArrCells[2, Row] == MarksOrSymbols);
            if (IsCellsEqual == false)  return IsCellsEqual; 

            AddToArray(0, Row, 'W');
            AddToArray(1, Row, 'W');
            AddToArray(2, Row, 'W');
                
            ChangeColorCellToGreen(IsCellsEqual);
            return IsCellsEqual;
           
        }

        public void StopGame() 
        {

            if (!IsRoundDraw())
            {
                LabelShowWhoIsWinGame.Text = CurrentPlayer.PlayerName;
            }
            else 
            {
                LabelShowWhoIsWinGame.Text = "No Winner";
            }
            
            
            LabelShowWhoIsWinGame.Tag = true;
            CurrentPlayer.IsRoundEnded = true;
            CountCell = 0;
            Cell_1_1.Enabled = false;
            Cell_1_2.Enabled = false;
            Cell_1_3.Enabled = false;
            Cell_2_1.Enabled = false;
            Cell_2_2.Enabled = false;
            Cell_2_3.Enabled = false;
            Cell_3_1.Enabled = false;
            Cell_3_2.Enabled = false;
            Cell_3_3.Enabled = false;

        }

        public void showMessageBox(string Type = "Error", string Title = "Wrong", string Text = "Wrong Choice")
        {
            if (Type == "Error") 
            {
                MessageBox.Show(Title,Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }else if (Type == "Info") 
            {

                MessageBox.Show(Title, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        public void WhoWinGame(bool latePass=true) 
        {

            if (Convert.ToBoolean(CurrentPlayer.CellUndo.Tag) != true && latePass == true) return;

            CurrentPlayer.CellUndo.Tag = false;



            if (CurrentPlayer.IsPlayerWinRound || IsRoundDraw())
            {
                showMessageBox("Info", "Game_Over", "Game Over");
                StopGame();
            }
            else if (CurrentPlayer.PlayerName == Player_1.PlayerName && CountCell != 9) 
            {
                Player_1 = CurrentPlayer;
                Player_2.CellUndo = CurrentPlayer.CellUndo;
                CurrentPlayer = Player_2;
                LabelPlayerName.Text = CurrentPlayer.PlayerName;

            }
            else if (CurrentPlayer.PlayerName == Player_2.PlayerName && CountCell!=9)
            {
                Player_2 = CurrentPlayer;
                Player_1.CellUndo = CurrentPlayer.CellUndo;
                CurrentPlayer = Player_1;
                LabelPlayerName.Text = CurrentPlayer.PlayerName;

            }

 
            //if (IsRoundDraw())
            //{
            //    StopGame();
              
            //    return;
            //}

          
        }
        public void RandomCell_XorO(byte Column, byte Row,ref Label GetCell) 
        {
            
            if (Convert.ToBoolean(GetCell.Tag) != true) 
            {


                showMessageBox();
                return;
               
            };


            CountCell++;

            CurrentPlayer.CellUndo = GetCell;

            ArrCells[Column, Row] += Convert.ToChar(RandNumber.Next(48, 50));
            GetCell.Image =
                (ArrCells[Column, Row] == 49) ?
                Resources.X :

                Resources.O;
            GetCell.BackColor = Color.AliceBlue;
            



        }
        private bool StartGame( byte Column,byte Row) 
        {

            if (Convert.ToBoolean(CurrentPlayer.CellUndo.Tag) != true) return false;


            if ((Row == 0 && Column == 0) || Row == 2 && Column == 2)
            {


                return (CalculateTheAnotherCornerFromLeftUpper(ArrCells[Column, Row])  ||
                                          CalculateRow(Column, ArrCells[Column, Row])  ||
                                          CalculateColumn(Row, ArrCells[Column, Row])) ? true : false;

             

            }
            else if (Row == 0 && Column == 2)   
            {

                return (CalculateTheAnotherCornerFromRightUpper(ArrCells[Column, Row]) ||
                    CalculateRow(Column, ArrCells[Column, Row]) ||
                    (CalculateColumn(Row, ArrCells[Column, Row]))) ? true : false;


            }
            else if (Row == 1 && Column == 1) 
            {

                return (CalculateTheAnotherCornerFromLeftUpper(ArrCells[Column, Row]) 
                    || CalculateTheAnotherCornerFromRightUpper(ArrCells[Column, Row]) 
                    || CalculateRow(Column, ArrCells[Column, Row]) 
                    || (CalculateColumn(Row, ArrCells[Column, Row]))) ? true : false;

            }   
            else if (Row == 2 && Column == 0)
            {

              

                return (CalculateTheAnotherCornerFromRightUpper(ArrCells[Column, Row])
                    || CalculateRow(Column, ArrCells[Column, Row])
                    || CalculateColumn(Row, ArrCells[Column, Row])) ? true : false;

            }
            else 
            {


                return CalculateRow(Column, ArrCells[Column, Row])
                    || CalculateColumn(Row, ArrCells[Column, Row]) ? true : false;

              
            }





        }




        // Any Click From [0,0] to [2,2];
        private void Cell_1_1_Click(object sender, EventArgs e)
        {
          
                RandomCell_XorO(0, 0, ref Cell_1_1);
                CurrentPlayer.IsPlayerWinRound = StartGame(0, 0);
                WhoWinGame();


        }

        private void Cell_1_2_Click(object sender, EventArgs e)
        {
           
            RandomCell_XorO(0, 1,ref Cell_1_2);
            CurrentPlayer.IsPlayerWinRound = StartGame(0, 1);
            WhoWinGame();
        }

        private void Cell_1_3_Click(object sender, EventArgs e)
        {
            RandomCell_XorO(0, 2, ref Cell_1_3);
            CurrentPlayer.IsPlayerWinRound = StartGame(0, 2);
            WhoWinGame();
        }

        private void Cell_2_1_Click(object sender, EventArgs e)
        {
            RandomCell_XorO(1, 0, ref Cell_2_1);
            CurrentPlayer.IsPlayerWinRound = StartGame(1, 0);
            WhoWinGame();
        }

        private void Cell_2_2_Click(object sender, EventArgs e)
        {
            
            RandomCell_XorO(1, 1, ref Cell_2_2);
            CurrentPlayer.IsPlayerWinRound = StartGame(1, 1);
            WhoWinGame();
        }

        private void Cell_2_3_Click(object sender, EventArgs e)
        {
            RandomCell_XorO(1, 2, ref Cell_2_3);
            CurrentPlayer.IsPlayerWinRound = StartGame(1, 2);
            WhoWinGame();
        }

        private void Cell_3_1_Click(object sender, EventArgs e)
        {
            RandomCell_XorO(2, 0, ref Cell_3_1);
            CurrentPlayer.IsPlayerWinRound = StartGame(2, 0);
            WhoWinGame();
        }

        private void Cell_3_2_Click(object sender, EventArgs e)
        {
            RandomCell_XorO(2, 1, ref Cell_3_2);
            CurrentPlayer.IsPlayerWinRound = StartGame(2, 1);
            WhoWinGame();
        }

        private void Cell_3_3_Click(object sender, EventArgs e)
        {
            RandomCell_XorO(2, 2, ref Cell_3_3);
            CurrentPlayer.IsPlayerWinRound = StartGame(2, 2);
            WhoWinGame();
        }

        private void labelResetGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }





    }
}
