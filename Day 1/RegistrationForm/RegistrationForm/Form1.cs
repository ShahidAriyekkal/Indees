using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            {
    string name = nm.Text;
    string phone = ph.Text;
    string email = em.Text;
    string gender = "";

    // Gender selection
    if (rb1.Checked)
    {
        gender = "Male";
    }
    else 
    {
                    gender = "Female";

                }
                    label1.Text = "Registered Succesfully...!";
                    
 

    // Display ONLY user input
    MessageBox.Show(
        name + ": "+tb1.Text+"\n" +
        phone +": "+ tb2.Text+ "\n" +
        email +": "+ tb3.Text+ "\n" +
        gender,
        "User Input"
    );
}

        }
    }
}
