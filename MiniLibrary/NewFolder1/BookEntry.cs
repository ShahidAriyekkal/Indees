using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniLibrary.NewFolder1
{
    public partial class BookEntry : Form
    {
        public BookEntry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
              
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            MessageBox.Show("Book Added Successfully!");
            using (SqlConnection con = new SqlConnection("server =; Database =TodoDb ; Trusted_Connection = True;"))
            {
                   con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Book (Title, Author, Genre) VALUES (@Title, @Author, @Genre)", con);
                cmd.Parameters.AddWithValue("@Title", textBox1.Text);
                cmd.Parameters.AddWithValue("@Author", textBox2.Text);
                cmd.Parameters.AddWithValue("@Genre", textBox3.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            }
            

        

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Close();
        }
    }
}
