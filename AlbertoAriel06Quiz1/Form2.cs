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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            this.Hide();

            form1.ShowDialog();

            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string[,] letters =
            {
                {"A", "B"},
                {"C", "D"},
                {"E", "F"}
            };

            resultText.Text = "[" + letters[0, 0] + "] [" + letters[0, 1] + "] [" + letters[1, 0] + "] [" + letters[1, 1] + "] [" + letters[2, 0] + "] [" + letters[2, 1] + "]";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }
    }
}
