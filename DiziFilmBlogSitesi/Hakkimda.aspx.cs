﻿using DiziFilmBlogSitesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziFilmBlogSitesi
{
    public partial class Hakkimda : System.Web.UI.Page
    {
        BlogDiziEntities db =new BlogDiziEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TblHakkımızda.ToList();
            Repeater1.DataBind();
        }
    }
}