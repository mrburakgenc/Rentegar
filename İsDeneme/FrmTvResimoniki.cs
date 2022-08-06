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
    public partial class FrmTvResimoniki : Form
    {
        public FrmTvResimoniki()
        {
            InitializeComponent();
        }
        public string tvresimoniki;
        private void FrmTvResimoniki_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = tvresimoniki;
        }
    }
}
