﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorEmpleados_Eneko.Models;

namespace RazorEmpleados_Eneko.Migrations
{
    [DbContext(typeof(RazorEmpleados_EnekoContext))]
    partial class RazorEmpleados_EnekoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorEmpleados_Eneko.Models.Empleados", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido");

                    b.Property<string>("Direccion");

                    b.Property<string>("Email");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("Nombre");

                    b.Property<int>("Telefono");

                    b.HasKey("ID");

                    b.ToTable("Empleados");
                });
#pragma warning restore 612, 618
        }
    }
}
