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
    public partial class FrmArsivRapor : Form
    {
        public FrmArsivRapor()
        {
            InitializeComponent();
        }

        private void FrmArsivRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DenemeİsDataSetArsiv.Tbl_Soforler' table. You can move, or remove it, as needed.
            this.Tbl_SoforlerTableAdapter.Fill(this.DenemeİsDataSetArsiv.Tbl_Soforler);

            this.reportViewer1.RefreshReport();
        }
    }
}
