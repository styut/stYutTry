namespace WebApplication1.Models
{
    public class job
    {
        public int id { get; set; }
        public string jobField { get; set; }
        public string jobTitle { get; set; }
        public string scopeOfHours { get; set; }
        public string region { get; set; }
        public string[] requirements { get; set; }
        public bool workFromHome { get; set; }
    }

   
}
