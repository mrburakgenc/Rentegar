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

namespace İsDeneme
{
    public partial class FrmTeslimAl : Form
    {
        public FrmTeslimAl()
        {
            InitializeComponent();
        }
        SqlCnt bgl = new SqlCnt();

        public string No, Marka, Plaka, Tip, Cins, TesliAlan, Tel, BulunduguYer, KiraTarihi, VideoYolu = "0", BelgeYolu = "0";
        
        private void FrmTeslimAl_Load(object sender, EventArgs e)
        {
            lblTNo.Text = No;
            txtMarka.Text = Marka;
            txtPlaka.Text = Plaka;
            txtTip.Text = Tip;
            txtCins.Text = Cins;
            txtTeslimKisi.Text = TesliAlan;
            txtTel.Text = Tel;
            txtByer.Text = BulunduguYer;
            dateTimePicker1.Value = Convert.ToDateTime(KiraTarihi);
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
                axAcroPDF2.LoadFile(pdfac.FileName);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Tpic1.ImageLocation==null || Tpic2.ImageLocation==null || Tpic3.ImageLocation==null || Tpic4.ImageLocation==null || Tpic5.ImageLocation==null || TrichTextBox1.Text==null || TrichTextBox1.Text=="" || TrichTextBox1.Text==" ")
            {
                 MessageBox.Show(" HATA: Boş Alanları Kontrol Edip Tekrar Deneyin (Resim1, Resim2, Resim3, Resim4, Resim5, Tutanak ve Açıklama Kısmı Boş Geçilemez.)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Araç Teslim Alınacak Devam Edilsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {              

                if (TesliAlan==null || TesliAlan=="" || TesliAlan==" " || Tel==null || Tel=="" || Tel==" ")
                {
                    SqlCommand koomut = new SqlCommand("insert into Tbl_TeslimIslemleri (Marka,Plaka,Tip,Cins,TeslimKisi,Tel,Firma,KiraBaslaTarihi,TeslimAlTarihi,Tresimbir,Tresimiki,Tresimuc,Tresimdort,Tresimbes,Tresimalti,Tresimyedi,Tresimsekiz,Tresimdokuz,Tresimon,Tresimonbir,Tresimoniki,Tresimonuc,Tresimondort,Tresimonbes,Tvideo,Ttutanak,Taciklama) values (@g1,@g2,@g3,@g4,@g5,@g6,@g7,@g8,@g9,@g10,@g11,@g12,@g13,@g14,@g15,@g16,@g17,@g18,@g19,@g20,@g21,@g22,@g23,@g24,@g25,@g26,@g27)", bgl.baglanti());
                    koomut.Parameters.AddWithValue("@g1",txtMarka.Text);
                    koomut.Parameters.AddWithValue("@g2",txtPlaka.Text);
                    koomut.Parameters.AddWithValue("@g3",txtTip.Text);
                    koomut.Parameters.AddWithValue("@g4",txtCins.Text);
                    koomut.Parameters.AddWithValue("@g5",txtTeslimKisi.Text);
                    koomut.Parameters.AddWithValue("@g6",txtTel.Text);
                    koomut.Parameters.AddWithValue("@g7",txtByer.Text);
                    koomut.Parameters.AddWithValue("@g8",dateTimePicker1.Value);
                    koomut.Parameters.AddWithValue("@g9",dateTimePicker2.Value);
                    koomut.Parameters.AddWithValue("@g10",Tpic1.ImageLocation);
                    koomut.Parameters.AddWithValue("@g11",Tpic2.ImageLocation);
                    koomut.Parameters.AddWithValue("@g12",Tpic3.ImageLocation);
                    koomut.Parameters.AddWithValue("@g13",Tpic4.ImageLocation);
                    koomut.Parameters.AddWithValue("@g14",Tpic5.ImageLocation);
                    koomut.Parameters.AddWithValue("@g15",Tpic6.ImageLocation);
                    koomut.Parameters.AddWithValue("@g16",Tpic7.ImageLocation);
                    koomut.Parameters.AddWithValue("@g17",Tpic8.ImageLocation);
                    koomut.Parameters.AddWithValue("@g18",Tpic9.ImageLocation);
                    koomut.Parameters.AddWithValue("@g19",Tpic10.ImageLocation);
                    koomut.Parameters.AddWithValue("@g20",Tpic11.ImageLocation);
                    koomut.Parameters.AddWithValue("@g21",Tpic12.ImageLocation);
                    koomut.Parameters.AddWithValue("@g22",Tpic13.ImageLocation);
                    koomut.Parameters.AddWithValue("@g23",Tpic14.ImageLocation);
                    koomut.Parameters.AddWithValue("@g24",Tpic15.ImageLocation);
                    koomut.Parameters.AddWithValue("@g25",VideoYolu);
                    koomut.Parameters.AddWithValue("@g26",BelgeYolu);
                    koomut.Parameters.AddWithValue("@g27", TrichTextBox1.Text);
                    koomut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                }
                else
                {
                    SqlCommand komut = new SqlCommand("update Tbl_TeslimIslemleri set Teslimkisi=@f1, Tel=@f2, Firma=@f3, TeslimAlTarihi=@p1, Tresimbir=@p2, Tresimiki=@p3, Tresimuc=@p4, Tresimdort=@p5, Tresimbes=@p6, Tresimalti=@p7, Tresimyedi=@p8, Tresimsekiz=@p9, Tresimdokuz=@p10, Tresimon=@p11, Tresimonbir=@p12, Tresimoniki=@p13, Tresimonuc=@p14, Tresimondort=@p15, Tresimonbes=@p16, Tvideo=@p17, Ttutanak=@p18, Taciklama=@p19 where Plaka=@p20 and KiraBaslaTarihi=@p21", bgl.baglanti());
                    komut.Parameters.AddWithValue("@f1", txtTeslimKisi.Text);
                    komut.Parameters.AddWithValue("@f2", txtTel.Text);
                    komut.Parameters.AddWithValue("@f3", txtByer.Text);
                    komut.Parameters.AddWithValue("@p1", dateTimePicker2.Value);
                    komut.Parameters.AddWithValue("@p2", Tpic1.ImageLocation);
                    komut.Parameters.AddWithValue("@p3", Tpic2.ImageLocation);
                    komut.Parameters.AddWithValue("@p4", Tpic3.ImageLocation);
                    komut.Parameters.AddWithValue("@p5", Tpic4.ImageLocation);
                    komut.Parameters.AddWithValue("@p6", Tpic5.ImageLocation);
                    komut.Parameters.AddWithValue("@p7", Tpic6.ImageLocation);
                    komut.Parameters.AddWithValue("@p8", Tpic7.ImageLocation);
                    komut.Parameters.AddWithValue("@p9", Tpic8.ImageLocation);
                    komut.Parameters.AddWithValue("@p10", Tpic9.ImageLocation);
                    komut.Parameters.AddWithValue("@p11", Tpic10.ImageLocation);
                    komut.Parameters.AddWithValue("@p12", Tpic11.ImageLocation);
                    komut.Parameters.AddWithValue("@p13", Tpic12.ImageLocation);
                    komut.Parameters.AddWithValue("@p14", Tpic13.ImageLocation);
                    komut.Parameters.AddWithValue("@p15", Tpic14.ImageLocation);
                    komut.Parameters.AddWithValue("@p16", Tpic15.ImageLocation);
                    komut.Parameters.AddWithValue("@p17", VideoYolu);
                    komut.Parameters.AddWithValue("@p18", BelgeYolu);
                    komut.Parameters.AddWithValue("@p19", TrichTextBox1.Text);
                    komut.Parameters.AddWithValue("@p20", txtPlaka.Text);
                    komut.Parameters.AddWithValue("@p21", dateTimePicker1.Value);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                }

                SqlCommand comut = new SqlCommand("update Tbl_Rentegar set TeslimSahis=NULL, Tel=NULL, BulunduguYer=@s3, SahisaTeslimTh=NULL, Durum=1 where No=@s5", bgl.baglanti());
               
                comut.Parameters.AddWithValue("@s3", lblKonum.Text);               
                comut.Parameters.AddWithValue("@s5", Convert.ToInt32(No));
                comut.ExecuteNonQuery();
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
                Tpic1.ImageLocation = imgac.FileName;  
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                Tpic2.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                Tpic3.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                Tpic4.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                Tpic5.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                Tpic6.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                Tpic7.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                Tpic8.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                Tpic9.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                Tpic10.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                Tpic11.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                Tpic12.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                Tpic13.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                Tpic14.ImageLocation = imgac.FileName;
            }
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg;*.png;*.jpeg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                Tpic15.ImageLocation = imgac.FileName;
            }
        }
    }
}
