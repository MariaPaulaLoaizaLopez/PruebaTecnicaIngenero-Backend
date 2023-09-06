using System;
using System.Collections.Generic;
using GestionLogistica.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionLogistica.Database.Context;

public partial class GestionLogisticaContext : DbContext
{
    public GestionLogisticaContext()
    {
    }

    public GestionLogisticaContext(DbContextOptions<GestionLogisticaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Almacenamiento> Almacenamientos { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Descuento> Descuentos { get; set; }

    public virtual DbSet<MedioDeTransporte> MedioDeTransportes { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<PlanDeEntrega> PlanDeEntregas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<TipoDeAlmacenamiento> TipoDeAlmacenamientos { get; set; }

    public virtual DbSet<TipoDeMedioDeTransporte> TipoDeMedioDeTransportes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=PSF-MPL; Database=GestionLogistica;Trusted_Connection=True;TrustServerCertificate=True;encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Almacenamiento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Almacena__3214EC074E503A3C");

            entity.ToTable("Almacenamiento");

            entity.Property(e => e.Direccion)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Pais)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Representante)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.HasOne(d => d.IdTipoNavigation).WithMany(p => p.Almacenamientos)
                .HasForeignKey(d => d.IdTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Almacenam__IdTip__60A75C0F");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cliente__3214EC071EC60D9F");

            entity.ToTable("Cliente");

            entity.Property(e => e.Direccion)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Dni).HasColumnName("DNI");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Descuento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Descuent__3214EC072B384119");

            entity.ToTable("Descuento");

            entity.Property(e => e.TipoDeLogistica)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MedioDeTransporte>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MedioDeT__3214EC073517B16D");

            entity.ToTable("MedioDeTransporte");

            entity.Property(e => e.Estado)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.FechaDeIngreso).HasColumnType("date");
            entity.Property(e => e.MatriculaTransporte)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.IdTipoNavigation).WithMany(p => p.MedioDeTransportes)
                .HasForeignKey(d => d.IdTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MedioDeTr__IdTip__6383C8BA");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pedido__3214EC077385437A");

            entity.ToTable("Pedido");

            entity.Property(e => e.PrecioConDescuento).HasColumnType("money");
            entity.Property(e => e.PrecioTotal).HasColumnType("money");

            entity.HasOne(d => d.IdDescuentoNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdDescuento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ProductoDescuento");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ProductoPedido");
        });

        modelBuilder.Entity<PlanDeEntrega>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PlanDeEn__3214EC07659F79A1");

            entity.ToTable("PlanDeEntrega");

            entity.Property(e => e.FechaDeEntrega).HasColumnType("date");
            entity.Property(e => e.FechaDeRegistro).HasColumnType("date");
            entity.Property(e => e.PrecioDeEnvio).HasColumnType("money");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.PlanDeEntregas)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_EntregaCliente");

            entity.HasOne(d => d.IdLugarEntregaNavigation).WithMany(p => p.PlanDeEntregas)
                .HasForeignKey(d => d.IdLugarEntrega)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_LugarEntrega");

            entity.HasOne(d => d.IdPedidoNavigation).WithMany(p => p.PlanDeEntregas)
                .HasForeignKey(d => d.IdPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_EntregaPedido");

            entity.HasOne(d => d.IdTransporteNavigation).WithMany(p => p.PlanDeEntregas)
                .HasForeignKey(d => d.IdTransporte)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_TipoDeTransporte");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Producto__3214EC0761B8BBD0");

            entity.ToTable("Producto");

            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.PrecioUnidad).HasColumnType("money");
        });

        modelBuilder.Entity<TipoDeAlmacenamiento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoDeAl__3214EC074D223C82");

            entity.ToTable("TipoDeAlmacenamiento");

            entity.Property(e => e.NombreDelTipo)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoDeMedioDeTransporte>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoDeMe__3214EC0735FF4D03");

            entity.ToTable("TipoDeMedioDeTransporte");

            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

