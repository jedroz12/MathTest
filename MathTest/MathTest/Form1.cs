using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTest
{
    public partial class Form1 : Form
    {
        static Random random = new Random();

        int questionsCompleted = 0;

        public int answer;
        int correct = 0;
        int userAnswer;

        public int left;
        public int right;

        public Form1()
        {
            InitializeComponent();
        }

        void GenerateNewQuestion(ref int questionsDone)
        {
            //generate new question
            left = random.Next(1, 12);
            right = random.Next(1, 12);
            answer = left * right;
            //increment questions done
            SetLabels();
        }

        void SetLabels()
        {
            //set labels to current values
            QuestionLabel.Text = left.ToString() + " * " + right.ToString();
            ScoreLabel.Text = "Score: " + correct.ToString() + " / " + questionsCompleted.ToString();
            if (questionsCompleted < 10)
            {
                StartButton.Visible = false;
            }
            else
            {
                StartButton.Visible = true;
            }
        }

        void CheckAnswer(ref int questionsDone)
        {
            //get user answer
            userAnswer = Convert.ToInt32(UserAnswerTextbox.Text);
            //if user answer is correct, run score function
            if (userAnswer == answer)
            {
                Scoring();
            }
            questionsDone++;
            if (questionsCompleted == 10)
            {
                EnterAnswerButton.Visible = false;
                StartButton.Visible = true;
            }
        }

        void Scoring()
        {
            //add to and update score
            correct++;
            SetLabels();
        }

        void Reset()
        {
            //reset everything
            questionsCompleted = 0;
            answer = 0;
            correct = 0;
            userAnswer = 0;
            SetLabels();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Reset();
            GenerateNewQuestion(ref questionsCompleted);
            EnterAnswerButton.Visible = true;
        }

        private void EnterAnswerButton_Click(object sender, EventArgs e)
        {
            //check user answer when enter button is pressed, then generate a new question
            //TODO Try Catch
            try
            {
                CheckAnswer(ref questionsCompleted);
                GenerateNewQuestion(ref questionsCompleted);
                UserAnswerTextbox.Text = "";
            }
            catch
            {
                MessageBox.Show("Please Enter An Answer!");
            }
        }
    }
}
