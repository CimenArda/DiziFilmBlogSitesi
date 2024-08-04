using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziFilmBlogSitesi.Entity;
namespace DiziFilmBlogSitesi
{
    public partial class Default : System.Web.UI.Page
    {
        BlogDiziEntities db =new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

            var bloglar = db.TblBlog.ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();


            var kategoriler = db.TblKategori.ToList();
            Repeater2.DataSource = kategoriler;
            Repeater2.DataBind();


            var bloglar2 = db.TblBlog.Take(5).ToList();
            Repeater3.DataSource = bloglar2;
            Repeater3.DataBind();


            var yorumlar = db.TblYorum.Take(3).ToList();
            Repeater4.DataSource = yorumlar;
            Repeater4.DataBind();

        }
    }
}