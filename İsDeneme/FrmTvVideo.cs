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
    public partial class FrmTvVideo : Form
    {
        public FrmTvVideo()
        {
            InitializeComponent();
        }
        public string tvvideo;
        private void FrmTvVideo_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = tvvideo;
        }
    }
}
