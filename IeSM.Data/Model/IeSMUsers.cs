using System;
using System.Collections.Generic;

namespace IeSM.Data.Model
{
    public partial class IeSMUsers
    {
        public IeSMUsers()
        {
            CallCategoriesUserCreatedNavigation = new HashSet<CallCategories>();
            CallCategoriesUserModifiedNavigation = new HashSet<CallCategories>();
            CallPriorityUserCreatedNavigation = new HashSet<CallPriority>();
            CallPriorityUserModifiedNavigation = new HashSet<CallPriority>();
            CallStatusUserCreatedNavigation = new HashSet<CallStatus>();
            CallStatusUserModifiedNavigation = new HashSet<CallStatus>();
            CallTypesUserCreatedNavigation = new HashSet<CallTypes>();
            CallTypesUserModifiedNavigation = new HashSet<CallTypes>();
            CategorySubCategoriesUserCreatedNavigation = new HashSet<CategorySubCategories>();
            CategorySubCategoriesUserModifiedNavigation = new HashSet<CategorySubCategories>();
            ContactsUserCreatedNavigation = new HashSet<IeSMContacts>();
            ContactsUserModifiedNavigation = new HashSet<IeSMContacts>();
            ContractsUserCreatedNavigation = new HashSet<Contracts>();
            ContractsUserModifiedNavigation = new HashSet<Contracts>();
            ContractTypesUserCreatedNavigation = new HashSet<ContractTypes>();
            ContractTypesUserModifiedNavigation = new HashSet<ContractTypes>();
            CustomerGroupsUserCreatedNavigation = new HashSet<CustomerGroups>();
            CustomerGroupsUserModifiedNavigation = new HashSet<CustomerGroups>();
            CustomersAccountManagerNavigation = new HashSet<IeSMCustomer>();
            CustomersUserCreatedNavigation = new HashSet<IeSMCustomer>();
            CustomersUserModifiedNavigation = new HashSet<IeSMCustomer>();
            CustomerStatusUserCreatedNavigation = new HashSet<CustomerStatus>();
            CustomerStatusUserModifiedNavigation = new HashSet<CustomerStatus>();
            LoggedCallsAssignedToNavigation = new HashSet<LoggedCalls>();
            LoggedCallsClosedByNavigation = new HashSet<LoggedCalls>();
            LoggedCallsLoggedByNavigation = new HashSet<LoggedCalls>();
            LoggedCallsUserModifiedNavigation = new HashSet<LoggedCalls>();
            ProfilesUserCreatedNavigation = new HashSet<Profiles>();
            ProfilesUserModifiedNavigation = new HashSet<Profiles>();
            RelatedDocumentsUserCreatedNavigation = new HashSet<RelatedDocuments>();
            RelatedDocumentsUserModifiedNavigation = new HashSet<RelatedDocuments>();
            SubCategoriesUserCreatedNavigation = new HashSet<SubCategories>();
            SubCategoriesUserModifiedNavigation = new HashSet<SubCategories>();
        }

        public decimal UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public decimal ProfileNo { get; set; }
        public DateTime? LoginDate { get; set; }
        public decimal? Checksum { get; set; }
        public short? ChangePassword { get; set; }
        public string UserEmail { get; set; }
        public short UserType { get; set; }
        public decimal? CustNo { get; set; }
        public short? UserCalls { get; set; }
        public short? WebCalls { get; set; }
        public short OutOfUse { get; set; }
        public decimal UserCreated { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal UserModified { get; set; }
        public DateTime DateModified { get; set; }
        public string UserFullname { get; set; }
        public short? LoginType { get; set; }
        public string ServerName { get; set; }
        public short AutoLogin { get; set; }
        public string ContactName { get; set; }
        public short? AllowedAssignCalls { get; set; }
        public short? LoginFailures { get; set; }
        public DateTime? LockedUntil { get; set; }
        public short? NotifyReOverdue { get; set; }
        public string Pan1 { get; set; }
        public string Pan2 { get; set; }
        public string Pan3 { get; set; }
        public string Pan4 { get; set; }
        public string Pan5 { get; set; }
        public string Pan6 { get; set; }

        public virtual ICollection<CallCategories> CallCategoriesUserCreatedNavigation { get; set; }
        public virtual ICollection<CallCategories> CallCategoriesUserModifiedNavigation { get; set; }
        public virtual ICollection<CallPriority> CallPriorityUserCreatedNavigation { get; set; }
        public virtual ICollection<CallPriority> CallPriorityUserModifiedNavigation { get; set; }
        public virtual ICollection<CallStatus> CallStatusUserCreatedNavigation { get; set; }
        public virtual ICollection<CallStatus> CallStatusUserModifiedNavigation { get; set; }
        public virtual ICollection<CallTypes> CallTypesUserCreatedNavigation { get; set; }
        public virtual ICollection<CallTypes> CallTypesUserModifiedNavigation { get; set; }
        public virtual ICollection<CategorySubCategories> CategorySubCategoriesUserCreatedNavigation { get; set; }
        public virtual ICollection<CategorySubCategories> CategorySubCategoriesUserModifiedNavigation { get; set; }
        public virtual ICollection<IeSMContacts> ContactsUserCreatedNavigation { get; set; }
        public virtual ICollection<IeSMContacts> ContactsUserModifiedNavigation { get; set; }
        public virtual ICollection<Contracts> ContractsUserCreatedNavigation { get; set; }
        public virtual ICollection<Contracts> ContractsUserModifiedNavigation { get; set; }
        public virtual ICollection<ContractTypes> ContractTypesUserCreatedNavigation { get; set; }
        public virtual ICollection<ContractTypes> ContractTypesUserModifiedNavigation { get; set; }
        public virtual ICollection<CustomerGroups> CustomerGroupsUserCreatedNavigation { get; set; }
        public virtual ICollection<CustomerGroups> CustomerGroupsUserModifiedNavigation { get; set; }
        public virtual ICollection<IeSMCustomer> CustomersAccountManagerNavigation { get; set; }
        public virtual ICollection<IeSMCustomer> CustomersUserCreatedNavigation { get; set; }
        public virtual ICollection<IeSMCustomer> CustomersUserModifiedNavigation { get; set; }
        public virtual ICollection<CustomerStatus> CustomerStatusUserCreatedNavigation { get; set; }
        public virtual ICollection<CustomerStatus> CustomerStatusUserModifiedNavigation { get; set; }
        public virtual ICollection<LoggedCalls> LoggedCallsAssignedToNavigation { get; set; }
        public virtual ICollection<LoggedCalls> LoggedCallsClosedByNavigation { get; set; }
        public virtual ICollection<LoggedCalls> LoggedCallsLoggedByNavigation { get; set; }
        public virtual ICollection<LoggedCalls> LoggedCallsUserModifiedNavigation { get; set; }
        public virtual ICollection<Profiles> ProfilesUserCreatedNavigation { get; set; }
        public virtual ICollection<Profiles> ProfilesUserModifiedNavigation { get; set; }
        public virtual ICollection<RelatedDocuments> RelatedDocumentsUserCreatedNavigation { get; set; }
        public virtual ICollection<RelatedDocuments> RelatedDocumentsUserModifiedNavigation { get; set; }
        public virtual ICollection<SubCategories> SubCategoriesUserCreatedNavigation { get; set; }
        public virtual ICollection<SubCategories> SubCategoriesUserModifiedNavigation { get; set; }
        public virtual IeSMCustomer CustNoNavigation { get; set; }
        public virtual Profiles ProfileNoNavigation { get; set; }
        public virtual IeSMUsers UserCreatedNavigation { get; set; }
        public virtual ICollection<IeSMUsers> InverseUserCreatedNavigation { get; set; }
        public virtual IeSMUsers UserModifiedNavigation { get; set; }
        public virtual ICollection<IeSMUsers> InverseUserModifiedNavigation { get; set; }
    }
}
