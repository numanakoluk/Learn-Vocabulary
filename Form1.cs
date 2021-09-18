using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Learn_Vocabulary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\nMn\Desktop\dbSozluk\dbSozluk.accdb");
        Random rast = new Random();
        int time = 90;
        int vocobulary = 0;


        void bring()
        {

            int sayi;
            sayi = rast.Next(1, 2490);
            LblAnswer.Text = sayi.ToString();


            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtEng.Text = dr[1].ToString();
                LblAnswer.Text = dr[2].ToString();
                LblAnswer.Text = LblAnswer.Text.ToLower();
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TxtTurk.Focus();
            bring();
            timer1.Start();
        }

        private void TxtTurk_TextChanged(object sender, EventArgs e)
        {
            if (TxtTurk.Text==LblAnswer.Text)
            {
                vocobulary++;
                LblVoc.Text = vocobulary.ToString();
                bring();
                TxtTurk.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            LblTime.Text = time.ToString();
            if (time==0)
            {
                TxtTurk.Enabled = false;
                TxtEng.Enabled = false;
            }
        }
    }
}
