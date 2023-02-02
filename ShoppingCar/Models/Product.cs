namespace ShoppingCar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.ComponentModel;
    using System.Drawing;

    [Table("Product")]
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        [DisplayName("產品編號")]
        public string PId { get; set; }

        [StringLength(50)]
        [DisplayName("品名")]
        public string Name { get; set; }

        [DisplayName("單價")]
        public int? Price { get; set; }

        [StringLength(50)]
        [DisplayName("圖示")]
        public string Img { get; set; }
    }
}
