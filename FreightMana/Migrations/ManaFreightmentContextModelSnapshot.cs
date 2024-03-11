﻿// <auto-generated />
using System;
using FreightMana.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FreightMana.Migrations
{
    [DbContext(typeof(ManaFreightmentContext))]
    partial class ManaFreightmentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FreightMana.Models.CusAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("password");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("username");

                    b.HasKey("Id")
                        .HasName("PK_accounts");

                    b.ToTable("CusAccounts");
                });

            modelBuilder.Entity("FreightMana.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("orderID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<float?>("Cod")
                        .HasColumnType("real")
                        .HasColumnName("cod");

                    b.Property<int?>("CusId")
                        .HasColumnType("int")
                        .HasColumnName("cusID");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("note");

                    b.Property<int?>("NumberOfProduct")
                        .HasColumnType("int")
                        .HasColumnName("numberOfProduct");

                    b.Property<string>("Product")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("product");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("int")
                        .HasColumnName("receiverID");

                    b.Property<DateTime?>("RecordAt")
                        .HasColumnType("datetime")
                        .HasColumnName("recordAt");

                    b.Property<int>("SenderId")
                        .HasColumnType("int")
                        .HasColumnName("senderID");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("status");

                    b.Property<float?>("TransportFee")
                        .HasColumnType("real")
                        .HasColumnName("transportFee");

                    b.Property<int>("TransportId")
                        .HasColumnType("int")
                        .HasColumnName("transportID");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int")
                        .HasColumnName("warehouseID");

                    b.HasKey("OrderId")
                        .HasName("PK_orders");

                    b.HasIndex("CusId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.HasIndex("TransportId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FreightMana.Models.Receiver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("address");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("phoneNumber");

                    b.HasKey("Id")
                        .HasName("PK_receivers");

                    b.ToTable("Receivers");
                });

            modelBuilder.Entity("FreightMana.Models.Sender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("address");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("phoneNumber");

                    b.HasKey("Id")
                        .HasName("PK_senders");

                    b.ToTable("Senders");
                });

            modelBuilder.Entity("FreightMana.Models.Shift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly?>("Day")
                        .HasColumnType("date")
                        .HasColumnName("day");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("employeeID");

                    b.Property<TimeOnly?>("TimeEnd")
                        .HasColumnType("time")
                        .HasColumnName("timeEnd");

                    b.Property<TimeOnly?>("TimeStart")
                        .HasColumnType("time")
                        .HasColumnName("timeStart");

                    b.HasKey("Id")
                        .HasName("PK_shifts");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("FreightMana.Models.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("phoneNumber");

                    b.Property<string>("Position")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("position");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int")
                        .HasColumnName("warehouseID");

                    b.HasKey("Id")
                        .HasName("PK_employees");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("FreightMana.Models.Transport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float?>("Cost")
                        .HasColumnType("real")
                        .HasColumnName("cost");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("type");

                    b.HasKey("Id")
                        .HasName("PK_transports");

                    b.ToTable("Transports");
                });

            modelBuilder.Entity("FreightMana.Models.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("address");

                    b.Property<string>("Hotline")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("hotline");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PK_warehouses");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("FreightMana.Models.WarehouseAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("password");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int")
                        .HasColumnName("warehouseID");

                    b.HasKey("Id")
                        .HasName("PK_warehouseAccounts");

                    b.HasIndex("WarehouseId");

                    b.ToTable("WarehouseAccounts");
                });

            modelBuilder.Entity("FreightMana.Models.Order", b =>
                {
                    b.HasOne("FreightMana.Models.CusAccount", "Cus")
                        .WithMany("Orders")
                        .HasForeignKey("CusId")
                        .HasConstraintName("FK_orders_accounts");

                    b.HasOne("FreightMana.Models.Receiver", "Receiver")
                        .WithMany("Orders")
                        .HasForeignKey("ReceiverId")
                        .IsRequired()
                        .HasConstraintName("FK_orders_receivers");

                    b.HasOne("FreightMana.Models.Sender", "Sender")
                        .WithMany("Orders")
                        .HasForeignKey("SenderId")
                        .IsRequired()
                        .HasConstraintName("FK_orders_senders");

                    b.HasOne("FreightMana.Models.Transport", "Transport")
                        .WithMany("Orders")
                        .HasForeignKey("TransportId")
                        .IsRequired()
                        .HasConstraintName("FK_orders_transports1");

                    b.HasOne("FreightMana.Models.Warehouse", "Warehouse")
                        .WithMany("Orders")
                        .HasForeignKey("WarehouseId")
                        .IsRequired()
                        .HasConstraintName("FK_orders_warehouses");

                    b.Navigation("Cus");

                    b.Navigation("Receiver");

                    b.Navigation("Sender");

                    b.Navigation("Transport");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("FreightMana.Models.Shift", b =>
                {
                    b.HasOne("FreightMana.Models.Staff", "Employee")
                        .WithMany("Shifts")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_shifts_employees");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("FreightMana.Models.Staff", b =>
                {
                    b.HasOne("FreightMana.Models.Warehouse", "Warehouse")
                        .WithMany("Staff")
                        .HasForeignKey("WarehouseId")
                        .IsRequired()
                        .HasConstraintName("FK_employees_warehouses");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("FreightMana.Models.WarehouseAccount", b =>
                {
                    b.HasOne("FreightMana.Models.Warehouse", "Warehouse")
                        .WithMany("WarehouseAccounts")
                        .HasForeignKey("WarehouseId")
                        .IsRequired()
                        .HasConstraintName("FK_warehouseAccounts_warehouses");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("FreightMana.Models.CusAccount", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("FreightMana.Models.Receiver", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("FreightMana.Models.Sender", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("FreightMana.Models.Staff", b =>
                {
                    b.Navigation("Shifts");
                });

            modelBuilder.Entity("FreightMana.Models.Transport", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("FreightMana.Models.Warehouse", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Staff");

                    b.Navigation("WarehouseAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
