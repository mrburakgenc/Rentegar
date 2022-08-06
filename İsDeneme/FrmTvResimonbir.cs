using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İsDeneme
{
    public partial class FrmTvResimonbir : Form
    {
        public FrmTvResimonbir()
        {
            InitializeComponent();
        }
        public string tvresimonbir;
        private void FrmTvResimonbir_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = tvresimonbir;
        }
    }
}
