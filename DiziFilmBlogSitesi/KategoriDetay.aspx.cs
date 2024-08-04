using DiziFilmBlogSitesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziFilmBlogSitesi
{
    public partial class KategoriDetay : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(Request.QueryString["KategoriID"]);
            var blog = db.TblBlog.Where(x => x.BlogKategori == id).ToList();
            Repeater1.DataSource = blog;
            Repeater1.DataBind();


          

            var kategoriler = db.TblKategori.ToList();
            Repeater2.DataSource = kategoriler;
            Repeater2.DataBind();


            var bloglar2 = db.TblBlog.ToList();
            Repeater3.DataSource = bloglar2;
            Repeater3.DataBind();

        }
    }
}