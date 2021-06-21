using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DienThoai.Models;

namespace DienThoai.Data
{
    public class AppDbContext : IdentityDbContext
    {
        private readonly DbContextOptions _options;

        public AppDbContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }
        public DbSet<User> User { get; set; }
        public DbSet<Hang> Hang { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
   

}
