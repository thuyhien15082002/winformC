using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("Categorys")]
    public class Category
    {
        [Key]
        [Column("Category_ID")]
        [MaxLength(255)] // Đặt độ dài tối đa của chuỗi
        public string CategoryID { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Category_Name")]
        public string CategoryName { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Description")]
        public string Description { get; set; }
    }
}
