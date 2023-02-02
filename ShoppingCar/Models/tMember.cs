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
        //None表示不處理 Identity表示自行增加

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }

       
        [DisplayName("帳號")]
        [Required]
        [StringLength(50)]
        public string Userid { get; set; }

        [StringLength(50)]
        [DisplayName("密碼")]
        [Required]
        public string Pwd { get; set; }

        [StringLength(50)]
        [DisplayName("姓名")]
        [Required]
        public string Name { get; set; }

        [StringLength(50)]
        [DisplayName("信箱")]
        [Required]
        public string Email { get; set; }
    }
}
