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
    public partial class FrmTvResimuc : Form
    {
        public FrmTvResimuc()
        {
            InitializeComponent();
        }
        public string tvresimuc;
        private void FrmTvResimuc_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = tvresimuc;
        }
    }
}
