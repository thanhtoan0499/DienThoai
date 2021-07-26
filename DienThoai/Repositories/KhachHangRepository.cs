using System.Collections.Generic;
using DienThoai.Data;
using DienThoai.Models;

namespace DienThoai.Repositories
{
    public class KhachHangRepository : IKhachHangRepository
    {
        private AppDbContext _appDbContext;
        public KhachHangRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<KhachHang> GetAllKhachHang => _appDbContext.KhachHang;
    }
}