using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyBanHang.Data
{
    public class SanPham
    {
        public int ID { get; set; } 
        public int HangSanXuatID { get; set; }
        public int LoaiSanXuatID { get; set; }

        public string TenSanPham { get; set; }
        public int DonGia{ get; set; }
        public int SoLuong {  get; set; }
        public string? Mota {  get; set; }

        public virtual ObservableCollectionListSource<HoaDon_ChiTiet> HoaDon_ChiTiet { get; } = new();
        public virtual LoaiSanPham LoaiSanPham { get; set; } = null!;
        public virtual HangSanXuat HangSanXuat { get; set; } = null!;
    }
}
