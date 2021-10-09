﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adam_asmaca
{
    public partial class Form1 : Form
    {
        string[] sehirler = { "ANKARA", "İZMİR", "VAN", "ÇANAKKALE", "DENİZLİ" };

        char[] alfabe = "ABCÇDEFGHIİJKLMNOÖPRSŞTUÜVYZ".ToCharArray();

        string sehir;

        int hak = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            harfPaneli.Controls.Clear();
            alfabePaneli.Controls.Clear();

            Random r = new Random();
            int rastgele = r.Next(0, sehirler.Length);
            sehir = sehirler[rastgele];

            for (int i = 0; i < alfabe.Length; i++)
            {
                Button harfButon = new Button();
                harfButon.Height = 20;
                harfButon.Width = 20;
                harfButon.Text = alfabe[i].ToString();
                harfButon.Click += HarfButon_Click;
                alfabePaneli.Controls.Add(harfButon);
            }

            int karakter_sayisi = sehir.Length;
            for (int i = 0; i < karakter_sayisi; i++)
            {
                TextBox txtBox = new TextBox();
                txtBox.Width = 30;
                txtBox.Height = 30;
                //txtBox.Text = sehir[i].ToString();
                txtBox.Enabled = false;
                harfPaneli.Controls.Add(txtBox);
            }
        }

        private void HarfButon_Click(object sender, EventArgs e)
        {
            Button harfButon = (Button)sender;
            harfButon.Enabled = false;

            char harf = harfButon.Text.First();

            if (sehir.Contains(harf))
            {
                harfButon.BackColor = Color.Green;

                for (int i = 0; i < sehir.Length; i++)
                {
                    if (harf == sehir[i])
                        harfPaneli.Controls[i].Text = harf.ToString();
                }

            }
            else
            {
                hak--;
                harfButon.BackColor = Color.Red;

                switch (hak)
                {

                    case 4:
                        pictureBox1.Image = Properties.Resources._1;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources._2;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources._3;
                        break;
                    case 1:
                        pictureBox1.Image = Properties.Resources._4;
                        break;
                    case 0:
                        pictureBox1.Image = Properties.Resources._0;
                        for (int i = 0; i < sehir.Length; i++)
                        {
                            harfPaneli.Controls[i].Text = sehir[i].ToString();
                        }
                        alfabePaneli.Controls.Clear();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
