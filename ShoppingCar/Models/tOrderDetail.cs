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
        [DisplayName("�q��s��")]
      
        public string OrderGuid { get; set; }

        [StringLength(50)]
        [DisplayName("�|���b��")]
        public string UserId { get; set; }

        [StringLength(50)]
        [DisplayName("���~�s��")]
        public string Pid { get; set; }

        [StringLength(50)]
        [DisplayName("�~�W")]
        public string Name { get; set; }

        [DisplayName("���")]
        public int? Price { get; set; }

        [DisplayName("�q�ʼƶq")]
        public int? Qty { get; set; }

        [StringLength(10)]
        [DisplayName("�O�_���q��")]
        public string flsQpproved { get; set; }
    }
}
