using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MODUL3_103022400063
{
    public partial class Form1 : Form
    {
        String input = "";
        double hasil = 0;
        String operasi = "";
        bool hasiloperasi = false;
        string tester;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBox1.Text = input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBox1.Text = input;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            input = "";
            hasil = 0;
            operasi = "";
            hasiloperasi = false;
            textBox1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBox1.Text = input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBox1.Text = input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBox1.Text = input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBox1.Text = input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBox1.Text = input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBox1.Text = input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBox1.Text = input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBox1.Text = input;
        }

        private void Evaluasi()
        {
            if (hasiloperasi)
            {
                double secondNumber = double.Parse(input);
                switch (operasi)
                {
                    case "+":
                        hasil += secondNumber;
                        break;
                }
            }
            textBox1.Text = hasil.ToString();
            input = "";
            hasiloperasi = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
                if (hasiloperasi)
            {
                Evaluasi();
            }
            Button button = (Button)sender;
            operasi = button.Text;
            hasil = double.Parse(input);
            input = "";
            hasiloperasi = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (hasiloperasi)
            {
                Evaluasi();
            }
            Button button = (Button)sender;
            operasi = button.Text;
            hasil = double.Parse(input);
            input = "";
            hasiloperasi = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
