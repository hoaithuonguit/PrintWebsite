﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.Responsity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Web_PrintEntities : DbContext
    {
        public Web_PrintEntities()
            : base("name=Web_PrintEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<M_Master_Data> M_Master_Data { get; set; }
        public virtual DbSet<M_News> M_News { get; set; }
        public virtual DbSet<M_Product> M_Product { get; set; }
        public virtual DbSet<M_User_Detail> M_User_Detail { get; set; }
        public virtual DbSet<M_User_Login> M_User_Login { get; set; }
    }
}