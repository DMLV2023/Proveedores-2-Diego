using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Proveedores2.Models
{
    public partial class Proveedores2Context : DbContext
    {
        public Proveedores2Context()
        {
        }

        public Proveedores2Context(DbContextOptions<Proveedores2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Proveedore> Proveedores { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("server=DESKTOP-54M18O1\\DIEGO; database=Proveedores2; integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.HasIndex(e => e.Cuit, "UQ__Proveedo__F46C15982128F890")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CondicionesPago)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("condiciones_pago");

                entity.Property(e => e.ContactoPrincipal)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("contacto_principal");

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("correo_electronico");

                entity.Property(e => e.Cuit)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("CUIT")
                    .IsFixedLength();

                entity.Property(e => e.DireccionCalle)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("direccion_calle");

                entity.Property(e => e.DireccionCiudad)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("direccion_ciudad");

                entity.Property(e => e.DireccionCodigoPostal)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("direccion_codigo_postal");

                entity.Property(e => e.DireccionEstado)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("direccion_estado");

                entity.Property(e => e.DireccionPais)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("direccion_pais");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("fecha_registro");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.SitioWeb)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sitio_web");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.Property(e => e.TipoProductosServicios)
                    .HasColumnType("text")
                    .HasColumnName("tipo_productos_servicios");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
