﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyAppMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ApplicationEntities : DbContext
    {
        public ApplicationEntities()
            : base("name=ApplicationEntities")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<TipoDocumento>()
                .HasMany(c => c.Cliente)
                .WithRequired(e => e.TipoDocumento);
            */

        }
    
        public virtual DbSet<EmployeeInfo> EmployeeInfo { get; set; }
        public virtual DbSet<Afiliado> Afiliado { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Empleador> Empleador { get; set; }
        public virtual DbSet<TipoCliente> TipoCliente { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }
    }
}
