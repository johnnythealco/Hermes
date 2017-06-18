using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IeSM.Data.Model
{
    public partial class IeSMContext : DbContext
    {
        public virtual DbSet<CallCategories> CallCategories { get; set; }
        public virtual DbSet<IeSMCallPriority> CallPriority { get; set; }
        public virtual DbSet<IeSMCallStatus> CallStatus { get; set; }
        public virtual DbSet<CallTypes> CallTypes { get; set; }
        public virtual DbSet<CategorySubCategories> CategorySubCategories { get; set; }
        public virtual DbSet<IeSMContacts> Contacts { get; set; }
        public virtual DbSet<ContractTypes> ContractTypes { get; set; }
        public virtual DbSet<Contracts> Contracts { get; set; }
        public virtual DbSet<CustomerGroups> CustomerGroups { get; set; }
        public virtual DbSet<CustomerStatus> CustomerStatus { get; set; }
        public virtual DbSet<IeSMCustomer> Customers { get; set; }
        public virtual DbSet<LoggedCalls> LoggedCalls { get; set; }
        public virtual DbSet<Profiles> Profiles { get; set; }
        public virtual DbSet<RelatedDocuments> RelatedDocuments { get; set; }
        public virtual DbSet<SubCategories> SubCategories { get; set; }
        public virtual DbSet<IeSMUsers> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=remote.hcs.ie,1433;Integrated Security=False;User ID=iesmuser; Password=iesmpassword;Initial Catalog=ieSM_Support");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CallCategories>(entity =>
            {
                entity.HasKey(e => e.CallCategory)
                    .HasName("PK_CALL_CATEGORIES");

                entity.ToTable("CALL_CATEGORIES");

                entity.HasIndex(e => e.Description)
                    .HasName("AK_CALL_CATEGORY_DESC")
                    .IsUnique();

                entity.Property(e => e.CallCategory)
                    .HasColumnName("CALL_CATEGORY")
                    .HasColumnType("numeric");

                entity.Property(e => e.CustomMandFields)
                    .HasColumnName("CUSTOM_MAND_FIELDS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("DATE_CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("DATE_MODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Mandatory)
                    .HasColumnName("MANDATORY")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OutOfUse).HasColumnName("OUT_OF_USE");

                entity.Property(e => e.UserCreated)
                    .HasColumnName("USER_CREATED")
                    .HasColumnType("numeric");

                entity.Property(e => e.UserModified)
                    .HasColumnName("USER_MODIFIED")
                    .HasColumnType("numeric");

                entity.HasOne(d => d.UserCreatedNavigation)
                    .WithMany(p => p.CallCategoriesUserCreatedNavigation)
                    .HasForeignKey(d => d.UserCreated)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CALL_CATEGORY_USER_CREATED");

                entity.HasOne(d => d.UserModifiedNavigation)
                    .WithMany(p => p.CallCategoriesUserModifiedNavigation)
                    .HasForeignKey(d => d.UserModified)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CALL_CATEGORY_USER_MODIFIED");
            });

            modelBuilder.Entity<IeSMCallPriority>(entity =>
            {
                entity.HasKey(e => e.PriorityNo)
                    .HasName("PK_CALL_PRIORITY");

                entity.ToTable("CALL_PRIORITY");

                entity.HasIndex(e => e.Description)
                    .HasName("AK_CALL_PRIORITY")
                    .IsUnique();

                entity.Property(e => e.PriorityNo)
                    .HasColumnName("PRIORITY_NO")
                    .HasColumnType("numeric");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("DATE_CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("DATE_MODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultMinutes).HasColumnName("DEFAULT_MINUTES");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Icon)
                    .HasColumnName("ICON")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.OutOfUse)
                    .HasColumnName("OUT_OF_USE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PriorityColour)
                    .HasColumnName("PRIORITY_COLOUR")
                    .HasColumnType("numeric");

                entity.Property(e => e.UserCreated)
                    .HasColumnName("USER_CREATED")
                    .HasColumnType("numeric");

                entity.Property(e => e.UserModified)
                    .HasColumnName("USER_MODIFIED")
                    .HasColumnType("numeric");

                entity.HasOne(d => d.UserCreatedNavigation)
                    .WithMany(p => p.CallPriorityUserCreatedNavigation)
                    .HasForeignKey(d => d.UserCreated)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CALL_PRIORITY_USER_CREATED");

                entity.HasOne(d => d.UserModifiedNavigation)
                    .WithMany(p => p.CallPriorityUserModifiedNavigation)
                    .HasForeignKey(d => d.UserModified)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CALL_PRIORITY_USER_MODIFIED");
            });

            modelBuilder.Entity<IeSMCallStatus>(entity =>
            {
                entity.HasKey(e => e.StatusNo)
                    .HasName("PK_CALL_STATUS");

                entity.ToTable("CALL_STATUS");

                entity.HasIndex(e => e.Description)
                    .HasName("AK_CALL_STATUS")
                    .IsUnique();

                entity.Property(e => e.StatusNo)
                    .HasColumnName("STATUS_NO")
                    .HasColumnType("numeric");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("DATE_CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("DATE_MODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Icon)
                    .HasColumnName("ICON")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.OutOfUse).HasColumnName("OUT_OF_USE");

                entity.Property(e => e.StatusColour)
                    .HasColumnName("STATUS_COLOUR")
                    .HasColumnType("numeric");

                entity.Property(e => e.UserCreated)
                    .HasColumnName("USER_CREATED")
                    .HasColumnType("numeric");

                entity.Property(e => e.UserModified)
                    .HasColumnName("USER_MODIFIED")
                    .HasColumnType("numeric");

                entity.HasOne(d => d.UserCreatedNavigation)
                    .WithMany(p => p.CallStatusUserCreatedNavigation)
                    .HasForeignKey(d => d.UserCreated)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CALL_STATUS_USER_CREATED");

                entity.HasOne(d => d.UserModifiedNavigation)
                    .WithMany(p => p.CallStatusUserModifiedNavigation)
                    .HasForeignKey(d => d.UserModified)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CALL_STATUS_USER_MODIFIED");
            });

            modelBuilder.Entity<CallTypes>(entity =>
            {
                entity.HasKey(e => e.CallType)
                    .HasName("PK_CALL_TYPES");

                entity.ToTable("CALL_TYPES");

                entity.HasIndex(e => e.Description)
                    .HasName("CALL_TYPES_DESC_AK")
                    .IsUnique();

                entity.Property(e => e.CallType)
                    .HasColumnName("CALL_TYPE")
                    .HasColumnType("numeric");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("DATE_CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("DATE_MODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OutOfUse).HasColumnName("OUT_OF_USE");

                entity.Property(e => e.UserCreated)
                    .HasColumnName("USER_CREATED")
                    .HasColumnType("numeric");

                entity.Property(e => e.UserModified)
                    .HasColumnName("USER_MODIFIED")
                    .HasColumnType("numeric");

                entity.HasOne(d => d.UserCreatedNavigation)
                    .WithMany(p => p.CallTypesUserCreatedNavigation)
                    .HasForeignKey(d => d.UserCreated)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CALL_TYPES_USER_CREATED");

                entity.HasOne(d => d.UserModifiedNavigation)
                    .WithMany(p => p.CallTypesUserModifiedNavigation)
                    .HasForeignKey(d => d.UserModified)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CALL_TYPES_USER_MODIFIED");
            });

            modelBuilder.Entity<CategorySubCategories>(entity =>
            {
                entity.HasKey(e => new { e.CallCategory, e.SubCategoryId })
                    .HasName("PK_CATEGORY_SUB_CATEGORIES");

                entity.ToTable("CATEGORY_SUB_CATEGORIES");

                entity.HasIndex(e => new { e.SubCategoryId, e.CallCategory })
                    .HasName("IX_CATEGORY_SUB_CATEGORIES1");

                entity.Property(e => e.CallCategory)
                    .HasColumnName("CALL_CATEGORY")
                    .HasColumnType("numeric");

                entity.Property(e => e.SubCategoryId)
                    .HasColumnName("SUB_CATEGORY_ID")
                    .HasColumnType("numeric");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("DATE_CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("DATE_MODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserCreated)
                    .HasColumnName("USER_CREATED")
                    .HasColumnType("numeric");

                entity.Property(e => e.UserModified)
                    .HasColumnName("USER_MODIFIED")
                    .HasColumnType("numeric");

                entity.HasOne(d => d.CallCategoryNavigation)
                    .WithMany(p => p.CategorySubCategories)
                    .HasForeignKey(d => d.CallCategory)
                    .HasConstraintName("FK_CATSUBCAT_CALL_CATEGORIES");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.CategorySubCategories)
                    .HasForeignKey(d => d.SubCategoryId)
                    .HasConstraintName("FK_CATSUBCAT_SUB_CATEGORIES");

                entity.HasOne(d => d.UserCreatedNavigation)
                    .WithMany(p => p.CategorySubCategoriesUserCreatedNavigation)
                    .HasForeignKey(d => d.UserCreated)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CATSUBCAT_USER_CREATED");

                entity.HasOne(d => d.UserModifiedNavigation)
                    .WithMany(p => p.CategorySubCategoriesUserModifiedNavigation)
                    .HasForeignKey(d => d.UserModified)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CATSUBCAT_USER_MODIFIED");
            });

            modelBuilder.Entity<IeSMContacts>(entity =>
            {
                entity.HasKey(e => e.ContactId)
                    .HasName("PK_CONTACTS");

                entity.ToTable("CONTACTS");

                entity.HasIndex(e => new { e.CustNo, e.ContactName })
                    .HasName("IX_CONTACTS")
                    .IsUnique();

                entity.Property(e => e.ContactId).HasColumnName("CONTACT_ID");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasColumnName("CONTACT_NAME")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ContactTitle)
                    .HasColumnName("CONTACT_TITLE")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.CustNo)
                    .HasColumnName("CUST_NO")
                    .HasColumnType("numeric");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("DATE_CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("DATE_MODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.FaxNo)
                    .HasColumnName("FAX_NO")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Firstname)
                    .HasColumnName("FIRSTNAME")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.IncludeInMailMerge)
                    .HasColumnName("INCLUDE_IN_MAIL_MERGE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IncludeInMailShots)
                    .HasColumnName("INCLUDE_IN_MAIL_SHOTS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MainContact).HasColumnName("MAIN_CONTACT");

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Salutation)
                    .HasColumnName("SALUTATION")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Surname)
                    .HasColumnName("SURNAME")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.UserCreated)
                    .HasColumnName("USER_CREATED")
                    .HasColumnType("numeric");

                entity.Property(e => e.UserModified)
                    .HasColumnName("USER_MODIFIED")
                    .HasColumnType("numeric");

                entity.HasOne(d => d.CustNoNavigation)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.CustNo)
                    .HasConstraintName("FK_CONTACTS_CUSTOMERS");

                entity.HasOne(d => d.UserCreatedNavigation)
                    .WithMany(p => p.ContactsUserCreatedNavigation)
                    .HasForeignKey(d => d.UserCreated)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CONTACTS_USER_CREATED");

                entity.HasOne(d => d.UserModifiedNavigation)
                    .WithMany(p => p.ContactsUserModifiedNavigation)
                    .HasForeignKey(d => d.UserModified)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CONTACTS_USER_MODIFIED");
            });

            modelBuilder.Entity<ContractTypes>(entity =>
            {
                entity.HasKey(e => e.ContractType)
                    .HasName("PK_CONTRACT_TYPES");

                entity.ToTable("CONTRACT_TYPES");

                entity.HasIndex(e => e.Description)
                    .HasName("ak_contract_type")
                    .IsUnique();

                entity.Property(e => e.ContractType)
                    .HasColumnName("CONTRACT_TYPE")
                    .HasColumnType("numeric");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("DATE_CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("DATE_MODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OutOfUse)
                    .HasColumnName("OUT_OF_USE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserCreated)
                    .HasColumnName("USER_CREATED")
                    .HasColumnType("numeric");

                entity.Property(e => e.UserModified)
                    .HasColumnName("USER_MODIFIED")
                    .HasColumnType("numeric");

                entity.HasOne(d => d.UserCreatedNavigation)
                    .WithMany(p => p.ContractTypesUserCreatedNavigation)
                    .HasForeignKey(d => d.UserCreated)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_contract_types_user_created");

                entity.HasOne(d => d.UserModifiedNavigation)
                    .WithMany(p => p.ContractTypesUserModifiedNavigation)
                    .HasForeignKey(d => d.UserModified)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_contract_types_user_modified");
            });

            modelBuilder.Entity<Contracts>(entity =>
            {
                entity.HasKey(e => e.ContractNo)
                    .HasName("PK_CONTRACTS");

                entity.ToTable("CONTRACTS");

                entity.Property(e => e.ContractNo)
                    .HasColumnName("CONTRACT_NO")
                    .HasColumnType("numeric");

                entity.Property(e => e.AllowanceType)
                    .HasColumnName("ALLOWANCE_TYPE")
                    .HasColumnType("char(1)");

                entity.Property(e => e.AllowanceValue)
                    .HasColumnName("ALLOWANCE_VALUE")
                    .HasColumnType("numeric");

                entity.Property(e => e.ContractAllowance)
                    .HasColumnName("CONTRACT_ALLOWANCE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContractCost)
                    .HasColumnName("CONTRACT_COST")
                    .HasColumnType("numeric");

                entity.Property(e => e.ContractSalePrice)
                    .HasColumnName("CONTRACT_SALE_PRICE")
                    .HasColumnType("numeric");

                entity.Property(e => e.ContractType)
                    .HasColumnName("CONTRACT_TYPE")
                    .HasColumnType("numeric");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("DATE_CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("DATE_MODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultPriority)
                    .HasColumnName("DEFAULT_PRIORITY")
                    .HasColumnType("numeric");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasColumnType("varchar(5000)");

                entity.Property(e => e.OutOfUse)
                    .HasColumnName("OUT_OF_USE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RepeatAnnualMonth).HasColumnName("REPEAT_ANNUAL_MONTH");

                entity.Property(e => e.RepeatDay).HasColumnName("REPEAT_DAY");

                entity.Property(e => e.RepeatDaynumber).HasColumnName("REPEAT_DAYNUMBER");

                entity.Property(e => e.RepeatMonth).HasColumnName("REPEAT_MONTH");

                entity.Property(e => e.RepeatPeriod).HasColumnName("REPEAT_PERIOD");

                entity.Property(e => e.RepeatType)
                    .HasColumnName("REPEAT_TYPE")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.RepeatValue)
                    .HasColumnName("REPEAT_VALUE")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.UserCreated)
                    .HasColumnName("USER_CREATED")
                    .HasColumnType("numeric");

                entity.Property(e => e.UserModified)
                    .HasColumnName("USER_MODIFIED")
                    .HasColumnType("numeric");

                entity.HasOne(d => d.ContractTypeNavigation)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.ContractType)
                    .HasConstraintName("FK_CONTRACTS_CONTRACT_TYPES");

                entity.HasOne(d => d.DefaultPriorityNavigation)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.DefaultPriority)
                    .HasConstraintName("FK_CONTRACTS_CALL_PRIORITY");

                entity.HasOne(d => d.UserCreatedNavigation)
                    .WithMany(p => p.ContractsUserCreatedNavigation)
                    .HasForeignKey(d => d.UserCreated)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CONTRACTS_USER_CREATED");

                entity.HasOne(d => d.UserModifiedNavigation)
                    .WithMany(p => p.ContractsUserModifiedNavigation)
                    .HasForeignKey(d => d.UserModified)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CONTRACTS_USER_MODIFIED");
            });

            modelBuilder.Entity<CustomerGroups>(entity =>
            {
                entity.HasKey(e => e.GroupNo)
                    .HasName("PK_CUSTOMER_GROUPS");

                entity.ToTable("CUSTOMER_GROUPS");

                entity.HasIndex(e => e.Description)
                    .HasName("AK_CUSTOMER_GROUPS")
                    .IsUnique();

                entity.Property(e => e.GroupNo)
                    .HasColumnName("GROUP_NO")
                    .HasColumnType("numeric");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("DATE_CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("DATE_MODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OutOfUse).HasColumnName("OUT_OF_USE");

                entity.Property(e => e.UserCreated)
                    .HasColumnName("USER_CREATED")
                    .HasColumnType("numeric");

                entity.Property(e => e.UserModified)
                    .HasColumnName("USER_MODIFIED")
                    .HasColumnType("numeric");

                entity.HasOne(d => d.UserCreatedNavigation)
                    .WithMany(p => p.CustomerGroupsUserCreatedNavigation)
                    .HasForeignKey(d => d.UserCreated)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CUST_GRPS_USER_CREATED");

                entity.HasOne(d => d.UserModifiedNavigation)
                    .WithMany(p => p.CustomerGroupsUserModifiedNavigation)
                    .HasForeignKey(d => d.UserModified)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CUST_GRPS_USER_MODIFIED");
            });

            modelBuilder.Entity<CustomerStatus>(entity =>
            {
                entity.HasKey(e => e.StatusNo)
                    .HasName("PK_CUSTOMER_STATUS");

                entity.ToTable("CUSTOMER_STATUS");

                entity.HasIndex(e => e.Description)
                    .HasName("AK_CUST_STATUS_DESC")
                    .IsUnique();

                entity.Property(e => e.StatusNo)
                    .HasColumnName("STATUS_NO")
                    .HasColumnType("numeric");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("DATE_CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("DATE_MODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Icon)
                    .HasColumnName("ICON")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.OutOfUse).HasColumnName("OUT_OF_USE");

                entity.Property(e => e.UserCreated)
                    .HasColumnName("USER_CREATED")
                    .HasColumnType("numeric");

                entity.Property(e => e.UserModified)
                    .HasColumnName("USER_MODIFIED")
                    .HasColumnType("numeric");

                entity.HasOne(d => d.UserCreatedNavigation)
                    .WithMany(p => p.CustomerStatusUserCreatedNavigation)
                    .HasForeignKey(d => d.UserCreated)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CUST_STATUS_USER_CREATED");

                entity.HasOne(d => d.UserModifiedNavigation)
                    .WithMany(p => p.CustomerStatusUserModifiedNavigation)
                    .HasForeignKey(d => d.UserModified)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CUST_STATUS_USER_MODIFIED");
            });

            modelBuilder.Entity<IeSMCustomer>(entity =>
            {
                entity.HasKey(e => e.CustNo)
                    .HasName("PK_CUSTOMERS");

                entity.ToTable("CUSTOMERS");

                entity.HasIndex(e => e.CustName)
                    .HasName("CUST_NAMES_AK");

                entity.HasIndex(e => e.CustRef)
                    .HasName("AK_CUST_REF");

                entity.Property(e => e.CustNo)
                    .HasColumnName("CUST_NO")
                    .HasColumnType("numeric");

                entity.Property(e => e.AccountManager)
                    .HasColumnName("ACCOUNT_MANAGER")
                    .HasColumnType("numeric");

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS_1")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS_2")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Address3)
                    .HasColumnName("ADDRESS_3")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Address4)
                    .HasColumnName("ADDRESS_4")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Address5)
                    .HasColumnName("ADDRESS_5")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ContractWarningOption)
                    .HasColumnName("CONTRACT_WARNING_OPTION")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CustName)
                    .HasColumnName("CUST_NAME")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CustRef)
                    .HasColumnName("CUST_REF")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("DATE_CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("DATE_MODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultPriority)
                    .HasColumnName("DEFAULT_PRIORITY")
                    .HasColumnType("numeric");

                entity.Property(e => e.FaxNo)
                    .HasColumnName("FAX_NO")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.GroupNo)
                    .HasColumnName("GROUP_NO")
                    .HasColumnType("numeric");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.OutOfUse).HasColumnName("OUT_OF_USE");

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.StatusNo)
                    .HasColumnName("STATUS_NO")
                    .HasColumnType("numeric");

                entity.Property(e => e.UserCreated)
                    .HasColumnName("USER_CREATED")
                    .HasColumnType("numeric");

                entity.Property(e => e.UserModified)
                    .HasColumnName("USER_MODIFIED")
                    .HasColumnType("numeric");

                entity.Property(e => e.Website)
                    .HasColumnName("WEBSITE")
                    .HasColumnType("varchar(500)");

                entity.HasOne(d => d.AccountManagerNavigation)
                    .WithMany(p => p.CustomersAccountManagerNavigation)
                    .HasForeignKey(d => d.AccountManager)
                    .HasConstraintName("fk_cust_acc_mgr");

                entity.HasOne(d => d.DefaultPriorityNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.DefaultPriority)
                    .HasConstraintName("FK_CUSTOMERS_DEFAULT_PRIORITY");

                entity.HasOne(d => d.GroupNoNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.GroupNo)
                    .HasConstraintName("FK_CUSTOMER_GROUPS");

                entity.HasOne(d => d.StatusNoNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.StatusNo)
                    .HasConstraintName("FK_CUSTOMER_STATUS");

                entity.HasOne(d => d.UserCreatedNavigation)
                    .WithMany(p => p.CustomersUserCreatedNavigation)
                    .HasForeignKey(d => d.UserCreated)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CUSTOMERS_USER_CREATED");

                entity.HasOne(d => d.UserModifiedNavigation)
                    .WithMany(p => p.CustomersUserModifiedNavigation)
                    .HasForeignKey(d => d.UserModified)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CUSTOMERS_USER_MODIFIED");
            });

            modelBuilder.Entity<LoggedCalls>(entity =>
            {
                entity.HasKey(e => e.CallNo)
                    .HasName("PK_LOGGED_CALLS");

                entity.ToTable("LOGGED_CALLS");

                entity.HasIndex(e => e.CustNo)
                    .HasName("IX_LOGGED_CALLS3");

                entity.HasIndex(e => e.DateLogged)
                    .HasName("DATE_AK");

                entity.HasIndex(e => new { e.CustomerContractNo, e.TotalDuration })
                    .HasName("AK_CUSTOMER_CONTRACT_NO");

                entity.HasIndex(e => new { e.ParentCall, e.CallNo })
                    .HasName("IX_LOGGED_CALLS5");

                entity.HasIndex(e => new { e.CallClosed, e.DueDate, e.CallNo })
                    .HasName("IX_LOGGED_CALLS1");

                entity.Property(e => e.CallNo)
                    .HasColumnName("CALL_NO")
                    .HasColumnType("numeric");

                entity.Property(e => e.AssignedTo)
                    .HasColumnName("ASSIGNED_TO")
                    .HasColumnType("numeric");

                entity.Property(e => e.CallCategory)
                    .HasColumnName("CALL_CATEGORY")
                    .HasColumnType("numeric");

                entity.Property(e => e.CallClosed).HasColumnName("CALL_CLOSED");

                entity.Property(e => e.CallDescription)
                    .HasColumnName("CALL_DESCRIPTION")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CallDuration)
                    .HasColumnName("CALL_DURATION")
                    .HasColumnType("numeric");

                entity.Property(e => e.CallType)
                    .HasColumnName("CALL_TYPE")
                    .HasColumnType("numeric");

                entity.Property(e => e.ClosedBy)
                    .HasColumnName("CLOSED_BY")
                    .HasColumnType("numeric");

                entity.Property(e => e.ComponentId)
                    .HasColumnName("COMPONENT_ID")
                    .HasColumnType("numeric");

                entity.Property(e => e.ContactName)
                    .HasColumnName("CONTACT_NAME")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CustNo)
                    .HasColumnName("CUST_NO")
                    .HasColumnType("numeric");

                entity.Property(e => e.CustomerContractNo)
                    .HasColumnName("CUSTOMER_CONTRACT_NO")
                    .HasColumnType("numeric");

                entity.Property(e => e.DateClosed)
                    .HasColumnName("DATE_CLOSED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateLogged)
                    .HasColumnName("DATE_LOGGED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("DATE_MODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DueDate)
                    .HasColumnName("DUE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoggedBy)
                    .HasColumnName("LOGGED_BY")
                    .HasColumnType("numeric");

                entity.Property(e => e.OutOfHours)
                    .HasColumnName("OUT_OF_HOURS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParentCall).HasColumnName("PARENT_CALL");

                entity.Property(e => e.PriorityNo)
                    .HasColumnName("PRIORITY_NO")
                    .HasColumnType("numeric");

                entity.Property(e => e.Problem)
                    .HasColumnName("PROBLEM")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.ProductNo)
                    .HasColumnName("PRODUCT_NO")
                    .HasColumnType("numeric");

                entity.Property(e => e.PublishToWeb)
                    .HasColumnName("PUBLISH_TO_WEB")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SerialNo)
                    .HasColumnName("SERIAL_NO")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Solution)
                    .HasColumnName("SOLUTION")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.StatusNo)
                    .HasColumnName("STATUS_NO")
                    .HasColumnType("numeric");

                entity.Property(e => e.SubCategoryId)
                    .HasColumnName("SUB_CATEGORY_ID")
                    .HasColumnType("numeric");

                entity.Property(e => e.TotalDuration)
                    .HasColumnName("TOTAL_DURATION")
                    .HasColumnType("numeric");

                entity.Property(e => e.UserModified)
                    .HasColumnName("USER_MODIFIED")
                    .HasColumnType("numeric");

                entity.Property(e => e.ViaLogger).HasColumnName("VIA_LOGGER");

                entity.Property(e => e.WebCall)
                    .HasColumnName("WEB_CALL")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.AssignedToNavigation)
                    .WithMany(p => p.LoggedCallsAssignedToNavigation)
                    .HasForeignKey(d => d.AssignedTo)
                    .HasConstraintName("FK_LOGGED_CALLS_ASSIGNED_TO");

                entity.HasOne(d => d.CallCategoryNavigation)
                    .WithMany(p => p.LoggedCalls)
                    .HasForeignKey(d => d.CallCategory)
                    .HasConstraintName("FK_LOGGED_CALLS_CATEGORY");

                entity.HasOne(d => d.CallTypeNavigation)
                    .WithMany(p => p.LoggedCalls)
                    .HasForeignKey(d => d.CallType)
                    .HasConstraintName("FK_LOGGED_CALL_TYPES");

                entity.HasOne(d => d.ClosedByNavigation)
                    .WithMany(p => p.LoggedCallsClosedByNavigation)
                    .HasForeignKey(d => d.ClosedBy)
                    .HasConstraintName("FK_LOGGED_CALL_CLOSED_BY");

                entity.HasOne(d => d.CustNoNavigation)
                    .WithMany(p => p.LoggedCalls)
                    .HasForeignKey(d => d.CustNo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LOGGED_CALLS_CUSTOMER");

                entity.HasOne(d => d.LoggedByNavigation)
                    .WithMany(p => p.LoggedCallsLoggedByNavigation)
                    .HasForeignKey(d => d.LoggedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LOGGED_CALL_USER");

                entity.HasOne(d => d.PriorityNoNavigation)
                    .WithMany(p => p.LoggedCalls)
                    .HasForeignKey(d => d.PriorityNo)
                    .HasConstraintName("fk_logged_calls_priority");

                entity.HasOne(d => d.StatusNoNavigation)
                    .WithMany(p => p.LoggedCalls)
                    .HasForeignKey(d => d.StatusNo)
                    .HasConstraintName("FK_LOGGED_CALL_STATUS");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.LoggedCalls)
                    .HasForeignKey(d => d.SubCategoryId)
                    .HasConstraintName("fk_logged_calls_sub_cat");

                entity.HasOne(d => d.UserModifiedNavigation)
                    .WithMany(p => p.LoggedCallsUserModifiedNavigation)
                    .HasForeignKey(d => d.UserModified)
                    .HasConstraintName("FK_LOGGED_CALLS_USER_MODIFIED");
            });

            modelBuilder.Entity<Profiles>(entity =>
            {
                entity.HasKey(e => e.ProfileNo)
                    .HasName("PK_PROFILES");

                entity.ToTable("PROFILES");

                entity.HasIndex(e => new { e.Description, e.ProfileType })
                    .HasName("AK_PROFILES")
                    .IsUnique();

                entity.Property(e => e.ProfileNo)
                    .HasColumnName("PROFILE_NO")
                    .HasColumnType("numeric");

                entity.Property(e => e.AccessRights)
                    .HasColumnName("ACCESS_RIGHTS")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Checksum)
                    .HasColumnName("CHECKSUM")
                    .HasColumnType("numeric");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("DATE_CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("DATE_MODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OutOfUse).HasColumnName("OUT_OF_USE");

                entity.Property(e => e.ProfileType).HasColumnName("PROFILE_TYPE");

                entity.Property(e => e.UserCreated)
                    .HasColumnName("USER_CREATED")
                    .HasColumnType("numeric");

                entity.Property(e => e.UserModified)
                    .HasColumnName("USER_MODIFIED")
                    .HasColumnType("numeric");

                entity.HasOne(d => d.UserCreatedNavigation)
                    .WithMany(p => p.ProfilesUserCreatedNavigation)
                    .HasForeignKey(d => d.UserCreated)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PROFILES_USER_CREATED");

                entity.HasOne(d => d.UserModifiedNavigation)
                    .WithMany(p => p.ProfilesUserModifiedNavigation)
                    .HasForeignKey(d => d.UserModified)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PROFILES_USER_MODIFIED");
            });

            modelBuilder.Entity<RelatedDocuments>(entity =>
            {
                entity.HasKey(e => new { e.SystemNo, e.SystemType, e.Description })
                    .HasName("PK_RELATED_DOCUMENTS");

                entity.ToTable("RELATED_DOCUMENTS");

                entity.HasIndex(e => new { e.SystemType, e.SystemNo })
                    .HasName("IX_RELATED_DOCUMENTS1");

                entity.Property(e => e.SystemNo)
                    .HasColumnName("SYSTEM_NO")
                    .HasColumnType("numeric");

                entity.Property(e => e.SystemType)
                    .HasColumnName("SYSTEM_TYPE")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("DATE_CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("DATE_MODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasColumnName("FILE_PATH")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.UserCreated)
                    .HasColumnName("USER_CREATED")
                    .HasColumnType("numeric");

                entity.Property(e => e.UserModified)
                    .HasColumnName("USER_MODIFIED")
                    .HasColumnType("numeric");

                entity.HasOne(d => d.UserCreatedNavigation)
                    .WithMany(p => p.RelatedDocumentsUserCreatedNavigation)
                    .HasForeignKey(d => d.UserCreated)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RELATED_DOCS_USER_CREATED");

                entity.HasOne(d => d.UserModifiedNavigation)
                    .WithMany(p => p.RelatedDocumentsUserModifiedNavigation)
                    .HasForeignKey(d => d.UserModified)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RELATED_DOCS_USER_MODIFIED");
            });

            modelBuilder.Entity<SubCategories>(entity =>
            {
                entity.HasKey(e => e.SubCategoryId)
                    .HasName("PK_SUB_CATEGORIES");

                entity.ToTable("SUB_CATEGORIES");

                entity.HasIndex(e => e.Description)
                    .HasName("AK_SUB_CATEGORIES")
                    .IsUnique();

                entity.Property(e => e.SubCategoryId)
                    .HasColumnName("SUB_CATEGORY_ID")
                    .HasColumnType("numeric");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("DATE_CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("DATE_MODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OutOfUse)
                    .HasColumnName("OUT_OF_USE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserCreated)
                    .HasColumnName("USER_CREATED")
                    .HasColumnType("numeric");

                entity.Property(e => e.UserModified)
                    .HasColumnName("USER_MODIFIED")
                    .HasColumnType("numeric");

                entity.HasOne(d => d.UserCreatedNavigation)
                    .WithMany(p => p.SubCategoriesUserCreatedNavigation)
                    .HasForeignKey(d => d.UserCreated)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_sub_cat_user_created");

                entity.HasOne(d => d.UserModifiedNavigation)
                    .WithMany(p => p.SubCategoriesUserModifiedNavigation)
                    .HasForeignKey(d => d.UserModified)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_sub_cat_user_modified");
            });

            modelBuilder.Entity<IeSMUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_USERS");

                entity.ToTable("USERS");

                entity.HasIndex(e => e.LockedUntil)
                    .HasName("IX_USERS2");

                entity.HasIndex(e => new { e.UserName, e.UserType })
                    .HasName("AK_USERS_NAME")
                    .IsUnique();

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("numeric");

                entity.Property(e => e.AllowedAssignCalls).HasColumnName("ALLOWED_ASSIGN_CALLS");

                entity.Property(e => e.AutoLogin)
                    .HasColumnName("AUTO_LOGIN")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChangePassword).HasColumnName("CHANGE_PASSWORD");

                entity.Property(e => e.Checksum)
                    .HasColumnName("CHECKSUM")
                    .HasColumnType("numeric");

                entity.Property(e => e.ContactName)
                    .HasColumnName("CONTACT_NAME")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CustNo)
                    .HasColumnName("CUST_NO")
                    .HasColumnType("numeric");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("DATE_CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("DATE_MODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.LockedUntil)
                    .HasColumnName("LOCKED_UNTIL")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginDate)
                    .HasColumnName("LOGIN_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginFailures)
                    .HasColumnName("LOGIN_FAILURES")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LoginType)
                    .HasColumnName("LOGIN_TYPE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NotifyReOverdue).HasColumnName("NOTIFY_RE_OVERDUE");

                entity.Property(e => e.OutOfUse).HasColumnName("OUT_OF_USE");

                entity.Property(e => e.Pan1)
                    .IsRequired()
                    .HasColumnName("PAN1")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Pan2)
                    .IsRequired()
                    .HasColumnName("PAN2")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Pan3)
                    .IsRequired()
                    .HasColumnName("PAN3")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Pan4)
                    .IsRequired()
                    .HasColumnName("PAN4")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Pan5)
                    .IsRequired()
                    .HasColumnName("PAN5")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Pan6)
                    .IsRequired()
                    .HasColumnName("PAN6")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ProfileNo)
                    .HasColumnName("PROFILE_NO")
                    .HasColumnType("numeric");

                entity.Property(e => e.ServerName)
                    .HasColumnName("SERVER_NAME")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.UserCalls).HasColumnName("USER_CALLS");

                entity.Property(e => e.UserCreated)
                    .HasColumnName("USER_CREATED")
                    .HasColumnType("numeric");

                entity.Property(e => e.UserEmail)
                    .HasColumnName("USER_EMAIL")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.UserFullname)
                    .HasColumnName("USER_FULLNAME")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.UserModified)
                    .HasColumnName("USER_MODIFIED")
                    .HasColumnType("numeric");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("USER_NAME")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasColumnName("USER_PASSWORD")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.UserType).HasColumnName("USER_TYPE");

                entity.Property(e => e.WebCalls).HasColumnName("WEB_CALLS");

                entity.HasOne(d => d.CustNoNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CustNo)
                    .HasConstraintName("FK_USERS_CUSTOMERS");

                entity.HasOne(d => d.ProfileNoNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ProfileNo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_USER_PROFILES");

                entity.HasOne(d => d.UserCreatedNavigation)
                    .WithMany(p => p.InverseUserCreatedNavigation)
                    .HasForeignKey(d => d.UserCreated)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_USERS_USER_CREATED");

                entity.HasOne(d => d.UserModifiedNavigation)
                    .WithMany(p => p.InverseUserModifiedNavigation)
                    .HasForeignKey(d => d.UserModified)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_USERS_USER_MODIFIED");
            });
        }
    }
}