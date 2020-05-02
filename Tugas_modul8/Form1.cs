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
                    harga = 300000;
                    alat = 30000;
                    hari = float.Parse(this.hari.Text);
                    hasil = (hari * harga) + alat;
                    this.harga.Text = Convert.ToString(hasil);
                }
                else if (comboBox2.SelectedItem == "P3K")
                {
                    harga = 300000;
                    alat = 10000;
                    hari = float.Parse(this.hari.Text);
                    hasil = (hari * harga) + alat;
                    this.harga.Text = Convert.ToString(hasil);
                }
                else if (comboBox2.SelectedItem == "Tidak Usah")
                {
                    harga = 300000;
                    alat = 0;
                    hari = float.Parse(this.hari.Text);
                    hasil = (hari * harga) + alat;
                    this.harga.Text = Convert.ToString(hasil);
                }

            }
            else if (comboBox1.SelectedItem == "Innova")
            {
                if (comboBox2.SelectedItem == "Payung")
                {
                    harga = 450000;
                    alat = 30000;
                    hari = float.Parse(this.hari.Text);
                    hasil = (hari * harga) + alat;
                    this.harga.Text = Convert.ToString(hasil);
                }
                else if (comboBox2.SelectedItem == "P3K")
                {
                    harga = 450000;
                    alat = 10000;
                    hari = float.Parse(this.hari.Text);
                    hasil = (hari * harga) + alat;
                    this.harga.Text = Convert.ToString(hasil);
                }
                else if (comboBox2.SelectedItem == "Tidak Usah")
                {
                    harga = 450000;
                    alat = 0;
                    hari = float.Parse(this.hari.Text);
                    hasil = (hari * harga) + alat;
                    this.harga.Text = Convert.ToString(hasil);
                }
                else if (comboBox1.SelectedItem == "Rush")
                {
                    if (comboBox2.SelectedItem == "Payung")
                    {
                        harga = 350000;
                        alat = 30000;
                        hari = float.Parse(this.hari.Text);
                        hasil = (hari * harga) + alat;
                        this.harga.Text = Convert.ToString(hasil);
                    }
                    else if (comboBox2.SelectedItem == "P3K")
                    {
                        harga = 350000;
                        alat = 10000;
                        hari = float.Parse(this.hari.Text);
                        hasil = (hari * harga) + alat;
                        this.harga.Text = Convert.ToString(hasil);
                    }
                    else if (comboBox2.SelectedItem == "Tidak Usah")
                    {
                        harga = 350000;
                        alat = 0;
                        hari = float.Parse(this.hari.Text);
                        hasil = (hari * harga) + alat;
                        this.harga.Text = Convert.ToString(hasil);
                    }
                }
                else if (comboBox1.SelectedItem == "Fortuner")
                {
                    if (comboBox2.SelectedItem == "Payung")
                    {
                        harga = 650000;
                        alat = 30000;
                        hari = float.Parse(this.hari.Text);
                        hasil = (hari * harga) + alat;
                        this.harga.Text = Convert.ToString(hasil);
                    }
                    else if (comboBox2.SelectedItem == "P3K")
                    {
                        harga = 650000;
                        alat = 10000;
                        hari = float.Parse(this.hari.Text);
                        hasil = (hari * harga) + alat;
                        this.harga.Text = Convert.ToString(hasil);
                    }
                    else if (comboBox2.SelectedItem == "Tidak Usah")
                    {
                        harga = 650000;
                        alat = 0;
                        hari = float.Parse(this.hari.Text);
                        hasil = (hari * harga) + alat;
                        this.harga.Text = Convert.ToString(hasil);
                    }
                }
                else if (comboBox1.SelectedItem =="Alphard")
                {
                    if (comboBox2.SelectedItem == "Payung")
                    {
                        harga = 1000000;
                        alat = 30000;
                        hari = float.Parse(this.hari.Text);
                        hasil = (hari * harga) + alat;
                        this.harga.Text = Convert.ToString(hasil);
                    }
                    else if (comboBox2.SelectedItem == "P3K")
                    {
                        harga = 1000000;
                        alat = 10000;
                        hari = float.Parse(this.hari.Text);
                        hasil = (hari * harga) + alat;
                        this.harga.Text = Convert.ToString(hasil);
                    }
                    else if (comboBox2.SelectedItem == "Tidak Usah")
                    {
                        harga = 1000000;
                        alat = 0;
                        hari = float.Parse(this.hari.Text);
                        hasil = (hari * harga) + alat;
                        this.harga.Text = Convert.ToString(hasil);
                    }
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
