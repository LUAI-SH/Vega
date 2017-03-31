using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using vega.Models;

namespace Vega.Migrations
{
    [DbContext(typeof(VegaDbContext))]
    [Migration("20170329133932_PopulateModelsTable")]
    partial class PopulateModelsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("vega.Models.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("vega.Models.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ModelsId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ModelsId");

                    b.ToTable("Makes");
                });

            modelBuilder.Entity("vega.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("vega.Models.Make", b =>
                {
                    b.HasOne("vega.Models.Model", "Models")
                        .WithMany()
                        .HasForeignKey("ModelsId");
                });
        }
    }
}
