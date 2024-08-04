using DiziFilmBlogSitesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziFilmBlogSitesi
{
    public partial class Login : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TblAdmin where x.KullanıcıAdı == TextBox1.Text && x.Sifre == TextBox2.Text select x;


            if (sorgu.Any())
            {
                Session.Add("KullanıcıAdı", TextBox1.Text);
                Response.Redirect("/AdminSayfalar/Bloglar.Aspx/");
            }
            else
            {
                Response.Write("Hatalı Giriş");
            }



        }
    }
}