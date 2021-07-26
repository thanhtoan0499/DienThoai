using System.Collections.Generic;
using DienThoai.Models;

namespace DienThoai.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUser();
        User GetUserById(string UserID);
    }
}