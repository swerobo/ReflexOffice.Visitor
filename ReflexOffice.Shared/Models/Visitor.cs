using System.ComponentModel.DataAnnotations;

namespace ReflexOffice.Shared.Models
{
    public class Visitor :Item
    {
        [Required]
        [StringLength(50, ErrorMessage = "First name is too long.")]
        public string first_name { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Last name is too long.")]
        public string last_name { get; set; }
        public string rfid { get; set; }
        public string Company_Id { get; set; }
    }
}