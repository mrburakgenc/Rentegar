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
using System.Management;
using System.Threading.Tasks;
using Microsoft.Win32;


namespace İsDeneme
{
    public partial class FrmSoforPanel : Form
    {
        public FrmSoforPanel()
        {
            InitializeComponent();
        }

        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SCUJ6TJ;Initial Catalog=Denemeİs;Integrated Security=True");
        SqlCnt bgl = new SqlCnt();
        void SoforListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select No,AdSoyad,Telefon,Adres,Arac,ServisBasi,Servis,MesaiSaat,EkServis,EkSaat,KurumPark from Tbl_Soforler where Durum=1",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
          
        }
        void Temizle()
        {
            txtid.Text = "0";
            txtAdSoyad.Text = "";
            txtArac.Text = "";
            txtEkMsaat.Text = "";
            txtEkServis.Text = "";
            txtServis.Text = "";
            txtTel.Text = "";
            rcAdres.Text = "";
            txtMsaat.Text = "";
            txtKurumPark.Text = "";
            txtServisBasi.Text = "";
            pictureBox1.ImageLocation = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SoforListele();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Width=90;
            dataGridView1.Columns[7].Width = 110;
            dataGridView1.Columns[9].Width = 110;
            dataGridView1.Columns[10].Width = 115;
            dataGridView1.Columns[1].Width = 145;
            dataGridView1.Columns[1].HeaderText = "Ad Soyad";
            dataGridView1.Columns[4].HeaderText = "Plaka";
            dataGridView1.Columns[5].HeaderText = "Servis Başı";
            dataGridView1.Columns[7].HeaderText = "Mesai Saat";
            dataGridView1.Columns[8].HeaderText = "Ek Servis";
            dataGridView1.Columns[9].HeaderText = "Ek Saat";
            dataGridView1.Columns[10].HeaderText = "Kurum Park";
            
            txtid.Text = "0";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAdSoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            lblgizliisim.Text = txtAdSoyad.Text;
            txtTel.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            rcAdres.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtArac.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtServisBasi.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtServis.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtMsaat.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtEkServis.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtEkMsaat.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();           
            txtKurumPark.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();

            
            SqlCommand komut = new SqlCommand("Select SoforProfResim from Tbl_Soforler where No=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                pictureBox1.ImageLocation = dr[0].ToString();
            }
            bgl.baglanti().Close();
             
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtidBul_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtSoforBul_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No,AdSoyad,Telefon,Adres,Arac,ServisBasi,Servis,MesaiSaat,EkServis,EkSaat,KurumPark From Tbl_Soforler where Durum=1 and AdSoyad Like '" + txtSoforBul.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtPlakaBul_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No,AdSoyad,Telefon,Adres,Arac,ServisBasi,Servis,MesaiSaat,EkServis,EkSaat,KurumPark From Tbl_Soforler where Durum=1 and Arac Like '" + txtPlakaBul.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtKurumBul_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No,AdSoyad,Telefon,Adres,Arac,ServisBasi,Servis,MesaiSaat,EkServis,EkSaat,KurumPark From Tbl_Soforler where Durum=1 and KurumPark Like '" + txtKurumBul.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            txtKurumBul.Text = "";
            txtPlakaBul.Text = "";
            txtSoforBul.Text = "";
            txtidBul.Text = "";
            SoforListele();
            Temizle();
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text=="" || txtArac.Text=="" || txtTel.Text=="" || rcAdres.Text==""|| txtServis.Text=="" || txtMsaat.Text=="")
            {
                MessageBox.Show("Boş bırakılan alanları doldurup tekrar deneyin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(MessageBox.Show("Kayıt Oluşturulsun mu?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {            
            
            SqlCommand komut = new SqlCommand("insert into Tbl_Soforler (AdSoyad,Telefon,Adres,Arac,ServisBasi,Servis,MesaiSaat,EkServis,EkSaat,KurumPark,Durum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11) ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", txtTel.Text);
            komut.Parameters.AddWithValue("@p3", rcAdres.Text);
            komut.Parameters.AddWithValue("@p4", txtArac.Text);
            komut.Parameters.AddWithValue("@p5", txtServisBasi.Text);
            komut.Parameters.AddWithValue("@p6", txtServis.Text);
            komut.Parameters.AddWithValue("@p7", txtMsaat.Text);
            komut.Parameters.AddWithValue("@p8", txtEkServis.Text);
            komut.Parameters.AddWithValue("@p9", txtEkMsaat.Text);
            komut.Parameters.AddWithValue("@p10", txtKurumPark.Text);
            komut.Parameters.AddWithValue("@p11", LblGizliDurum.Text);
            komut.ExecuteNonQuery();    
            bgl.baglanti().Close();
                            
            MessageBox.Show("Kayıt Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SoforListele();
            Temizle();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtid.Text=="0")
            {
                MessageBox.Show("Personel seçmediniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Personel Arşivlenip Silinsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {                            
            
            SqlCommand komut = new SqlCommand("Update Tbl_Soforler Set Durum=@p1 where No=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblGizliSilDurum.Text);
            komut.Parameters.AddWithValue("@p2", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Arşivlendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SoforListele();
            Temizle();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtid.Text=="0")
            {
                MessageBox.Show("Personel Seçmediniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lblgizliisim.Text!=txtAdSoyad.Text)
            {
                MessageBox.Show("Personel ismi değiştirilemez, Hem isim hem de plaka da değiştirilemez, Aynı araca farklı personel kayıt edilecekse önce değiştirilecek personeli silin ve yeni kayıt oluşturun. Aynı araca ikinci Personel atanacaksa yeni kayıt olarak oluşturulabilir. (( İsim kutusuna yanlışlıkla boşluk bırakdıysanız da bu hatayı alabilirsiniz, Öyle ise isim kutusuna dokunmadan tekrar deneyin.))", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAdSoyad.Text = lblgizliisim.Text;
            }

            else if (MessageBox.Show("Değişiklikler Kaydedilsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                
                SqlCommand komut = new SqlCommand("Update Tbl_Soforler set Telefon=@p2, Adres=@p3, Arac=@p4, ServisBasi=@p5, Servis=@p6, MesaiSaat=@p7, EkServis=@p8, EkSaat=@p9, KurumPark=@p10 where No=@p11", bgl.baglanti());
                
                komut.Parameters.AddWithValue("@p2", txtTel.Text);
                komut.Parameters.AddWithValue("@p3", rcAdres.Text);
                komut.Parameters.AddWithValue("@p4", txtArac.Text);
                komut.Parameters.AddWithValue("@p5", txtServisBasi.Text);
                komut.Parameters.AddWithValue("@p6", txtServis.Text);
                komut.Parameters.AddWithValue("@p7", txtMsaat.Text);
                komut.Parameters.AddWithValue("@p8", txtEkServis.Text);
                komut.Parameters.AddWithValue("@p9", txtEkMsaat.Text);
                komut.Parameters.AddWithValue("@p10", txtKurumPark.Text);
                komut.Parameters.AddWithValue("@p11", txtid.Text);                
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Personel Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SoforListele();
                Temizle();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RentegarAnasayfa rentegarAnasayfa = new RentegarAnasayfa();
            rentegarAnasayfa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtid.Text=="0")
            {
                MessageBox.Show("Personel Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SfEvrakDuzenle sf = new SfEvrakDuzenle();
                sf.ID = txtid.Text;
                sf.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtid.Text=="0")
            {
                MessageBox.Show("Personel Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmSoforHakkinda shr = new FrmSoforHakkinda();
                shr.SoforHakkindaID = txtid.Text;
                shr.Show();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtid.Text == "0")
            {
                MessageBox.Show("Personel Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmEhliyetKimlik fh = new FrmEhliyetKimlik();
                fh.EhliyetKimlikID = txtid.Text;
                fh.Show();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtid.Text=="0")
            {
                MessageBox.Show("Personel Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmSrcBelgesi sb = new FrmSrcBelgesi();
                sb.SrcBelgeID = txtid.Text;
                sb.Show();
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtid.Text=="0")
            {
                MessageBox.Show("Personel Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmMyBelgesi my = new FrmMyBelgesi();
                my.MyBelgeID = txtid.Text;
                my.Show();
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtid.Text=="0")
            {
                MessageBox.Show("Personel Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ADSBelgesi ad = new ADSBelgesi();
                ad.ADSBelgeID = txtid.Text;
                ad.Show();
            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtid.Text=="0")
            {
                MessageBox.Show("Personel Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmIsBasvuruBelgesi isb = new FrmIsBasvuruBelgesi();
                isb.IsBasvuruBelgeID = txtid.Text;
                isb.Show();
            }
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtid.Text=="0")
            {
                MessageBox.Show("Personel Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmIkametBelgesi ikm = new FrmIkametBelgesi();
                ikm.IkametgahBelgeID = txtid.Text;
                ikm.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog imgac = new OpenFileDialog();
            imgac.Title = "Resim Aç";
            imgac.Filter = "JPG Dosyaları (*.jpg) | *.jpg";
            if (imgac.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = imgac.FileName;
            }            
                
                SqlCommand komut = new SqlCommand("update Tbl_Soforler set SoforProfResim=@p1 where No=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", imgac.FileName);
                komut.Parameters.AddWithValue("@p2", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtid.Text=="0")
            {
                MessageBox.Show("Personel Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmSoforKazaKayit sk = new FrmSoforKazaKayit();
                sk.KazaID = txtid.Text;
                sk.Show();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            FrmArsiv farsiv = new FrmArsiv();
            farsiv.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmYakitKmEkle fr = new FrmYakitKmEkle();
            fr.Show();
            this.Hide();
            
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            FrmSoforRapor fr = new FrmSoforRapor();
            fr.Show();
        }
    }
}
