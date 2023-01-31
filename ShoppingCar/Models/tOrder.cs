namespace ShoppingCar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.ComponentModel;

    [Table("tOrder")]
    public partial class tOrder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        [DisplayName("訂單編號")]
        public string OrderGuid { get; set; }

        [StringLength(50)]
        [DisplayName("會員帳號")]
        public string UserId { get; set; }

        [StringLength(50)]
        [DisplayName("收件人姓名")]
        [Required]
        public string Receiver { get; set; }

        [StringLength(50)]
        [DisplayName("收件人信箱")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(100)]
        [DisplayName("收件人地址")]
        [Required]
        public string Address { get; set; }

        [DisplayName("訂單日期")]
        public DateTime Date { get; set; }
    }
}
