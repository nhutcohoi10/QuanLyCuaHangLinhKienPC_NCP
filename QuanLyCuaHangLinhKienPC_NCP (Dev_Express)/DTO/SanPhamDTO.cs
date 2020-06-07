using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class SanPhamDTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string LoaiSP { get; set; }
        public decimal GiaGoc { get; set; }
        public decimal GiaBan { get; set; }
        public int SLT { get; set; }
        public DateTime BaoHanh { get; set; }
        public int KM { get; set; }
        public string MaNCC { get; set; }
        public int TrangThai { get; set; }
        public string XuatXu { get; set; }
        public DateTime NgayNhap { get; set; }
    }
}
