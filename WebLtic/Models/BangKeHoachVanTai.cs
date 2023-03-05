using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebLtic.Models
{
    public class BangKeHoachVanTai
    {
        [Key]
        public long ID { get; set; }


        [Required(ErrorMessage = "Yêu cầu nhập ngày")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? NgayLapKH { get; set; }

        [StringLength(50)]
        public string KhachHang { get; set; }


        [Required(ErrorMessage = "Yêu cầu nhập ngày")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? NgayNhan { get; set; }

        [StringLength(150)]
        public string NoiNhanHang { get; set; }


        [Required(ErrorMessage = "Yêu cầu nhập ngày")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? NgayGiaoHang { get; set; }

        [StringLength(150)]
        public string NoiGiaoHang { get; set; }

        [StringLength(150)]
        public string TenHang { get; set; }

        [StringLength(50)]
        public string DVT { get; set; }

        [StringLength(50)]
        public string SoLuong { get; set; }

        public decimal? DonGia { get; set; }

        public decimal? ThanhTien { get; set; }

        public decimal? TienDaGiao { get; set; }

        public decimal? TienThieu { get; set; }

        [StringLength(250)]
        public string DienDan { get; set; }

        public bool? TinhTrang { get; set; }

        public decimal? ThanhToan { get; set; }

        public decimal? TongBX { get; set; }

        public decimal? PhiPhatSinh { get; set; }

        [StringLength(10)]
        public string TongPhi { get; set; }

        [StringLength(50)]
        public string BienSoXe { get; set; }

        [StringLength(50)]
        public string ChuHang { get; set; }


        [Required(ErrorMessage = "Yêu cầu nhập ngày")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        public string NguoiTao { get; set; }
    }
}