using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGAme
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            if (this.DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }
            timer1.Interval = 1000;
            timer1.Start();
            DisplayQuestion();
        }
 

        private struct Question
        {
            public string QuestionText;
            public string Choice1;
            public string Choice2;
            public string Choice3;
            public int CorrectChoice; 
        }
        private Question[] quizQuestions = new Question[]
        {    
         new Question {
        QuestionText = "What is the capital of France?",
        Choice1 = "London",
        Choice2 = "Paris",
        Choice3 = "Berlin",
        CorrectChoice = 2
    },
         new Question {
        QuestionText = "Which color do you get by mixing blue and yellow?",
        Choice1 = "Green",
        Choice2 = "Orange",
        Choice3 = "Purple",
        CorrectChoice = 1
    },
         new Question {
        QuestionText = "How many days are there in a week?",
        Choice1 = "5",
        Choice2 = "6",
        Choice3 = "7",
        CorrectChoice = 3
    },
         new Question {
        QuestionText = "Which animal is known as the King of the Jungle?",
        Choice1 = "Elephant",
        Choice2 = "Lion",
        Choice3 = "Tiger",
        CorrectChoice = 2
    },
         new Question {
        QuestionText = "What is the largest planet in our solar system?",
        Choice1 = "Earth",
        Choice2 = "Mars",
        Choice3 = "Jupiter",
        CorrectChoice = 3
    },
         new Question {
        QuestionText = "Which element has the chemical symbol 'O'?",
        Choice1 = "Oxygen",
        Choice2 = "Gold",
        Choice3 = "Silver",
        CorrectChoice = 1
    },
         new Question {
        QuestionText = "How many continents are there on Earth?",
        Choice1 = "5",
        Choice2 = "7",
        Choice3 = "6",
        CorrectChoice = 2
    },
         new Question {
        QuestionText = "What is the freezing point of water in Celsius?",
        Choice1 = "100°C",
        Choice2 = "0°C",
        Choice3 = "50°C",
        CorrectChoice = 2
    },
         new Question {
        QuestionText = "Which gas do plants absorb from the atmosphere?",
        Choice1 = "Oxygen",
        Choice2 = "Nitrogen",
        Choice3 = "Carbon Dioxide",
        CorrectChoice = 3
    },
         new Question {
        QuestionText = "Who painted the Mona Lisa?",
        Choice1 = "Vincent van Gogh",
        Choice2 = "Leonardo da Vinci",
        Choice3 = "Pablo Picasso",
        CorrectChoice = 2
    }
        };
        public struct GameResult
        {
            public int Score;          
            public int TotalQuestions; 
        }
        private GameResult playerResult = new GameResult { Score = 0, TotalQuestions = 0 };
        private int currentIndex = 0;
        private int timeLeft = 60;
        private void ResetButtonColors()
        {
            Color defaultColor = Color.FromArgb(80, 60, 45);
            btnChoice1.BackColor = defaultColor;
            btnChoice2.BackColor = defaultColor;
            btnChoice3.BackColor = defaultColor;

            btnChoice1.Enabled = true;
            btnChoice2.Enabled = true;
            btnChoice3.Enabled = true;
        }
        private async void OpenResultForm()
        {
            for (double j = 1.0; j > 0.0; j -= 0.1)
            {
                this.Opacity = j;
                await Task.Delay(20);
            }
            Score S = new Score(playerResult, quizQuestions.Length);
            S.Show();
            this.Hide();
            this.Opacity = 1.0;
        }
        private async void ShowResult(Button clickedButton, int selectedChoice)
        {
            int correctChoice = quizQuestions[currentIndex].CorrectChoice;
            playerResult.TotalQuestions++;
            if (selectedChoice == correctChoice)
            {
                playerResult.Score++;
            }
            else
            {
                clickedButton.BackColor = Color.FromArgb(231, 76, 60);
            }
            if (correctChoice == 1) btnChoice1.BackColor = Color.FromArgb(46, 204, 113);
            else if (correctChoice == 2) btnChoice2.BackColor = Color.FromArgb(46, 204, 113);
            else if (correctChoice == 3) btnChoice3.BackColor = Color.FromArgb(46, 204, 113);

            await Task.Delay(1000);
            currentIndex++;
            ResetButtonColors();
            DisplayQuestion();
        }
        private void DisplayQuestion()
        {
            
            if (currentIndex < quizQuestions.Length)
            {
                lblQuestionNumber.Text = (currentIndex + 1) + "/" + quizQuestions.Length;
                lblQuestion.Text = quizQuestions[currentIndex].QuestionText;                
                btnChoice1.Text = quizQuestions[currentIndex].Choice1;
                btnChoice2.Text = quizQuestions[currentIndex].Choice2;
                btnChoice3.Text = quizQuestions[currentIndex].Choice3;
                lblQuestion.Left = (this.ClientSize.Width - lblQuestion.Width) / 2;
            }
            else
            {          
                timer1.Stop();
                OpenResultForm();
            }
        }
    
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                lbltimer.Text = timeLeft.ToString(); 
            }
            else
            {                
                timer1.Stop();
                OpenResultForm(); 
            }
        }

        private void ChoiceButton_Click(object sender, EventArgs e)
        {           
            Button clickedButton = (Button)sender;         
            int selectedChoice = Convert.ToInt32(clickedButton.Tag);
            ShowResult(clickedButton, selectedChoice);
        }

        
    }
}
