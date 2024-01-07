using System.ComponentModel.DataAnnotations;

namespace AzureDbHosting.Models
{
    public class LeadEntity
    {
        [Key]
        public int ID { get; set; }
        public DateTime LeadDate { get; set; }
        public string LeadSource { get; set; }
        public string Name { get; set; }
        public string  Email { get; set; }



    }
}
