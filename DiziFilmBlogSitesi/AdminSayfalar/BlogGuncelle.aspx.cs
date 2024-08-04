using DiziFilmBlogSitesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziFilmBlogSitesi.AdminSayfalar
{
    public partial class BlogGuncelle : System.Web.UI.Page
    {
        BlogDiziEntities db =new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["BlogID"]);



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


                var deger = db.TblBlog.Find(y);

                TextBox1.Text = deger.BlogBaslik;
                TextBox2.Text = deger.BlogTarih.ToString();
                TextBox3.Text =deger.BlogGorsel.ToString();
                TextBox4.Text = deger.BlogIcerik;

                DropDownList1.SelectedValue =deger.BlogTur.ToString();
                DropDownList2.SelectedValue =deger.BlogKategori.ToString();



            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["BlogID"]);
            var blog =db.TblBlog.Find(y);

            blog.BlogBaslik = TextBox1.Text;
            blog.BlogGorsel = TextBox3.Text;
            blog.BlogIcerik = TextBox4.Text;
            blog.BlogBaslik = TextBox1.Text;
            blog.BlogTarih = DateTime.Parse(TextBox2.Text);
            blog.BlogTur = byte.Parse(DropDownList1.SelectedValue);
            blog.BlogKategori = byte.Parse(DropDownList2.SelectedValue);

            db.SaveChanges();
            Response.Redirect("Bloglar.Aspx");
        }
    }
    }
