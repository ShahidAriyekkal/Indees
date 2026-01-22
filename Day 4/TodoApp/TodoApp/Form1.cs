using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TodoApp
{
    public partial class Form1 : Form
    {
        string filePath = "tasks.txt";

        public Form1()
        {
            InitializeComponent();
            LoadTasks();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
                RefreshTaskNumbers();
                SaveTasks();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a task.");
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                RefreshTaskNumbers();
                SaveTasks();
            }
            else
            {
                MessageBox.Show("Please select a task to remove.");
            }
        }


        private void RefreshTaskNumbers()
        {
            List<string> tasks = new List<string>();

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string task = listBox1.Items[i].ToString();

                // Remove old number if exists
                if (task.Contains(". "))
                    task = task.Substring(task.IndexOf(". ") + 2);

                tasks.Add($"{i + 1}. {task}");
            }

            listBox1.Items.Clear();
            listBox1.Items.AddRange(tasks.ToArray());
        }



        private void SaveTasks()
        {
            List<string> tasks = new List<string>();

            foreach (var item in listBox1.Items)
            {
                tasks.Add(item.ToString());
            }

            File.WriteAllLines(filePath, tasks);
        }

        private void LoadTasks()
        {
            if (File.Exists(filePath))
            {
                string[] tasks = File.ReadAllLines(filePath);
                listBox1.Items.AddRange(tasks);
                RefreshTaskNumbers();
            }
        }

    }
}