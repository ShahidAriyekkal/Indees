using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentClass
{
    public partial class Form1 : Form
    {
        private readonly List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();

            // wire the button
            this.button1.Click += Button1_Click;

            // configure the ListView to behave like a grid with columns
            listView1.View = View.Details;                // show columns
            listView1.FullRowSelect = true;               // select whole row
            listView1.GridLines = true;                   // draw grid lines
            listView1.HideSelection = false;
            listView1.Columns.Clear();
            listView1.Columns.Add("Name", 110, HorizontalAlignment.Left);
            listView1.Columns.Add("Age", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("Course", 120, HorizontalAlignment.Left);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text.Trim();
            var ageText = textBox2.Text.Trim();
            var course = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (!int.TryParse(ageText, out var age) || age < 0)
            {
                MessageBox.Show("Please enter a valid non-negative integer for age.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            if (string.IsNullOrEmpty(course))
            {
                MessageBox.Show("Please enter a course.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }

            var student = new Student(name, age, course);
            students.Add(student);

            // Create a ListViewItem with subitems so each detail appears in its column
            var item = new ListViewItem(student.Name);   // column 0
            item.SubItems.Add(student.Age.ToString());   // column 1
            item.SubItems.Add(student.Course);           // column 2
            listView1.Items.Add(item);                   // add the row to the grid

            // optional: auto-resize columns to fit content (uncomment if desired)
            // listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            // listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            // clear inputs for next entry
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }
    }
}
