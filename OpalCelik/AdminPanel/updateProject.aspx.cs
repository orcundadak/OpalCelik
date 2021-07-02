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
    public partial class updateProject : System.Web.UI.Page
    {
        sqlbaglantisi bag = new sqlbaglantisi();

        protected void Page_Load(object sender, EventArgs e)
        {
            int projeID = Convert.ToInt32(Request.QueryString["projeID"]);

            if (!IsPostBack)
            {
                SqlCommand projeGetir = new SqlCommand("select * from dbo.projects where projeID=" + projeID, bag.baglan());
                SqlDataReader projeGetirRdr = projeGetir.ExecuteReader();

                while (projeGetirRdr.Read())
                {
                    txtProjeAdi.Text = projeGetirRdr["ProjeAdi"].ToString();
                    txtMusteri.Text = projeGetirRdr["Musteri"].ToString();
                    txtLokasyon.Text = projeGetirRdr["Lokasyon"].ToString();
                    txtSektor.Text = projeGetirRdr["Sektor"].ToString();
                    txtKapsam.Text = projeGetirRdr["Kapsam"].ToString();
                    txtYil.Text = projeGetirRdr["Yil"].ToString();
                    txtMiktar.Text = projeGetirRdr["Miktar"].ToString();
                    txtProjectName.Text = projeGetirRdr["ProjectName"].ToString();
                    txtSector.Text = projeGetirRdr["Sector"].ToString();
                    txtScope.Text = projeGetirRdr["Scope"].ToString();
                    txtSira.Text = projeGetirRdr["sira"].ToString();
                }
            }
            lblKategori.Text = "";
            SqlCommand seciliKategori = new SqlCommand("select * from dbo.projectCategory pc left join dbo.categories c on pc.categoryID = c.categoryID where pc.projectID =" + projeID, bag.baglan());
            SqlDataReader kategoriGrdr = seciliKategori.ExecuteReader();

            while (kategoriGrdr.Read())
            {
                lblKategori.Text += kategoriGrdr["CategoryName"] + " - ";
            }

            #region readonlyTrue
            txtProjeAdi.ReadOnly = true;
            txtMusteri.ReadOnly = true;
            txtLokasyon.ReadOnly = true;
            txtSektor.ReadOnly = true;
            txtKapsam.ReadOnly = true;
            txtYil.ReadOnly = true;
            txtMiktar.ReadOnly = true;
            txtProjectName.ReadOnly = true;
            txtSector.ReadOnly = true;
            txtScope.ReadOnly = true;
            txtSira.ReadOnly = true;
            btnKaydet.Visible = false;
            #endregion
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            int projeID = Convert.ToInt32(Request.QueryString["projeID"]);
            if (FileUpload1.HasFile)
            {
                try
                {
                    StringBuilder files = new StringBuilder();
                    if (MultipleFileUpload.HasFiles)
                    {
                        #region ProjeGuncelle-TumImagesVar
                        FileUpload1.SaveAs(Server.MapPath("~/images/projeler/") + FileUpload1.FileName);

                        SqlCommand projeGuncelle = new SqlCommand("update dbo.projects set ProjeAdi=@ProjeAdi, Musteri=@Musteri, Lokasyon=@Lokasyon, Sektor=@Sektor, Kapsam=@Kapsam, Yil=@Yil, Miktar=@Miktar, ProjectName=@ProjectName,Sector=@Sector,Scope=@Scope,image=@image,sira=@sira,image1=@image1,image2=@image2,image3 =@image3 where projeID=" + projeID, bag.baglan());

                        projeGuncelle.Parameters.AddWithValue("@ProjeAdi", txtProjeAdi.Text);
                        projeGuncelle.Parameters.AddWithValue("@Musteri", txtMusteri.Text);
                        projeGuncelle.Parameters.AddWithValue("@Lokasyon", txtLokasyon.Text);
                        projeGuncelle.Parameters.AddWithValue("@Sektor", txtSektor.Text);
                        projeGuncelle.Parameters.AddWithValue("@Kapsam", txtKapsam.Text);
                        projeGuncelle.Parameters.AddWithValue("@Yil", txtYil.Text);
                        projeGuncelle.Parameters.AddWithValue("@Miktar", txtMiktar.Text);
                        projeGuncelle.Parameters.AddWithValue("@ProjectName", txtProjectName.Text);
                        projeGuncelle.Parameters.AddWithValue("@Sector", txtSector.Text);
                        projeGuncelle.Parameters.AddWithValue("@Scope", txtScope.Text);
                        projeGuncelle.Parameters.AddWithValue("@image", FileUpload1.FileName.ToString());
                        projeGuncelle.Parameters.AddWithValue("@sira", txtSira.Text);
                        int i = 1;
                        foreach (HttpPostedFile file in MultipleFileUpload.PostedFiles)
                        {

                            string fileName = System.IO.Path.GetFileName(file.FileName);
                            string SaveLocation = Server.MapPath("~/images/projeler/") + fileName;
                            //string filePath = System.IO.Path.Combine(Server.MapPath("~/images/projeler/"), fileName);
                            file.SaveAs(SaveLocation);
                            if (i == 1)
                            {
                                projeGuncelle.Parameters.AddWithValue("@image1", fileName);
                                i++;
                            }
                            else if (i == 2)
                            {
                                projeGuncelle.Parameters.AddWithValue("@image2", fileName);
                                i++;
                            }
                            else if (i == 3)
                            {
                                projeGuncelle.Parameters.AddWithValue("@image3", fileName);
                                i++;
                            }

                        }
                        //ProjeEkle.Parameters.AddWithValue("@categoryID", CheckBoxList1.SelectedIndex);

                        var result = projeGuncelle.ExecuteScalar();
                        //ProjeEkle.ExecuteNonQuery();
                        int id = Convert.ToInt32(result);
                        #region kategori

                        SqlCommand categoryTemizle = new SqlCommand("Delete From dbo.projectCategory where projectID = " + projeID, bag.baglan());
                        categoryTemizle.ExecuteNonQuery();

                        List<ListItem> selected = CheckBoxList1.Items.Cast<ListItem>().Where(li => li.Selected).ToList();

                        for (int j = 0; j < selected.Count; j++)
                        {
                            SqlCommand cmd = new SqlCommand("insert into dbo.projectCategory values(" + projeID + "," + selected[j].Value + ")", bag.baglan());
                            cmd.ExecuteNonQuery();

                        }

                        #endregion
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Proje Güncellendi')", true);
                    }
                    #endregion
                    else
                    {
                        #region ProjeEkle-KapakImagesVar
                        FileUpload1.SaveAs(Server.MapPath("~/images/projeler/") + FileUpload1.FileName);
                        SqlCommand projeGuncelle = new SqlCommand("update dbo.projects set ProjeAdi=@ProjeAdi, Musteri=@Musteri, Lokasyon=@Lokasyon, Sektor=@Sektor, Kapsam=@Kapsam, Yil=@Yil, Miktar=@Miktar, ProjectName=@ProjectName,Sector=@Sector,Scope=@Scope,image=@image,sira=@sira where projeID=" + projeID, bag.baglan());

                        projeGuncelle.Parameters.AddWithValue("@ProjeAdi", txtProjeAdi.Text);
                        projeGuncelle.Parameters.AddWithValue("@Musteri", txtMusteri.Text);
                        projeGuncelle.Parameters.AddWithValue("@Lokasyon", txtLokasyon.Text);
                        projeGuncelle.Parameters.AddWithValue("@Sektor", txtSektor.Text);
                        projeGuncelle.Parameters.AddWithValue("@Kapsam", txtKapsam.Text);
                        projeGuncelle.Parameters.AddWithValue("@Yil", txtYil.Text);
                        projeGuncelle.Parameters.AddWithValue("@Miktar", txtMiktar.Text);
                        projeGuncelle.Parameters.AddWithValue("@ProjectName", txtProjectName.Text);
                        projeGuncelle.Parameters.AddWithValue("@Sector", txtSector.Text);
                        projeGuncelle.Parameters.AddWithValue("@Scope", txtScope.Text);
                        projeGuncelle.Parameters.AddWithValue("@image", FileUpload1.FileName.ToString());
                        projeGuncelle.Parameters.AddWithValue("@sira", txtSira.Text);

                        //ProjeEkle.Parameters.AddWithValue("@categoryID", CheckBoxList1.SelectedIndex);

                        var result = projeGuncelle.ExecuteScalar();
                        //ProjeEkle.ExecuteNonQuery();
                        int id = Convert.ToInt32(result);
                        #region kategori

                        SqlCommand categoryTemizle = new SqlCommand("Delete From dbo.projectCategory where projectID = " + projeID, bag.baglan());
                        categoryTemizle.ExecuteNonQuery();

                        List<ListItem> selected = CheckBoxList1.Items.Cast<ListItem>().Where(li => li.Selected).ToList();

                        for (int j = 0; j < selected.Count; j++)
                        {
                            SqlCommand cmd = new SqlCommand("insert into dbo.projectCategory values(" + projeID + "," + selected[j].Value + ")", bag.baglan());
                            cmd.ExecuteNonQuery();

                        }

                        #endregion
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Proje Güncellendi')", true);
                        #endregion
                    }

                }
                catch (Exception ex)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + ex.Message.ToString() + "')", true);

                }

            }
            else
            {
                try
                {
                    StringBuilder files = new StringBuilder();
                    if (MultipleFileUpload.HasFiles)
                    {
                        #region ProjeGuncelle-KapakImagesYokDigerleriVar
                        SqlCommand projeGuncelle = new SqlCommand("update dbo.projects set ProjeAdi=@ProjeAdi, Musteri=@Musteri, Lokasyon=@Lokasyon, Sektor=@Sektor, Kapsam=@Kapsam, Yil=@Yil, Miktar=@Miktar, ProjectName=@ProjectName,Sector=@Sector,Scope=@Scope,sira=@sira,image1=@image1,image2=@image2,image3 =@image3 where projeID=" + projeID, bag.baglan());

                        projeGuncelle.Parameters.AddWithValue("@ProjeAdi", txtProjeAdi.Text);
                        projeGuncelle.Parameters.AddWithValue("@Musteri", txtMusteri.Text);
                        projeGuncelle.Parameters.AddWithValue("@Lokasyon", txtLokasyon.Text);
                        projeGuncelle.Parameters.AddWithValue("@Sektor", txtSektor.Text);
                        projeGuncelle.Parameters.AddWithValue("@Kapsam", txtKapsam.Text);
                        projeGuncelle.Parameters.AddWithValue("@Yil", txtYil.Text);
                        projeGuncelle.Parameters.AddWithValue("@Miktar", txtMiktar.Text);
                        projeGuncelle.Parameters.AddWithValue("@ProjectName", txtProjectName.Text);
                        projeGuncelle.Parameters.AddWithValue("@Sector", txtSector.Text);
                        projeGuncelle.Parameters.AddWithValue("@Scope", txtScope.Text);
                        projeGuncelle.Parameters.AddWithValue("@sira", txtSira.Text);
                        int i = 1;
                        foreach (HttpPostedFile file in MultipleFileUpload.PostedFiles)
                        {

                            string fileName = System.IO.Path.GetFileName(file.FileName);
                            string SaveLocation = Server.MapPath("~/images/projeler/") + fileName;
                            //string filePath = System.IO.Path.Combine(Server.MapPath("~/images/projeler/"), fileName);
                            file.SaveAs(SaveLocation);
                            if (i == 1)
                            {
                                projeGuncelle.Parameters.AddWithValue("@image1", fileName);
                                i++;
                            }
                            else if (i == 2)
                            {
                                projeGuncelle.Parameters.AddWithValue("@image2", fileName);
                                i++;
                            }
                            else if (i == 3)
                            {
                                projeGuncelle.Parameters.AddWithValue("@image3", fileName);
                                i++;
                            }

                        }
                        //ProjeEkle.Parameters.AddWithValue("@categoryID", CheckBoxList1.SelectedIndex);

                        var result = projeGuncelle.ExecuteScalar();
                        //ProjeEkle.ExecuteNonQuery();
                        int id = Convert.ToInt32(result);
                        #region kategori

                        SqlCommand categoryTemizle = new SqlCommand("Delete From dbo.projectCategory where projectID = " + projeID, bag.baglan());
                        categoryTemizle.ExecuteNonQuery();

                        List<ListItem> selected = CheckBoxList1.Items.Cast<ListItem>().Where(li => li.Selected).ToList();

                        for (int j = 0; j < selected.Count; j++)
                        {
                            SqlCommand cmd = new SqlCommand("insert into dbo.projectCategory values(" + projeID + "," + selected[j].Value + ")", bag.baglan());
                            cmd.ExecuteNonQuery();

                        }

                        #endregion
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Proje Güncellendi')", true);
                        #endregion
                    }


                    else
                    {
                        #region ProjeGuncelle-TumImagesYok
                        SqlCommand projeGuncelle = new SqlCommand("update dbo.projects set ProjeAdi=@ProjeAdi, Musteri=@Musteri, Lokasyon=@Lokasyon, Sektor=@Sektor, Kapsam=@Kapsam, Yil=@Yil, Miktar=@Miktar, ProjectName=@ProjectName,Sector=@Sector,Scope=@Scope,sira=@sira where projeID=" + projeID, bag.baglan());

                        projeGuncelle.Parameters.AddWithValue("@ProjeAdi", txtProjeAdi.Text);
                        projeGuncelle.Parameters.AddWithValue("@Musteri", txtMusteri.Text);
                        projeGuncelle.Parameters.AddWithValue("@Lokasyon", txtLokasyon.Text);
                        projeGuncelle.Parameters.AddWithValue("@Sektor", txtSektor.Text);
                        projeGuncelle.Parameters.AddWithValue("@Kapsam", txtKapsam.Text);
                        projeGuncelle.Parameters.AddWithValue("@Yil", txtYil.Text);
                        projeGuncelle.Parameters.AddWithValue("@Miktar", txtMiktar.Text);
                        projeGuncelle.Parameters.AddWithValue("@ProjectName", txtProjectName.Text);
                        projeGuncelle.Parameters.AddWithValue("@Sector", txtSector.Text);
                        projeGuncelle.Parameters.AddWithValue("@Scope", txtScope.Text);
                        projeGuncelle.Parameters.AddWithValue("@sira", txtSira.Text);

                        //ProjeEkle.Parameters.AddWithValue("@categoryID", CheckBoxList1.SelectedIndex);

                        projeGuncelle.ExecuteNonQuery();
                        //ProjeEkle.ExecuteNonQuery();
                        //int id = Convert.ToInt32(result);
                        #region kategori



                        List<ListItem> selected = CheckBoxList1.Items.Cast<ListItem>().Where(li => li.Selected).ToList();

                        for (int j = 0; j < selected.Count; j++)
                        {
                            SqlCommand cmd = new SqlCommand("insert into dbo.projectCategory values(" + projeID + "," + selected[j].Value + ")", bag.baglan());
                            cmd.ExecuteNonQuery();

                        }

                        #endregion
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Proje Güncellendi')", true);
                        #endregion
                    }

                }


                catch (Exception ex)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + ex.Message.ToString() + "')", true);

                }
            }
        }

        protected void btnAc_Click(object sender, EventArgs e)
        {
            int projeID = Convert.ToInt32(Request.QueryString["projeID"]);
            SqlCommand categoryTemizle = new SqlCommand("Delete From dbo.projectCategory where projectID = " + projeID, bag.baglan());
            categoryTemizle.ExecuteNonQuery();
            txtProjeAdi.ReadOnly = false;
            txtMusteri.ReadOnly = false;
            txtLokasyon.ReadOnly = false;
            txtSektor.ReadOnly = false;
            txtKapsam.ReadOnly = false;
            txtYil.ReadOnly = false;
            txtMiktar.ReadOnly = false;
            txtProjectName.ReadOnly = false;
            txtSector.ReadOnly = false;
            txtScope.ReadOnly = false;
            txtSira.ReadOnly = false;
            btnKaydet.Visible = true;
        }
    }
}