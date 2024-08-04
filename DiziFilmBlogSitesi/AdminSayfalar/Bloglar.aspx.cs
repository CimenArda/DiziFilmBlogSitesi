using DiziFilmBlogSitesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziFilmBlogSitesi.AdminSayfalar
{
    public partial class Bloglar : System.Web.UI.Page
    {
        BlogDiziEntities db =new BlogDiziEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(Session["KullanıcıAdı"].ToString());

            if (Session["KullanıcıAdı"] == null)
            {
                Response.Redirect("~/Login.Aspx");
            }
            else
            {
                Response.Write("Hoşgeldiniz." + Session["KullanıcıAdı"].ToString());
            }
            Repeater1.DataSource=db.TblBlog.ToList();
            Repeater1.DataBind();

        }
    }
}