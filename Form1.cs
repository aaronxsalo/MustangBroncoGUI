using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MustandBroncoGUI
{
    public partial class mustangBronco : Form
    {
        public mustangBronco()
        {
            InitializeComponent();
            txtInput.Focus(); //sets focus to txtInput textbox
        }

        private string mustBronc(int input) //checks if user's int input is divisible by 3 (Mustang) and/or 5 (Bronco) - neither echoes input  
        {
            string final = ""; //holds final descision output - mustang, bronco, both, or neither
            int rem1 = 0; //holds the remainder while divided by 3
            int rem2 = 0; //holds the reaminder while divided by 5

            rem1 = input % 3; //finds remainder for dividing by 3
            rem2 = input % 5; //finds remainder for dividing by 5

            if (rem1 == 0) //Mustang - number divisible by 3 (remainder is 0 when divided by 3)
            {
                final += "Mustang";
            }

            if (rem2 == 0) //Bronco - number divisible by 5 (remainder is 0 when divided by 5)
            {
                final += "Bronco";
            }

            if (final == "") //display input - neither divisible by 3 or 5 (first two "if" statements didn't happen - no change to final)
            {
                final = input.ToString();
            }

            return final; //returns final output
        }
        
        private void btnSubmit_Click(object sender, EventArgs e) //code for the btnSubmit button - processes the user input
        {
            int input = 0; //holds user integer input

            try //error checking for the string to int parse from the txtInput textbox
            {
                lblMustBronc.Text = "-"; //resets lblMustBronc label in case of past uses
                input = Int32.Parse(txtInput.Text); //performs the string to int parse from the txtInput textbox
            }
            catch //displays input error to user for invalid non-integer input
            {
                System.Windows.Forms.MessageBox.Show("Unable to process input. Please enter an integer.", "Input Error"); //displays error message popup
                return; //exits 
            }

            lblMustBronc.Text = mustBronc(input); //calls mustBronc function to process input
        }

        private void btnClear_Click(object sender, EventArgs e) //code for the btnClear button - clears the form
        {
            lblMustBronc.Text = "-"; //clears the lblMustBronc label
            txtInput.Text = ""; //clears txtInput textbox
        }
    }
}
