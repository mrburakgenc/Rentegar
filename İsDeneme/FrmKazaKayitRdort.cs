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
    public partial class FrmKazaKayitRdort : Form
    {
        public FrmKazaKayitRdort()
        {
            InitializeComponent();
        }
        public string resim4ac;
        private void FrmKazaKayitRdort_Load(object sender, EventArgs e)
        {
            pictureZR4.ImageLocation = resim4ac;
        }
    }
}
