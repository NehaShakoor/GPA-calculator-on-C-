using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            float[] arr = new float[6];
            int[] arr1 = new int[6];
            float[] mul = new float[6];
            float suma = 0;
            int sum = 0;
            float gpa1 = 0;
            int a;
            string c;
            arr[0] = Int32.Parse(textBox1.Text);
            arr[1] = Int32.Parse(textBox2.Text);
            arr[2] = Int32.Parse(textBox3.Text);
            arr[3] = Int32.Parse(textBox4.Text);
            arr[4] = Int32.Parse(textBox5.Text);
            arr[5] = Int32.Parse(textBox6.Text);

            arr1[0] = Int32.Parse(comboBox1.Text);
            arr1[1] = Int32.Parse(comboBox2.Text);
            arr1[2] = Int32.Parse(comboBox3.Text);
            arr1[3] = Int32.Parse(comboBox4.Text);
            arr1[4] = Int32.Parse(comboBox5.Text);
            arr1[5] = Int32.Parse(comboBox6.Text);

            if (checkBox1.Checked)
            {
                arr[0] = 0;
            }
            if (checkBox2.Checked)
            {
                arr[1] = 0;
            }
            if (checkBox3.Checked)
            {
                arr[2] = 0;
            }
            if (checkBox4.Checked)
            {
                arr[3] = 0;
            }
            if (checkBox5.Checked)
            {
                arr[4] = 0;
            }
            if (checkBox6.Checked)
            {
                arr[5] = 0;
            }
            else
            {

            }

            for (int i = 0; i <= 5; i++)
            {
                mul[i] = arr[i] * arr1[i];
                suma += mul[i];
            }
            sum = arr1[0] + arr1[1] + arr1[2] + arr1[3] + arr1[4] + arr1[5];
            gpa1 = suma / sum;
            if (gpa1 >= 90 && gpa1 <= 100)
            {
                gpa.Text = "Your GPA = " + "A+" + ", 4.0";
            }
            else if (gpa1 < 90 && gpa1 >= 80)
            {
                gpa.Text = "Your GPA = " + "A" + ", 4.0";
            }
            else if (gpa1 < 80 && gpa1 >= 70)
            {
                gpa.Text = "Your GPA = " + "B" + ", 3.0";
            }
            else if (gpa1 < 70 && gpa1 >= 60)
            {
                gpa.Text = "Your GPA = " + "C" + ", 2.0";
            }
            else if (gpa1 < 60 && gpa1 >= 50)
            {
                gpa.Text = "Your GPA = " + "D" + ", 1.0";
            }
            else if (gpa1 < 50)
            {
                gpa.Text = "Your GPA = " + "F" + ", 0.0";
            }
            else
            {
                gpa.Text = "Withdrawn";
            }
        }

        private void oop_TextChanged(object sender, EventArgs e)
        {

        }

        private void gpa_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
