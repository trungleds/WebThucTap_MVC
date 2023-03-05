using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebLtic.Models
{
    public class HangHoa
    {
        [Key]
        public long ID { get; set; }

        public bool HienThi { get; set; }

        [StringLength(50)]
        public string TenHangHoa { get; set; }

        [StringLength(50)]
        public string LoaiHangHoa { get; set; }
    }
}