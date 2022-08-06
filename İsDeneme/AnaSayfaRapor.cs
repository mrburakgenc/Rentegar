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
    public partial class AnaSayfaRapor : Form
    {
        public AnaSayfaRapor()
        {
            InitializeComponent();
        }

        private void AnaSayfaRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DenemeİsDtRapor.Tbl_Rentegar' table. You can move, or remove it, as needed.
            this.Tbl_RentegarTableAdapter.Fill(this.DenemeİsDtRapor.Tbl_Rentegar);

            this.reportViewer1.RefreshReport();
        }
    }
}
