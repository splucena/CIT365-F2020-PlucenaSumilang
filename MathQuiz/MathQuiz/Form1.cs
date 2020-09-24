using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class frmMathQuiz : Form
    {
        // Create a random object called randomizer
        // generate a random number.
        Random randomizer = new Random();

        // These integer variables stores the numbers
        // for the addition problem.
        int addend1;
        int addend2;

        // These integer variables stores the numbers
        // for the subtraction problem.
        int minuend;
        int subtrahend;

        // These integer variables stores the numbers
        // for the multiplication problem.
        int multiplicand;
        int multiplier;

        // These integer variables stores the numbers
        // for the diviion problems
        int dividend;
        int divisor;

        // This integer variable keeps track of the
        // remaining time
        int timeLeft;
        public frmMathQuiz()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Disable all numericupdown elements.
            sum.Enabled = false;
            difference.Enabled = false;
            product.Enabled = false;
            quotient.Enabled = false;

            lblDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Start the quiz by filling in all of the problems and starting the timer
        /// </summary>
        public void StartTheQuiz()
        {
            // Enable numericupdown elements.
            sum.Enabled = true;
            difference.Enabled = true;
            product.Enabled = true;
            quotient.Enabled = true;

            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            sum.Value = 0;

            // Fill in the subrtraction problem.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timeLeftLabel.Text = multiplicand.ToString();
            timeRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Fill in the division problems
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            // Start the timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;

            sum.BackColor = Color.White;
            difference.BackColor = Color.White;
            product.BackColor = Color.White;
            quotient.BackColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user
                // got the answer right. Stop the timer
                // and show a Messagebox.
                timer1.Stop();
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("You got all the answers right!", "Congratulations!");
                startButton.Enabled = true;
                // Disable all numericupdown elements.
                sum.Enabled = false;
                difference.Enabled = false;
                product.Enabled = false;
                quotient.Enabled = false;
            }
            else if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
                // Disable all numericupdown elements.
                sum.Enabled = false;
                difference.Enabled = false;
                product.Enabled = false;
                quotient.Enabled = false;
            }

            if (timeLeft > 0 && timeLeft < 5)
            {
                System.Media.SystemSounds.Hand.Play();
            }
            
        }

        private bool CheckTheAnswer()
        {
            if (addend1 + addend2 == sum.Value
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown Control
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void sum_ValueChanged(object sender, EventArgs e)
        {
            if (addend1 + addend2 == sum.Value)
            {
                sum.BackColor = Color.White;
            } else
            {
                sum.BackColor = Color.Red;
            }
        }

        private void difference_ValueChanged(object sender, EventArgs e)
        {
            if (minuend - subtrahend == difference.Value)
            {
                difference.BackColor = Color.White;
            } else
            {
                difference.BackColor = Color.Red;
            }
        }

        private void product_ValueChanged(object sender, EventArgs e)
        {
            if (multiplicand * multiplier == product.Value)
            {
                product.BackColor = Color.White;
            } else
            {
                product.BackColor = Color.Red;
            }
        }

        private void quotient_ValueChanged(object sender, EventArgs e)
        {
            if (dividend / divisor == quotient.Value)
            {
                quotient.BackColor = Color.White;
            } else
            {
                quotient.BackColor = Color.Red;
            }
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
