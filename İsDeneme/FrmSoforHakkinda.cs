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

namespace İsDeneme
{
    public partial class FrmSoforHakkinda : Form
    {
        public FrmSoforHakkinda()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       // SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SCUJ6TJ;Initial Catalog=Denemeİs;Integrated Security=True");
        SqlCnt bgl = new SqlCnt();

        public string SoforHakkindaID;
        private void FrmSoforHakkinda_Load(object sender, EventArgs e)
        {
            
            
            SqlCommand komut = new SqlCommand("Select AdSoyad, SoforProfResim, SoforHakkinda from Tbl_Soforler where No=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", SoforHakkindaID);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
                pictureBox1.ImageLocation = dr[1].ToString();
                richTextBox1.Text = dr[2].ToString();
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Enabled = true;
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kaydedilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
              
                SqlCommand komut = new SqlCommand("update Tbl_Soforler set SoforHakkinda=@p1 where No=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", richTextBox1.Text);
                komut.Parameters.AddWithValue("@p2", SoforHakkindaID);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();                
            }
            richTextBox1.Enabled = false;
            button2.Enabled = false;
        }
    }
}
