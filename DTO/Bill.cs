using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("Bills")]
    public class Bill
    {
        [Key]
        [Column("Bill_ID")]
        [MaxLength(255)] // Đặt độ dài tối đa của chuỗi
        public string BillID { get; set; }

        [Column("User_ID")]
        [ForeignKey("User")]
        [MaxLength(255)] // Đặt độ dài tối đa của chuỗi
        public string UserID { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }

        [Column("Account_ID")]
        [ForeignKey("Account")]
        [MaxLength(255)] // Đặt độ dài tối đa của chuỗi
        public string AccountID { get; set; }

        [ForeignKey("AccountID")]
        public Account Account { get; set; }

        [Column("Date")]
        public DateTime Date { get; set; }

        [Column("Status")]
        public string Status { get; set; }

        [Column("Total_Amount")]
        public decimal TotalAmount { get; set; }

        [StringLength(255)]
        [Column("Note")]
        public string Note { get; set; }

        [Column("Discount")]
        public decimal Discount { get; set; }
    }
}
