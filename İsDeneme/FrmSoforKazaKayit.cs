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
    public partial class FrmSoforKazaKayit : Form
    {
        public FrmSoforKazaKayit()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SCUJ6TJ;Initial Catalog=Denemeİs;Integrated Security=True");
        SqlCnt bgl = new SqlCnt();
        public string KazaID;

        void KazaListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select KzID, KAdSoyad, AracPlaka,Tarih,Aciklama from Tbl_SoforKaza where KAdSoyad=@s1 and Durum=1", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@s1", txtkisim.Text);
            da.Fill(dt);
            DataGridKaza.DataSource = dt;
        }
        private void FrmSoforKazaKayit_Load(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("Select AdSoyad, Arac, SoforProfResim from Tbl_Soforler where No=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", KazaID);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtkisim.Text = dr[0].ToString();
                txtKplaka.Text = dr[1].ToString();
                pckazaprof.ImageLocation = dr[2].ToString();
            }
            bgl.baglanti().Close();

            KazaListele();
            DataGridKaza.Columns[0].Visible = false;
            DataGridKaza.Columns[4].Visible = false;
            DataGridKaza.Columns[2].Width = 95;
            DataGridKaza.Columns[1].HeaderText = "Şoför";
            DataGridKaza.Columns[2].HeaderText = "Plaka";
        }
        public string VdYolu="0";
        private void DataGridKaza_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int secilen = DataGridKaza.SelectedCells[0].RowIndex;
            lblGizliID.Text=DataGridKaza.Rows[secilen].Cells[0].Value.ToString();
            RchAciklama.Text = DataGridKaza.Rows[secilen].Cells[4].Value.ToString();

            
            SqlCommand komutt = new SqlCommand("select Resimbir,Resimiki,Resimuc,Resimdort,Vidyo from Tbl_SoforKaza where KzID=@k1", bgl.baglanti());
            komutt.Parameters.AddWithValue("@k1", Convert.ToInt16(lblGizliID.Text));
            SqlDataReader drr = komutt.ExecuteReader();
            while (drr.Read())
            {
                pictureBox2.ImageLocation = drr[0].ToString();
                pictureBox4.ImageLocation = drr[1].ToString();
                pictureBox5.ImageLocation = drr[2].ToString();
                pictureBox3.ImageLocation = drr[3].ToString();
                VdYolu = drr[4].ToString();
            }
            bgl.baglanti().Close();
            resim1 = pictureBox2.ImageLocation;
            resim2 = pictureBox4.ImageLocation;
            resim3 = pictureBox5.ImageLocation;
            resim4 = pictureBox3.ImageLocation;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnR1_Click(object sender, EventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = imgac.FileName;
            }
            
        }

        private void BtnKKayit_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnR2_Click(object sender, EventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.ImageLocation = imgac.FileName;
            }
        }

        private void BtnR3_Click(object sender, EventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                pictureBox5.ImageLocation = imgac.FileName;
            }
        }

        private void BtnR4_Click(object sender, EventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.ImageLocation = imgac.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RchAciklama.Text == "") 
            {
                MessageBox.Show("Lütfen Açıklama Ekleyin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(MessageBox.Show("Kaydedilsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                
                SqlCommand komut = new SqlCommand("insert into Tbl_SoforKaza (KAdSoyad,AracPlaka,Tarih,Aciklama,Resimbir,Resimiki,Resimuc,Resimdort,Vidyo,Durum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtkisim.Text);
                komut.Parameters.AddWithValue("@p2", txtKplaka.Text);
                komut.Parameters.AddWithValue("@p3", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@p4", RchAciklama.Text);
                komut.Parameters.AddWithValue("@p5", pictureBox2.ImageLocation);
                komut.Parameters.AddWithValue("@p6", pictureBox4.ImageLocation);
                komut.Parameters.AddWithValue("@p7", pictureBox5.ImageLocation);
                komut.Parameters.AddWithValue("@p8", pictureBox3.ImageLocation);
                komut.Parameters.AddWithValue("@p9", VdYolu);
                komut.Parameters.AddWithValue("@p10", lblDurum.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                KazaListele();
                lblGizliID.Text = "0";
            } 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (lblGizliID.Text=="0")
            {
                MessageBox.Show("Silinecek Kaydı Seçin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Kayıt Silinsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                
                SqlCommand komut = new SqlCommand("Delete From Tbl_SoforKaza where KzID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", lblGizliID.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                KazaListele();
                lblGizliID.Text = "0";
                RchAciklama.Text = "";
                
            }
        }

        private void BtnVidyoEkle_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog vdac = new OpenFileDialog();
            vdac.Title = "Video Aç";
            vdac.Filter = "MP4 Dosyaları (*.mp4) | *.mp4";
            if (vdac.ShowDialog() == DialogResult.OK)
            {
                VdYolu = vdac.FileName;
            }
             
        }

        private void BtnVidyoOynat_Click(object sender, EventArgs e)
        {
            if (VdYolu == "0" || VdYolu=="")
            {
                MessageBox.Show("Bu Kayıt için Video Eklenmedi yada Kayıt Seçmediniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmKazaVideo fkv = new FrmKazaVideo();
                fkv.KazaOynat = VdYolu;
                fkv.Show();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lblGizliID.Text=="0")
            {
                MessageBox.Show("Güncellenecek Kaydı Seçin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Kayıt Güncellensin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                
                SqlCommand komut = new SqlCommand("Update Tbl_SoforKaza set AracPlaka=@p1, Tarih=@p2, Aciklama=@p3, Resimbir=@p4, Resimiki=@p5, Resimuc=@p6, Resimdort=@p7, Vidyo=@p8 where KzID=@p9", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1",txtKplaka.Text);
                komut.Parameters.AddWithValue("@p2",dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@p3", RchAciklama.Text);
                komut.Parameters.AddWithValue("@p4", pictureBox2.ImageLocation);
                komut.Parameters.AddWithValue("@p5", pictureBox4.ImageLocation);
                komut.Parameters.AddWithValue("@p6", pictureBox5.ImageLocation);
                komut.Parameters.AddWithValue("@p7", pictureBox3.ImageLocation);
                komut.Parameters.AddWithValue("@p8", VdYolu);
                komut.Parameters.AddWithValue("@p9", lblGizliID.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();                
                KazaListele();
                lblGizliID.Text = "0";
            }

        }
        public string resim1, resim2, resim3, resim4;
        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            FrmKazaKayitRbircs rbir = new FrmKazaKayitRbircs();
            rbir.resim1ac = resim1;
            rbir.Show();

        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            FrmKazaKayitRiki riki = new FrmKazaKayitRiki();
            riki.resimikiac = resim2;
            riki.Show();
        }

        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {
            FrmKazaKayitRuc ruc = new FrmKazaKayitRuc();
            ruc.resim3ac = resim3;
            ruc.Show();
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            FrmKazaKayitRdort rdort = new FrmKazaKayitRdort();
            rdort.resim4ac = resim4;
            rdort.Show();
        }
    }
}
