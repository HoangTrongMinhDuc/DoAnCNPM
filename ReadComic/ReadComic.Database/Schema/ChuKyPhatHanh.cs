﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReadComic.DataBase.Schema
{
    [Table("ChuKyPhatHanh")]
    public class ChuKyPhatHanh : TableHaveIdInt
    {
        public ChuKyPhatHanh()
        {
            Truyens = new HashSet<Truyen>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string TenChuKy { get; set; }

        public ICollection<Truyen> Truyens { get; set; }
    }
}