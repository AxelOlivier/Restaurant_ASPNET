// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestoApi.Data;

#nullable disable

namespace RestoApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("RestoApi.models.Alimentaire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Etat")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TypeAliment")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Etat");

                    b.HasIndex("TypeAliment");

                    b.ToTable("Alimentaire");
                });

            modelBuilder.Entity("RestoApi.models.Commande", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Alimentaire")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Table")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Alimentaire");

                    b.HasIndex("Table");

                    b.ToTable("Commande");
                });

            modelBuilder.Entity("RestoApi.models.Etat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("libelle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Etat");
                });

            modelBuilder.Entity("RestoApi.models.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NumTable")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Table");
                });

            modelBuilder.Entity("RestoApi.models.TypeAliment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("libelle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TypeAliment");
                });

            modelBuilder.Entity("RestoApi.models.Alimentaire", b =>
                {
                    b.HasOne("RestoApi.models.Etat", "etat")
                        .WithMany()
                        .HasForeignKey("Etat")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestoApi.models.TypeAliment", "Type")
                        .WithMany()
                        .HasForeignKey("TypeAliment")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");

                    b.Navigation("etat");
                });

            modelBuilder.Entity("RestoApi.models.Commande", b =>
                {
                    b.HasOne("RestoApi.models.Alimentaire", "Aliment")
                        .WithMany()
                        .HasForeignKey("Alimentaire")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestoApi.models.Table", "table")
                        .WithMany()
                        .HasForeignKey("Table")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aliment");

                    b.Navigation("table");
                });
#pragma warning restore 612, 618
        }
    }
}
