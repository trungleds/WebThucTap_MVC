using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebLtic.Models
{
    public class BangGiaVanTai
    {
        [Key] 
        public long ID { get; set; }

        [StringLength(250)]
        public string TenTuyenDuong { get; set; }

        [StringLength(50)]
        public string TenHangHoa { get; set; }

        [StringLength(50)]
        public string DVT { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? DonGia { get; set; }

        [StringLength(250)]
        public string DienDan { get; set; }

        [StringLength(50)]
        public string ChiNhanh { get; set; }


        [Required(ErrorMessage = "Yêu cầu nhập ngày")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? NgayTao { get; set; }
    }
}