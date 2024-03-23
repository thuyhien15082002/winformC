using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [Column("Product_ID")]
        [MaxLength(255)] // Đặt độ dài tối đa của chuỗi
        public string ProductID { get; set; }

        [Required]
        [StringLength(100)]
        [Column("Product_Name")]
        public string ProductName { get; set; }

        [Column("Category_ID")]
        [ForeignKey("Category")]
        [MaxLength(255)] // Đặt độ dài tối đa của chuỗi
        public string CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public Category Category { get; set; }

        [Column("Input_Price")]
        public decimal InputPrice { get; set; }

        [Column("Output_Price")]
        public decimal OutputPrice { get; set; }

        [StringLength(100)]
        [Column("Status")]
        public string Status { get; set; }

        [Column("Input_Date")]
        public DateTime InputDate { get; set; }

        [Column("Quantity")]
        public int Quantity { get; set; }

        [Column("Sell")]
        public int Sell { get; set; }

        [StringLength(100)]
        [Column("Material")]
        public string Material { get; set; }

        [StringLength(100)]
        [Column("Origin")]
        public string Origin { get; set; }

        [StringLength(255)]
        [Column("Image")]
        public string Image { get; set; }
    }
}
