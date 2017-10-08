using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/********************************
 * THIS IS FROM THE CONSOLE GAME WE HAVE BEEN USING
 * 
 * 
 *  while (true)
            {
                bestState = gameTree.getBestState(gameTree.root);
                gameTree.setNewRoot(bestState);
                Console.Out.WriteLine(gameTree.root.ToString());
                playerState = humanTurn(bestState);
                gameTree.setNewRoot(playerState);
                

            }
 * 
 * 
 * *****************************/

namespace ConnectFour
{
    public partial class Board : Form
    {
        int[,]arr = new int[4,4];//for player,this will check for winner
        Boolean isTurn = true;//based on this, the color changes from blue to red
        Color paint = Color.White;//initialaize a color
        StateTree gameTree = new StateTree(4, 4);

        //for coloring:counter  for each row,they decrement after player chooses spot
        int row0 = 3, row1 = 3, row2 = 3, row3 = 3;
       
        //for the array:these place either 1 or 2 based on player
        int ROW0 = 3, ROW1 = 3, ROW2 = 3, ROW3 = 3;

        public Board()
        {
         
            InitializeComponent();
            
        }        

        private void START_Click_1(object sender, EventArgs e)
        {
            
            Button[] btn;//create an array of buttons
            btn = new Button[4] { zero0,one0,two0,three0 };
            Button[,] moreBtns = new Button[4, 4] { { zero0, one0, two0, three0 }, { zero1, one1, two1, three1 }, { zero2, one2, two2, three2 }, { zero3, one3, two3, three3 } };
            if (row0 >= 0)
            {

                

                for (int i = arr.GetLength(0) - 1; i >= 0; i--)
                {

                    if (arr[i, 0] == 0)
                    {
                        arr[i, 0] = 2;
                        i = -1;
                    }
                }

                gameTree.setNewRoot(arr);
                int[,] bestState = gameTree.getBestState(gameTree.root);
                Array.Copy(bestState, arr, bestState.Length);
                row0--;

                for (int i = 0; i < moreBtns.GetLength(0); i++)
                {
                    for (int j = 0; j < moreBtns.GetLength(1); j++){
                        if (arr[i, j] == 1) { moreBtns[j,i].BackColor = Color.Blue; }
                        else if (arr[i, j] == 2) { moreBtns[j,i].BackColor = Color.Red; }
                    }
                    
                    

                }
         
            }

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Button[] btn;//create an array of buttons
            btn = new Button[4] { zero1, one1, two1, three1 };
            Button[,] moreBtns = new Button[4, 4] { { zero0, one0, two0, three0 }, { zero1, one1, two1, three1 }, { zero2, one2, two2, three2 }, { zero3, one3, two3, three3 } };
            if (row1 >= 0)
            {

                

                for (int i = arr.GetLength(0) - 1; i >= 0; i--)
                {

                    if (arr[i, 1] == 0)
                    {
                        arr[i, 1] = 2;
                        i = -1;
                    }
                }

                gameTree.setNewRoot(arr);
                int[,] bestState = gameTree.getBestState(gameTree.root);
                Array.Copy(bestState, arr, bestState.Length);
                row1--;

                for (int i = 0; i < moreBtns.GetLength(0); i++)
                {
                    for (int j = 0; j < moreBtns.GetLength(1); j++)
                    {
                        if (arr[i, j] == 1) { moreBtns[j, i].BackColor = Color.Blue; }
                        else if (arr[i, j] == 2) { moreBtns[j, i].BackColor = Color.Red; }
                    }



                }

            }

        }


        private void btn_2_Click(object sender, EventArgs e)
        {

            Button[] btn;//create an array of buttons
            btn = new Button[4] { zero2, one2, two2, three2 };
            Button[,] moreBtns = new Button[4, 4] { { zero0, one0, two0, three0 }, { zero1, one1, two1, three1 }, { zero2, one2, two2, three2 }, { zero3, one3, two3, three3 } };
            if (row0 >= 0)
            {

                

                for (int i = arr.GetLength(0) - 1; i >= 0; i--)
                {

                    if (arr[i, 2] == 0)
                    {
                        arr[i, 2] = 2;
                        i = -1;
                    }
                }

                gameTree.setNewRoot(arr);
                int[,] bestState = gameTree.getBestState(gameTree.root);
                Array.Copy(bestState, arr, bestState.Length);
                row2--;

                for (int i = 0; i < moreBtns.GetLength(0); i++)
                {
                    for (int j = 0; j < moreBtns.GetLength(1); j++)
                    {
                        if (arr[i, j] == 1) { moreBtns[j, i].BackColor = Color.Blue; }
                        else if (arr[i, j] == 2) { moreBtns[j, i].BackColor = Color.Red; }
                    }



                }

            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Button[] btn;//create an array of buttons
            btn = new Button[4] { zero3, one3, two3, three3 };
            Button[,] moreBtns = new Button[4, 4] { { zero0, one0, two0, three0 }, { zero1, one1, two1, three1 }, { zero2, one2, two2, three2 }, { zero3, one3, two3, three3 } };
            if (row0 >= 0)
            {

                

                for (int i = arr.GetLength(0) - 1; i >= 0; i--)
                {

                    if (arr[i, 3] == 0)
                    {
                        arr[i, 3] = 2;
                        i = -1;
                    }
                }

                gameTree.setNewRoot(arr);
                int[,] bestState = gameTree.getBestState(gameTree.root);
                Array.Copy(bestState, arr, bestState.Length);
                row3--;

                for (int i = 0; i < moreBtns.GetLength(0); i++)
                {
                    for (int j = 0; j < moreBtns.GetLength(1); j++)
                    {
                        if (arr[i, j] == 1) { moreBtns[j, i].BackColor = Color.Blue; }
                        else if (arr[i, j] == 2) { moreBtns[j, i].BackColor = Color.Red; }
                    }



                }

            }

        }


        //this places the player on a row/col
        public void place(int [,]a ,int i,int j,int player)
        {
            a[i,j] = player;

           printArray(arr);
        }
        
        
        
        public void printArray(int[,] values)
        {
         
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int k = 0; k < values.GetLength(1); k++)
                {
                    Console.Write(values[i,k]);
                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
        
        
        
        
        //We dont need these buttons  

    private void button3_Click(object sender, EventArgs e)
        {

        }

        private void one1_Click(object sender, EventArgs e)
        {

        }

        private void one2_Click(object sender, EventArgs e)
        {

        }

        private void one0_Click(object sender, EventArgs e)
        {
            zero0.BackColor = Color.Green;
        }

        private void one3_Click(object sender, EventArgs e)
        {

        }

        private void two0_Click(object sender, EventArgs e)
        {

        }

        private void two1_Click(object sender, EventArgs e)
        {

        }

        private void two2_Click(object sender, EventArgs e)
        {

        }



        private void two3_Click(object sender, EventArgs e)
        {

        }
    }
    }

