using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace İsDeneme
{
    class SqlCnt
    {
        //public string Adres = System.IO.File.ReadAllText(@"C:\SqlConnect.txt");

        public SqlConnection baglanti()
        {

            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-OQ5MVOB;Initial Catalog=Denemeİs;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
