using System;

namespace Ystervark.Models.DTO
{
    public class ClientModel
    {
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
    }
}