using DiziFilmBlogSitesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziFilmBlogSitesi
{
    public partial class BlogDetay : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["BlogID"]);
            var blog = db.TblBlog.Where(x => x.BlogID == id).ToList();
            Repeater1.DataSource = blog;
            Repeater1.DataBind();


            var yorumlar =db.TblYorum.Where(x=>x.YorumBlog==id).ToList();
            Repeater2.DataSource = yorumlar;
            Repeater2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["BlogID"]);

            TblYorum t = new TblYorum();

            t.KullanıcıAd = TextBox1.Text;
            t.Mail = TextBox2.Text;
            t.YorumIcerik = TextBox3.Text;
            t.YorumBlog = id;

            db.TblYorum.Add(t);
            db.SaveChanges();

            Response.Redirect("BlogDetay.Aspx?BlogID=" + id);
        }
    }
}