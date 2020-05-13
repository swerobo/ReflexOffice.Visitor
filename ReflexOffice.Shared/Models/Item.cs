using System;
using System.ComponentModel.DataAnnotations;

namespace ReflexOffice.Shared.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Description is too long.")]
        public string Description { get; set; }
        public DateTime? Created_Date { get; set; }
        public DateTime? Updated_Date { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? End_Date { get; set; }
        public int Created_By { get; set; }
        [Required]
        public string Assigned_To { get; set; }
        public string Owner_Id { get; set; }
        public bool Completed { get; set; }
        public string Category_Id { get; set; }
        public string Cost_Id { get; set; }
        public bool Alarm { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
        public int Module_Id { get; set; }
        public bool Deleted { get; set; }
        [Required]
        public ItemStatus Item_Status { get; set; }
    }
}