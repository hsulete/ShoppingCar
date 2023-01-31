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
        [DisplayName("�q��s��")]
        public string OrderGuid { get; set; }

        [StringLength(50)]
        [DisplayName("�|���b��")]
        public string UserId { get; set; }

        [StringLength(50)]
        [DisplayName("����H�m�W")]
        [Required]
        public string Receiver { get; set; }

        [StringLength(50)]
        [DisplayName("����H�H�c")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(100)]
        [DisplayName("����H�a�}")]
        [Required]
        public string Address { get; set; }

        [DisplayName("�q����")]
        public DateTime Date { get; set; }
    }
}
