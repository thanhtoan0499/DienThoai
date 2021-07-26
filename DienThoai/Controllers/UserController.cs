using DienThoai.Repositories;
using DienThoai.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DienThoai.UserController 
{
    public class UserController : Controller
    {
    private readonly IUserRepository _userRepository;
    private readonly IKhachHangRepository _khachhangRepository;
    public UserController(IKhachHangRepository khachHangRepository, IUserRepository userRepository)
    {
        _khachhangRepository = khachHangRepository;
        _userRepository = userRepository;
    }
    public IActionResult List()
    {
        var userListViewModel = new UserListViewModel();
        userListViewModel.User = _userRepository.GetAllUser();
        return View(userListViewModel);
    }
    }
    
    
}