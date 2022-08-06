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
    public partial class FrmTeResimon : Form
    {
        public FrmTeResimon()
        {
            InitializeComponent();
        }
        public string teresimon;
        private void FrmTeResimon_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = teresimon;
        }
    }
}
