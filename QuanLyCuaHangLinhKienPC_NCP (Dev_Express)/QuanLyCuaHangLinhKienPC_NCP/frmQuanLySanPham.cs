using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using Bunifu;
namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmQuanLySanPham : Form
    {
        public frmQuanLySanPham()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            btnCapNhat.Visible = false;
            btnLuuCapNhat.Visible = true;
            txtTenSP.Enabled = true;
            dtpNgayNhap.Enabled = true;
            cboLoai.Enabled = true;
            numericSoLuong.Enabled = true;
            txtGiaGoc.Enabled = true;
            txtGiaBan.Enabled = true;
            dtpBaoHanh.Enabled = true;
            numericKhuyenMai.Enabled = true;
            cboXuatXu.Enabled = true;
            txtTenSP.Focus();
        }

        private void btnLuuCapNhat_Click(object sender, EventArgs e)
        {
            btnCapNhat.Visible = true;
            btnLuuCapNhat.Visible = false;
            txtTenSP.Enabled = false;
            dtpNgayNhap.Enabled = false;
            cboLoai.Enabled = false;
            numericSoLuong.Enabled = false;
            txtGiaGoc.Enabled = false;
            txtGiaBan.Enabled = false;
            numericKhuyenMai.Enabled = false;
            cboXuatXu.Enabled = false;
            dtpBaoHanh.Enabled = false;
            txtTenSP.Focus();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang frmNH = new frmNhapHang();
            frmNH.ShowDialog();
        }

        private void frmQuanLySanPham_Load(object sender, EventArgs e)
        {
            SanPhamBUS SPBUS = new SanPhamBUS();
            dgvDanhSachSP.AutoGenerateColumns = false;
            dgvDanhSachSP.DataSource = SPBUS.LayDanhSachSanPham();
        }

        private void dgvDanhSachSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDanhSachSP.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                dgvDanhSachSP.CurrentRow.Selected = true;
                txtMaSP.Text = dgvDanhSachSP.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenSP.Text = dgvDanhSachSP.Rows[e.RowIndex].Cells[1].Value.ToString();
                cboLoai.Text = dgvDanhSachSP.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGiaGoc.Text = dgvDanhSachSP.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtGiaBan.Text = dgvDanhSachSP.Rows[e.RowIndex].Cells[4].Value.ToString();
                numericSoLuong.Text = dgvDanhSachSP.Rows[e.RowIndex].Cells[5].Value.ToString();
                dtpBaoHanh.Text = dgvDanhSachSP.Rows[e.RowIndex].Cells[6].Value.ToString();
                numericKhuyenMai.Text = dgvDanhSachSP.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtMaNCC.Text = dgvDanhSachSP.Rows[e.RowIndex].Cells[8].Value.ToString();
                cboXuatXu.Text = dgvDanhSachSP.Rows[e.RowIndex].Cells[9].Value.ToString();
                dtpNgayNhap.Text = dgvDanhSachSP.Rows[e.RowIndex].Cells[10].Value.ToString();



            }
        }
    }
}
