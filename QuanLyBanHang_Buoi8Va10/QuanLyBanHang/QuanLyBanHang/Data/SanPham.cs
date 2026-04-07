using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Data
{
    internal class SanPham
    {
        public int ID { get; set; }
        public int HangSanXuatID { get; set; }
        [NotMapped]
        public string TenHangSanXuat { get; set; } = string.Empty;
        public int LoaiSanPhamID { get; set; }
        [NotMapped]
        public string TenLoai { get; set; } = string.Empty;
        public string TenSanPham { get; set; } = string.Empty;
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public string? HinhAnh { get; set; }
        public string? MoTa { get; set; }
        public virtual ObservableCollectionListSource<HoaDon_ChiTiet> HoaDon_ChiTiet { get; } = new();
        public virtual LoaiSanPham LoaiSanPham { get; set; } = null!;
        public virtual HangSanXuat HangSanXuat { get; set; } = null!;
    }

    [NotMapped]
    public class DanhSachSanPham
    {
        public int ID { get; set; }
        public int HangSanXuatID { get; set; }
        [NotMapped]
        public string TenHangSanXuat { get; set; } = string.Empty; // Thêm 
        public int LoaiSanPhamID { get; set; }
        [NotMapped]
        public string TenLoai { get; set; } = string.Empty;       // Thêm 
        public string TenSanPham { get; set; } = string.Empty;
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public string? HinhAnh { get; set; }
        public string? MoTa { get; set; }
    }

}
