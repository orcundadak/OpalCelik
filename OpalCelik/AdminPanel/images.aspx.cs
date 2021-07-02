using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpalCelik.AdminPanel
{
    public partial class images : System.Web.UI.Page
    {
        sqlbaglantisi bag = new sqlbaglantisi();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand getir = new SqlCommand("select image,image1,image2,image3 from dbo.projects", bag.baglan());
            SqlDataReader reader = getir.ExecuteReader();
            while (reader.Read())
            {
                Label1.Text +="<div class='card no-b p-3'>" +
                                        "<div>" +
                                            "<div class='mr-3 float-left'>" +
                                                "<img src='../images/projeler/" + reader["image"] + "'/>" +
                                            "</div>" +
                                        "<div>" +
                                            "<div>" +
                                                "<strong># red lighten-5</strong>" +
                                            "</div>" +
                                        "<small>ffebee</small>" +
                                        "</div>" +
                                    "</div>" +
                                "</div>";
                Label2.Text += "<div class='card no-b p-3'>" +
                                       "<div>" +
                                           "<div class='mr-3 float-left'>" +
                                               "<img src='../images/projeler/" + reader["image1"] + "'/>" +
                                           "</div>" +
                                       "<div>" +
                                           "<div>" +
                                               "<strong># red lighten-5</strong>" +
                                           "</div>" +
                                       "<small>ffebee</small>" +
                                       "</div>" +
                                   "</div>" +
                               "</div>";
            }
        }
    }
}