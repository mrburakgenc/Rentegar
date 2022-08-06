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
    public partial class FrmPlakaGecmisi : Form
    {
        public FrmPlakaGecmisi()
        {
            InitializeComponent();
        }
        SqlCnt bgl = new SqlCnt();

        public string Gplaka, Tvvideo = "0", Tevideo = "0", Tvtutanak="0", Tetutanak="0";
        public string picbos = "0";

        void PlakaListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select No,Marka,Plaka,Tip,Cins,TeslimKisi,Tel,Firma,KiraBaslaTarihi,TeslimAlTarihi from Tbl_TeslimIslemleri where Plaka=@k1", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@k1", Gplaka);
            da.Fill(dt);
            DtPlakaGecmis.DataSource = dt;
        }
        private void FrmPlakaGecmisi_Load(object sender, EventArgs e)
        {
            PlakaListele();
            DtPlakaGecmis.Columns[0].Visible = false;

        }

        private void DtPlakaGecmis_CellClick(object sender, DataGridViewCellEventArgs e)
        {                        
            int secilen = DtPlakaGecmis.SelectedCells[0].RowIndex;
            lblNo.Text = DtPlakaGecmis.Rows[secilen].Cells[0].Value.ToString();

            SqlCommand komut = new SqlCommand("Select Resimbir,Resimiki,Resimuc,Resimdort,Resimbes,Resimalti,Resimyedi,Resimsekiz,Resimdokuz,Resimon,Resimonbir,Resimoniki,Resimonuc,Resimondort,Resimonbes,Video,Tutanak,Aciklama, Tresimbir,Tresimiki,Tresimuc,Tresimdort,Tresimbes,Tresimalti,Tresimyedi,Tresimsekiz,Tresimdokuz,Tresimon,Tresimonbir,Tresimoniki,Tresimonuc,Tresimdort,Tresimonbes,Tvideo,Ttutanak,Taciklama from Tbl_TeslimIslemleri where No=@m1", bgl.baglanti());
            komut.Parameters.AddWithValue("@m1", lblNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                if (dr[0]==null)
                {
                    Tvpic1.ImageLocation = picbos;
                }
                else
                {
                    Tvpic1.ImageLocation = dr[0].ToString();
                }
                if (dr[1]==null)
                {
                    Tvpic2.ImageLocation = picbos;                 
                }
                else
                {
                    Tvpic2.ImageLocation = dr[1].ToString();
                }
                if (dr[2]==null)
                {
                    Tvpic3.ImageLocation = picbos;
                }
                else
                {
                    Tvpic3.ImageLocation = dr[2].ToString();
                }
                if (dr[3]==null)
                {
                    Tvpic4.ImageLocation = picbos;
                }
                else
                {
                    Tvpic4.ImageLocation = dr[3].ToString();
                }
                if (dr[4] == null)
                {
                    Tvpic5.ImageLocation = picbos;
                }
                else
                {
                    Tvpic5.ImageLocation = dr[4].ToString();
                }
                if (dr[5] == null)
                {
                    Tvpic6.ImageLocation = picbos;
                }
                else
                {
                    Tvpic6.ImageLocation = dr[5].ToString();
                }
                if (dr[6] == null)
                {
                    Tvpic7.ImageLocation = picbos;
                }
                else
                {
                    Tvpic7.ImageLocation = dr[6].ToString();
                }
                if (dr[7] == null)
                {
                    Tvpic8.ImageLocation = picbos;
                }
                else
                {
                    Tvpic8.ImageLocation = dr[7].ToString();
                }
                if (dr[8] == null)
                {
                    Tvpic9.ImageLocation = picbos;
                }
                else
                {
                    Tvpic9.ImageLocation = dr[8].ToString();
                }
                if (dr[9] == null)
                {
                    Tvpic10.ImageLocation = picbos;
                }
                else
                {
                    Tvpic10.ImageLocation = dr[9].ToString();
                }
                if (dr[10] == null)
                {
                    Tvpic11.ImageLocation = picbos;
                }
                else
                {
                    Tvpic11.ImageLocation = dr[10].ToString();
                }
                if (dr[11] == null)
                {
                    Tvpic12.ImageLocation = picbos;
                }
                else
                {
                    Tvpic12.ImageLocation = dr[11].ToString();
                }
                if (dr[12] == null)
                {
                    Tvpic13.ImageLocation = picbos;
                }
                else
                {
                    Tvpic13.ImageLocation = dr[12].ToString();
                }
                if (dr[13] == null)
                {
                    Tvpic14.ImageLocation = picbos;
                }
                else
                {
                    Tvpic14.ImageLocation = dr[13].ToString();
                }
                if (dr[14] == null)
                {
                    Tvpic15.ImageLocation = picbos;
                }
                else
                {
                    Tvpic15.ImageLocation = dr[14].ToString();
                }
                              
                Tvvideo = dr[15].ToString();
                Tvtutanak = dr[16].ToString();
                RcOnce.Text = dr[17].ToString();

                if (dr[18] == null)
                {
                    Tepic1.ImageLocation = picbos;
                }
                else
                {
                    Tepic1.ImageLocation = dr[18].ToString();
                }
                if (dr[19] == null)
                {
                    Tepic2.ImageLocation = picbos;
                }
                else
                {
                    Tepic2.ImageLocation = dr[19].ToString();
                }
                if (dr[20] == null)
                {
                    Tepic3.ImageLocation = picbos;
                }
                else
                {
                    Tepic3.ImageLocation = dr[20].ToString();
                }
                if (dr[21] == null)
                {
                    Tepic4.ImageLocation = picbos;
                }
                else
                {
                    Tepic4.ImageLocation = dr[21].ToString();
                }
                if (dr[22] == null)
                {
                    Tepic5.ImageLocation = picbos;
                }
                else
                {
                    Tepic5.ImageLocation = dr[22].ToString();
                }
                if (dr[23] == null)
                {
                    Tepic6.ImageLocation = picbos;
                }
                else
                {
                    Tepic6.ImageLocation = dr[23].ToString();
                }
                if (dr[24] == null)
                {
                    Tepic7.ImageLocation = picbos;
                }
                else
                {
                    Tepic7.ImageLocation = dr[24].ToString();
                }
                if (dr[25] == null)
                {
                    Tepic8.ImageLocation = picbos;
                }
                else
                {
                    Tepic8.ImageLocation = dr[25].ToString();
                }
                if (dr[26] == null)
                {
                    Tepic9.ImageLocation = picbos;
                }
                else
                {
                    Tepic9.ImageLocation = dr[26].ToString();
                }
                if (dr[27] == null)
                {
                    Tepic10.ImageLocation = picbos;
                }
                else
                {
                    Tepic10.ImageLocation = dr[27].ToString();
                }
                if (dr[28] == null)
                {
                    Tepic11.ImageLocation = picbos;
                }
                else
                {
                    Tepic11.ImageLocation = dr[28].ToString();
                }
                if (dr[29] == null)
                {
                    Tepic12.ImageLocation = picbos;
                }
                else
                {
                    Tepic12.ImageLocation = dr[29].ToString();
                }
                if (dr[30] == null)
                {
                    Tepic13.ImageLocation = picbos;
                }
                else
                {
                    Tepic13.ImageLocation = dr[30].ToString();
                }
                if (dr[31] == null)
                {
                    Tepic14.ImageLocation = picbos;
                }
                else
                {
                    Tepic14.ImageLocation = dr[31].ToString();
                }
                if (dr[32] == null)
                {
                    Tepic15.ImageLocation = picbos;
                }
                else
                {
                    Tepic15.ImageLocation = dr[32].ToString();
                }
                                                                
                
                Tevideo = dr[33].ToString();
                Tetutanak = dr[34].ToString();
                RcSonra.Text = dr[35].ToString();
            }

            


        }

        private void Tvpic1_DoubleClick(object sender, EventArgs e)
        {
            FrmTvResimbir fr = new FrmTvResimbir();
            fr.tvresimbir = Tvpic1.ImageLocation;
            fr.Show();

        }

        private void Tvpic2_DoubleClick(object sender, EventArgs e)
        {
            FrmTvResimiki fr = new FrmTvResimiki();
            fr.tvresimiki = Tvpic2.ImageLocation;
            fr.Show();
        }

        private void Tvpic3_DoubleClick(object sender, EventArgs e)
        {
            FrmTvResimuc fr = new FrmTvResimuc();
            fr.tvresimuc = Tvpic3.ImageLocation;
            fr.Show();
        }

        private void Tvpic4_DoubleClick(object sender, EventArgs e)
        {
            FrmTvResimdort fr = new FrmTvResimdort();
            fr.tvresimdort = Tvpic4.ImageLocation;
            fr.Show();
        }

        private void Tvpic5_DoubleClick(object sender, EventArgs e)
        {
            FrmTvResimbes fr = new FrmTvResimbes();
            fr.tvresimbes = Tvpic5.ImageLocation;
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmTvVideo fr = new FrmTvVideo();
            fr.tvvideo = Tvvideo;
            fr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmTvTutanak fr = new FrmTvTutanak();
            fr.tvtutanak = Tvtutanak;
            fr.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmTeVideo fr = new FrmTeVideo();
            fr.tevideo = Tevideo;
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmTeTutanak fr = new FrmTeTutanak();
            fr.tetutanak = Tetutanak;
            fr.Show();
        }

        private void Tepic1_DoubleClick(object sender, EventArgs e)
        {
            TeResimbir fr = new TeResimbir();
            fr.teresimbir = Tepic1.ImageLocation;
            fr.Show();
        }

        private void Tepic2_DoubleClick(object sender, EventArgs e)
        {
            FrmTeResimiki fr = new FrmTeResimiki();
            fr.teresimiki = Tepic2.ImageLocation;
            fr.Show();
        }

        private void Tepic3_DoubleClick(object sender, EventArgs e)
        {
            FrmTeResimuc fr = new FrmTeResimuc();
            fr.teresimuc = Tepic3.ImageLocation;
            fr.Show();
        }

        private void Tepic4_DoubleClick(object sender, EventArgs e)
        {
            FrmTeResimdort fr = new FrmTeResimdort();
            fr.teresimdort = Tepic4.ImageLocation;
            fr.Show();
        }

        private void Tepic5_DoubleClick(object sender, EventArgs e)
        {
            FrmTeResimbes fr = new FrmTeResimbes();
            fr.teresimbes = Tepic5.ImageLocation;
            fr.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            RentegarAnasayfa fr = new RentegarAnasayfa();
            fr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmAracTeslimIslem fr = new FrmAracTeslimIslem();
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRentaCar fr = new FrmRentaCar();
            fr.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Tvpic6_DoubleClick(object sender, EventArgs e)
        {
            FrmTvResimalti fr = new FrmTvResimalti();
            fr.tvresimalti = Tvpic6.ImageLocation;
            fr.Show();
        }

        private void Tvpic7_DoubleClick(object sender, EventArgs e)
        {
            FrmTvResimyedi fr = new FrmTvResimyedi();
            fr.tvresimyedi = Tvpic7.ImageLocation;
            fr.Show();
        }

        private void Tvpic8_DoubleClick(object sender, EventArgs e)
        {
            FrmTvResimsekiz fr = new FrmTvResimsekiz();
            fr.tvresimsekiz = Tvpic8.ImageLocation;
            fr.Show();
        }

        private void Tvpic9_DoubleClick(object sender, EventArgs e)
        {
            FrmTvResimdokuz fr = new FrmTvResimdokuz();
            fr.tvresimdokuz = Tvpic9.ImageLocation;
            fr.Show();
        }

        private void Tvpic10_DoubleClick(object sender, EventArgs e)
        {
            FrmTvResimon fr = new FrmTvResimon();
            fr.tvresimon = Tvpic10.ImageLocation;
            fr.Show();
        }

        private void Tvpic11_DoubleClick(object sender, EventArgs e)
        {
            FrmTvResimonbir fr = new FrmTvResimonbir();
            fr.tvresimonbir = Tvpic11.ImageLocation;
            fr.Show();
        }

        private void Tvpic12_DoubleClick(object sender, EventArgs e)
        {
            FrmTvResimoniki fr = new FrmTvResimoniki();
            fr.tvresimoniki = Tvpic12.ImageLocation;
            fr.Show();
        }

        private void Tvpic13_DoubleClick(object sender, EventArgs e)
        {
            FrmTvResimonuc fr = new FrmTvResimonuc();
            fr.tvresimonuc = Tvpic13.ImageLocation;
            fr.Show();
        }

        private void Tvpic14_DoubleClick(object sender, EventArgs e)
        {
            FrmTvResimondort fr = new FrmTvResimondort();
            fr.tvresimondort = Tvpic14.ImageLocation;
            fr.Show();
        }

        private void Tvpic15_DoubleClick(object sender, EventArgs e)
        {
            FrmTvResimonbes fr = new FrmTvResimonbes();
            fr.tvresimonbes = Tvpic15.ImageLocation;
            fr.Show();
        }

        private void Tepic6_DoubleClick(object sender, EventArgs e)
        {
            FrmTeResimalti fr = new FrmTeResimalti();
            fr.teresimalti = Tepic6.ImageLocation;
            fr.Show();
        }

        private void Tepic7_DoubleClick(object sender, EventArgs e)
        {
            FrmTeResimyedi fr = new FrmTeResimyedi();
            fr.teresimyedi = Tepic7.ImageLocation;
            fr.Show();
        }

        private void Tepic8_DoubleClick(object sender, EventArgs e)
        {
            FrmTeResimsekiz fr = new FrmTeResimsekiz();
            fr.teresimsekiz = Tepic8.ImageLocation;
            fr.Show();
        }

        private void Tepic9_DoubleClick(object sender, EventArgs e)
        {
            FrmTeResimdokuz fr = new FrmTeResimdokuz();
            fr.teresimdokuz = Tepic9.ImageLocation;
            fr.Show();
        }

        private void Tepic10_DoubleClick(object sender, EventArgs e)
        {
            FrmTeResimon fr = new FrmTeResimon();
            fr.teresimon = Tepic10.ImageLocation;
            fr.Show();
        }

        private void Tepic11_DoubleClick(object sender, EventArgs e)
        {
            FrmTeResimonbir fr = new FrmTeResimonbir();
            fr.teresimonbir = Tepic11.ImageLocation;
            fr.Show();
        }

        private void Tepic12_DoubleClick(object sender, EventArgs e)
        {
            FrmTeResimoniki fr = new FrmTeResimoniki();
            fr.teresimoniki = Tepic12.ImageLocation;
            fr.Show();
        }

        private void Tepic13_DoubleClick(object sender, EventArgs e)
        {
            FrmTeResimonuc fr = new FrmTeResimonuc();
            fr.teresimonuc = Tepic13.ImageLocation;
            fr.Show();
        }

        private void Tepic14_DoubleClick(object sender, EventArgs e)
        {
            FrmTeResimondort fr = new FrmTeResimondort();
            fr.teresimondort = Tepic14.ImageLocation;
            fr.Show();
        }

        private void Tepic15_DoubleClick(object sender, EventArgs e)
        {
            FrmTeResimonbes fr = new FrmTeResimonbes();
            fr.teresimonbes = Tepic15.ImageLocation;
            fr.Show();
        }
    }
}
