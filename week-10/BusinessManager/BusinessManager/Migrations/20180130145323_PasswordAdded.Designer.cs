﻿// <auto-generated />
using BusinessManager.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BusinessManager.Migrations
{
    [DbContext(typeof(BusinessContext))]
    [Migration("20180130145323_PasswordAdded")]
    partial class PasswordAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("BusinessManager.Models.BillingInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BillingAddress");

                    b.Property<int>("CompanyRegistryNumber");

                    b.Property<string>("OfficialName");

                    b.Property<int>("TaxNumber");

                    b.HasKey("Id");

                    b.ToTable("BillingInfoList");
                });

            modelBuilder.Entity("BusinessManager.Models.Case", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClientId");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("BusinessManager.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<int?>("BillingInfoId");

                    b.Property<string>("GeneralEmail");

                    b.Property<int>("GeneralPhone");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("BillingInfoId")
                        .IsUnique();

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("BusinessManager.Models.ContactPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClientId");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<int>("Phone");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ContacPeople");
                });

            modelBuilder.Entity("BusinessManager.Models.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CaseId");

                    b.Property<string>("Path");

                    b.HasKey("Id");

                    b.HasIndex("CaseId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("BusinessManager.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CaseId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CaseId");

                    b.HasIndex("UserId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("BusinessManager.Models.JointModels.Billable", b =>
                {
                    b.Property<int>("CaseId");

                    b.Property<int>("UserId");

                    b.Property<double>("HourlyRate");

                    b.Property<double>("Hours");

                    b.HasKey("CaseId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Billables");
                });

            modelBuilder.Entity("BusinessManager.Models.JointModels.CaseAdmin", b =>
                {
                    b.Property<int>("CaseId");

                    b.Property<int>("UserId");

                    b.HasKey("CaseId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("CaseAdmin");
                });

            modelBuilder.Entity("BusinessManager.Models.JointModels.ClientAdmin", b =>
                {
                    b.Property<int>("ClientId");

                    b.Property<int>("UserId");

                    b.HasKey("ClientId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("ClientAdmin");
                });

            modelBuilder.Entity("BusinessManager.Models.JointModels.DocumentEvent", b =>
                {
                    b.Property<int>("DocumentId");

                    b.Property<int>("EventId");

                    b.HasKey("DocumentId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("DocumentEvent");
                });

            modelBuilder.Entity("BusinessManager.Models.JointModels.UserDocument", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("DocumentId");

                    b.HasKey("UserId", "DocumentId");

                    b.HasIndex("DocumentId");

                    b.ToTable("UserDocument");
                });

            modelBuilder.Entity("BusinessManager.Models.JointModels.UserEvent", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("EventId");

                    b.HasKey("UserId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("UserEvent");
                });

            modelBuilder.Entity("BusinessManager.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BusinessManager.Models.Case", b =>
                {
                    b.HasOne("BusinessManager.Models.Client", "Client")
                        .WithMany("Cases")
                        .HasForeignKey("ClientId");
                });

            modelBuilder.Entity("BusinessManager.Models.Client", b =>
                {
                    b.HasOne("BusinessManager.Models.BillingInfo", "BillingInfo")
                        .WithOne("Client")
                        .HasForeignKey("BusinessManager.Models.Client", "BillingInfoId");
                });

            modelBuilder.Entity("BusinessManager.Models.ContactPerson", b =>
                {
                    b.HasOne("BusinessManager.Models.Client", "Client")
                        .WithMany("ContactPeople")
                        .HasForeignKey("ClientId");
                });

            modelBuilder.Entity("BusinessManager.Models.Document", b =>
                {
                    b.HasOne("BusinessManager.Models.Case", "Case")
                        .WithMany("Documents")
                        .HasForeignKey("CaseId");
                });

            modelBuilder.Entity("BusinessManager.Models.Event", b =>
                {
                    b.HasOne("BusinessManager.Models.Case", "Case")
                        .WithMany("Events")
                        .HasForeignKey("CaseId");

                    b.HasOne("BusinessManager.Models.User")
                        .WithMany("Events")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BusinessManager.Models.JointModels.Billable", b =>
                {
                    b.HasOne("BusinessManager.Models.Case", "Case")
                        .WithMany("Billables")
                        .HasForeignKey("CaseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BusinessManager.Models.User", "FeeEarner")
                        .WithMany("Billables")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BusinessManager.Models.JointModels.CaseAdmin", b =>
                {
                    b.HasOne("BusinessManager.Models.Case", "Case")
                        .WithMany("CaseAdmins")
                        .HasForeignKey("CaseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BusinessManager.Models.User", "Admin")
                        .WithMany("AdministeredCases")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BusinessManager.Models.JointModels.ClientAdmin", b =>
                {
                    b.HasOne("BusinessManager.Models.Client", "Client")
                        .WithMany("ClientAdmins")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BusinessManager.Models.User", "Admin")
                        .WithMany("AdministeredClients")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BusinessManager.Models.JointModels.DocumentEvent", b =>
                {
                    b.HasOne("BusinessManager.Models.Document", "Document")
                        .WithMany("Events")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BusinessManager.Models.Event", "Event")
                        .WithMany("Documents")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BusinessManager.Models.JointModels.UserDocument", b =>
                {
                    b.HasOne("BusinessManager.Models.Document", "Document")
                        .WithMany()
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BusinessManager.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BusinessManager.Models.JointModels.UserEvent", b =>
                {
                    b.HasOne("BusinessManager.Models.Event", "Event")
                        .WithMany("Participants")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BusinessManager.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
