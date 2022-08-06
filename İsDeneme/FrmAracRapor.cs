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
    public partial class FrmAracRapor : Form
    {
        public FrmAracRapor()
        {
            InitializeComponent();
        }

        private void FrmAracRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DenemeİsDataSetArac.Tbl_Araclar' table. You can move, or remove it, as needed.
            this.Tbl_AraclarTableAdapter.Fill(this.DenemeİsDataSetArac.Tbl_Araclar);

            this.reportViewer1.RefreshReport();
        }
    }
}
