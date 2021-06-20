using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DienThoai.Models
{
    public class Hang
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string IDHang { get; set; }
        [Required(ErrorMessage ="Vui lòng điền trường này")]
        public string TenHang { get; set; }

    }
}
