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
    public partial class FrmAracKazaKayit : Form
    {
        public FrmAracKazaKayit()
        {
            InitializeComponent();
        }
        SqlCnt bgl = new SqlCnt();

        void AracListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No, Marka, Plaka, Cins, TeslimSahis, Tel, BulunduguYer,SahisaTeslimTh From Tbl_Rentegar", bgl.baglanti());
            da.Fill(dt);
            DtArac.DataSource = dt;
            
        }
        private void FrmAracKazaKayit_Load(object sender, EventArgs e)
        {
            AracListele();
        }

        private void DtArac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = DtArac.SelectedCells[0].RowIndex;            
            lblKazaGizliNo.Text = DtArac.Rows[secilen].Cells[0].Value.ToString();
            txtMarka.Text = DtArac.Rows[secilen].Cells[1].Value.ToString();
            txtPlaka.Text = DtArac.Rows[secilen].Cells[2].Value.ToString();
            txtCins.Text = DtArac.Rows[secilen].Cells[3].Value.ToString();
            txtTeslimKisi.Text = DtArac.Rows[secilen].Cells[4].Value.ToString();
            txtTel.Text = DtArac.Rows[secilen].Cells[5].Value.ToString();
            txtByer.Text = DtArac.Rows[secilen].Cells[6].Value.ToString();
            txtKiraTh.Text = DtArac.Rows[secilen].Cells[7].Value.ToString();
            

        }
    }
}
