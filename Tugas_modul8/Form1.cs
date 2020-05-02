using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_modul8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        private float hitung (float hari,float harga,float supir)
        {
            return (hari * harga) + (hari * supir);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            float hari, hasil, harga, supir;
            for (int i = 1; i <= 3; i++)
            {
                if (i == 1)
                {
                    string message = "TELAT MENGEMBALIKAN DENDA Rp.300.000/hari";
                    string title = "Peringatan";
                    MessageBox.Show(message, title);
                }
                else if (i == 2)
                {
                    string message = "JANGAN SAMPAI TELAT";
                    string title = "Peringatan";
                    MessageBox.Show(message, title);
                }
                else if (i == 3)
                {
                    string message = "Terima kasih telah merental mobil ditempat kami";
                    string title = "Peringatan";
                    MessageBox.Show(message, title);
                }
            }
            Console.ReadLine();

            if (comboBox1.SelectedItem == "Avanza")
            {
                if (comboBox2.SelectedItem == "IYA")
                {
                    harga = 300000;
                    supir = 30000;
                    hari = float.Parse(this.hari.Text);
                    hasil = hitung(hari, harga, supir);
                    this.harga.Text = Convert.ToString(hasil);
                }
                else if (comboBox2.SelectedItem == "TIDAK")
                {
                    harga = 300000;
                    supir = 0;
                    hari = float.Parse(this.hari.Text);
                    hasil = (hari * harga) + supir;
                    this.harga.Text = Convert.ToString(hasil);
                }

            }
            else if (comboBox1.SelectedItem == "Innova")
            {
                if (comboBox2.SelectedItem == "IYA")
                {
                    harga = 450000;
                    supir = 30000;
                    hari = float.Parse(this.hari.Text);
                    hasil = (hari * harga) + supir;
                    this.harga.Text = Convert.ToString(hasil);
                }
                else if (comboBox2.SelectedItem == "TIDAK")
                {
                    harga = 450000;
                    supir = 0;
                    hari = float.Parse(this.hari.Text);
                    hasil = (hari * harga) + supir;
                    this.harga.Text = Convert.ToString(hasil);
                }
                
            }
            else if (comboBox1.SelectedItem == "Rush")
            {
                if (comboBox2.SelectedItem == "IYA")
                {
                    harga = 350000;
                    supir = 30000;
                    hari = float.Parse(this.hari.Text);
                    hasil = (hari * harga) + supir;
                    this.harga.Text = Convert.ToString(hasil);
                }
                else if (comboBox2.SelectedItem == "TIDAK")
                {
                    harga = 350000;
                    supir = 0;
                    hari = float.Parse(this.hari.Text);
                    hasil = (hari * harga) + supir;
                    this.harga.Text = Convert.ToString(hasil);
                }
                
            }
            else if (comboBox1.SelectedItem == "Fortuner")
            {
                if (comboBox2.SelectedItem == "IYA")
                {
                    harga = 650000;
                    supir = 30000;
                    hari = float.Parse(this.hari.Text);
                    hasil = (hari * harga) + supir;
                    this.harga.Text = Convert.ToString(hasil);
                }
                else if (comboBox2.SelectedItem == "TIDAK")
                {
                    harga = 650000;
                    supir = 10000;
                    hari = float.Parse(this.hari.Text);
                    hasil = (hari * harga) + supir;
                    this.harga.Text = Convert.ToString(hasil);
                }
                
            }
            else if (comboBox1.SelectedItem == "Alphard")
            {
                if (comboBox2.SelectedItem == "IYA")
                {
                    harga = 1000000;
                    supir = 30000;
                    hari = float.Parse(this.hari.Text);
                    hasil = (hari * harga) + supir;
                    this.harga.Text = Convert.ToString(hasil);
                }
                else if (comboBox2.SelectedItem == "TIDAK")
                {
                    harga = 1000000;
                    supir = 10000;
                    hari = float.Parse(this.hari.Text);
                    hasil = (hari * harga) + supir;
                    this.harga.Text = Convert.ToString(hasil);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
