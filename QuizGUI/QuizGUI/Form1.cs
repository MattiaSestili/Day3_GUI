using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGUI
{
    public partial class Form1 : Form
    {
        int timeleft = 60;
        bool q3correct = true;
        bool q1correct = false;
        bool q2correct = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeleft = 60;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {

                //update and display the time left
                timeleft--;
                labelTimeLeft.Text = timeleft + "seconds";
            }
            else
            {
                //if the user run out of
                timer1.Stop();
                labelTimeLeft.Text = "Time's up!";
                MessageBox.Show("You ran out of time", "Sorry");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //display an alert to the user which I'll closing the game
            MessageBox.Show("You are closing this game!");
            Close();
        }

        private void radioButtonQ3A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A3.Checked)
            {
                labelAnswer.ForeColor = Color.Green;
                labelAnswer.Text = "\u00fc"; //tick
                q3correct = true;
            }
            else
            {
                labelAnswer.Text = "";
            }
        }

        private void radioButtonQ1A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A2.Checked)
            {
                labelAnswer.ForeColor = Color.Red;
                labelAnswer.Text = "\u00fb"; //cross
                q2correct = false;
            }
            else
            {
                labelAnswer.Text = "";
            }
        }

        private void radioButtonQ1A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A1.Checked)
            {
                labelAnswer.ForeColor = Color.Red;
                labelAnswer.Text = "\u00fb"; //cross
                q1correct = false;
            }
            else
            {
                labelAnswer.Text = "";
            }
        }
    }
}
