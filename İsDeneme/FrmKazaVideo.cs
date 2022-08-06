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
    public partial class FrmKazaVideo : Form
    {
        public FrmKazaVideo()
        {
            InitializeComponent();
        }
        public string KazaOynat;
        private void FrmKazaVideo_Load(object sender, EventArgs e)
        {
            axMediaKazaVideo.URL = KazaOynat;
        }
    }
}
