using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebLtic.Models
{
    public class ChuXe
    {
        [Key]
        public long ID { get; set; }

        [StringLength(250)]
        public string HoTen { get; set; }

        [StringLength(50)]
        public string DienThoai { get; set; }

        [StringLength(50)]
        public string CCCD { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }

        [StringLength(250)]
        public string DienDan { get; set; }
        public object Title { get; internal set; }
    }
}