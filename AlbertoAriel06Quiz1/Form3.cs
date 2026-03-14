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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string message = messageTextBox.Text;

            bool isContainsHello = message.ToLower().Contains("hello");

            if (isContainsHello)
            {
                label2.ForeColor = Color.Lime;
                label2.Text = "Result: The message contains hello!";
            }
            else
            {
                label2.ForeColor = Color.HotPink;
                label2.Text = "Result: The message does not contains hello.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            this.Hide();

            form2.ShowDialog();

            this.Close();
        }
    }
}
