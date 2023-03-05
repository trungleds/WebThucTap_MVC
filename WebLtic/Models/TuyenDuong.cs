using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Web;

namespace WebLtic.Models
{
    public class TuyenDuong
    {
        [Key]
        public long ID { get; set; }

        [StringLength(50)]
        public string MaTuyen { get; set; }

        [StringLength(250)]
        public string TenTuyenDuong { get; set; }

        [StringLength(50)]
        public string NoiDi { get; set; }

        [StringLength(50)]
        public string NoiDen { get; set; }

        [StringLength(50)]
        public string DauDM { get; set; }

        [StringLength(50)]
        public string ChieuDai { get; set; }

        [StringLength(250)]
        public string DienDan { get; set; }
    }
}