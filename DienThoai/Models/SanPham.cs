using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DienThoai.Models
{
    public class SanPham
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string ID { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string TenSanPham { get; set; }
        [ForeignKey ("IDHang")]
        public string IDHang { get; set; }

        public decimal Gia { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ImageName { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
        public string MoTa { get; set; }
        public int SoLuong { get; set; } 
        public string KichThuoc { get; set; }
        public string Ram { get; set; }
        public string CPU { get; set; }
    }
}
