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
        int count = 1; // Counter for adding values to my lotto text box's

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // On form load, populate both my combo box's with values
            for (int i = 1; i < 11; i++)
            {
                cmbNumbers.Items.Add(i); // 1 to 10
            }

            for (int i = 1; i < 50; i++)
            {
                cmbNumber2.Items.Add(i); // 1 to 49
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

        // Play button click method
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

                Array.Sort(lottoNumbers); // Sort the lotto numbers before displaying them

                // Display the values in the list box area
                listNumbers.Items.Add(lottoNumbers[0] + "\t" + lottoNumbers[1] + "\t" + lottoNumbers[2] +
                        "\t" + lottoNumbers[3] + "\t" + lottoNumbers[4] + "\t" + lottoNumbers[5]);
            }
        }

        // Clear the list items method
        private void btnClear_Click(object sender, EventArgs e)
        {
            listNumbers.Items.Clear();
        }

        private void btnAddToLine_Click(object sender, EventArgs e)
        {
            addToTextBoxes(); // When the button is clicked, call this method
            count++; // after method call, increment the global counter
        }

        // Method to add values to text box's
        private void addToTextBoxes()
        {
            switch (count)
            {
                case 1:
                    textBox1.Text = cmbNumber2.Text; // Add the selected text from the combo box to the text Box
                    cmbNumber2.Items.Remove(cmbNumber2.SelectedItem); // Remove the selected item from the combo box
                    // If the user clicks the "Add to Line" button twice, then 
                    // stop it and reverse the global count so it can be entered again.
                    if (textBox1.Text == "") 
                    {
                        MessageBox.Show("Error, skipping a box not allowed!");
                        count--;
                    }
                    break;
                case 2:
                    textBox2.Text = cmbNumber2.Text; 
                    cmbNumber2.Items.Remove(cmbNumber2.SelectedItem);
                    if (textBox2.Text == "")
                    {
                        MessageBox.Show("Error, skipping a box not allowed!");
                        count--;
                    }
                    break;
                case 3:
                    textBox3.Text = cmbNumber2.Text;
                    cmbNumber2.Items.Remove(cmbNumber2.SelectedItem);
                    if (textBox3.Text == "")
                    {
                        MessageBox.Show("Error, skipping a box not allowed!");
                        count--;
                    }
                    break;
                case 4:
                    textBox4.Text = cmbNumber2.Text;
                    cmbNumber2.Items.Remove(cmbNumber2.SelectedItem);
                    if (textBox4.Text == "")
                    {
                        MessageBox.Show("Error, skipping a box not allowed!");
                        count--;
                    }
                    break;
                case 5:
                    textBox5.Text = cmbNumber2.Text;
                    cmbNumber2.Items.Remove(cmbNumber2.SelectedItem);
                    if (textBox5.Text == "")
                    {
                        MessageBox.Show("Error, skipping a box not allowed!");
                        count--;
                    }
                    break;
                case 6:
                    textBox6.Text = cmbNumber2.Text;
                    cmbNumber2.Items.Remove(cmbNumber2.SelectedItem);
                    if (textBox6.Text == "")
                    {
                        MessageBox.Show("Error, skipping a box not allowed!");
                        count--;
                    }
                    break;
                default:
                    MessageBox.Show("There are already 6 numbers!");
                    break;
            }
        }

        // Method to clear the text box's and reset the lines
        private void btnClearLine_Click(object sender, EventArgs e)
        {
            resetMyTextAndCombo(); // I used a method so I can call it multiple times!
        }

        // A method to reset my text box's and comboBox
        private void resetMyTextAndCombo()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            cmbNumber2.Items.Clear(); // First clear the combobox of all numbers

            // Then reload the combobox with the numbers again
            for (int i = 1; i < 50; i++)
            {
                cmbNumber2.Items.Add(i); // 1 to 49
            }

            count = 1; // Reset the counter!
        }

        // A method to add the text box numbers to my list box
        private void btnAddLine_Click(object sender, EventArgs e)
        {
            int[] lottoNumbers = new int[6]; // local variable lottoNumbers, not the same as above!

            if (textBox6.Text == "") // If this text box is empty, then all the box's are not complete
            {
                MessageBox.Show("Please fill all numbers first!");
            }

            // If textBox6 is not empty, then its logical to assume that all values 
            // have been entered 
            else 
            {
                // Assign values from the text boxes into the lottoNumbers array
                lottoNumbers[0] = int.Parse(textBox1.Text); 
                lottoNumbers[1] = int.Parse(textBox2.Text);
                lottoNumbers[2] = int.Parse(textBox3.Text);
                lottoNumbers[3] = int.Parse(textBox4.Text);
                lottoNumbers[4] = int.Parse(textBox5.Text);
                lottoNumbers[5] = int.Parse(textBox6.Text);

                resetMyTextAndCombo(); // Reset the text box's and reset the comboBox

                Array.Sort(lottoNumbers); // Sort the array before displaying it

                // Display the values in the list box area
                listNumbers2.Items.Add(lottoNumbers[0] + "\t" + lottoNumbers[1] + "\t" + lottoNumbers[2] +
                        "\t" + lottoNumbers[3] + "\t" + lottoNumbers[4] + "\t" + lottoNumbers[5]);
            }
        }

        // Reset the listbox and call the resetMyTextBoxAndLines() method as well (to clear everything!)
        private void btnClearTicket_Click(object sender, EventArgs e)
        {
            listNumbers2.Items.Clear();
            resetMyTextAndCombo();
        }
    }
}
