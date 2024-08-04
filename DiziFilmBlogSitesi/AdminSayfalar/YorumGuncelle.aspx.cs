using DiziFilmBlogSitesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziFilmBlogSitesi.AdminSayfalar
{
    public partial class YorumGuncelle : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["YorumID"]);

            if (Page.IsPostBack == false)
            {





                var deger = db.TblYorum.Find(y);

                TextBox1.Text = deger.TblBlog.BlogBaslik;
                TextBox2.Text = deger.KullanıcıAd;
                TextBox4.Text = deger.YorumIcerik;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int y = int.Parse(Request.QueryString["YorumID"]);
            var yorum = db.TblYorum.Find(y);

            yorum.KullanıcıAd = TextBox2.Text;
            yorum.YorumIcerik = TextBox4.Text;
           
            db.SaveChanges();
            Response.Redirect("Yorumlar.Aspx");
        }
        }
}