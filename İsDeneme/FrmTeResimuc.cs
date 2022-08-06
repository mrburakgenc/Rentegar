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
    public partial class FrmTeResimuc : Form
    {
        public FrmTeResimuc()
        {
            InitializeComponent();
        }
        public string teresimuc;
        private void FrmTeResimuc_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = teresimuc;
        }
    }
}
