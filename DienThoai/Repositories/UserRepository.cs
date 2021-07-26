using System.Collections.Generic;
using System.Linq;
using DienThoai.Data;
using DienThoai.Models;
using Microsoft.EntityFrameworkCore;

namespace DienThoai.Repositories
{
    public class UserRepository  : IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<User> GetAllUser()
        {
            return _appDbContext.User.Include(c => c.KhachHang).ToList();
        }
        public User GetUserById(string UserID)
        {
            return _appDbContext.User.FirstOrDefault(p => p.UserID == UserID);
        }
    }
}