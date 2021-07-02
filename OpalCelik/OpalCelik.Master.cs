using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpalCelik
{
    public partial class OpalCelik : System.Web.UI.MasterPage
    {
        sqlbaglantisi bag = new sqlbaglantisi();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand getir = new SqlCommand("select * from dbo.categories", bag.baglan());
            SqlDataReader reader = getir.ExecuteReader();

            while (reader.Read())
            {
                if ((int)reader["CategoryOrder"] <= 5)
                {
                    lblProje.Text += "<li><a href='Projeler.aspx?categoryID=" + reader["categoryID"] + "'>" + reader["CategoryName"] + "</a></li>";
                }

                if ((int)reader["CategoryOrder"] > 5 && (int)reader["CategoryOrder"] <= 10)
                {
                    lblProje2.Text += "<li><a href='Projeler.aspx?categoryID=" + reader["categoryID"] + "'>" + reader["CategoryName"] + "</a></li>";
                }

                if ((int)reader["CategoryOrder"] > 10 && (int)reader["CategoryOrder"] <= 15)
                {
                    lblProje3.Text += "<li><a href='Projeler.aspx?categoryID=" + reader["categoryID"] + "'>" + reader["CategoryName"] + "</a></li>";
                }

                if ((int)reader["CategoryOrder"] > 15 && (int)reader["CategoryOrder"] <= 20)
                {
                    lblProje4.Text += "<li><a href='Projeler.aspx?categoryID=" + reader["categoryID"] + "'>" + reader["CategoryName"] + "</a></li>";
                }

            }

        }
    }
}