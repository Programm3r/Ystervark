using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Client
    {
        public Client()
        {
            BillingLocker = new HashSet<BillingLocker>();
            ClientContact = new HashSet<ClientContact>();
            ClientSite = new HashSet<ClientSite>();
            Invoice = new HashSet<Invoice>();
            InvoicePayment = new HashSet<InvoicePayment>();
            Opportunity = new HashSet<Opportunity>();
            Project = new HashSet<Project>();
            Quote = new HashSet<Quote>();
            Resource = new HashSet<Resource>();
        }

        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public DateTime? DateInserted { get; set; }
        public int? BillingPeriodStart { get; set; }
        public int? ClientManagerId { get; set; }
        public string TradingAsName { get; set; }
        public string CompanyRegNumber { get; set; }
        public string PostalAdressOld { get; set; }
        public string PhysicalAdressOld { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public string Vatnumber { get; set; }
        public string Registered { get; set; }
        public bool? Archived { get; set; }
        public decimal? DefaultRatePerHour { get; set; }
        public string AccountNumber { get; set; }
        public int TenantId { get; set; }
        public int? RegionId { get; set; }
        public decimal Tariff { get; set; }
        public int? PhysicalAddressId { get; set; }
        public int? PostalAddressId { get; set; }
        public string ImageUrl { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public Resource ClientManager { get; set; }
        public Resource CreatedByNavigation { get; set; }
        public Address PhysicalAddress { get; set; }
        public Address PostalAddress { get; set; }
        public Region Region { get; set; }
        public Tenant Tenant { get; set; }
        public Resource UpdatedByNavigation { get; set; }
        public ICollection<BillingLocker> BillingLocker { get; set; }
        public ICollection<ClientContact> ClientContact { get; set; }
        public ICollection<ClientSite> ClientSite { get; set; }
        public ICollection<Invoice> Invoice { get; set; }
        public ICollection<InvoicePayment> InvoicePayment { get; set; }
        public ICollection<Opportunity> Opportunity { get; set; }
        public ICollection<Project> Project { get; set; }
        public ICollection<Quote> Quote { get; set; }
        public ICollection<Resource> Resource { get; set; }
    }
}
