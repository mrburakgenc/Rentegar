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
    public partial class FrmTeResimonuc : Form
    {
        public FrmTeResimonuc()
        {
            InitializeComponent();
        }
        public string teresimonuc;
        private void FrmTeResimonuc_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = teresimonuc;
        }
    }
}
