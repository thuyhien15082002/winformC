using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Column("User_ID")]
        [MaxLength(255)] // Đặt độ dài tối đa của chuỗi
        public string UserID { get; set; }

        [Required]
        [StringLength(100)]
        [Column("User_Name")]
        public string UserName { get; set; }

        [Required]
        [MaxLength(255)] // Đặt độ dài tối đa của chuỗi
        [Column("Password")]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Role")]
        public string Role { get; set; }
    }
}
