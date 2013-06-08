using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace PlayLotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                cmbNumbers.Items.Add(i);
                //cmbNumbers.SelectedItem = 1;
            }

            for (int i = 1; i < 50; i++)
            {
                cmbNumber2.Items.Add(i);
                //cmbNumber2.SelectedItem = 1;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mnuClear_Click(object sender, EventArgs e)
        {

        }

        private void tabSelectOwnNum_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Random rand = new Random(); // Random number generator
            int[] lottoNumbers = new int[6]; //Array to hold random values for the lotto numbers
            int randomNumber = 0;

            int lines = cmbNumbers.SelectedIndex + 1; // Assign the selected index of cmbNumbers to numLines (+1 because the index starts at 0)

            for (int i = 0; i < lines; i++) // Loop through the number of lines chosen from the cmbNumbers
            {
                int lottoNumberIndex = 0;

                while (lottoNumberIndex < 6)
                {
                    randomNumber = rand.Next(1, 49);
                    if (Array.IndexOf(lottoNumbers, randomNumber) == -1) //
                    {
                        lottoNumbers[lottoNumberIndex] = randomNumber;
                        lottoNumberIndex++;
                    }
                }

                Array.Sort(lottoNumbers);

                // Display the values in the list box area
                listNumbers.Items.Add(lottoNumbers[0] + "\t" + lottoNumbers[1] + "\t" + lottoNumbers[2] +
                        "\t" + lottoNumbers[3] + "\t" + lottoNumbers[4] + "\t" + lottoNumbers[5]);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listNumbers.Items.Clear();
        }

        private void btnAddToLine_Click(object sender, EventArgs e)
        {
            // Argh! Damit this is annoying.. to be continued.....
            textBox1.Text = cmbNumber2.GetItemText(cmbNumber2.SelectedIndex + 1);
            cmbNumber2.GetContainerControl();
            textBox2.Text = cmbNumber2.GetItemText(cmbNumber2.SelectedIndex + 1);
            textBox3.Text = cmbNumber2.GetItemText(cmbNumber2.SelectedIndex + 1);
            textBox4.Text = cmbNumber2.GetItemText(cmbNumber2.SelectedIndex + 1);
            textBox5.Text = cmbNumber2.GetItemText(cmbNumber2.SelectedIndex + 1);
            textBox6.Text = cmbNumber2.GetItemText(cmbNumber2.SelectedIndex + 1);
        }

        private void cmbNumber2_SelectedIndexChanged(object sender, EventArgs e)
        {
            {

            }

        }
    }
}
