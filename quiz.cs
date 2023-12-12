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
    public partial class quiz : Form
    {
        private List<Tanong> allQuestions;
        private List<Tanong> aveQuestions;
        private List<Tanong> hardQuestions;
        private List<Tanong> currentQuestions;
        private int currentQuestionIndex;
        private int score;
        public quiz()
        {
            InitializeComponent();
            InitializeQuestions();
            DisplayQuestion();
        }

        private void InitializeQuestions()
        {
            allQuestions = new List<Tanong>
            {
                new Tanong { Difficulty = "EASY", Question = "How many colors are typically seen in a rainbow?", CorrectAnswer = "Seven", Point = 1},
                new Tanong { Difficulty = "EASY", Question = "If you mix blue and yellow paint, what color do you get?", CorrectAnswer = "Green", Point = 1},
                new Tanong { Difficulty = "EASY", Question = "What color is often associated with happiness and sunshine?", CorrectAnswer = "Yellow", Point = 1},
            
                new Tanong { Difficulty = "AVERAGE", Question = "What kind of color scheme uses variations of a single color, such as different shades and tints?", CorrectAnswer = "Monochromatic", Point = 3},
                new Tanong { Difficulty = "AVERAGE", Question = "What is the most common eye color in humans?", CorrectAnswer = "Brown", Point = 3},
                new Tanong { Difficulty = "AVERAGE", Question = "In a traditional color wheel, which color is directly opposite to green?", CorrectAnswer = "Red", Point = 3},
                new Tanong { Difficulty = "AVERAGE", Question = "In the CMYK color model used for color printing, what color does the \"K\" represent?", CorrectAnswer = "Black", Point = 3},
                new Tanong { Difficulty = "AVERAGE", Question = "In color theory, what term is used to describe colors that are adjacent to each other on the color wheel and share a common base color?", CorrectAnswer = "Analogous", Point = 3},
            
                new Tanong { Difficulty = "HARD", Question = "What part of the eye contains photoreceptor cells responsible for detecting color?", CorrectAnswer = "Retina", Point = 5},
                new Tanong { Difficulty = "HARD", Question = "Color pairs that when combined they cancel each other out. They are often found opposite each other on the color wheel.", CorrectAnswer = "Complimentary", Point = 5 },
                new Tanong { Difficulty = "HARD", Question = "It refers to the degree of purity or vividness of a color.", CorrectAnswer = "Saturation", Point = 5 }
            };    
        }

      

       private void DisplayQuestion()
        {
            if (currentQuestionIndex < allQuestions.Count)
            {
                labelDiff.Text = allQuestions[currentQuestionIndex].Difficulty;
                QuestionLabel.Text = allQuestions[currentQuestionIndex].Question;
                currentQuestions = allQuestions;
                userAnswer.Text = "";
            }         
            else
            {
                Form scoreForm = new Score(score);
                scoreForm.Show();
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string answer = userAnswer.Text.ToLower().Trim();
            string correctAns = currentQuestions[currentQuestionIndex].CorrectAnswer.ToLower().Trim();
            
            if (answer == correctAns)
            {
                score += currentQuestions[currentQuestionIndex].Point;
                MessageBox.Show("Nice! Your answer is correct.", "", MessageBoxButtons.OK);
            } 
            else
            {
                MessageBox.Show("Oops! Your answer is wrong.", "", MessageBoxButtons.OK);
            }
            currentQuestionIndex++;
            DisplayQuestion();
        }
    }
}
