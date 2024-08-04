using DiziFilmBlogSitesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziFilmBlogSitesi
{
    public partial class Iletisim : System.Web.UI.Page
    {
        BlogDiziEntities  db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           TblIletisim t =new TblIletisim();
            t.AdSoyad = TextBox1.Text;
            t.Konu = TextBox4.Text;
            t.Mail = TextBox2.Text;
            t.Telefon = TextBox3.Text;
            t.Mesaj = TextBox5.Text;

            db.TblIletisim.Add(t);
            db.SaveChanges();
        }
    }
}