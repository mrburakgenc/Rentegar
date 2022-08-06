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
    public partial class FrmArsiv : Form
    {
        public FrmArsiv()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SCUJ6TJ;Initial Catalog=Denemeİs;Integrated Security=True");
        SqlCnt bgl = new SqlCnt();

        void ArsivListele()
        {
            DataTable adt = new DataTable();
            SqlDataAdapter ada=new SqlDataAdapter("Select No,AdSoyad,Telefon,Arac,Adres From Tbl_Soforler where Durum=0",bgl.baglanti());
            ada.Fill(adt);
            dataGridView1.DataSource=adt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Ad Soyad";
            dataGridView1.Columns[3].HeaderText = "Plaka";

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAid.Text=="0")
            {
                MessageBox.Show("Personel Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Personel Geri Yüklensin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                
                SqlCommand komut = new SqlCommand("Update Tbl_Soforler set Durum=1 where No=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtAid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Personel Geri Yüklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ArsivListele();

                pictureBox1.ImageLocation = "";
                txtAid.Text = "0";
                txtAAdSoyad.Text = "Ad Soyad";
                txtAArac.Text = "Araç Plaka";
                txtATel.Text = "Telefon";
                rcAAdres.Text = "Adres...";

            }

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void FrmArsiv_Load(object sender, EventArgs e)
        {
            ArsivListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAAdSoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtATel.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            rcAAdres.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtAArac.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

            
            SqlCommand komut = new SqlCommand("Select SoforProfResim from Tbl_Soforler where No=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAid.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                pictureBox1.ImageLocation = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtAid.Text == "0")
            {
                MessageBox.Show("Personel Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmEhliyetKimlik fh = new FrmEhliyetKimlik();
                fh.EhliyetKimlikID = txtAid.Text;
                fh.Show();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtAid.Text == "0")
            {
                MessageBox.Show("Personel Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmSrcBelgesi sb = new FrmSrcBelgesi();
                sb.SrcBelgeID = txtAid.Text;
                sb.Show();
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtAid.Text == "0")
            {
                MessageBox.Show("Personel Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmMyBelgesi my = new FrmMyBelgesi();
                my.MyBelgeID = txtAid.Text;
                my.Show();
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtAid.Text == "0")
            {
                MessageBox.Show("Personel Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ADSBelgesi ad = new ADSBelgesi();
                ad.ADSBelgeID = txtAid.Text;
                ad.Show();
            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtAid.Text == "0")
            {
                MessageBox.Show("Personel Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmIsBasvuruBelgesi isb = new FrmIsBasvuruBelgesi();
                isb.IsBasvuruBelgeID = txtAid.Text;
                isb.Show();
            }
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtAid.Text == "0")
            {
                MessageBox.Show("Personel Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmIkametBelgesi ikm = new FrmIkametBelgesi();
                ikm.IkametgahBelgeID = txtAid.Text;
                ikm.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtAid.Text == "0")
            {
                MessageBox.Show("Personel Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmSoforHakkinda shr = new FrmSoforHakkinda();
                shr.SoforHakkindaID = txtAid.Text;
                shr.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtAid.Text == "0")
            {
                MessageBox.Show("Personel Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmSoforKazaKayit sk = new FrmSoforKazaKayit();
                sk.KazaID = txtAid.Text;
                sk.Show();
            }
        }

        private void txtidBul_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No,AdSoyad,Telefon,Adres,Arac From Tbl_Soforler where Durum=0 and No Like '" + txtidBul.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtSoforBul_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No,AdSoyad,Telefon,Adres,Arac From Tbl_Soforler where Durum=0 and AdSoyad Like '" + txtSoforBul.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtPlakaBul_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No,AdSoyad,Telefon,Adres,Arac From Tbl_Soforler where Durum=0 and Arac Like '" + txtPlakaBul.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            ArsivListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmArsivRapor fr = new FrmArsivRapor();
            fr.Show();
        }
    }
}
