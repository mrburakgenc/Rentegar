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
    public partial class FrmYakitHaftaGrafik : Form
    {
        public FrmYakitHaftaGrafik()
        {
            InitializeComponent();
        }
        // SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SCUJ6TJ;Initial Catalog=Denemeİs;Integrated Security=True");

        public int ghgunbir, ghguniki, ghgunuc, ghgundort, ghgunbes, ghgunalti, ghgunyedi, gdgunbir, gdguniki, gdgunuc, gdgundort, gdgunbes, gdgunalti, gdgunyedi;
        public string ggunbir, gguniki, ggunuc, ggundort, ggunbes, ggunalti, ggunyedi, gkagunbir, gkaguniki, gkagunuc, gkagundort, gkagunbes, gkagunalti, gkagunyedi;
        public int gkgunbir, gkguniki, gkgunuc, gkgundort, gkgunbes, gkgunalti, gkgunyedi;
        
        private void FrmYakitHaftaGrafik_Load(object sender, EventArgs e)
        {
            if (ggunbir=="Boş Kayıt")
            {
                ggunbir = "Boş Kayıt";
                chartYakitHaftaSec.Series["Harcanan Yakıt"].Points.AddXY(ggunbir, ghgunbir);

            }
            else
            {
                dateTimePicker1.Value = Convert.ToDateTime(ggunbir);
                chartYakitHaftaSec.Series["Harcanan Yakıt"].Points.AddXY("" + dateTimePicker1.Value.ToString("dd MMMM"), ghgunbir);
            }
            if (gguniki=="Boş Kayıt")
            {
                gguniki = "Boş Kayıt";
                chartYakitHaftaSec.Series["Harcanan Yakıt"].Points.AddXY(gguniki, ghguniki);
            }
            else
            {
                dateTimePicker2.Value = Convert.ToDateTime(gguniki);
                chartYakitHaftaSec.Series["Harcanan Yakıt"].Points.AddXY("" + dateTimePicker2.Value.ToString("dd MMMM"), ghguniki);
            }
            if (ggunuc == "Boş Kayıt")
            {
                ggunuc = "Boş Kayıt";
                chartYakitHaftaSec.Series["Harcanan Yakıt"].Points.AddXY(ggunuc, ghgunuc);
            }
            else
            {
                dateTimePicker3.Value = Convert.ToDateTime(ggunuc);
                chartYakitHaftaSec.Series["Harcanan Yakıt"].Points.AddXY("" + dateTimePicker3.Value.ToString("dd MMMM"), ghgunuc);
            }
            if (ggundort == "Boş Kayıt")
            {
                ggundort = "Boş Kayıt";
                chartYakitHaftaSec.Series["Harcanan Yakıt"].Points.AddXY(ggundort, ghgundort);
            }
            else
            {
                dateTimePicker4.Value = Convert.ToDateTime(ggundort);
                chartYakitHaftaSec.Series["Harcanan Yakıt"].Points.AddXY("" + dateTimePicker4.Value.ToString("dd MMMM"), ghgundort);

            }
            if (ggunbes == "Boş Kayıt")
            {
                ggunbes = "Boş Kayıt";
                chartYakitHaftaSec.Series["Harcanan Yakıt"].Points.AddXY(ggunbes, ghgunbes);
            }
            else
            {
                dateTimePicker5.Value = Convert.ToDateTime(ggunbes);
                chartYakitHaftaSec.Series["Harcanan Yakıt"].Points.AddXY("" + dateTimePicker5.Value.ToString("dd MMMM"), ghgunbes);
            }
            if (ggunalti=="Boş Kayıt")
            {
                ggunalti = "Boş Kayıt";
                chartYakitHaftaSec.Series["Harcanan Yakıt"].Points.AddXY(ggunalti, ghgunalti);
            }
            else
            {
                dateTimePicker6.Value = Convert.ToDateTime(ggunalti);
                chartYakitHaftaSec.Series["Harcanan Yakıt"].Points.AddXY("" + dateTimePicker6.Value.ToString("dd MMMM"), ghgunalti);
            }
            if (ggunyedi=="Boş Kayıt")
            {                
                ggunyedi = "Boş Kayıt";
                chartYakitHaftaSec.Series["Harcanan Yakıt"].Points.AddXY(ggunyedi, ghgunyedi);
            }
            else
            {               
                dateTimePicker7.Value = Convert.ToDateTime(ggunyedi);
                chartYakitHaftaSec.Series["Harcanan Yakıt"].Points.AddXY("" + dateTimePicker7.Value.ToString("dd MMMM"), ghgunyedi);
            }
           
            // Km
            if (gkagunbir == "Boş Kayıt")
            {
                gkagunbir = "Boş Kayıt";
                chartKm.Series["Gidilen Km-m"].Points.AddXY(gkagunbir, gkgunbir);

            }
            else
            {
                dateTimePicker8.Value = Convert.ToDateTime(gkagunbir);
                chartKm.Series["Gidilen Km-m"].Points.AddXY("" + dateTimePicker8.Value.ToString("dd MMMM"), gkgunbir);
            }
            if (gkaguniki == "Boş Kayıt")
            {
                gkaguniki = "Boş Kayıt";
                chartKm.Series["Gidilen Km-m"].Points.AddXY(gkaguniki, gkguniki);

            }
            else
            {
                dateTimePicker9.Value = Convert.ToDateTime(gkaguniki);
                chartKm.Series["Gidilen Km-m"].Points.AddXY("" + dateTimePicker9.Value.ToString("dd MMMM"), gkguniki);
            }
            if (gkagunuc == "Boş Kayıt")
            {
                gkagunuc = "Boş Kayıt";
                chartKm.Series["Gidilen Km-m"].Points.AddXY(gkagunuc, gkgunuc);

            }
            else
            {
                dateTimePicker10.Value = Convert.ToDateTime(gkagunuc);
                chartKm.Series["Gidilen Km-m"].Points.AddXY("" + dateTimePicker10.Value.ToString("dd MMMM"), gkgunuc);
            }
            if (gkagundort == "Boş Kayıt")
            {
                gkagundort = "Boş Kayıt";
                chartKm.Series["Gidilen Km-m"].Points.AddXY(gkagundort, gkgundort);

            }
            else
            {
                dateTimePicker11.Value = Convert.ToDateTime(gkagundort);
                chartKm.Series["Gidilen Km-m"].Points.AddXY("" + dateTimePicker11.Value.ToString("dd MMMM"), gkgundort);
            }
            if (gkagunbes == "Boş Kayıt")
            {
                gkagunbes = "Boş Kayıt";
                chartKm.Series["Gidilen Km-m"].Points.AddXY(gkagunbes, gkgunbes);

            }
            else
            {
                dateTimePicker12.Value = Convert.ToDateTime(gkagunbes);
                chartKm.Series["Gidilen Km-m"].Points.AddXY("" + dateTimePicker12.Value.ToString("dd MMMM"), gkgunbes);
            }
            if (gkagunalti == "Boş Kayıt")
            {
                gkagunalti = "Boş Kayıt";
                chartKm.Series["Gidilen Km-m"].Points.AddXY(gkagunalti, gkgunalti);

            }
            else
            {
                dateTimePicker13.Value = Convert.ToDateTime(gkagunalti);
                chartKm.Series["Gidilen Km-m"].Points.AddXY("" + dateTimePicker13.Value.ToString("dd MMMM"), gkgunalti);
            }
            if (gkagunyedi == "Boş Kayıt")
            {
                gkagunyedi = "Boş Kayıt";
                chartKm.Series["Gidilen Km-m"].Points.AddXY(gkagunyedi, gkgunyedi);

            }
            else
            {
                dateTimePicker14.Value = Convert.ToDateTime(gkagunyedi);
                chartKm.Series["Gidilen Km-m"].Points.AddXY("" + dateTimePicker14.Value.ToString("dd MMMM"), gkgunyedi);
            }
            
                                 

            chartYakitHaftaSec.Series["Doldurulan Yakıt"].Points.AddXY("", gdgunbir);
            chartYakitHaftaSec.Series["Doldurulan Yakıt"].Points.AddXY("", gdguniki);
            chartYakitHaftaSec.Series["Doldurulan Yakıt"].Points.AddXY("", gdgunuc);
            chartYakitHaftaSec.Series["Doldurulan Yakıt"].Points.AddXY("", gdgundort);
            chartYakitHaftaSec.Series["Doldurulan Yakıt"].Points.AddXY("", gdgunbes);
            chartYakitHaftaSec.Series["Doldurulan Yakıt"].Points.AddXY("", gdgunalti);
            chartYakitHaftaSec.Series["Doldurulan Yakıt"].Points.AddXY("", gdgunyedi);
        }
    }
}
