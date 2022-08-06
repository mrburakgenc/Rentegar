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
    public partial class RentegarAnasayfa : Form
    {
        public RentegarAnasayfa()
        {
            InitializeComponent();
        }
        SqlCnt bgl = new SqlCnt();


        private void RentegarAnasayfa_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No,Marka,Plaka,Tip,Cins,BulunduguYer,Durum From Tbl_Rentegar", bgl.baglanti());
            da.Fill(dt);
            DtAna.DataSource = dt;
            DtAna.Columns[0].Visible = false;
            DtAna.Columns[1].HeaderText = "MARKA";
            DtAna.Columns[2].HeaderText = "PLAKA";
            DtAna.Columns[3].HeaderText = "TİP";
            DtAna.Columns[4].HeaderText = "CİNS";
            DtAna.Columns[5].HeaderText = "BULUNDUĞU YER";
            DtAna.Columns[6].HeaderText = "DURUM";
            DtAna.Columns[3].Width = 380;

            int kayitsayisi;
            kayitsayisi = DtAna.RowCount;
            TxtTopamKayit.Text = kayitsayisi.ToString();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            FrmAracTeslimIslem fr = new FrmAracTeslimIslem();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRentaCar fr = new FrmRentaCar();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textMarka.Text = "";
            textKurum.Text = "";
            textPlaka.Text = "";
            textCins.Text = "";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No,Marka,Plaka,Tip,Cins,BulunduguYer,Durum From Tbl_Rentegar", bgl.baglanti());
            da.Fill(dt);
            DtAna.DataSource = dt;

            int kayitsayisi;
            kayitsayisi = DtAna.RowCount;
            TxtTopamKayit.Text = kayitsayisi.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No,Marka,Plaka,Tip,Cins,BulunduguYer,Durum From Tbl_Rentegar where Durum=0", bgl.baglanti());
            da.Fill(dt); 
            DtAna.DataSource = dt;

            int kayitsayisi;
            kayitsayisi = DtAna.RowCount;
            TxtTopamKayit.Text = kayitsayisi.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No,Marka,Plaka,Tip,Cins,BulunduguYer,Durum From Tbl_Rentegar where Durum=1", bgl.baglanti());
            da.Fill(dt);
            DtAna.DataSource = dt;

            int kayitsayisi;
            kayitsayisi = DtAna.RowCount;
            TxtTopamKayit.Text = kayitsayisi.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmSoforPanel frmsofor = new FrmSoforPanel();
            frmsofor.Show();
            this.Hide();
        }

        private void textMarka_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No,Marka,Plaka,Tip,Cins,BulunduguYer,Durum From Tbl_Rentegar where Marka Like '" + textMarka.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            DtAna.DataSource = dt;

            int kayitsayisi;
            kayitsayisi = DtAna.RowCount;
            TxtTopamKayit.Text = kayitsayisi.ToString();
        }

        private void textPlaka_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No,Marka,Plaka,Tip,Cins,BulunduguYer,Durum From Tbl_Rentegar where Plaka Like '" + textPlaka.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            DtAna.DataSource = dt;

            int kayitsayisi;
            kayitsayisi = DtAna.RowCount;
            TxtTopamKayit.Text = kayitsayisi.ToString();
        }

        private void textCins_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No,Marka,Plaka,Tip,Cins,BulunduguYer,Durum From Tbl_Rentegar where Cins Like '" + textCins.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            DtAna.DataSource = dt;

            int kayitsayisi;
            kayitsayisi = DtAna.RowCount;
            TxtTopamKayit.Text = kayitsayisi.ToString();
        }

        private void textKurum_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No,Marka,Plaka,Tip,Cins,BulunduguYer,Durum From Tbl_Rentegar where BulunduguYer Like '" + textKurum.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            DtAna.DataSource = dt;

            int kayitsayisi;
            kayitsayisi = DtAna.RowCount;
            TxtTopamKayit.Text = kayitsayisi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaSayfaRapor fr = new AnaSayfaRapor();
            fr.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            if (lblGizliRuhsat.Text==null|| lblGizliRuhsat.Text=="" || lblGizliRuhsat.Text==" " || lblGizliRuhsat.Text=="0")
            {
                MessageBox.Show("Seçilen Araç İçin Ruhsat Bilgisi Eklenmedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmRuhsat fr = new FrmRuhsat();
                fr.Ruhsat = lblGizliRuhsat.Text;
                fr.Show();
            }
            
        }
        
        private void DtAna_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = DtAna.SelectedCells[0].RowIndex;
            lblGizliNo.Text = DtAna.Rows[secilen].Cells[0].Value.ToString();

            SqlCommand komut = new SqlCommand("Select Ruhsat from Tbl_Rentegar where No=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblGizliNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblGizliRuhsat.Text = dr[0].ToString();
                
            }
            bgl.baglanti().Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No,Marka,Plaka,Tip,Cins,BulunduguYer,Durum From Tbl_Rentegar where Ruhsat!='NULL' and Ruhsat!='0'", bgl.baglanti());
            
            da.Fill(dt);
            DtAna.DataSource = dt;

            int kayitsayisi;
            kayitsayisi = DtAna.RowCount;
            TxtTopamKayit.Text = kayitsayisi.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No,Marka,Plaka,Tip,Cins,BulunduguYer,Durum From Tbl_Rentegar where Ruhsat IS NULL or Ruhsat='0'", bgl.baglanti());

            da.Fill(dt);
            DtAna.DataSource = dt;

            int kayitsayisi;
            kayitsayisi = DtAna.RowCount;
            TxtTopamKayit.Text = kayitsayisi.ToString();
        }
    }
}
