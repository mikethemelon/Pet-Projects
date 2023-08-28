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
    public partial class Form1 : Form
    {
        private List<Button> answerButtons;
        private int totalQuestions;
        private int currentQuestionIndex;
        private int correctAnswersCount;
        private Random random;

        public Form1()
        {
            InitializeComponent();
            answerButtons = new List<Button> { btna, btnb, btnc, btnd };
            totalQuestions = 10; // Set the total number of questions
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



        private void MainForm_Load(object sender, EventArgs e)
        {
            // No need to call InitializeForm() here since it's already called in the constructor.
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            CheckAnswer(clickedButton);
        }

        private void DisableAnswerButtons()
        {
            foreach (Button button in answerButtons)
            {
                button.Enabled = false;
            }
        }

        private void EnableAnswerButtons()
        {
            foreach (Button button in answerButtons)
            {
                button.Enabled = true;
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void thirtyq_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
