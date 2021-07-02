using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpalCelik
{
    public partial class Projeler : System.Web.UI.Page
    {
        sqlbaglantisi bag = new sqlbaglantisi();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataReader reader;
            int categoryID = Convert.ToInt32(Request.QueryString["categoryID"]);
            if (categoryID == 0)
            {
                SqlCommand getAll = new SqlCommand("select * from dbo.projects", bag.baglan());
                 reader = getAll.ExecuteReader();
            }
            else
            {
                SqlCommand getir = new SqlCommand("select p.* from dbo.projects p inner join dbo.projectCategory pc on p.projeID = pc.projectID  where pc.categoryID = " + categoryID, bag.baglan());
                 reader = getir.ExecuteReader();
            }

            while (reader.Read())
            {
                Label1.Text += "<div class='masonry-item cat-1  col-md-4 col-sm-6 m-b30'>" +
                                    "<div class='image-effect-two hover-shadow'>" +
                                        "<img src = 'images/projeler/" + reader["image"] + "' alt='' style='max-width:360px;height:245px;object-fit:cover'>" +
                                        "<div class='figcaption'>" +
                                            "<h4 class='mt-tilte'>" + reader["ProjeAdi"] + "</h4>" +
                                            "<p>" +
                                            "Lokasyon: " + reader["Lokasyon"] + "<br/>" +
                                            "Sektör: " + reader["Sektor"] + "<br/>" +
                                            "Kapsam: " + reader["Kapsam"] + "<br/>" +

                                            "</p>" +
                                            "<a href = 'projeDetay.aspx?id=" + reader["projeID"] + "' class='read-more site-button btn-effect'>Detay</a>" +
                                            "<a class='mfp-link' href='images/projeler/" + reader["image"] + "'>" +
                                            "<i class='fa fa-arrows-alt'></i> </a>" +
                                        "</div>" +
                                    "</div>" +
                                "</div>";
            }

            //DataList1.DataSource = reader;
            //DataList1.DataBind();

            //fileID = Request.QueryString["fileid"];
            //islem = Request.QueryString["islem"];
            //if (islem == "sil")
            //{
            //    SqlCommand maksil = new SqlCommand("delete from TBLfile where fileid='" + fileID + "'", bag.baglan());
            //    maksil.ExecuteNonQuery();
            //    Response.Redirect("Files.aspx");
            //}
        }
    }
}