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
    public partial class FrmYakitKmTakip : Form
    {
        public FrmYakitKmTakip()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SCUJ6TJ;Initial Catalog=Denemeİs;Integrated Security=True");
        SqlCnt bgl = new SqlCnt();
        void SoforAracListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Arac,AdSoyad from Tbl_Soforler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void YakitKmListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Plaka,Sofor,Km,HarcananYakit,DoldurulanYakit,Tarih from Tbl_YakitKm where Tarih Between @s1 and @s2", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@s1", dateTimePicker3.Value.AddDays(-7).AddHours(-9));
            da.SelectCommand.Parameters.AddWithValue("@s2", dateTimePicker3.Value);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        public int hgunbir = 0, hguniki = 0, hgunuc = 0, hgundort = 0, hgunbes = 0, hgunalti = 0, hgunyedi = 0, dgunbir = 0, dguniki = 0, dgunuc = 0, dgundort = 0, dgunbes = 0, dgunalti = 0, dgunyedi = 0, RowSayisi=0;
        public string gunbir, guniki, gunuc, gundort, gunbes, gunalti, gunyedi, kagunbir, kaguniki, kagunuc, kagundort, kagunbes, kagunalti, kagunyedi;
        public int kgunbir = 0, kguniki = 0, kgunuc = 0, kgundort = 0, kgunbes = 0, kgunalti = 0, kgunyedi = 0;
        private void FrmYakitKmTakip_Load(object sender, EventArgs e)
        {
            SoforAracListele();
            YakitKmListele();
            dataGridView1.Columns[0].HeaderText = "Plaka";
            dataGridView1.Columns[1].HeaderText = "Şoför";
            dataGridView1.Columns[0].Width = 95;
            dataGridView2.Columns[1].Width = 188;
            dataGridView2.Columns[2].Width = 60;
            dataGridView2.Columns[1].HeaderText = "Şoför";
            dataGridView2.Columns[2].HeaderText = "Km-M";
            dataGridView2.Columns[3].HeaderText = "Harcanan Yakıt";
            dataGridView2.Columns[4].HeaderText = "Doldurulan Yakıt";
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        { 
           DataTable dt = new DataTable();
           SqlDataAdapter da = new SqlDataAdapter("Select Plaka,Sofor,Km,HarcananYakit,DoldurulanYakit,Tarih From Tbl_YakitKm where Tarih Between @p1 and @p2", bgl.baglanti());
           da.SelectCommand.Parameters.AddWithValue("@p1", dateTimePicker3.Value.AddDays(-7).AddHours(-9));
           da.SelectCommand.Parameters.AddWithValue("@p2", dateTimePicker3.Value);
           da.Fill(dt);
           dataGridView2.DataSource = dt; 

            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtPlaka.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtSofor.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnSonHaftaListele_Click(object sender, EventArgs e)
        {
            
            if (txtPlaka.Text == "")
            {
                MessageBox.Show("Şoför-Araç Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                label9.Text = "1";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select Plaka,Sofor,Km,HarcananYakit,DoldurulanYakit,Tarih from Tbl_YakitKm where Plaka=@c1 and Tarih Between @c2 and @c3", bgl.baglanti());
                da.SelectCommand.Parameters.AddWithValue("@c1", txtPlaka.Text);
                da.SelectCommand.Parameters.AddWithValue("@c2", dateTimePicker3.Value.AddDays(-7).AddHours(-9));
                da.SelectCommand.Parameters.AddWithValue("@c3", dateTimePicker3.Value);
                da.Fill(dt);
                dataGridView2.DataSource = dt;

                RowSayisi = dataGridView2.RowCount;                

                if (RowSayisi==0)
	            {
		            hgunbir = 0;
                    hguniki = 0;
                    hgunuc = 0;
                    hgundort = 0;
                    hgunbes = 0;
                    hgunalti = 0;
                    hgunyedi = 0;

                    dgunbir = 0;
                    dguniki = 0;
                    dgunuc = 0;
                    dgundort = 0;
                    dgunbes = 0;
                    dgunalti = 0;
                    dgunyedi = 0;

                    kgunbir = 0;
                    kguniki = 0;
                    kgunuc = 0;
                    kgundort = 0;
                    kgunbes = 0;
                    kgunalti = 0;
                    kgunyedi = 0;

                    kagunbir = "Boş Kayıt";
                    kaguniki = "Boş Kayıt";
                    kagunuc = "Boş Kayıt";
                    kagundort = "Boş Kayıt";
                    kagunbes = "Boş Kayıt";
                    kagunalti = "Boş Kayıt";
                    kagunyedi = "Boş Kayıt";

                    gunbir = "Boş Kayıt";
                    guniki = "Boş Kayıt";
                    gunuc = "Boş Kayıt";
                    gundort = "Boş Kayıt";
                    gunbes = "Boş Kayıt";
                    gunalti = "Boş Kayıt";
                    gunyedi = "Boş Kayıt";
	            }
                else if (RowSayisi==1)
                {
                    hgunbir = Convert.ToInt32(dataGridView2.Rows[0].Cells[3].Value);
                    hguniki = 0;
                    hgunuc = 0;
                    hgundort = 0;
                    hgunbes = 0;
                    hgunalti = 0;
                    hgunyedi = 0;

                    dgunbir = Convert.ToInt32(dataGridView2.Rows[0].Cells[4].Value);
                    dguniki = 0;
                    dgunuc = 0;
                    dgundort = 0;
                    dgunbes = 0;
                    dgunalti = 0;
                    dgunyedi = 0;

                    kgunbir = Convert.ToInt32(dataGridView2.Rows[0].Cells[2].Value);
                    kguniki = 0;
                    kgunuc = 0;
                    kgundort = 0;
                    kgunbes = 0;
                    kgunalti = 0;
                    kgunyedi = 0;

                    gunbir = dataGridView2.Rows[0].Cells[5].Value.ToString();
                    guniki = "Boş Kayıt";
                    gunuc = "Boş Kayıt";
                    gundort = "Boş Kayıt";
                    gunbes = "Boş Kayıt";
                    gunalti = "Boş Kayıt";
                    gunyedi = "Boş Kayıt";

                    kagunbir = dataGridView2.Rows[0].Cells[5].Value.ToString();
                    kaguniki = "Boş Kayıt";
                    kagunuc = "Boş Kayıt";
                    kagundort = "Boş Kayıt";
                    kagunbes = "Boş Kayıt";
                    kagunalti = "Boş Kayıt";
                    kagunyedi = "Boş Kayıt";
                }
                else if (RowSayisi==2)
                {
                    hgunbir = Convert.ToInt32(dataGridView2.Rows[0].Cells[3].Value);
                    hguniki = Convert.ToInt32(dataGridView2.Rows[1].Cells[3].Value);
                    hgunuc = 0;
                    hgundort = 0;
                    hgunbes = 0;
                    hgunalti = 0;
                    hgunyedi = 0;

                    dgunbir = Convert.ToInt32(dataGridView2.Rows[0].Cells[4].Value);
                    dguniki = Convert.ToInt32(dataGridView2.Rows[1].Cells[4].Value);
                    dgunuc = 0;
                    dgundort = 0;
                    dgunbes = 0;
                    dgunalti = 0;
                    dgunyedi = 0;

                    kgunbir = Convert.ToInt32(dataGridView2.Rows[0].Cells[2].Value);
                    kguniki = Convert.ToInt32(dataGridView2.Rows[1].Cells[2].Value); 
                    kgunuc = 0;
                    kgundort = 0;
                    kgunbes = 0;
                    kgunalti = 0;
                    kgunyedi = 0;

                    kagunbir = dataGridView2.Rows[0].Cells[5].Value.ToString();
                    kaguniki = dataGridView2.Rows[1].Cells[5].Value.ToString(); 
                    kagunuc = "Boş Kayıt";
                    kagundort = "Boş Kayıt";
                    kagunbes = "Boş Kayıt";
                    kagunalti = "Boş Kayıt";
                    kagunyedi = "Boş Kayıt";

                    gunbir = dataGridView2.Rows[0].Cells[5].Value.ToString();
                    guniki = dataGridView2.Rows[1].Cells[5].Value.ToString();
                    gunuc = "Boş Kayıt";
                    gundort = "Boş Kayıt";
                    gunbes = "Boş Kayıt";
                    gunalti = "Boş Kayıt";
                    gunyedi = "Boş Kayıt";
                }
                else if (RowSayisi==3)
                {
                    hgunbir = Convert.ToInt32(dataGridView2.Rows[0].Cells[3].Value);
                    hguniki = Convert.ToInt32(dataGridView2.Rows[1].Cells[3].Value);
                    hgunuc = Convert.ToInt32(dataGridView2.Rows[2].Cells[3].Value);
                    hgundort = 0;
                    hgunbes = 0;
                    hgunalti = 0;
                    hgunyedi = 0;

                    dgunbir = Convert.ToInt32(dataGridView2.Rows[0].Cells[4].Value);
                    dguniki = Convert.ToInt32(dataGridView2.Rows[1].Cells[4].Value);
                    dgunuc = Convert.ToInt32(dataGridView2.Rows[2].Cells[4].Value);
                    dgundort = 0;
                    dgunbes = 0;
                    dgunalti = 0;
                    dgunyedi = 0;

                    kgunbir = Convert.ToInt32(dataGridView2.Rows[0].Cells[2].Value);
                    kguniki = Convert.ToInt32(dataGridView2.Rows[1].Cells[2].Value);
                    kgunuc = Convert.ToInt32(dataGridView2.Rows[2].Cells[2].Value); 
                    kgundort = 0;
                    kgunbes = 0;
                    kgunalti = 0;
                    kgunyedi = 0;

                    kagunbir = dataGridView2.Rows[0].Cells[5].Value.ToString();
                    kaguniki = dataGridView2.Rows[1].Cells[5].Value.ToString();
                    kagunuc = dataGridView2.Rows[2].Cells[5].Value.ToString();
                    kagundort = "Boş Kayıt";
                    kagunbes = "Boş Kayıt";
                    kagunalti = "Boş Kayıt";
                    kagunyedi = "Boş Kayıt";

                    gunbir = dataGridView2.Rows[0].Cells[5].Value.ToString();
                    guniki = dataGridView2.Rows[1].Cells[5].Value.ToString();
                    gunuc = dataGridView2.Rows[2].Cells[5].Value.ToString();
                    gundort = "Boş Kayıt";
                    gunbes = "Boş Kayıt";
                    gunalti = "Boş Kayıt";
                    gunyedi = "Boş Kayıt";
                }
                else if (RowSayisi==4)
                {
                    hgunbir = Convert.ToInt32(dataGridView2.Rows[0].Cells[3].Value);
                    hguniki = Convert.ToInt32(dataGridView2.Rows[1].Cells[3].Value);
                    hgunuc = Convert.ToInt32(dataGridView2.Rows[2].Cells[3].Value);
                    hgundort = Convert.ToInt32(dataGridView2.Rows[3].Cells[3].Value);
                    hgunbes = 0;
                    hgunalti = 0;
                    hgunyedi = 0;

                    dgunbir = Convert.ToInt32(dataGridView2.Rows[0].Cells[4].Value);
                    dguniki = Convert.ToInt32(dataGridView2.Rows[1].Cells[4].Value);
                    dgunuc = Convert.ToInt32(dataGridView2.Rows[2].Cells[4].Value);
                    dgundort = Convert.ToInt32(dataGridView2.Rows[3].Cells[4].Value);
                    dgunbes = 0;
                    dgunalti = 0;
                    dgunyedi = 0;

                    kgunbir = Convert.ToInt32(dataGridView2.Rows[0].Cells[2].Value);
                    kguniki = Convert.ToInt32(dataGridView2.Rows[1].Cells[2].Value);
                    kgunuc = Convert.ToInt32(dataGridView2.Rows[2].Cells[2].Value);
                    kgundort = Convert.ToInt32(dataGridView2.Rows[3].Cells[2].Value);
                    kgunbes = 0;
                    kgunalti = 0;
                    kgunyedi = 0;

                    kagunbir = dataGridView2.Rows[0].Cells[5].Value.ToString();
                    kaguniki = dataGridView2.Rows[1].Cells[5].Value.ToString();
                    kagunuc = dataGridView2.Rows[2].Cells[5].Value.ToString();
                    kagundort = dataGridView2.Rows[3].Cells[5].Value.ToString();
                    kagunbes = "Boş Kayıt";
                    kagunalti = "Boş Kayıt";
                    kagunyedi = "Boş Kayıt";

                    gunbir = dataGridView2.Rows[0].Cells[5].Value.ToString();
                    guniki = dataGridView2.Rows[1].Cells[5].Value.ToString();
                    gunuc = dataGridView2.Rows[2].Cells[5].Value.ToString();
                    gundort = dataGridView2.Rows[3].Cells[5].Value.ToString();
                    gunbes = "Boş Kayıt";
                    gunalti = "Boş Kayıt";
                    gunyedi = "Boş Kayıt";
                }
                else if (RowSayisi==5)
                {
                    hgunbir = Convert.ToInt32(dataGridView2.Rows[0].Cells[3].Value);
                    hguniki = Convert.ToInt32(dataGridView2.Rows[1].Cells[3].Value);
                    hgunuc = Convert.ToInt32(dataGridView2.Rows[2].Cells[3].Value);
                    hgundort = Convert.ToInt32(dataGridView2.Rows[3].Cells[3].Value);
                    hgunbes = Convert.ToInt32(dataGridView2.Rows[4].Cells[3].Value);
                    hgunalti = 0;
                    hgunyedi = 0;

                    dgunbir = Convert.ToInt32(dataGridView2.Rows[0].Cells[4].Value);
                    dguniki = Convert.ToInt32(dataGridView2.Rows[1].Cells[4].Value);
                    dgunuc = Convert.ToInt32(dataGridView2.Rows[2].Cells[4].Value);
                    dgundort = Convert.ToInt32(dataGridView2.Rows[3].Cells[4].Value);
                    dgunbes = Convert.ToInt32(dataGridView2.Rows[4].Cells[4].Value);
                    dgunalti = 0;
                    dgunyedi = 0;

                    kgunbir = Convert.ToInt32(dataGridView2.Rows[0].Cells[2].Value);
                    kguniki = Convert.ToInt32(dataGridView2.Rows[1].Cells[2].Value);
                    kgunuc = Convert.ToInt32(dataGridView2.Rows[2].Cells[2].Value);
                    kgundort = Convert.ToInt32(dataGridView2.Rows[3].Cells[2].Value);
                    kgunbes = Convert.ToInt32(dataGridView2.Rows[4].Cells[2].Value);
                    kgunalti = 0;
                    kgunyedi = 0;

                    kagunbir = dataGridView2.Rows[0].Cells[5].Value.ToString();
                    kaguniki = dataGridView2.Rows[1].Cells[5].Value.ToString();
                    kagunuc = dataGridView2.Rows[2].Cells[5].Value.ToString();
                    kagundort = dataGridView2.Rows[3].Cells[5].Value.ToString();
                    kagunbes = dataGridView2.Rows[4].Cells[5].Value.ToString();
                    kagunalti = "Boş Kayıt";
                    kagunyedi = "Boş Kayıt";

                    gunbir = dataGridView2.Rows[0].Cells[5].Value.ToString();
                    guniki = dataGridView2.Rows[1].Cells[5].Value.ToString();
                    gunuc = dataGridView2.Rows[2].Cells[5].Value.ToString();
                    gundort = dataGridView2.Rows[3].Cells[5].Value.ToString();
                    gunbes = dataGridView2.Rows[4].Cells[5].Value.ToString();
                    gunalti = "Boş Kayıt";
                    gunyedi = "Boş Kayıt";
                }
                else if (RowSayisi==6)
                {
                    hgunbir = Convert.ToInt32(dataGridView2.Rows[0].Cells[3].Value);
                    hguniki = Convert.ToInt32(dataGridView2.Rows[1].Cells[3].Value);
                    hgunuc = Convert.ToInt32(dataGridView2.Rows[2].Cells[3].Value);
                    hgundort = Convert.ToInt32(dataGridView2.Rows[3].Cells[3].Value);
                    hgunbes = Convert.ToInt32(dataGridView2.Rows[4].Cells[3].Value);
                    hgunalti = Convert.ToInt32(dataGridView2.Rows[5].Cells[3].Value);
                    hgunyedi = 0;

                    dgunbir = Convert.ToInt32(dataGridView2.Rows[0].Cells[4].Value);
                    dguniki = Convert.ToInt32(dataGridView2.Rows[1].Cells[4].Value);
                    dgunuc = Convert.ToInt32(dataGridView2.Rows[2].Cells[4].Value);
                    dgundort = Convert.ToInt32(dataGridView2.Rows[3].Cells[4].Value);
                    dgunbes = Convert.ToInt32(dataGridView2.Rows[4].Cells[4].Value);
                    dgunalti = Convert.ToInt32(dataGridView2.Rows[5].Cells[4].Value);
                    dgunyedi = 0;

                    kgunbir = Convert.ToInt32(dataGridView2.Rows[0].Cells[2].Value);
                    kguniki = Convert.ToInt32(dataGridView2.Rows[1].Cells[2].Value);
                    kgunuc = Convert.ToInt32(dataGridView2.Rows[2].Cells[2].Value);
                    kgundort = Convert.ToInt32(dataGridView2.Rows[3].Cells[2].Value);
                    kgunbes = Convert.ToInt32(dataGridView2.Rows[4].Cells[2].Value);
                    kgunalti = Convert.ToInt32(dataGridView2.Rows[5].Cells[2].Value);
                    kgunyedi = 0;

                    kagunbir = dataGridView2.Rows[0].Cells[5].Value.ToString();
                    kaguniki = dataGridView2.Rows[1].Cells[5].Value.ToString();
                    kagunuc = dataGridView2.Rows[2].Cells[5].Value.ToString();
                    kagundort = dataGridView2.Rows[3].Cells[5].Value.ToString();
                    kagunbes = dataGridView2.Rows[4].Cells[5].Value.ToString();
                    kagunalti = dataGridView2.Rows[5].Cells[5].Value.ToString();
                    kagunyedi = "Boş Kayıt";

                    gunbir = dataGridView2.Rows[0].Cells[5].Value.ToString();
                    guniki = dataGridView2.Rows[1].Cells[5].Value.ToString();
                    gunuc = dataGridView2.Rows[2].Cells[5].Value.ToString();
                    gundort = dataGridView2.Rows[3].Cells[5].Value.ToString();
                    gunbes = dataGridView2.Rows[4].Cells[5].Value.ToString();
                    gunalti = dataGridView2.Rows[5].Cells[5].Value.ToString();
                    gunyedi = "Boş Kayıt";
                }
                else if (RowSayisi==7 || RowSayisi>=7)
                {
                    hgunbir = Convert.ToInt32(dataGridView2.Rows[0].Cells[3].Value);
                    hguniki = Convert.ToInt32(dataGridView2.Rows[1].Cells[3].Value);
                    hgunuc = Convert.ToInt32(dataGridView2.Rows[2].Cells[3].Value);
                    hgundort = Convert.ToInt32(dataGridView2.Rows[3].Cells[3].Value);
                    hgunbes = Convert.ToInt32(dataGridView2.Rows[4].Cells[3].Value);
                    hgunalti = Convert.ToInt32(dataGridView2.Rows[5].Cells[3].Value);
                    hgunyedi = Convert.ToInt32(dataGridView2.Rows[6].Cells[3].Value);

                    dgunbir = Convert.ToInt32(dataGridView2.Rows[0].Cells[4].Value);
                    dguniki = Convert.ToInt32(dataGridView2.Rows[1].Cells[4].Value);
                    dgunuc = Convert.ToInt32(dataGridView2.Rows[2].Cells[4].Value);
                    dgundort = Convert.ToInt32(dataGridView2.Rows[3].Cells[4].Value);
                    dgunbes = Convert.ToInt32(dataGridView2.Rows[4].Cells[4].Value);
                    dgunalti = Convert.ToInt32(dataGridView2.Rows[5].Cells[4].Value);
                    dgunyedi = Convert.ToInt32(dataGridView2.Rows[6].Cells[4].Value);

                    kgunbir = Convert.ToInt32(dataGridView2.Rows[0].Cells[2].Value);
                    kguniki = Convert.ToInt32(dataGridView2.Rows[1].Cells[2].Value);
                    kgunuc = Convert.ToInt32(dataGridView2.Rows[2].Cells[2].Value);
                    kgundort = Convert.ToInt32(dataGridView2.Rows[3].Cells[2].Value);
                    kgunbes = Convert.ToInt32(dataGridView2.Rows[4].Cells[2].Value);
                    kgunalti = Convert.ToInt32(dataGridView2.Rows[5].Cells[2].Value);
                    kgunyedi = Convert.ToInt32(dataGridView2.Rows[6].Cells[2].Value);

                    kagunbir = dataGridView2.Rows[0].Cells[5].Value.ToString();
                    kaguniki = dataGridView2.Rows[1].Cells[5].Value.ToString();
                    kagunuc = dataGridView2.Rows[2].Cells[5].Value.ToString();
                    kagundort = dataGridView2.Rows[3].Cells[5].Value.ToString();
                    kagunbes = dataGridView2.Rows[4].Cells[5].Value.ToString();
                    kagunalti = dataGridView2.Rows[5].Cells[5].Value.ToString();
                    kagunyedi = dataGridView2.Rows[6].Cells[5].Value.ToString();

                    gunbir = dataGridView2.Rows[0].Cells[5].Value.ToString();
                    guniki = dataGridView2.Rows[1].Cells[5].Value.ToString();
                    gunuc = dataGridView2.Rows[2].Cells[5].Value.ToString();
                    gundort = dataGridView2.Rows[3].Cells[5].Value.ToString();
                    gunbes = dataGridView2.Rows[4].Cells[5].Value.ToString();
                    gunalti = dataGridView2.Rows[5].Cells[5].Value.ToString();
                    gunyedi = dataGridView2.Rows[6].Cells[5].Value.ToString();
                }
                
       
                       
            }
            
        }

        private void BtnAyListele_Click(object sender, EventArgs e)
        {
            if (txtPlaka.Text == "")
            {
                MessageBox.Show("Şoför-Araç Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select Plaka,Sofor,Km,HarcananYakit,DoldurulanYakit,Tarih from Tbl_YakitKm where Plaka=@c1 and Tarih Between @c2 and @c3", bgl.baglanti());
                da.SelectCommand.Parameters.AddWithValue("@c1", txtPlaka.Text);
                da.SelectCommand.Parameters.AddWithValue("@c2", dateTimePicker3.Value.AddDays(-30));
                da.SelectCommand.Parameters.AddWithValue("@c3", dateTimePicker3.Value);
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }

        private void BtnTarihListele_Click(object sender, EventArgs e)
        {
            label9.Text = "0";
            if (txtPlaka.Text == "")
            {
                MessageBox.Show("Şoför-Araç Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select Plaka,Sofor,Km,HarcananYakit,DoldurulanYakit,Tarih from Tbl_YakitKm where Plaka=@c1 and Tarih Between @c2 and @c3", bgl.baglanti());
                da.SelectCommand.Parameters.AddWithValue("@c1", txtPlaka.Text);
                da.SelectCommand.Parameters.AddWithValue("@c2", dateTimePicker1.Value);
                da.SelectCommand.Parameters.AddWithValue("@c3", dateTimePicker2.Value);
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }

        private void BtnHaftaGrafik_Click(object sender, EventArgs e)
        {
            if (label9.Text == "1")
            {


                FrmYakitHaftaGrafik yhg = new FrmYakitHaftaGrafik();
               
                yhg.gkgunbir = kgunbir;
                yhg.gkguniki = kguniki;
                yhg.gkgunuc = kgunuc;
                yhg.gkgundort = kgundort;
                yhg.gkgunbes = kgunbes;
                yhg.gkgunalti = kgunalti;
                yhg.gkgunyedi = kgunyedi;

                yhg.gkagunbir = kagunbir;
                yhg.gkaguniki = kaguniki;
                yhg.gkagunuc = kagunuc;
                yhg.gkagundort = kagundort;
                yhg.gkagunbes = kagunbes;
                yhg.gkagunalti = kagunalti;
                yhg.gkagunyedi = kagunyedi;

                yhg.ghgunbir = hgunbir;
                yhg.ghguniki = hguniki;
                yhg.ghgunuc = hgunuc;
                yhg.ghgundort = hgundort;
                yhg.ghgunbes = hgunbes;
                yhg.ghgunalti = hgunalti;
                yhg.ghgunyedi = hgunyedi;

                yhg.gdgunbir = dgunbir;
                yhg.gdguniki = dguniki;
                yhg.gdgunuc = dgunuc;
                yhg.gdgundort = dgundort;
                yhg.gdgunbes = dgunbes;
                yhg.gdgunalti = dgunalti;
                yhg.gdgunyedi = dgunyedi;

                yhg.ggunbir = gunbir;
                yhg.gguniki = guniki;
                yhg.ggunuc = gunuc;
                yhg.ggundort = gundort;
                yhg.ggunbes = gunbes;
                yhg.ggunalti = gunalti;
                yhg.ggunyedi = gunyedi;

                yhg.Show();
            }
            else
            {
                MessageBox.Show("Haftalık Grafik Çizelgesini görüntülemek için tabloda Son Haftayı Listelemelisiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void BtnHaftaTopGrafik_Click(object sender, EventArgs e)
        {
            FrmTopYakitHaftaGrafik ythg = new FrmTopYakitHaftaGrafik();
            

            ythg.Show();
        }

        private void BtnYakitEklePanel_Click(object sender, EventArgs e)
        {
            FrmYakitKmEkle fr = new FrmYakitKmEkle();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSoforPanel fr = new FrmSoforPanel();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void txtPlakaBul_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select AdSoyad,Arac From Tbl_Soforler where Durum=1 and Arac Like '" + txtPlakaBul.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtSoforBul_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select AdSoyad,Arac From Tbl_Soforler where Durum=1 and AdSoyad Like '" + txtSoforBul.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }
    }
}
