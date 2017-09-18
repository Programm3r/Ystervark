namespace Ystervark.Models.DTO
{
    /// <summary>
    /// Region Model Class
    /// </summary>
    public class RegionModel
    {
        public int RegionId { get; set; }
        public int TenantId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}