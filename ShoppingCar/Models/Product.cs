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
        [DisplayName("���~�s��")]
        public string PId { get; set; }

        [StringLength(50)]
        [DisplayName("�~�W")]
        public string Name { get; set; }

        [DisplayName("���")]
        public int? Price { get; set; }

        [StringLength(50)]
        [DisplayName("�ϥ�")]
        public string Img { get; set; }
    }
}
