using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpalCelik
{
    public partial class projeDetay : System.Web.UI.Page
    {
        sqlbaglantisi bag = new sqlbaglantisi();
        string projectID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //MAKALE GETİR
            projectID = Request.QueryString["id"];
            SqlCommand proje = new SqlCommand("SELECT * FROM dbo.projects WHERE projeID = '" + projectID + "'", bag.baglan());
            SqlDataReader oku = proje.ExecuteReader();
            DataList1.DataSource = oku;
            DataList1.DataBind();

            SqlCommand proje2 = new SqlCommand("SELECT * FROM dbo.projects WHERE projeID = '" + projectID + "'", bag.baglan());
            SqlDataReader oku2 = proje2.ExecuteReader();

            while (oku2.Read())
            {
                lblProjeAdi.Text = oku2["ProjeAdi"].ToString();
                lblProjeAdi2.Text = oku2["ProjeAdi"].ToString();
                Title = (oku2["ProjeAdi"].ToString());
            }


        }
    }
}