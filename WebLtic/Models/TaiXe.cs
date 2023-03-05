using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebLtic.Models
{
    public class TaiXe
    {
        [Key]
        public long ID { get; set; }
        public bool HienThi { get; set; }

        [StringLength(250)]
        public string HoTen { get; set; }
  
        [StringLength(50)]
        public string BienSoXe { get; set; }

        [StringLength(50)]
        public string DienThoai { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập ngày")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? NamSinh { get; set; }

        [StringLength(50)]
        public string CCCD { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập ngày")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? NgayCap { get; set; }

        [StringLength(250)]
        public string NoiCap { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }

        [DisplayFormat(DataFormatString ="{0:C}")]
        public decimal? LuongCB { get; set; }

        [StringLength(250)]
        public string GiayTo { get; set; }

        [StringLength(250)]
        public string DienDan { get; set; }
    }
}