using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OpalCelik.AdminPanel
{
    public partial class addProject : System.Web.UI.Page
    {
        sqlbaglantisi bag = new sqlbaglantisi();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand getir = new SqlCommand("select * from dbo.categories", bag.baglan());
            SqlDataReader reader = getir.ExecuteReader();
            
        }


        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                try
                {
                    StringBuilder files = new StringBuilder();
                    if (MultipleFileUpload.HasFiles)
                    {
                        #region ProjeEkle
                        FileUpload1.SaveAs(Server.MapPath("~/images/projeler/") + FileUpload1.FileName);

                        SqlCommand ProjeEkle = new SqlCommand("insert into dbo.projects (ProjeAdi,Musteri,Lokasyon,Sektor,Kapsam,Yil,Miktar,ProjectName,Sector,Scope,image,sira,categoryID,image1,image2,image3) OUTPUT Inserted.projeID values (@ProjeAdi,@Musteri,@Lokasyon,@Sektor,@Kapsam,@Yil,@Miktar,@ProjectName,@Sector,@Scope,@image,@sira,@categoryID,@image1,@image2,@image3)", bag.baglan());
                        ProjeEkle.Parameters.AddWithValue("@ProjeAdi", txtProjeAdi.Text);
                        ProjeEkle.Parameters.AddWithValue("@Musteri", txtMusteri.Text);
                        ProjeEkle.Parameters.AddWithValue("@Lokasyon", txtLokasyon.Text);
                        ProjeEkle.Parameters.AddWithValue("@Sektor", txtSektor.Text);
                        ProjeEkle.Parameters.AddWithValue("@Kapsam", txtKapsam.Text);
                        ProjeEkle.Parameters.AddWithValue("@Yil", txtYil.Text);
                        ProjeEkle.Parameters.AddWithValue("@Miktar", txtMiktar.Text);
                        ProjeEkle.Parameters.AddWithValue("@ProjectName", txtProjectName.Text);
                        ProjeEkle.Parameters.AddWithValue("@Sector", txtSector.Text);
                        ProjeEkle.Parameters.AddWithValue("@Scope", txtScope.Text);
                        ProjeEkle.Parameters.AddWithValue("@image", FileUpload1.FileName.ToString());
                        ProjeEkle.Parameters.AddWithValue("@sira", txtSira.Text);
                        ProjeEkle.Parameters.AddWithValue("@categoryID", 0);
                        int i = 1;
                        foreach (HttpPostedFile file in MultipleFileUpload.PostedFiles)
                        {
                            
                            string fileName = System.IO.Path.GetFileName(file.FileName);
                            string SaveLocation = Server.MapPath("~/images/projeler/") + fileName;
                            //string filePath = System.IO.Path.Combine(Server.MapPath("~/images/projeler/"), fileName);
                            file.SaveAs(SaveLocation);
                            if (i == 1)
                            {
                                ProjeEkle.Parameters.AddWithValue("@image1", fileName);
                                i++;
                            }
                            else if (i == 2)
                            {
                                ProjeEkle.Parameters.AddWithValue("@image2", fileName);
                                i++;
                            }
                            else if (i == 3)
                            {
                                ProjeEkle.Parameters.AddWithValue("@image3", fileName);
                                i++;
                            }

                        }
                        //ProjeEkle.Parameters.AddWithValue("@categoryID", CheckBoxList1.SelectedIndex);

                        var result = ProjeEkle.ExecuteScalar();
                        //ProjeEkle.ExecuteNonQuery();
                        int id = Convert.ToInt32(result);
                        #region kategori
                        SqlCommand categoryEkle = new SqlCommand("insert into dbo.projectCategory (projectID,categoryID) values (@projectID,@categoryID)", bag.baglan());

                        List<ListItem> selected = CheckBoxList1.Items.Cast<ListItem>().Where(li => li.Selected).ToList();

                        //foreach (ListItem item in selected)
                        //{
                        //    if (item.Selected)
                        //    {
                        for (int j = 0; j < selected.Count; j++)
                        {
                            //if (CheckBoxList1.Items[i].Selected)// getting selected value from CheckBox List  
                            //{
                            //categoryEkle.Parameters.AddWithValue("@projectID", id);
                            //categoryEkle.Parameters.AddWithValue("@categoryID", selected[j].Value );
                            //categoryEkle.ExecuteNonQuery();
                            //}

                            SqlCommand cmd = new SqlCommand("insert into dbo.projectCategory values(" + id + "," + selected[j].Value + ")", bag.baglan());
                            cmd.ExecuteNonQuery();

                        }


                        //    }
                        //}
                        #endregion
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Proje Eklendi')", true);
                    }
                    #endregion


                }
                catch (Exception ex)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + ex.Message.ToString() + "')", true);

                }

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Resim Ekleyin')", true);
            }
        }
    }
}