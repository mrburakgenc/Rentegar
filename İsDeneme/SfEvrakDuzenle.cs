using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace İsDeneme
{
    public partial class SfEvrakDuzenle : Form
    {
        public SfEvrakDuzenle()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SCUJ6TJ;Initial Catalog=Denemeİs;Integrated Security=True");
        SqlCnt bgl = new SqlCnt();
        void EvrakEkle()
        {
            OpenFileDialog pdfac = new OpenFileDialog();
            pdfac.Title = "Pdf Aç";
            pdfac.Filter = "PDF Dosyaları (*.Pdf) | *.Pdf";
            if (pdfac.ShowDialog()==DialogResult.OK)
            {
                TxtEvrakDosyaYoluEkle.Text = pdfac.FileName;
                AdobeEvrakEkle.LoadFile(pdfac.FileName);
            }
        }
        public string ID;

        private void SfEvrakDuzenle_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EvrakEkle();
            if (MessageBox.Show("Evrak Eklensin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                
                SqlCommand komut = new SqlCommand("update Tbl_Soforler set EhliyetKimlik=@p1 where No=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtEvrakDosyaYoluEkle.Text);
                komut.Parameters.AddWithValue("@p2", ID);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                TxtEvrakDosyaYoluEkle.Text = ".";
            }
        }

        private void BtnEvrakKaydet_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSrcEkle_Click(object sender, EventArgs e)
        {
            EvrakEkle();
            if (MessageBox.Show("Evrak Eklensin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                SqlCommand komut = new SqlCommand("update Tbl_Soforler set SrcBelge=@p1 where No=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtEvrakDosyaYoluEkle.Text);
                komut.Parameters.AddWithValue("@p2", ID);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                TxtEvrakDosyaYoluEkle.Text = ".";
            }
        }

        private void BtnMyEkle_Click(object sender, EventArgs e)
        {
            EvrakEkle();
            if (MessageBox.Show("Evrak Eklensin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                SqlCommand komut = new SqlCommand("update Tbl_Soforler set MYBelgesi=@p1 where No=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtEvrakDosyaYoluEkle.Text);
                komut.Parameters.AddWithValue("@p2", ID);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                TxtEvrakDosyaYoluEkle.Text = ".";
            }
        }

        private void BtnASEkle_Click(object sender, EventArgs e)
        {
            EvrakEkle();
            if (MessageBox.Show("Evrak Eklensin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                SqlCommand komut = new SqlCommand("update Tbl_Soforler set AdliSicil=@p1 where No=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtEvrakDosyaYoluEkle.Text);
                komut.Parameters.AddWithValue("@p2", ID);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                TxtEvrakDosyaYoluEkle.Text = ".";
            }
        }

        private void BtnIsBEkle_Click(object sender, EventArgs e)
        {
            EvrakEkle();
            if (MessageBox.Show("Evrak Eklensin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                SqlCommand komut = new SqlCommand("update Tbl_Soforler set IsBasvuru=@p1 where No=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtEvrakDosyaYoluEkle.Text);
                komut.Parameters.AddWithValue("@p2", ID);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                TxtEvrakDosyaYoluEkle.Text = ".";
            }
        }

        private void BtnIkEkle_Click(object sender, EventArgs e)
        {
            EvrakEkle();
            if (MessageBox.Show("Evrak Eklensin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                SqlCommand komut = new SqlCommand("update Tbl_Soforler set Ikametgah=@p1 where No=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtEvrakDosyaYoluEkle.Text);
                komut.Parameters.AddWithValue("@p2", ID);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                TxtEvrakDosyaYoluEkle.Text = ".";
            }
        }
    }
}
