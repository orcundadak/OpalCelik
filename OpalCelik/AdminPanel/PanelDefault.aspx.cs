using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpalCelik.AdminPanel
{
    public partial class PanelDefault : System.Web.UI.Page
    {
        sqlbaglantisi bag = new sqlbaglantisi();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand ToplamProjeSayisi = new SqlCommand("Select count(projeID) from dbo.projects", bag.baglan());
            int countToplam = Convert.ToInt32(ToplamProjeSayisi.ExecuteScalar());
            lblToplamProje.Text = countToplam.ToString();

            SqlCommand DevamEdenProjeSayisi = new SqlCommand("select count(pc.categoryID) from dbo.projectCategory pc left join dbo.categories c on c.categoryID = pc.CategoryID where c.categoryID = 1 group by pc.categoryID ", bag.baglan());
            int countDevamEden = Convert.ToInt32(DevamEdenProjeSayisi.ExecuteScalar());
            lblDevamEdenProje.Text = countDevamEden.ToString();

            SqlCommand YurtDisiProjeSayisi = new SqlCommand("select count(pc.categoryID) from dbo.projectCategory pc left join dbo.categories c on c.categoryID = pc.CategoryID where c.categoryID = 2 group by pc.categoryID ", bag.baglan());
            int countYurtDisi = Convert.ToInt32(YurtDisiProjeSayisi.ExecuteScalar());
            lblYurtDisi.Text = countYurtDisi.ToString();

            SqlCommand CalisanSayisi = new SqlCommand("Select count(userID) from dbo.users", bag.baglan());
            int countCalisan = Convert.ToInt32(CalisanSayisi.ExecuteScalar());
            lblCalisan.Text = countCalisan.ToString();

        }
    }
}