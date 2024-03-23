using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("Detail_Orders")]
    public class DetailOrder
    {
        [Key]
        [Column("Detail_Order_ID")]
        [MaxLength(255)] // Đặt độ dài tối đa của chuỗi
        public string DetailOrderID { get; set; }

        [Column("Product_ID")]
        [ForeignKey("Product")]
        [MaxLength(255)] // Đặt độ dài tối đa của chuỗi
        public string ProductID { get; set; }

        [ForeignKey("ProductID")]
        public Product Product { get; set; }

        [Column("Bill_ID")]
        [ForeignKey("Bill")]
        [MaxLength(255)] // Đặt độ dài tối đa của chuỗi
        public string BillID { get; set; }

        [ForeignKey("BillID")]
        public Bill Bill { get; set; }

        [Column("Quantity")]
        public int Quantity { get; set; }

        [Column("Output_Price")]
        public decimal OutputPrice { get; set; }
    }
}
