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
            Random rand = new Random(); // Random number generato
            int[] randValues = new int[6]; //Array to hold random values
            int number = 0;

            int lines = cmbNumbers.SelectedIndex + 1; // Assign the selected index of cmbNumbers to numLines (+1 because the index starts at 0)

            for (int i = 0; i < lines; i++) // Loop through the number of lines
            {
                int lottoNumbers = 0;

                while (lottoNumbers < 6)
                {
                    number = rand.Next(1, 49);
                    if (Array.IndexOf(randValues, number) == -1)
                    {
                        randValues[lottoNumbers] = number;
                        lottoNumbers++;
                    }
                 }
                
                Array.Sort(randValues);               
                       
                // Display the values in the list box area
                listNumbers.Items.Add(randValues[0] + "\t" + randValues[1] + "\t" + randValues[2] +
                        "\t" + randValues[3] + "\t" + randValues[4] + "\t" + randValues[5]);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listNumbers.Items.Clear();
        }

        private void mnuClearTicket_Click(object sender, EventArgs e)
        {
            listNumbers.Items.Clear();
        }

    }
}
