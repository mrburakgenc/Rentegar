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
    public partial class FrmYakitKmEkle : Form
    {
        public FrmYakitKmEkle()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SCUJ6TJ;Initial Catalog=Denemeİs;Integrated Security=True");
        SqlCnt bgl = new SqlCnt();
        void SoforAracSecim()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Arac,AdSoyad from Tbl_Soforler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void GunlukVeriGirisListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No,Plaka,Sofor,Km,HarcananYakit,DoldurulanYakit,Tarih from Tbl_YakitKm where Tarih Between @p1 and @p2", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", dateTimePicker2.Value.AddHours(-9));
            da.SelectCommand.Parameters.AddWithValue("@p2", dateTimePicker2.Value.AddHours(+9));
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void FrmYakitKmEkle_Load(object sender, EventArgs e)
        {
            SoforAracSecim();
            GunlukVeriGirisListele();
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[2].HeaderText = "Şoför";
            dataGridView2.Columns[3].HeaderText = "Km-M";
            dataGridView2.Columns[4].HeaderText = "Harcanan Yakıt";
            dataGridView2.Columns[5].HeaderText = "Doldurulan Yakıt";
            dataGridView1.Columns[0].Width = 95;
            dataGridView1.Columns[0].HeaderText = "Plaka";
            dataGridView1.Columns[1].HeaderText = "Şoför";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtPlaka.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtSofor.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtHarcananY.Text = "";
            txtDoldurulanY.Text = "";
            txtTarih.Text = "";
            textGidilenKm.Text = "";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            lblGizliNo.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            txtPlaka.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            txtSofor.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            textGidilenKm.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            txtHarcananY.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
            txtDoldurulanY.Text = dataGridView2.Rows[secilen].Cells[5].Value.ToString();
            txtTarih.Text = dataGridView2.Rows[secilen].Cells[6].Value.ToString();
            
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            
            if (txtSofor.Text=="" || txtPlaka.Text=="" || txtHarcananY.Text=="" || txtDoldurulanY.Text=="")
            {
                MessageBox.Show("Boş Alanları Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Kayıt Eklensin mi?","Bilgi",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                
                SqlCommand komut = new SqlCommand("Insert into Tbl_YakitKm (Plaka,Sofor,Km,HarcananYakit,DoldurulanYakit,Tarih) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", txtSofor.Text);               
                komut.Parameters.AddWithValue("@p3", Convert.ToInt32(textGidilenKm.Text));
                komut.Parameters.AddWithValue("@p4", Convert.ToInt32(txtHarcananY.Text));
                komut.Parameters.AddWithValue("@p5", Convert.ToInt32(txtDoldurulanY.Text));
                komut.Parameters.AddWithValue("@p6", dateTimeTarih.Value);                
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                GunlukVeriGirisListele();
                txtTarih.Text = "";
                txtSofor.Text = "";
                txtPlaka.Text = "";
                txtHarcananY.Text = "";
                txtDoldurulanY.Text = "";
                textGidilenKm.Text = "";
                lblGizliNo.Text = "No";
                
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (lblGizliNo.Text=="No")
            {
                MessageBox.Show("Kayıt Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Kayıt Silinsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                
                SqlCommand komut = new SqlCommand("Delete From Tbl_YakitKm where No=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", lblGizliNo.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                GunlukVeriGirisListele();
                txtTarih.Text = "";
                txtSofor.Text = "";
                txtPlaka.Text = "";
                txtHarcananY.Text = "";
                txtDoldurulanY.Text = "";
                textGidilenKm.Text = "";
                lblGizliNo.Text = "No";

            }
        }

        private void BtnDegistir_Click(object sender, EventArgs e)
        {
            if (lblGizliNo.Text == "No")
            {
                MessageBox.Show("Kayıt Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Değişiklikler Kaydedilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
               
                SqlCommand komut = new SqlCommand("Update Tbl_YakitKm set Plaka=@p1,Sofor=@p2,Km=@p3,HarcananYakit=@p4,DoldurulanYakit=@p5,Tarih=@p6 where No=@p7", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", txtSofor.Text);
                komut.Parameters.AddWithValue("@p3", Convert.ToInt32(textGidilenKm.Text));
                komut.Parameters.AddWithValue("@p4", Convert.ToInt32(txtHarcananY.Text));
                komut.Parameters.AddWithValue("@p5", Convert.ToInt32(txtDoldurulanY.Text));
                komut.Parameters.AddWithValue("@p6", Convert.ToDateTime(txtTarih.Text));
                komut.Parameters.AddWithValue("@p7", lblGizliNo.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                GunlukVeriGirisListele();
                txtTarih.Text = "";
                txtSofor.Text = "";
                txtPlaka.Text = "";
                txtHarcananY.Text = "";
                txtDoldurulanY.Text = "";
                textGidilenKm.Text = "";
                lblGizliNo.Text = "No";
            }
        }

        private void txtSofor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Arac,AdSoyad From Tbl_Soforler where Adsoyad Like '" + textBox2.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Arac,AdSoyad From Tbl_Soforler where Arac Like '" + textBox1.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GunlukVeriGirisListele();
            textBox1.Text = "";
            textBox2.Text = "";
            txtDoldurulanY.Text = "";
            txtHarcananY.Text = "";
            txtPlaka.Text = "";
            txtSofor.Text = "";
            txtTarih.Text = "";
            lblGizliNo.Text = "";
            textGidilenKm.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYakitKmTakip yk = new FrmYakitKmTakip();
            yk.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSoforPanel fr = new FrmSoforPanel();
            fr.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmYakitKmTakip fr = new FrmYakitKmTakip();
            fr.Show();
            this.Hide();
        }
    }
}
