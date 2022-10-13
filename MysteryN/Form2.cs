using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MysteryN
{
    public partial class gameScreen : Form
    {

        Random GenerateRandomValue = new Random();
        int maxValue = 0;
        int minValue = 0;
        int randomValue = 0;
        int attempts = 0;
        int wrongs = 0;
        int myguess = 0;
        int numbersOff = 0;
        string newLine = Environment.NewLine;
        int temp = 0;
        SoundPlayer uwu = new SoundPlayer(@"C:\Users\Danial\Desktop\visual studio\MysteryN\bin\wafs\waf_uwu.wav");
        SoundPlayer fortnite = new SoundPlayer(@"C:\Users\Danial\Desktop\visual studio\MysteryN\bin\wafs\ffornite waf.wav");
        SoundPlayer fart = new SoundPlayer(@"C:\Users\Danial\Desktop\visual studio\MysteryN\bin\wafs\perfect-fart wav.wav");
        SoundPlayer fail = new SoundPlayer(@"C:\Users\Danial\Desktop\visual studio\MysteryN\bin\wafs\spongebob-fail wav.wav");



        public gameScreen()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.StartPosition = FormStartPosition.CenterScreen;
            gbxPlay.Enabled = false;
            rtbxInfo.Text = "Enter the setup value first.";
            lblNumbersOff.Visible = false;
            cmbxAttempts.SelectedIndex = 4;
            gbxDebug.Enabled = false;
            gbxSetUp.BackColor = Color.FromArgb(32,32, 32);
        }
        
        //return=========================================================================================
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;   
        }

        //start==========================================================================================
        private void btnStartf2_Click(object sender, EventArgs e)
        {
            if (txbStartAt.Text == "")
            {
                txbStartAt.Text = "0";
                MessageBox.Show("You didnt fill anythig in!" + "\n" + "Default values for minimum were applied.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txbEndAt.Text == "")
            {
                txbEndAt.Text = "10";
                MessageBox.Show("You didnt fill anythig in!" + "\n" + "Default values for maximum were applied.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cmbxAttempts.Text == "")
            {
                cmbxAttempts.Text = "5";
                MessageBox.Show("You didnt fill anythig in!" + "\n" + "Default values for attempts were applied.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {


                uwu.Play();
                maxValue = Convert.ToInt32(txbEndAt.Text);
                minValue = Convert.ToInt32(txbStartAt.Text);

                randomValue = GenerateRandomValue.Next(minValue, maxValue);
                attempts = Convert.ToInt32(cmbxAttempts.Text);
                lblRemainingTries.Text = attempts.ToString();


                gbxSetUp.Enabled = false;
                gbxSetUp.BackColor = Color.FromArgb(64, 64, 64);

                gbxPlay.Enabled = true;
                gbxPlay.BackColor = Color.FromArgb(32, 32, 32);
                rtbxInfo.Text = ("Guess the number!");


                tbGuess.Maximum = randomValue;
                tbGuess.Minimum = minValue;

                pgbGuess.Maximum = attempts;
                pgbGuess.Value = attempts;
            }
            catch
            {
                MessageBox.Show("Please only enter numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtbxInfo.Text = ("Why would you even try that?");
                txbStartAt.Text = "0";
                txbEndAt.Text = "10";
            }

        }   
        //cheat========================================================================================
        private void btnCheat_Click(object sender, EventArgs e)
        {
            rtbxInfo.Text = ("Random value is " + randomValue.ToString());
        }


        //guess=========================================================================================
         void btnGuess_Click(object sender, EventArgs e)
        {
            try
            {
                myguess = Convert.ToInt32(txbMyGuess.Text);
                txbMyGuess.Text = myguess.ToString();



                if (myguess > maxValue)
                {
                    MessageBox.Show("You cant go over the maximum", "Error");
                }
                if (myguess < minValue)
                {
                    MessageBox.Show("You cant go under the minimum", "Error");
                }


                if (myguess == randomValue)
                {

                    tbGuess.Value = myguess;

                    lblCorrectIncorrect.Text = "Correct!";
                    lblCorrectIncorrect.ForeColor = Color.Green;
                    rtbxInfo.Text = ("You guessed it!" + newLine +
                    "-----------------------------" + newLine +
                    "Enter the setup value first.");
                    fortnite.Play();
                    MessageBox.Show("Congratulations you guessed it right!", "Yay!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    pgbGuess.Value = 0;

                    gbxPlay.Enabled = false;
                    gbxPlay.BackColor = Color.FromArgb(64, 64, 64);
                    gbxSetUp.Enabled = true;
                    gbxSetUp.BackColor = Color.FromArgb(32, 32, 32);

                    txbMyGuess.Text = "0";
                    lblRemainingTries.Text = "-";
                    lblWrongCounter.Text = "0";
                    wrongs = wrongs = 0;
                    lblCorrectIncorrect.Text = "?????";
                    lblCorrectIncorrect.ForeColor = Color.White;
                    lblNumbersOff.Text = "-";

                }
                else
                {
                    fart.Play();
                    attempts = attempts - 1;
                    lblRemainingTries.Text = attempts.ToString();

                    wrongs = wrongs + 1;
                    lblWrongCounter.Text = wrongs.ToString();

                    pgbGuess.Value = pgbGuess.Value - 1;

                    lblCorrectIncorrect.Text = "False!";
                    lblCorrectIncorrect.ForeColor = Color.Red;
                    rtbxInfo.Text = ("Nope! Try again.");

                    //numbersoff::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                    numbersOff = (randomValue - myguess);
                    lblNumbersOff.Text = numbersOff.ToString();



                    if (attempts == 0)
                    {
                        fail.Play();
                        MessageBox.Show("No more attempts! You lost!", "LOL noob.");
                        rtbxInfo.Text = "Enter the setup value first";

                        gbxPlay.Enabled = false;
                        gbxPlay.BackColor = Color.FromArgb(64, 64, 64);

                        gbxSetUp.Enabled = true;
                        gbxSetUp.BackColor = Color.FromArgb(32, 32, 32);

                        txbMyGuess.Text = "0";
                        lblRemainingTries.Text = "-";
                        lblWrongCounter.Text = "0";
                        wrongs = wrongs = 0;
                        lblCorrectIncorrect.Text = "?????";
                        lblCorrectIncorrect.ForeColor = Color.White;
                        lblNumbersOff.Text = "-";

                    }

                    if (myguess < minValue)
                    {
                        myguess = minValue;
                    }

                    if (myguess < randomValue)
                    {
                        tbGuess.Maximum = randomValue;
                        tbGuess.Value = myguess;
                    }

                    if (myguess > randomValue)
                    {
                        temp = (randomValue - (myguess - randomValue));

                        if (temp < minValue)
                        {
                            tbGuess.Value = minValue;
                        }
                        else
                        {
                            tbGuess.Value = randomValue - (myguess - randomValue);
                        }
                    }


                }
            }
            catch
            {
                MessageBox.Show("Please only enter numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtbxInfo.Text = ("Bruh -_-");
                txbMyGuess.Text = "";
            }
        }
        //tb scroll======================================================================================================
        private void tbGuess_Scroll(object sender, EventArgs e)
        {
            tbGuess.Value = tbGuess.Minimum;
            MessageBox.Show("DO NOT TOUCH THE SLIDER.", "NO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void btnNumbersOffShow_Click(object sender, EventArgs e)
        {
            

            if (lblNumbersOff.Visible == false)
            {
                lblNumbersOff.Visible = true;
            }
            else lblNumbersOff.Visible = false;
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            gbxPlay.Enabled = false;
            gbxPlay.BackColor = Color.FromArgb(64, 64, 64);

            gbxSetUp.Enabled = true;
            gbxSetUp.BackColor = Color.FromArgb(32, 32, 32);

            txbMyGuess.Text = "0";
            lblRemainingTries.Text = "-";
            lblWrongCounter.Text = "0";
            wrongs = wrongs = 0;
            lblCorrectIncorrect.Text = "?????";
            lblCorrectIncorrect.ForeColor = Color.White;
            lblNumbersOff.Text = "-";
            txbEndAt.Text = "";
            txbStartAt.Text = "";
            cmbxAttempts.Text = "";
            
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            txbStartAt.Text = "0";
            txbEndAt.Text = "10";
            cmbxAttempts.Text = "5";

        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            txbStartAt.Text = "0";
            txbEndAt.Text = "1000";
            cmbxAttempts.Text = "100";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            gbxDebug.Enabled = checkBox1.Checked;
            if (checkBox1.Checked)
            {
                gbxDebug.BackColor = Color.FromArgb(32, 32, 32);
            }
            else gbxDebug.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ik ben verliefd op jayjay");
        }
    }
}
