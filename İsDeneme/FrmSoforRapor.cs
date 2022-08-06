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
    public partial class FrmSoforRapor : Form
    {
        public FrmSoforRapor()
        {
            InitializeComponent();
        }

        private void FrmSoforRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DenemeİsDataSetSofor.Tbl_Soforler' table. You can move, or remove it, as needed.
            this.Tbl_SoforlerTableAdapter.Fill(this.DenemeİsDataSetSofor.Tbl_Soforler);

            this.reportViewer1.RefreshReport();
        }
    }
}
