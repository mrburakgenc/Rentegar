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
    public partial class FrmTeResimdort : Form
    {
        public FrmTeResimdort()
        {
            InitializeComponent();
        }
        public string teresimdort;
        private void FrmTeResimdort_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = teresimdort;
        }
    }
}
