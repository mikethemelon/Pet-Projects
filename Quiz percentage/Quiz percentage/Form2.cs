using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_percentage
{
    public partial class Form2 : Form
    {
        private List<Button> answerButtons;
        private int totalQuestions;
        private int currentQuestionIndex;
        private int correctAnswersCount;
        private Random random;

        public Form2()
        {
            InitializeComponent();
            answerButtons = new List<Button> { btna, btnb, btnc, btnd };
            totalQuestions = 30; // Set the total number of questions
            currentQuestionIndex = -1; // Start from -1 to show the first question
            correctAnswersCount = 0;
            random = new Random();
            InitializeForm();
        }

        private void InitializeForm()
        {
            Text = "Quiz Percentage";

            foreach (Button button in answerButtons)
            {
                button.Click += AnswerButton_Click;
            }

            Label resultLabel = new Label
            {
                Location = new System.Drawing.Point(10, 150),
                AutoSize = true
            };
            Controls.Add(resultLabel);

            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            currentQuestionIndex++;

            if (currentQuestionIndex < totalQuestions)
            {
                SetAnswersRandomly();
            }
            else
            {
                CalculateAndDisplayResult();
                DisableAnswerButtons(); // Disable answer buttons after completing all questions
            }
        }

        private void SetAnswersRandomly()
        {
            int correctIndex = random.Next(answerButtons.Count); // Randomly select the index for the correct answer
            for (int i = 0; i < answerButtons.Count; i++)
            {
                answerButtons[i].Text = ((char)('A' + i)).ToString();
                answerButtons[i].Tag = i == correctIndex ? "correct" : "incorrect";
            }
        }

        private void CheckAnswer(Button clickedButton)
        {
            if (clickedButton.Tag.ToString() == "correct")
            {
                correctAnswersCount++;
            }

            ShowNextQuestion();
        }

        private void CalculateAndDisplayResult()
        {
            double percentage = (double)correctAnswersCount / totalQuestions * 100;
            ResultLabel.Text = $"You got {correctAnswersCount} out of {totalQuestions} correct ({percentage:F2}%).";
        }


        private void DisableAnswerButtons()
        {
            foreach (Button button in answerButtons)
            {
                button.Enabled = false;
            }
        }
        private void AnswerButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            CheckAnswer(clickedButton);
        }

        private void EnableAnswerButtons()
        {
            foreach (Button button in answerButtons)
            {
                button.Enabled = true;
            }
        }

        private void tenq_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            // Reset all variables and controls to their initial state
            currentQuestionIndex = -1;
            correctAnswersCount = 0;
            SetAnswersRandomly();
            EnableAnswerButtons();
            ResultLabel.Text = "";
            ShowNextQuestion();
        }
    }
}
