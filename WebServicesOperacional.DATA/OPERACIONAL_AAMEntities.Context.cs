﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceAltamira.DATA
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Operacional_AAMEntities : DbContext
    {
        public Operacional_AAMEntities()
            : base("name=Operacional_AAMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GET_COMUNIDADES> GET_COMUNIDADES { get; set; }
        public virtual DbSet<GET_TRIBUTOS> GET_TRIBUTOS { get; set; }
    }
}