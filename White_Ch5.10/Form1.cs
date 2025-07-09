using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace White_Ch5._10
{
    public partial class Addition_Tutor : Form
    {
        private int firstNum;
        private int secNum;
        public Addition_Tutor()
        {
            InitializeComponent();
        }

        private void User_Answers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            //set counter variable to 1 therefore it is always true making it an infinite loop
            int countVar = 1;
            


            while (countVar > 0)
            {
                Random rand = new Random();
                //never use int or double when redelcaring variables that are class level there is no need
                firstNum = rand.Next(100, 501);
                secNum = rand.Next(100, 501);

                ProblemLbl.Text = ($"What is {firstNum} + {secNum} =");
                //reinstantiate the counter so that it can stop the loop if need be
                countVar = 0;
            }

        }

        private void CheckAnsBtn_Click(object sender, EventArgs e)
        {
            int UserInput;
           // int Total;
           //after user input is made calculable you must continue down with if statements and loops 
           //do not make a new if statement
            if (int.TryParse(User_Answers.Text, out UserInput))
            {
                if (UserInput < 0)
                {
                    MessageBox.Show("Enter a Postive Number as Your Answer.");
                }
                if (UserInput == firstNum + secNum)
                {
                    MessageBox.Show($"Your Answer is Correct: {firstNum + secNum}");
                }
                else
                {
                    MessageBox.Show($"Your Answer is Wrong. The correct answer is: {firstNum + secNum}");
                }
            }
            
        }
    }
    }

// int Answer = firstNum + secNum; Rand_NumsLbl.Text = $"{Answer}";