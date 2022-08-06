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
    public partial class FrmRentaCar : Form
    {
        public FrmRentaCar()
        {
            InitializeComponent();
        }
        SqlCnt bgl = new SqlCnt();

        void AracListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No, Marka, Plaka, Tip, Cins, BulunduguYer, Durum from Tbl_Rentegar", bgl.baglanti());
            da.Fill(dt);
            DtArac.DataSource = dt;
        }
        void Temizle()
        {
            txtMarka.Text = "";
            txtPlaka.Text = "";
            txtTip.Text = "";
            txtCins.Text = "";
            txtByer.Text = "";
            txtMarka.Text = "";
            txtPlakaBul.Text = "";
            txtKurumBul.Text = "";
            rdKirada.Checked = false;
            rdSirket.Checked = false;
            label7.Text = "0";
        }
        public string RuhsatYolu = "0";
        private void FrmRentaCar_Load(object sender, EventArgs e)
        {
            AracListele();
            DtArac.Columns[0].Visible = false;
            DtArac.Columns[1].HeaderText = "MARKA";
            DtArac.Columns[2].HeaderText = "PLAKA";
            DtArac.Columns[3].HeaderText = "TİP";
            DtArac.Columns[4].HeaderText = "CİNS";
            DtArac.Columns[5].HeaderText = "KURUM";
            DtArac.Columns[6].HeaderText = "DURUM";
            DtArac.Columns[3].Width = 340;

        }

        private void DtArac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = DtArac.SelectedCells[0].RowIndex;
            lblGizliNo.Text = DtArac.Rows[secilen].Cells[0].Value.ToString();
            txtMarka.Text = DtArac.Rows[secilen].Cells[1].Value.ToString();
            txtPlaka.Text = DtArac.Rows[secilen].Cells[2].Value.ToString();
            txtTip.Text = DtArac.Rows[secilen].Cells[3].Value.ToString();
            txtCins.Text = DtArac.Rows[secilen].Cells[4].Value.ToString();
            txtByer.Text = DtArac.Rows[secilen].Cells[5].Value.ToString();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmAracTeslimIslem fr = new FrmAracTeslimIslem();
            fr.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtMarka.Text=="" || txtMarka.Text==" " || txtPlaka.Text=="" || txtPlaka.Text==" " || txtTip.Text=="" || txtTip.Text==" " || txtCins.Text=="" || txtCins.Text==" " || txtByer.Text=="" || txtByer.Text==" ")
            {
                MessageBox.Show("Boş alanları kontrol edip tekrar deneyin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Kayıt Eklensin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Rentegar (Marka,Plaka,Tip,Cins,BulunduguYer,Durum,Ruhsat) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtMarka.Text);
                komut.Parameters.AddWithValue("@p2", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p3", txtTip.Text);
                komut.Parameters.AddWithValue("@p4", txtCins.Text);
                komut.Parameters.AddWithValue("@p5", txtByer.Text);
                
                komut.Parameters.AddWithValue("@p6", label6.Text);
                komut.Parameters.AddWithValue("@p7", RuhsatYolu);
                
                
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                Temizle();
                AracListele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lblGizliNo.Text=="0")
            {
                MessageBox.Show("Kayıt Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Kayıt silinecek, Devam edilsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete from Tbl_Rentegar where No=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", lblGizliNo.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                Temizle();
                AracListele();
            }
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lblGizliNo.Text == "0")
            {
                MessageBox.Show("Kayıt Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Kayıt Güncellensin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Update Tbl_Rentegar set Marka=@p1, Plaka=@p2, Tip=@p3, Cins=@p4, BulunduguYer=@p5, Durum=@p7, Ruhsat=@p8 where No=@p6", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtMarka.Text);
                komut.Parameters.AddWithValue("@p2", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p3", txtTip.Text);
                komut.Parameters.AddWithValue("@p4", txtCins.Text);
                komut.Parameters.AddWithValue("@p5", txtByer.Text);
                komut.Parameters.AddWithValue("@p6", lblGizliNo.Text);
                komut.Parameters.AddWithValue("@p7", label6.Text);

                
                SqlCommand cmt = new SqlCommand("Select Ruhsat from Tbl_Rentegar where No=@c1", bgl.baglanti());
                cmt.Parameters.AddWithValue("@c1", lblGizliNo.Text);
                cmt.ExecuteNonQuery();
                SqlDataReader dtr = cmt.ExecuteReader();
                while (dtr.Read())
                {
                    lblGizliRuhsat.Text = dtr[0].ToString();
                }
                bgl.baglanti().Close();
                if (lblGizliRuhsat.Text=="" || lblGizliRuhsat.Text==" " || lblGizliRuhsat.Text==null || lblGizliRuhsat.Text=="0")
                {
                    komut.Parameters.AddWithValue("@p8", RuhsatYolu);
                }
                else
                {
                    if (label7.Text=="0")
                    {
                        komut.Parameters.AddWithValue("@p8", lblGizliRuhsat.Text);
                    }
                    else
                    {
                        komut.Parameters.AddWithValue("@p8", RuhsatYolu);
                    }
                    
                    
                }

                
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                Temizle();
                AracListele();
            }
          
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            RentegarAnasayfa fr = new RentegarAnasayfa();
            fr.Show();
            this.Hide();
        }

        private void txtMarkaBul_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No, Marka,Plaka,Tip,Cins,BulunduguYer,Durum From Tbl_Rentegar where Marka Like '" + txtMarkaBul.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            DtArac.DataSource = dt;
        }

        private void txtPlakaBul_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No, Marka,Plaka,Tip,Cins,BulunduguYer,Durum From Tbl_Rentegar where Plaka Like '" + txtPlakaBul.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            DtArac.DataSource = dt;
        }

        private void txtKurumBul_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No, Marka,Plaka,Tip,Cins,BulunduguYer,Durum From Tbl_Rentegar where BulunduguYer Like '" + txtKurumBul.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            DtArac.DataSource = dt;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            txtMarka.Text = "";
            txtPlaka.Text = "";
            txtMarkaBul.Text = "";
            txtPlakaBul.Text = "";
            txtTip.Text = "";
            txtKurumBul.Text = "";
            txtByer.Text = "";
            txtCins.Text = "";

            AracListele();
        }

        private void rdKirada_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "0";
        }

        private void rdSirket_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (lblGizliNo.Text=="0")
            {
                MessageBox.Show("Kayıt Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);           
            }
            else
            {
                OpenFileDialog pdfac = new OpenFileDialog();
                pdfac.Title = "Pdf Aç";
                pdfac.Filter = "PDF Dosyaları (*.Pdf) | *.Pdf";
                if (pdfac.ShowDialog() == DialogResult.OK)
                {
                    RuhsatYolu = pdfac.FileName;
                    label7.Text = "1";
                }
            }
            
            
        }
    }
}
