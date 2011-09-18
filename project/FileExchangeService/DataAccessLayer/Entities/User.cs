using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class User
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string UserName { get; set; }

        [Required]
        [RegularExpression(@"([A-Za-z0-9]\.{0,}){1,}@[A-Za-z]{2,}\.[a-zA-Z]{2,4}")]
        public string Email { get; set; }

        [Required]
        public string PasswordSalt { get; set; }

        [Required]
        public string PasswordHash { get; set; }
    }
}