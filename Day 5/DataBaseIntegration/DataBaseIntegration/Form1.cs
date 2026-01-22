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
using System.Xml.Linq;

namespace DataBaseIntegration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Server = ; Database = TodoDb ; Trusted_Connection = True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Students(Name, Age, Course) VALUES(@Name, @Age, @Course)", conn);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Age", int.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@Course", textBox3.Text);
                cmd.ExecuteNonQuery();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Server = ; Database = TodoDb ; Trusted_Connection = True;"))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }
    }
}
