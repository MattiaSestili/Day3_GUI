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
        bool q1correct = false;
        bool q2correct = false;
        bool q3correct = false;

        public Form1()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;

            timeleft = 60;
            timer1.Start();
            button1.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (q1correct&&q2correct&&q3correct)
            {
                timer1.Stop();
                MessageBox.Show("Well Done!!! You got all the question right");
            }
            else if (timeleft > 0)
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

        private void radioButtonQ1A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A3.Checked)
            {
                labelAnswer1.ForeColor = Color.Green;
                labelAnswer1.Text = "\u00fc"; //cross
                q1correct = true;
            }
            else
            {
                labelAnswer1.Text = "";
            }
        }

        private void radioButtonQ1A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A2.Checked)
            {
                labelAnswer1.ForeColor = Color.Red;
                labelAnswer1.Text = "\u00fb"; //cross
                q1correct = false;
            }
            else
            {
                labelAnswer1.Text = "";
            }
        }

        private void radioButtonQ1A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A1.Checked)
            {
                labelAnswer1.ForeColor = Color.Red;
                labelAnswer1.Text = "\u00fb"; //cross
                q1correct = false;
            }
            else
            {
                labelAnswer1.Text = "";
            }
        }

        private void radioButtonQ1A3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButtonQ1A3.Checked)
            {
                labelAnswer1.ForeColor = Color.Green;
                labelAnswer1.Text = "\u00fc"; //tick
                q1correct = true;
            }
            else
            {
                labelAnswer1.Text = "";
            }
        }

        private void radioButtonQ2A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A1.Checked)
            {
                labelAnswer2.ForeColor = Color.Green;
                labelAnswer2.Text = "\u00fc"; //tick
                q2correct = true;
            }
            else
            {
                labelAnswer2.Text = "";
            }
        }

        private void radioButtonQ2A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A2.Checked)
            {
                labelAnswer2.ForeColor = Color.Red;
                labelAnswer2.Text = "\u00fb"; //cross
                q2correct = false;
            }
            else
            {
                labelAnswer2.Text = "";
            }
        }

        private void radioButtonQ2A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A3.Checked)
            {
                labelAnswer2.ForeColor = Color.Red;
                labelAnswer2.Text = "\u00fb"; //cross
                q2correct = false;
            }
            else
            {
                labelAnswer2.Text = "";
            }
        }

        private void radioButtonQ3A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A1.Checked)
            {
                labelAnswer3.ForeColor = Color.Red;
                labelAnswer3.Text = "\u00fb"; //cross
                q3correct = false;
            }
            else
            {
                labelAnswer3.Text = "";
            }
        }

        private void radioButtonQ3A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A2.Checked)
            {
                labelAnswer3.ForeColor = Color.Green;
                labelAnswer3.Text = "\u00fc"; //tick
                q3correct = true;
            }
            else
            {
                labelAnswer3.Text = "";
            }
        }

        private void radioButtonQ3A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A3.Checked)
            {
                labelAnswer3.ForeColor = Color.Red;
                labelAnswer3.Text = "\u00fb"; //cross
                q3correct = false;
            }
            else
            {
                labelAnswer3.Text = "";
            }
        }
    }
}
