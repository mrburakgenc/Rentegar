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
    public partial class FrmTvResimbes : Form
    {
        public FrmTvResimbes()
        {
            InitializeComponent();
        }
        public string tvresimbes;
        private void FrmTvResimbes_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = tvresimbes;
        }
    }
}
