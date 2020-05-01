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

        private void button1_Click(object sender, EventArgs e)
        {
            float hari, hasil, harga, alat;

            if (comboBox1.SelectedItem == "Avanza")
            {
                if (comboBox2.SelectedItem == "Payung")
                {
                    harga = 200000;
                    alat = 30000;
                    hari = float.Parse(this.hari.Text);
                    hasil = (hari * harga) + alat;
                    this.harga.Text = Convert.ToString(hasil);
                }
                else if (comboBox2.SelectedItem == "P3K")
                {
                    harga = 200000;
                    alat = 10000;
                    hari = float.Parse(this.hari.Text);
                    hasil = (hari * harga) + alat;
                    this.harga.Text = Convert.ToString(hasil);
                }
            }
            else if (comboBox1.SelectedItem == "Kijang")
            {
                if (comboBox2.SelectedItem == "Payung")
                {
                    harga = 150000;
                    alat = 30000;
                    hari = float.Parse(this.hari.Text);
                    hasil = (hari * harga) + alat;
                    this.harga.Text = Convert.ToString(hasil);
                }
                else if (comboBox2.SelectedItem == "P3K")
                {
                    harga = 150000;
                    alat = 10000;
                    hari = float.Parse(this.hari.Text);
                    hasil = (hari * harga) + alat;
                    this.harga.Text = Convert.ToString(hasil);
                }
                else if (comboBox1.SelectedItem == "APV")
                {
                    if (comboBox2.SelectedItem == "Payung")
                    {
                        harga = 250000;
                        alat = 30000;
                        hari = float.Parse(this.hari.Text);
                        hasil = (hari * harga) + alat;
                        this.harga.Text = Convert.ToString(hasil);
                    }
                    else if (comboBox2.SelectedItem == "P3K")
                    {
                        harga = 250000;
                        alat = 10000;
                        hari = float.Parse(this.hari.Text);
                        hasil = (hari * harga) + alat;
                        this.harga.Text = Convert.ToString(hasil);
                    }
                }
            }
        }
    }
}
