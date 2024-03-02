using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilhaKm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CmbBox1.Items.Add("M/h -> Km/h");
            CmbBox1.Items.Add("Km/h -> M/h");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Converte converte = new Converte() { media = txtValor1.Text };

            if (CmbBox1.SelectedIndex == 1)
            {
                txtResultado1.Text = converte.getKm() + " M/h";

            }

            else
            {
                txtResultado1.Text = converte.getMilhas() + "Km/h";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Converte converte2 = new Converte() { media = textBox1.Text };

            if (radioButton1.Checked)
            {
                textBox2.Text = converte2.getKm() + "M/h";
            }

            else
            {
                textBox2.Text = converte2.getMilhas() + "Km/h";
            }
                
            
            
            
        }
    }
}