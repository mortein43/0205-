using System;

namespace _0205_паліндром
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            string y = "";
            for (int i = x.Length-1, j = 0; i != -1; i--, j++)
            {
                char g = x[i];             
                y = y.Insert(j, g.ToString());

            }
            if (x.Equals(y))
            {
                label1.Text = "Це паліндром";
            } else
            {
                label1.Text = "Це не паліндром";
            }
        }
    }
}