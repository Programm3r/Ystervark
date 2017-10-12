namespace Ystervarkie.Models
{
    public class AppConfiguration
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public AppSettings AppSettings { get; set; }
        public ApiSettings Api { get; set; }
    }
}