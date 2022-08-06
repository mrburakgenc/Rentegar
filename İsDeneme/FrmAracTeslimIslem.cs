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
    public partial class FrmAracTeslimIslem : Form
    {
        public FrmAracTeslimIslem()
        {
            InitializeComponent();
        }
        SqlCnt bgl = new SqlCnt();


        void AracListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No, Marka, Plaka, Tip, Cins, TeslimSahis, Tel, BulunduguYer, SahisaTeslimTh, SirketeTeslimTh,Durum From Tbl_Rentegar", bgl.baglanti());
            da.Fill(dt);
            DtArac.DataSource = dt;
            
        }
        public byte Durum;
        private void FrmAracTeslimIslem_Load(object sender, EventArgs e)
        {
            AracListele();
            
            DtArac.Columns[0].Visible = false;
            DtArac.Columns[3].Visible = false;
            DtArac.Columns[1].HeaderText = "MARKA";
            DtArac.Columns[2].HeaderText = "PLAKA";
            DtArac.Columns[4].HeaderText = "CİNS";
            DtArac.Columns[5].HeaderText = "KİRALAYAN KİŞİ";
            DtArac.Columns[6].HeaderText = "TEL";
            DtArac.Columns[7].HeaderText = "KURUM";
            DtArac.Columns[8].HeaderText = "KİRA TARİHİ";
            DtArac.Columns[9].Visible = false;
            DtArac.Columns[10].Visible = false;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRentaCar fr = new FrmRentaCar();
            fr.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
        
        }

        private void DtArac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = DtArac.SelectedCells[0].RowIndex;            
            lblGizliTeslimNo.Text = DtArac.Rows[secilen].Cells[0].Value.ToString();
            txtMarka.Text = DtArac.Rows[secilen].Cells[1].Value.ToString();
            txtPlaka.Text = DtArac.Rows[secilen].Cells[2].Value.ToString();
            lblGizliTip.Text = DtArac.Rows[secilen].Cells[3].Value.ToString();
            txtCins.Text = DtArac.Rows[secilen].Cells[4].Value.ToString();
            txtTeslimKisi.Text = DtArac.Rows[secilen].Cells[5].Value.ToString();
            txtTel.Text = DtArac.Rows[secilen].Cells[6].Value.ToString();
            txtByer.Text = DtArac.Rows[secilen].Cells[7].Value.ToString();
            txtKiraTarih.Text = DtArac.Rows[secilen].Cells[8].Value.ToString();           
            
            lblGizliDurum.Text = DtArac.Rows[secilen].Cells[10].Value.ToString(); 
               
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (lblGizliTeslimNo.Text=="0")
            {
                MessageBox.Show("Araç Seçin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lblGizliDurum.Text=="False")
            {
                MessageBox.Show("Seçtiğiniz Araç zaten Kirada", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //secilen araca ait gerekli bilgiler çekilecek...                  
                FrmKirayaGonder fr = new FrmKirayaGonder();
                fr.No = lblGizliTeslimNo.Text;
                fr.Marka = txtMarka.Text;
                fr.Plaka = txtPlaka.Text;
                fr.Tip = lblGizliTip.Text;
                fr.Cins = txtCins.Text;
                fr.Show();
                this.Hide();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (lblGizliTeslimNo.Text=="0")
            {
                MessageBox.Show("Araç Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lblGizliDurum.Text=="True")
            {
                MessageBox.Show("Seçtiğiniz Araç Kirada değil", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                FrmTeslimAl fr = new FrmTeslimAl();
                fr.No = lblGizliTeslimNo.Text;
                fr.Marka = txtMarka.Text;
                fr.Plaka = txtPlaka.Text;
                fr.Tip = lblGizliTip.Text;
                fr.Cins = txtCins.Text;
                fr.TesliAlan = txtTeslimKisi.Text;
                fr.Tel = txtTel.Text;
                fr.BulunduguYer = txtByer.Text;
                if (txtKiraTarih.Text==null|| txtKiraTarih.Text==""|| txtKiraTarih.Text==" ")
                {
                    fr.KiraTarihi = text1.Text;
                }
                else
                {
                    fr.KiraTarihi = txtKiraTarih.Text;
                }
                
                fr.Show();
                this.Hide();

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmPlakaGecmisi fr = new FrmPlakaGecmisi();
            
                fr.Gplaka = txtPlaka.Text;
            
            
            fr.Show();
            this.Hide();
           
        }

        private void DtArac_Click(object sender, EventArgs e)
        {

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            txtMarkaBul.Text = "";
            txtPlakaBul.Text = "";
            

            AracListele();
            
            
        }

        private void txtSoforBul_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPlakaBul_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No, Marka, Plaka, Tip, Cins, TeslimSahis, Tel, BulunduguYer, SahisaTeslimTh, SirketeTeslimTh,Durum From Tbl_Rentegar where Plaka Like '" + txtPlakaBul.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            DtArac.DataSource = dt;
        }

        private void txtMarkaBul_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No, Marka, Plaka, Tip, Cins, TeslimSahis, Tel, BulunduguYer, SahisaTeslimTh, SirketeTeslimTh,Durum From Tbl_Rentegar where BulunduguYer Like '" + txtMarkaBul.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            DtArac.DataSource = dt;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            RentegarAnasayfa fr = new RentegarAnasayfa();
            fr.Show();
            this.Hide();
        }
    }
}
