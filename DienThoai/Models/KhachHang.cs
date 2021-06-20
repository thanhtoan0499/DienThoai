using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DienThoai.Models
{
    public class KhachHang
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string IDKhachHang { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        public string NameKH { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        [RegularExpression(@"^[0]+[0-9]*$")]
        [StringLength(maximumLength:10, MinimumLength=10)]
        public string SDTKH { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập trường này")]
        [EmailAddress(ErrorMessage ="Vui lòng nhập đúng định dạng Email")]
        public string EmailKH { get; set; }
    }
}
