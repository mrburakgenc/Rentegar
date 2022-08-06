using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace İsDeneme
{
    public partial class FrmRuhsat : Form
    {
        public FrmRuhsat()
        {
            InitializeComponent();
        }
        public string Ruhsat = "0";
        private void FrmRuhsat_Load(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(Ruhsat);
        }
    }
}
