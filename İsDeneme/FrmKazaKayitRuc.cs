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
    public partial class FrmKazaKayitRuc : Form
    {
        public FrmKazaKayitRuc()
        {
            InitializeComponent();
        }
        public string resim3ac;
        private void FrmKazaKayitRuc_Load(object sender, EventArgs e)
        {
            pictureZR3.ImageLocation = resim3ac;
        }
    }
}
