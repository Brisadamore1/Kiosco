﻿// <auto-generated />
using System;
using KioscoInformaticoBackend.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KioscoInformaticoBackend.Migrations
{
    [DbContext(typeof(KioscoContext))]
    [Migration("20240904210911_inicio")]
    partial class inicio
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");
            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("KioscoInformaticoBackend.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasMaxLength(6)
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("LocalidadId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefonos")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "LocalidadId" }, "IX_Clientes_LocalidadId");

                    b.ToTable("clientes", (string)null);
                });

            modelBuilder.Entity("KioscoInformaticoBackend.Models.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Fecha")
                        .HasMaxLength(6)
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FormaDePago")
                        .HasColumnType("int");

                    b.Property<int>("Iva")
                        .HasColumnType("int");

                    b.Property<int?>("ProveedorId")
                        .HasColumnType("int")
                        .HasColumnName("ProveedorId");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "ProveedorId" }, "IX_Compras_ProveedorId");

                    b.ToTable("compras", (string)null);
                });

            modelBuilder.Entity("KioscoInformaticoBackend.Models.Detallescompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("CompraId")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "ProductoId" }, "IX_DetallesCompras_ProductoId");

                    b.ToTable("detallescompras", (string)null);
                });

            modelBuilder.Entity("KioscoInformaticoBackend.Models.Detallesventa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("VentaId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "ProductoId" }, "IX_DetallesVentas_ProductoId");

                    b.HasIndex(new[] { "VentaId" }, "IX_DetallesVentas_VentaId");

                    b.ToTable("detallesventas", (string)null);
                });

            modelBuilder.Entity("KioscoInformaticoBackend.Models.Localidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("localidades", (string)null);
                });

            modelBuilder.Entity("KioscoInformaticoBackend.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("productos", (string)null);
                });

            modelBuilder.Entity("KioscoInformaticoBackend.Models.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cbu")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CondicionIva")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("LocalidadId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefonos")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "LocalidadId" }, "IX_Proveedores_LocalidadId");

                    b.ToTable("proveedores", (string)null);
                });

            modelBuilder.Entity("KioscoInformaticoBackend.Models.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasMaxLength(6)
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FormaPago")
                        .HasColumnType("int");

                    b.Property<decimal>("Iva")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "ClienteId" }, "IX_Ventas_ClienteId");

                    b.ToTable("ventas", (string)null);
                });

            modelBuilder.Entity("KioscoInformaticoBackend.Models.Cliente", b =>
                {
                    b.HasOne("KioscoInformaticoBackend.Models.Localidad", "Localidad")
                        .WithMany("Clientes")
                        .HasForeignKey("LocalidadId")
                        .HasConstraintName("FK_Clientes_Localidades_LocalidadId");

                    b.Navigation("Localidad");
                });

            modelBuilder.Entity("KioscoInformaticoBackend.Models.Compra", b =>
                {
                    b.HasOne("KioscoInformaticoBackend.Models.Proveedor", "Proveedor")
                        .WithMany("Compras")
                        .HasForeignKey("ProveedorId")
                        .HasConstraintName("FK_Compras_Proveedores_ProveedorId");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("KioscoInformaticoBackend.Models.Detallescompra", b =>
                {
                    b.HasOne("KioscoInformaticoBackend.Models.Producto", "Producto")
                        .WithMany("Detallescompras")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_DetallesCompras_Productos_ProductoId");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("KioscoInformaticoBackend.Models.Detallesventa", b =>
                {
                    b.HasOne("KioscoInformaticoBackend.Models.Producto", "Producto")
                        .WithMany("Detallesventa")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_DetallesVentas_Productos_ProductoId");

                    b.HasOne("KioscoInformaticoBackend.Models.Venta", "Venta")
                        .WithMany("Detallesventa")
                        .HasForeignKey("VentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_DetallesVentas_Ventas_VentaId");

                    b.Navigation("Producto");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("KioscoInformaticoBackend.Models.Proveedor", b =>
                {
                    b.HasOne("KioscoInformaticoBackend.Models.Localidad", "Localidad")
                        .WithMany("Proveedores")
                        .HasForeignKey("LocalidadId")
                        .HasConstraintName("FK_Proveedores_Localidades_LocalidadId");

                    b.Navigation("Localidad");
                });

            modelBuilder.Entity("KioscoInformaticoBackend.Models.Venta", b =>
                {
                    b.HasOne("KioscoInformaticoBackend.Models.Cliente", "Cliente")
                        .WithMany("Venta")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Ventas_Clientes_ClienteId");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("KioscoInformaticoBackend.Models.Cliente", b =>
                {
                    b.Navigation("Venta");
                });

            modelBuilder.Entity("KioscoInformaticoBackend.Models.Localidad", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("KioscoInformaticoBackend.Models.Producto", b =>
                {
                    b.Navigation("Detallescompras");

                    b.Navigation("Detallesventa");
                });

            modelBuilder.Entity("KioscoInformaticoBackend.Models.Proveedor", b =>
                {
                    b.Navigation("Compras");
                });

            modelBuilder.Entity("KioscoInformaticoBackend.Models.Venta", b =>
                {
                    b.Navigation("Detallesventa");
                });
#pragma warning restore 612, 618
        }
    }
}
