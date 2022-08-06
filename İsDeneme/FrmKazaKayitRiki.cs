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
    public partial class FrmKazaKayitRiki : Form
    {
        public FrmKazaKayitRiki()
        {
            InitializeComponent();
        }
        public string resimikiac;
        private void FrmKazaKayitRiki_Load(object sender, EventArgs e)
        {
            pictureZR2.ImageLocation = resimikiac;
        }
    }
}
