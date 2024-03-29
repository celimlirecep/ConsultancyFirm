﻿// <auto-generated />
using System;
using ColsultancyFirm.DAL.Concreate.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ColsultancyFirm.DAL.Migrations
{
    [DbContext(typeof(ConsultantFirmContext))]
    [Migration("20220524095517_headingpublishtime")]
    partial class headingpublishtime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("AuthorHeading", b =>
                {
                    b.Property<int>("AuthorsAuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HeadingsHeadingId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AuthorsAuthorId", "HeadingsHeadingId");

                    b.HasIndex("HeadingsHeadingId");

                    b.ToTable("AuthorHeading");
                });

            modelBuilder.Entity("ConsultancyFirm.EL.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AuthorImages")
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthorMail")
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthorName")
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthorPhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthorSurname")
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthorUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("ConsultancyFirm.EL.AuthorHeading", b =>
                {
                    b.Property<int>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HeadingId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AuthorId", "HeadingId");

                    b.HasIndex("HeadingId");

                    b.ToTable("AuthorHeadings");
                });

            modelBuilder.Entity("ConsultancyFirm.EL.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryDesription")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ConsultancyFirm.EL.Heading", b =>
                {
                    b.Property<int>("HeadingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HeadingContent")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<string>("HeadingImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("HeadingName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("HeadingPublishTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("HeadingUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.HasKey("HeadingId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Headings");
                });

            modelBuilder.Entity("ConsultancyFirm.EL.HomeSlider", b =>
                {
                    b.Property<int>("HomeSliderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("HomeSliderHead")
                        .HasColumnType("TEXT");

                    b.Property<string>("HomeSliderImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("HomeSliderRoute")
                        .HasColumnType("TEXT");

                    b.Property<string>("HomeSliderUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("INTEGER");

                    b.HasKey("HomeSliderId");

                    b.ToTable("HomeSliders");
                });

            modelBuilder.Entity("ConsultancyFirm.EL.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MemberImageURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("MemberMail")
                        .HasColumnType("TEXT");

                    b.Property<string>("MemberName")
                        .HasColumnType("TEXT");

                    b.Property<string>("MemberPasword")
                        .HasColumnType("TEXT");

                    b.Property<string>("MemberSurname")
                        .HasColumnType("TEXT");

                    b.Property<string>("MemberUsername")
                        .HasColumnType("TEXT");

                    b.HasKey("MemberId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("AuthorHeading", b =>
                {
                    b.HasOne("ConsultancyFirm.EL.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsAuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsultancyFirm.EL.Heading", null)
                        .WithMany()
                        .HasForeignKey("HeadingsHeadingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsultancyFirm.EL.AuthorHeading", b =>
                {
                    b.HasOne("ConsultancyFirm.EL.Author", "Author")
                        .WithMany("AuthorHeadings")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsultancyFirm.EL.Heading", "Heading")
                        .WithMany("AuthorHeadings")
                        .HasForeignKey("HeadingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Heading");
                });

            modelBuilder.Entity("ConsultancyFirm.EL.Heading", b =>
                {
                    b.HasOne("ConsultancyFirm.EL.Category", "Category")
                        .WithMany("Headings")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ConsultancyFirm.EL.Author", b =>
                {
                    b.Navigation("AuthorHeadings");
                });

            modelBuilder.Entity("ConsultancyFirm.EL.Category", b =>
                {
                    b.Navigation("Headings");
                });

            modelBuilder.Entity("ConsultancyFirm.EL.Heading", b =>
                {
                    b.Navigation("AuthorHeadings");
                });
#pragma warning restore 612, 618
        }
    }
}
