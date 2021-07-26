using System.Collections.Generic;
using DienThoai.Models;

namespace DienThoai.Repositories
{
    public interface IKhachHangRepository
    {
        IEnumerable<KhachHang> GetAllKhachHang();
    }
}