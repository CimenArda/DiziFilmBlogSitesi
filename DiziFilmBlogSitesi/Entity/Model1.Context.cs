﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiziFilmBlogSitesi.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BlogDiziEntities : DbContext
    {
        public BlogDiziEntities()
            : base("name=BlogDiziEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblBlog> TblBlog { get; set; }
        public virtual DbSet<TblHakkımızda> TblHakkımızda { get; set; }
        public virtual DbSet<TblKategori> TblKategori { get; set; }
        public virtual DbSet<TblTur> TblTur { get; set; }
        public virtual DbSet<TblYorum> TblYorum { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TblIletisim> TblIletisim { get; set; }
        public virtual DbSet<TblAdmin> TblAdmin { get; set; }
    }
}
