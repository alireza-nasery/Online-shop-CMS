﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WebMarket_Entity : DbContext
    {
        public WebMarket_Entity()
            : base("name=WebMarket_Entity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Product_Groups> Product_Groups { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Features> Features { get; set; }
        public virtual DbSet<FeaturesSummery> FeaturesSummery { get; set; }
        public virtual DbSet<ProductGallery> ProductGallery { get; set; }
        public virtual DbSet<Product_Features> Product_Features { get; set; }
        public virtual DbSet<Order_CustomerAddress> Order_CustomerAddress { get; set; }
        public virtual DbSet<Order_CustomerProducts> Order_CustomerProducts { get; set; }

    }
}
