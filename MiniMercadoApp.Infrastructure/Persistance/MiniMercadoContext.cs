using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Infrastructure.Persistance
{
    public partial class MiniMercadoContext : DbContext
    {
        public MiniMercadoContext()
        {
        }

        public MiniMercadoContext(DbContextOptions<MiniMercadoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; } = null!;
        public virtual DbSet<Cliente> Cliente { get; set; } = null!;
        public virtual DbSet<Factura> Facturas { get; set; } = null!;
        public virtual DbSet<Productos> Productoss { get; set; } = null!;
        public virtual DbSet<Proveedores> Proveedoress { get; set; } = null!;
        public virtual DbSet<Ventas> Ventass { get; set; } = null!;
        public virtual DbSet<Login> Login { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.ToTable("TblCategoria");
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__TblCateg__A3C02A101B266B3E");

                entity.Property(e => e.IdCategoria).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCategoria)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("TblCliente");
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__TblClien__D594664284A4FD43");

                entity.ToTable("Cliente");

                entity.Property(e => e.IdCliente).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Apellido1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono).HasColumnType("numeric(10, 0)");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.ToTable("TblFacturas");
                entity.HasKey(e => e.IdFactura)
                    .HasName("PK__TblFactu__50E7BAF1975EDDC9");

                entity.Property(e => e.IdFactura).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdCliente).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValorFactura).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblFactur__IdCli__2A4B4B5E");
            });

            modelBuilder.Entity<Productos>(entity =>
            {
                entity.ToTable("TblProductos");
                entity.HasKey(e => e.IdProducto)
                    .HasName("PK__TblProdu__098892108E9EE02A");

                entity.Property(e => e.IdProducto).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DescripcionProducto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCategoria).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdProveedor).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Precio).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Productoss)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblProduc__IdCat__2D27B809");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.Productoss)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblProduc__IdPro__2E1BDC42");
            });

            modelBuilder.Entity<Proveedores>(entity =>
            {
                entity.ToTable("TblProveedores");
                entity.HasKey(e => e.IdProveedor)
                    .HasName("PK__TblProve__E8B631AF5905CDA9");

                entity.Property(e => e.IdProveedor).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionProveedor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProveedor)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoProveedor).HasColumnType("numeric(10, 0)");
            });

            modelBuilder.Entity<Ventas>(entity =>
            {
                entity.ToTable("TblVentas");
                entity.HasKey(e => e.IdVenta)
                    .HasName("PK__Ventas__BC1240BD614A2614");

                entity.Property(e => e.IdVenta).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Cantidad).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdFactura).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdProducto).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdFacturaNavigation)
                    .WithMany(p => p.Ventas)
                    .HasForeignKey(d => d.IdFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ventass__IdFac__30F848ED");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.Ventas)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ventass__IdPro__31EC6D26");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK__Login__B7C926385DC01C60");

                entity.ToTable("Login");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Active)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("active");

                entity.Property(e => e.Pass)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pass");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
