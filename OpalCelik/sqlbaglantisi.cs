using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OpalCelik
{
    public class sqlbaglantisi
    {
        public SqlConnection baglan()
        {

            string connectionString = ConfigurationManager.ConnectionStrings["OpalConStr"].ConnectionString;
            SqlConnection baglanti = new SqlConnection(connectionString);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlConnection.ClearPool(baglanti);
                SqlConnection.ClearAllPools();
            }

            return (baglanti);
        }
    }
}