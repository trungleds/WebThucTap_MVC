using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebLtic.Models
{
    public class DanhSachXe
    {
        [Key]
        public long ID { get; set; }

        public bool HienThi { get; set; }

        [StringLength(50)]
        public string TenXe { get; set; }

        [StringLength(50)]
        public string BienSoXe { get; set; }

        [StringLength(50)]
        public string LoaiXe { get; set; }

        [StringLength(250)]
        public string ChuXe { get; set; }

        [StringLength(50)]
        public string TaiXe { get; set; }

        [StringLength(50)]
        public string MauSon { get; set; }

        [StringLength(50)]
        public string HangXe { get; set; }

        [StringLength(250)]
        public string GhiChu { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập ngày")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? NgayTao { get; set; }
    }
}