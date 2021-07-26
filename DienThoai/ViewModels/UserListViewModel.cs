using System.Collections.Generic;
using DienThoai.Models;

namespace DienThoai.ViewModels
{
    public class UserListViewModel
    {
        public IEnumerable<User> User { get; set; }
    }
}