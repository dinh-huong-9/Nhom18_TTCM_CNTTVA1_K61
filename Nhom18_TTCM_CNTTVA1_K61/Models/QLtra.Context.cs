﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nhom18_TTCM_CNTTVA1_K61.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLtrasenEntities : DbContext
    {
        public QLtrasenEntities()
            : base("name=QLtrasenEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Rank> Ranks { get; set; }
        public virtual DbSet<Tool> Tools { get; set; }
        public virtual DbSet<Trademark> Trademarks { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public System.Data.Entity.DbSet<Nhom18_TTCM_CNTTVA1_K61.Models.LoginModel> LoginModels { get; set; }
    }
}
