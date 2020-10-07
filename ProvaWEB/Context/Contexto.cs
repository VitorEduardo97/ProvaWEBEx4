using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ProvaWEB.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProvaWEB.Context
{
    public class Contexto : DbContext
    {
        public DbSet<ProfessorModel> professor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}