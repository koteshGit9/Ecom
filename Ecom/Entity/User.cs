using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ecom.Entity
{
    public class User
    {
        [Key]
        [StringLength(10)]
        [Column(TypeName = "Char")]
        public string? UserId { get; set; }

        [Required]
        [StringLength(10)]
        [Column("UserName", TypeName = "char")]
        public string? Name { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "char")]

        public string? Email { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Phone number", TypeName = "char")]
        public string? Mobile { get; set; }

        [Required]
        [StringLength(20)]
        public string? Password { get; set; }

    }
}
