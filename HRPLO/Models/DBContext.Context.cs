﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRPLO.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<USER_GROUP> USER_GROUP { get; set; }
        public virtual DbSet<USER> USERS { get; set; }
        public virtual DbSet<EM_BRANCH> EM_BRANCH { get; set; }
        public virtual DbSet<EM_COMP> EM_COMP { get; set; }
        public virtual DbSet<EM_FACT> EM_FACT { get; set; }
    }
}
