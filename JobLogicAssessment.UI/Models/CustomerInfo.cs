using System.ComponentModel.DataAnnotations;

namespace JobLogicAssessment.UI.Models
{
    public class CustomerInfo : EntityBase
    {
        [Required]
        [MaxLength(20)]
        public string Title { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }
        [Required]
        [MaxLength(200)]
        public string Address1 { get; set; }
        [MaxLength(200)]
        public string? Address2 { get; set; }
        [MaxLength(200)]
        public string? Address3 { get; set; }
        [MaxLength(200)]
        public string? Address4 { get; set; }
        [Required]
        public string PostCode { get; set; }
        [Required]
        public int Telephone { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
