using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebLtic.Models
{
    public class KhachHang
    {
        [Key]
        public long ID { get; set; }

        [StringLength(250)]
        public string DoiTac { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string DienThoai { get; set; }

        public decimal? NoBanDau { get; set; }

        [StringLength(250)]
        public string KhuVuc { get; set; }

        [StringLength(50)]
        public string LoaiDoiTac { get; set; }

        [StringLength(50)]
        public string CCCD { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }
    }
}