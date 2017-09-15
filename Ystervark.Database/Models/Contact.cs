using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Contact
    {
        public Contact()
        {
            ClientContact = new HashSet<ClientContact>();
            ContactTypeMap = new HashSet<ContactTypeMap>();
            OpportunityContact = new HashSet<OpportunityContact>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string BusinessPhone { get; set; }
        public string MobilePhone { get; set; }
        public string JobTitle { get; set; }
        public string PostalAddress { get; set; }
        public string PhysicalAddress { get; set; }
        public string Description { get; set; }
        public int TenantId { get; set; }

        public Tenant Tenant { get; set; }
        public ICollection<ClientContact> ClientContact { get; set; }
        public ICollection<ContactTypeMap> ContactTypeMap { get; set; }
        public ICollection<OpportunityContact> OpportunityContact { get; set; }
    }
}
