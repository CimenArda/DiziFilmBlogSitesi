using DiziFilmBlogSitesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziFilmBlogSitesi.AdminSayfalar
{
    public partial class İstatistik : System.Web.UI.Page
    {
        BlogDiziEntities db =new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {


            Label1.Text =db.TblBlog.Count().ToString();

            Label2.Text =db.TblYorum.Count().ToString();

            Label3.Text = db.TblBlog.Where(x=>x.BlogTur==2).Count().ToString();  


            Label4.Text =db.TblBlog.Where(x=>x.TblTur.TurAd=="Dizi").Count().ToString();    


            Label5.Text =db.TblBlog.Where(x=>x.TblTur.TurAd=="Animasyon").Count().ToString();

            Label6.Text = db.TblBlog.Where(y => y.BlogID == (db.TblYorum.GroupBy(x => x.YorumBlog).OrderByDescending(x => x.Count()).Select(z => z.Key).FirstOrDefault())).Select(k => k.BlogBaslik).FirstOrDefault();


        }
    }
}