using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Hermes.Data;

namespace Hermes.Data.Migrations
{
    [DbContext(typeof(HermesDbContext))]
    [Migration("20170615150822_UpdateTables1")]
    partial class UpdateTables1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hermes.Domain.Call", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AssignedToId");

                    b.Property<int?>("CallCategoryId");

                    b.Property<bool>("CallClosed");

                    b.Property<string>("CallDescription");

                    b.Property<int>("CallDuration");

                    b.Property<int?>("ClosedById");

                    b.Property<int?>("ContactId");

                    b.Property<int?>("CustomerId");

                    b.Property<DateTime>("DateClosed");

                    b.Property<DateTime>("DateLogged");

                    b.Property<DateTime>("DateModified");

                    b.Property<int>("IeSM_CALL_NO");

                    b.Property<int?>("LoggedById");

                    b.Property<int?>("PriorityId");

                    b.Property<string>("Problem");

                    b.Property<bool>("Resolved");

                    b.Property<string>("Solution");

                    b.Property<int?>("StatusId");

                    b.Property<int>("TotalDuration");

                    b.Property<int?>("UserModifiedId");

                    b.HasKey("Id");

                    b.HasIndex("AssignedToId");

                    b.HasIndex("CallCategoryId");

                    b.HasIndex("ClosedById");

                    b.HasIndex("ContactId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LoggedById");

                    b.HasIndex("PriorityId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserModifiedId");

                    b.ToTable("Calls");
                });

            modelBuilder.Entity("Hermes.Domain.CallCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("IeSM_CALL_CATEGORY_ID");

                    b.HasKey("Id");

                    b.ToTable("CallCategories");
                });

            modelBuilder.Entity("Hermes.Domain.CallPriority", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("IeSM_SUB_CATEGORY_ID");

                    b.HasKey("Id");

                    b.ToTable("CallPriorities");
                });

            modelBuilder.Entity("Hermes.Domain.CallStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("IeSM_CALL_STATUS_ID");

                    b.HasKey("Id");

                    b.ToTable("CallStatus");
                });

            modelBuilder.Entity("Hermes.Domain.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContactName");

                    b.Property<int?>("CustomerId");

                    b.Property<string>("Email");

                    b.Property<string>("FaxNo");

                    b.Property<int>("IeSM_CONTACT_ID");

                    b.Property<string>("MobileNo");

                    b.Property<string>("PhoneNo");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Hermes.Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("Address3");

                    b.Property<string>("Address4");

                    b.Property<string>("Address5");

                    b.Property<string>("FaxNo");

                    b.Property<int>("IeSM_SUB_CATEGORY_ID");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNo");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Hermes.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IeSM_USER_ID");

                    b.Property<string>("UserEmail");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Hermes.Domain.Call", b =>
                {
                    b.HasOne("Hermes.Domain.User", "AssignedTo")
                        .WithMany()
                        .HasForeignKey("AssignedToId");

                    b.HasOne("Hermes.Domain.CallCategory", "CallCategory")
                        .WithMany()
                        .HasForeignKey("CallCategoryId");

                    b.HasOne("Hermes.Domain.User", "ClosedBy")
                        .WithMany()
                        .HasForeignKey("ClosedById");

                    b.HasOne("Hermes.Domain.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId");

                    b.HasOne("Hermes.Domain.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("Hermes.Domain.User", "LoggedBy")
                        .WithMany()
                        .HasForeignKey("LoggedById");

                    b.HasOne("Hermes.Domain.CallPriority", "Priority")
                        .WithMany()
                        .HasForeignKey("PriorityId");

                    b.HasOne("Hermes.Domain.CallStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.HasOne("Hermes.Domain.User", "UserModified")
                        .WithMany()
                        .HasForeignKey("UserModifiedId");
                });

            modelBuilder.Entity("Hermes.Domain.Contact", b =>
                {
                    b.HasOne("Hermes.Domain.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });
        }
    }
}
