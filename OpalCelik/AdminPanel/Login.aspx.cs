using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpalCelik.AdminPanel
{
    public partial class Login : System.Web.UI.Page
    {
        sqlbaglantisi bag = new sqlbaglantisi();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from dbo.users where username='" + txtKulAdi.Text + "'and password ='" + txtSifre.Text + "'", bag.baglan());
            SqlDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                Session["kullaniciAdi"] = rdr["username"].ToString();
                Session["userID"] = rdr["userID"].ToString();
                Session["realname"] = rdr["realname"].ToString();

                Response.Redirect("PanelDefault.aspx");
            }
          

        }
    }
}