using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpalCelik.AdminPanel
{
    public partial class profile : System.Web.UI.Page
    {
        sqlbaglantisi bag = new sqlbaglantisi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userID"] != null)
            {
                int userid = Convert.ToInt32(Session["userID"]);
                if (!IsPostBack)
                {
                    SqlCommand usergetir = new SqlCommand("select * from dbo.users where userID=" + userid, bag.baglan());
                    SqlDataReader rdr = usergetir.ExecuteReader();

                    while (rdr.Read())
                    {
                        txtRealName.Text = rdr["realname"].ToString();
                        txtSifre.Text = rdr["password"].ToString();
                        txtUserName.Text = rdr["username"].ToString();
                    }

                    txtRealName.ReadOnly = true;
                    txtSifre.ReadOnly = true;
                    txtUserName.ReadOnly = true;
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
           

        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        { 
            txtRealName.ReadOnly = false;
            txtSifre.ReadOnly = false;
            txtUserName.ReadOnly = false;
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(Session["userID"]);

            if (txtRealName != null && txtSifre != null && txtUserName != null)
            {

                SqlCommand cmd = new SqlCommand("Update dbo.users set username= @username, password=@password, realname=@realname where userID=@userID", bag.baglan());
                cmd.Parameters.AddWithValue("@userID", userid);
                cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                cmd.Parameters.AddWithValue("@password", txtSifre.Text);
                cmd.Parameters.AddWithValue("@realname", txtRealName.Text);

                cmd.ExecuteNonQuery();


                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Kayıt Başarılı')", true);
                Response.Redirect("profile.aspx");
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Boş Alanları Doldurun!')", true);
            }
        }
    }
}