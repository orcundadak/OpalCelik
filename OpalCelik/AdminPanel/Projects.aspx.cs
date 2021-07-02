using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpalCelik.AdminPanel
{
    public partial class Projects : System.Web.UI.Page
    {
        sqlbaglantisi bag = new sqlbaglantisi();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand getir = new SqlCommand("select * from dbo.projects", bag.baglan());
            SqlDataReader reader = getir.ExecuteReader();

            while (reader.Read())
            {

                Label1.Text += "<tr class='no-b'>" +
                                        "<td class='w-10'>" +
                                           "<img src = '../images/projeler/" + reader["image"] + "' alt='' style='max-height:71px;object-fit:cover;width: 100%;'>" +
                                   "   </td>" +
                                      "  <td>" +
                                       "     <h6>" + reader["ProjeAdi"] + "</h6>" +
                                        "    <small class='text-muted'> " + reader["Musteri"] + "</small>" +
                                        "</td> " +
                                        "<td>" + reader["Miktar"] + " " + "Ton</td> " +
                                        "<td><span class='badge badge-success'>Aktif</span></td>" +
                                        "<td>" +
                                           //" <span><i class='icon icon-data_usage'></i> 5 days ago</span><br>" +
                                           " <span><i class='icon icon-timer'></i>" + reader["Yil"] + "</span>" +
                                       " </td>" +
                                       " <td>" +
                                        "    <a class='btn-fab btn-fab-sm btn-primary shadow text-white' href='updateProject.aspx?projeID=" + reader["projeID"] + "' target='_blank'><i class='icon-pencil'></i></a>" +
                                      "  </td>" +
                                  "  </tr>";
            }

        }
    }
}