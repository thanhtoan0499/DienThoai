using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DienThoai.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string IDUser { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string TenUser { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string TenDangNhap { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống")]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; }
    }
}
