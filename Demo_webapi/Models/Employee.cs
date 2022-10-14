using System.ComponentModel.DataAnnotations;

namespace Demo_webapi.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }//nullable property
       public string? Designation { get; set; }
        [DataType(DataType.Date)]
       public DateTime? JoinDate { get; set; }
    }
}
