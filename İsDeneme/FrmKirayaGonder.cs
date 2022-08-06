using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using WMPLib;

namespace İsDeneme
{
    public partial class FrmKirayaGonder : Form
    {
        public FrmKirayaGonder()
        {
            InitializeComponent();
        }
        SqlCnt bgl = new SqlCnt();

        public string No, Marka, Plaka, Tip, Cins, VideoYolu="0",BelgeYolu="0";

        private void FrmKirayaGonder_Load(object sender, EventArgs e)
        {
            lblGno.Text = No;
            txtMarka.Text = Marka;
            txtPlaka.Text = Plaka;
            txtTip.Text = Tip;
            txtCins.Text = Cins;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog vdac = new OpenFileDialog();
            vdac.Title = "Video Aç";
            vdac.Filter = "MP4 Dosyaları (*.mp4) | *.mp4";
            if (vdac.ShowDialog() == DialogResult.OK)
            {
                VideoYolu = vdac.FileName;
                axWindowsMediaPlayer1.URL = VideoYolu;
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdfac = new OpenFileDialog();
            pdfac.Title = "Pdf Aç";
            pdfac.Filter = "PDF Dosyaları (*.Pdf) | *.Pdf";
            if (pdfac.ShowDialog() == DialogResult.OK)
            {
                BelgeYolu = pdfac.FileName;
                axAcroPDF1.LoadFile(pdfac.FileName);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {  
            if (pic1.ImageLocation==null || pic2.ImageLocation==null || pic3.ImageLocation==null || pic4.ImageLocation==null || richTextBox1.Text==null || richTextBox1.Text=="" || richTextBox1.Text==" " || txtTeslimKisi.Text=="" || txtTeslimKisi.Text==null || txtTeslimKisi.Text==" " || txtTel.Text==null || txtTel.Text=="" || txtTel.Text==" " || txtByer.Text==null || txtByer.Text=="" || txtByer.Text==" " || pic5.ImageLocation==null)
            {
                MessageBox.Show(" HATA: Boş Alanları Kontrol Edip Tekrar Deneyin (Teslim Alan Kişi, Tel, Kurum, Resim1, Resim2, Resim3, Resim4, Resim5, Tutanak ve Açıklama Kısmı Boş Geçilemez.)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Araç Kiralanacak, Devam edilsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_TeslimIslemleri (Marka, Plaka, Tip, Cins, TeslimKisi, Tel, Firma, KiraBaslaTarihi, Resimbir, Resimiki, Resimuc, Resimdort, Resimbes, Resimalti, Resimyedi, Resimsekiz, Resimdokuz, Resimon, Resimonbir, Resimoniki, Resimonuc, Resimondort, Resimonbes, Video, Tutanak, Aciklama) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20,@p21,@p22,@p23,@p24,@p25,@p26,@p27)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtMarka.Text);
                komut.Parameters.AddWithValue("@p2", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p3", txtTip.Text);
                komut.Parameters.AddWithValue("@p4", txtCins.Text);
                komut.Parameters.AddWithValue("@p5", txtTeslimKisi.Text);
                komut.Parameters.AddWithValue("@p6", txtTel.Text);
                komut.Parameters.AddWithValue("@p7", txtByer.Text);
                komut.Parameters.AddWithValue("@p8", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@p10", pic1.ImageLocation);
                komut.Parameters.AddWithValue("@p11", pic2.ImageLocation);
                komut.Parameters.AddWithValue("@p12", pic3.ImageLocation);
                komut.Parameters.AddWithValue("@p13", pic4.ImageLocation);
                komut.Parameters.AddWithValue("@p14", pic5.ImageLocation);
                komut.Parameters.AddWithValue("@p15", pic6.ImageLocation);
                komut.Parameters.AddWithValue("@p16", pic7.ImageLocation);
                komut.Parameters.AddWithValue("@p17", pic8.ImageLocation);
                komut.Parameters.AddWithValue("@p18", pic9.ImageLocation);
                komut.Parameters.AddWithValue("@p19", pic10.ImageLocation);
                komut.Parameters.AddWithValue("@p20", pic11.ImageLocation);
                komut.Parameters.AddWithValue("@p21", pic12.ImageLocation);
                komut.Parameters.AddWithValue("@p22", pic13.ImageLocation);
                komut.Parameters.AddWithValue("@p23", pic14.ImageLocation);
                komut.Parameters.AddWithValue("@p24", pic15.ImageLocation);
                komut.Parameters.AddWithValue("@p25", VideoYolu);
                komut.Parameters.AddWithValue("@p26", BelgeYolu);
                komut.Parameters.AddWithValue("@p27", richTextBox1.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                SqlCommand komutt = new SqlCommand("update Tbl_Rentegar set TeslimSahis=@pp1, Tel=@pp2, BulunduguYer=@pp3, SahisaTeslimTh=@pp4, Durum=0 where No=@pp5", bgl.baglanti());
                komutt.Parameters.AddWithValue("@pp1", txtTeslimKisi.Text);
                komutt.Parameters.AddWithValue("@pp2", txtTel.Text);
                komutt.Parameters.AddWithValue("@pp3", txtByer.Text);
                komutt.Parameters.AddWithValue("@pp4", dateTimePicker1.Value);
                komutt.Parameters.AddWithValue("@pp5", Convert.ToInt32(No));
                komutt.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("İşlem Başarıyla Tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmAracTeslimIslem fr = new FrmAracTeslimIslem();
                fr.Show();
                this.Hide();
                
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                pic1.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                pic2.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                pic3.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                pic4.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                pic5.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                pic6.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                pic7.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                pic8.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                pic9.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                pic10.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                pic11.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                pic12.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                pic13.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                pic14.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                pic15.ImageLocation = imgac.FileName;
            }
        }
    }
}
