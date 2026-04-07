using System.Configuration;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyBanHang.Data
{
    internal class QLBHDbContext : DbContext
    {
        public DbSet<LoaiSanPham> LoaiSanPham { get; set; } = null!;
        public DbSet<HangSanXuat> HangSanXuat { get; set; } = null!;
        public DbSet<SanPham> SanPham { get; set; } = null!;
        public DbSet<NhanVien> NhanVien { get; set; } = null!;
        public DbSet<KhachHang> KhachHang { get; set; } = null!;
        public DbSet<HoaDon> HoaDon { get; set; } = null!;
        public DbSet<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=QLBH;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            }
        }
    }
}
