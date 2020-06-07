using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
   public  class SanPhamDAO
    {
        
        DataProvider con = new DataProvider();
        public List<SanPhamDTO>LayDSSP()
        {
            List<SanPhamDTO> SanPhams = new List<SanPhamDTO>();// Tao List
            con.Ketnoi();
            String Query = "SELECT sp.MaSanPham, sp.TenSanPham, sp.LoaiSanPham, sp.GiaGoc, sp.GiaBan, sp.SoLuongTon, sp.BaoHanh, sp.KhuyenMai,sp.MaNCC, sp.XuatXu, pn.NgayNhap FROM SanPham sp, PhieuNhap pn WHERE sp.MaNCC = pn.MaNCC";
            SqlDataReader reader = con.getdata(Query);
            while(reader.Read())
            {
                SanPhamDTO SP = new SanPhamDTO();
                SP.MaSP = reader.GetString(0);
                SP.TenSP = reader.GetString(1);
                SP.LoaiSP = reader.GetString(2);
                SP.GiaGoc = Math.Round(reader.GetDecimal(3));
                SP.GiaBan = Math.Round(reader.GetDecimal(4));
                SP.SLT = reader.GetInt32(5);
                SP.BaoHanh = reader.GetDateTime(6);
                SP.KM = reader.GetInt32(7);
                SP.MaNCC = reader.GetString(8);
                //SP.TrangThai = reader.GetInt32(9);
                SP.XuatXu = reader.GetString(9);
                SP.NgayNhap = reader.GetDateTime(10);
                SanPhams.Add(SP);

            }
            con.Ngatketnoi();
            return SanPhams;
        }
    }
}
