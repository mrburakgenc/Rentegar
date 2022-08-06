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
    public partial class FrmIkametBelgesi : Form
    {
        public FrmIkametBelgesi()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SCUJ6TJ;Initial Catalog=Denemeİs;Integrated Security=True");
        SqlCnt bgl = new SqlCnt();
        public string IkametgahBelgeID;

        private void FrmIkametBelgesi_Load(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("Select Ikametgah from Tbl_Soforler where No=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", IkametgahBelgeID);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
            AdobeIkametAc.LoadFile(label1.Text);
        }
    }
}
