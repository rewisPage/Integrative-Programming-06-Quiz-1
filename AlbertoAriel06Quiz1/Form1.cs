using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbertoAriel06Quiz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(classmateNameBox1.Text) ||
                string.IsNullOrEmpty(classmateNameBox2.Text) ||
                string.IsNullOrEmpty(classmateNameBox3.Text) ||
                string.IsNullOrEmpty(classmateNameBox4.Text) ||
                string.IsNullOrEmpty(classmateNameBox5.Text) ||
                string.IsNullOrEmpty(classmateNameBox6.Text))
            {
                MessageBox.Show("Fill up all fields!", "Input Error");
            }
            else
            {
                string[] className = new string[6];

                className[0] = classmateNameBox1.Text.ToString().Trim();
                className[1] = classmateNameBox2.Text.ToString().Trim();
                className[2] = classmateNameBox3.Text.ToString().Trim();
                className[3] = classmateNameBox4.Text.ToString().Trim();
                className[4] = classmateNameBox5.Text.ToString().Trim();
                className[5] = classmateNameBox6.Text.ToString().Trim();

                StringBuilder sb = new StringBuilder("The names of your classmates are: ");

                foreach (string name in className)
                {
                    sb.Append(name + ", ");
                }

                string result = sb.ToString();

                MessageBox.Show(result, "Input Result");

                classmateNameBox1.Clear();
                classmateNameBox2.Clear();
                classmateNameBox3.Clear();
                classmateNameBox4.Clear();
                classmateNameBox5.Clear();
                classmateNameBox6.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            this.Hide();

            form2.ShowDialog();

            this.Close();
        }
    }
}
