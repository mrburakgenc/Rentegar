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
    public partial class FrmTvTutanak : Form
    {
        public FrmTvTutanak()
        {
            InitializeComponent();
        }
        public string tvtutanak;
        private void FrmTvTutanak_Load(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(tvtutanak);
        }
    }
}
