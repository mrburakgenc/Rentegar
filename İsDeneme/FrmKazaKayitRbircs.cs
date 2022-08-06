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
    public partial class FrmKazaKayitRbircs : Form
    {
        public FrmKazaKayitRbircs()
        {
            InitializeComponent();
        }
        public string resim1ac;
        private void FrmKazaKayitRbircs_Load(object sender, EventArgs e)
        {
            pictureZR1.ImageLocation = resim1ac;
        }
    }
}
