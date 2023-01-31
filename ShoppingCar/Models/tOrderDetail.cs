namespace ShoppingCar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.ComponentModel;

    [Table("tOrderDetail")]
    public partial class tOrderDetail
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
        [DisplayName("產品編號")]
        public string Pid { get; set; }

        [StringLength(50)]
        [DisplayName("品名")]
        public string Name { get; set; }

        [DisplayName("單價")]
        public int? Price { get; set; }

        [DisplayName("訂購數量")]
        public int? Qty { get; set; }

        [StringLength(10)]
        [DisplayName("是否為訂單")]
        public string flsQpproved { get; set; }
    }
}
