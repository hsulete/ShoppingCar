namespace ShoppingCar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.ComponentModel;

    [Table("tMember")]
    public partial class tMember
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

       
        [DisplayName("±b¸¹")]
        [Required]
        [StringLength(50)]
        public string Userid { get; set; }

        [StringLength(50)]
        [DisplayName("±K½X")]
        [Required]
        public string Pwd { get; set; }

        [StringLength(50)]
        [DisplayName("©m¦W")]
        [Required]
        public string Name { get; set; }

        [StringLength(50)]
        [DisplayName("«H½c")]
        [Required]
        public string Email { get; set; }
    }
}
