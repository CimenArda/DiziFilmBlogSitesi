using DiziFilmBlogSitesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziFilmBlogSitesi.AdminSayfalar
{
    public partial class YeniBlog : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var turler = (from x in db.TblTur
                              select new
                              {
                                  x.TurAd,
                                  x.TurID
                              }).ToList();

                DropDownList1.DataSource = turler;
                DropDownList1.DataBind();



                var kategoriler = (from x in db.TblKategori
                                   select new
                                   {
                                       x.KategoriAd,
                                       x.KategoriID
                                   }).ToList();

                DropDownList2.DataSource = kategoriler;
                DropDownList2.DataBind();

            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TblBlog t = new TblBlog();

            t.BlogBaslik = TextBox1.Text;
            t.BlogGorsel = TextBox3.Text;
            t.BlogIcerik = TextBox4.Text;
            t.BlogBaslik = TextBox1.Text;
            t.BlogTarih =DateTime.Parse(TextBox2.Text);
            t.BlogTur = byte.Parse(DropDownList1.SelectedValue);
            t.BlogKategori = byte.Parse(DropDownList2.SelectedValue);
            db.TblBlog.Add(t);
            db.SaveChanges();

            Response.Redirect("Bloglar.Aspx");
        }
    }
}