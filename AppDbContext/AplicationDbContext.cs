using Bangalore.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Bangalore.API.AppDbContext
{
    public class ApplicationDbContex : DbContext
    {


        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here


            //PERSONA
            //modelBuilder.Entity<Personas>(entity =>
            //{
            //    entity.ToTable("PERSONA").HasKey(x => x.Id);
            //    entity.Property(x => x.Id).HasColumnName("ID");
            //    entity.Property(x => x.Nombres).HasColumnName("NOMBRES");
            //    entity.Property(x => x.Apellidos).HasColumnName("APELLIDOS");
            //    entity.Property(x => x.Estado).HasColumnName("ESTADO");
            //    entity.Property(x => x.Evaluado).HasColumnName("EVALUADO");
            //    entity.Property(x => x.Foto).HasColumnName("FOTO");
            //    entity.Property(x => x.RolesId)
            //     .HasColumnName("ROLEID");
            //    entity.HasOne(x => x.Roles);

            //});
            ////ROLES
            //modelBuilder.Entity<Roles>(entity =>
            //{
            //    entity.ToTable("Roles").HasKey(x => x.Id);
            //    entity.Property(x => x.Id).HasColumnName("ID").UseIdentityColumn();
            //    entity.Property(x => x.Descripcion).HasColumnName("DESCRIPCION");
            //});


            //modelBuilder.Entity<Marcas>(entity =>
            //{
            //    entity.ToTable("MARCA").HasKey(x => x.Id);
            //    entity.Property(x => x.Id).HasColumnName("ID");
            //    entity.Property(x => x.Descripcion).HasColumnName("DESCRIPCION");
            //});

        }











        public DbSet<Users> Users { get; set; }
        //public DbSet<Roles> Roles { get; set; }
        //public DbSet<Marcas> Marcas { get; set; }
    }
}