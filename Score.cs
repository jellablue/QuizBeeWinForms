using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizBeeWinForms
{
    public partial class Score : Form        
    {
        private int scoreValue;
        public Score(int score)
        {
            InitializeComponent();
            scoreValue = score;
        }
        

        private void labelScore_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form retake = new Form1();
            retake.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gonzales, Jella Anne M. \nBSCS 1A \nFundamentals of Programming in C#", "Bye!", MessageBoxButtons.OK);
            Application.Exit();

        }

        private void Score_Load(object sender, EventArgs e)
        {
            labelScore.Text = scoreValue.ToString();
        }
    }
}
