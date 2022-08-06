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
    public partial class FrmTvResimonbes : Form
    {
        public FrmTvResimonbes()
        {
            InitializeComponent();
        }
        public string tvresimonbes;
        private void FrmTvResimonbes_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = tvresimonbes;
        }
    }
}
