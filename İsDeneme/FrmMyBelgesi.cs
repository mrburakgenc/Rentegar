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
    public partial class FrmMyBelgesi : Form
    {
        public FrmMyBelgesi()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SCUJ6TJ;Initial Catalog=Denemeİs;Integrated Security=True");
        SqlCnt bgl = new SqlCnt();
        public string MyBelgeID;


        private void FrmMyBelgesi_Load(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("Select MYBelgesi from Tbl_Soforler where No=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MyBelgeID);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
            AdobeMYAc.LoadFile(label1.Text);
        }
    }
}
