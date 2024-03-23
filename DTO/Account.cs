using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        [Column("Account_ID")]
        [MaxLength(255)] // Đặt độ dài tối đa của chuỗi
        public string AccountID { get; set; }

        [Required]
        [StringLength(100)]
        [Column("Account_Name")]
        public string AccountName { get; set; }

        [StringLength(15)] // Assuming a standard phone number length
        [Column("Phone")]
        [MaxLength(15)] // Đặt độ dài tối đa của chuỗi
        public string Phone { get; set; }

        [StringLength(10)] // Assuming 'Male', 'Female', or other values
        [Column("Gender")]
        [MaxLength(10)] // Đặt độ dài tối đa của chuỗi
        public string Gender { get; set; }

        [Column("Date_of_Birth")]
        public DateTime? DateOfBirth { get; set; }
    }
}
