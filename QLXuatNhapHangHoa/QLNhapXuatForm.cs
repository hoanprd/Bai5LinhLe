using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLXuatNhapHangHoa.DB;

namespace QLXuatNhapHangHoa
{
    public partial class QLNhapXuatForm : Form
    {
        private int pageNumber = 1;
        private int numberRecord = 5;
        private int maxPage = 0;
        private int tongNhap = 0, tongXuat = 0;
        private int gridIndex = 1;

        DataGridViewRow r;
        private QLXNHHDatabaseDataContext db;

        public QLNhapXuatForm()
        {
            InitializeComponent();
        }

        private void QLNhapXuatForm_Load(object sender, EventArgs e)
        {
            db = new QLXNHHDatabaseDataContext();
            ShowData();
        }

        private void ShowData()
        {
            var rs = from chiTiet in db.PhieuNhap_ChiTiets
                        join phieuNhap in db.PhieuNhaps on chiTiet.MSPN equals phieuNhap.MSPN
                        join hangHoa in db.HangHoas on chiTiet.MSHH equals hangHoa.MSHH
                        select new
                        {
                            phieuNhap.NgayNhap,
                            chiTiet.SoLuong,
                            hangHoa.MSHH,
                            hangHoa.TenHH
                        };

            var rs2 = from chiTiet in db.PhieuXuat_ChiTiets
                     join phieuXuat in db.PhieuXuats on chiTiet.MSPX equals phieuXuat.MSPX
                     join hangHoa in db.HangHoas on chiTiet.MSHH equals hangHoa.MSHH
                     select new
                     {
                         phieuXuat.NgayXuat,
                         chiTiet.SoLuong,
                         hangHoa.MSHH,
                         hangHoa.TenHH
                     };

            int i = 0;

            if (rs != null)
            {
                foreach (var d in rs)
                {
                    i++;
                    tongNhap += d.SoLuong;
                }
            }

            if (rs2 != null)
            {
                foreach (var d in rs2)
                {
                    tongXuat += d.SoLuong;
                }
            }
            double t = i;
            double r = Math.Ceiling(t / 5);
            maxPage = (int)r;

            pageNumber = 1;
            dgvNhap.DataSource = rs.Skip((pageNumber - 1) * numberRecord).Take(numberRecord).ToList();
            dgvXuat.DataSource = rs2.Skip((pageNumber - 1) * numberRecord).Take(numberRecord).ToList();
            lblPage.Text = pageNumber.ToString() + "/" + maxPage.ToString();

            txtMaHangHoa.DataBindings.Add("Text", dgvNhap.DataSource, "MSHH");
            txtTenHangHoa.DataBindings.Add("Text", dgvNhap.DataSource, "TenHH");

            dgvNhap.Columns["MSHH"].Visible = false;
            dgvNhap.Columns["TenHH"].Visible = false;

            dgvXuat.Columns["MSHH"].Visible = false;
            dgvXuat.Columns["TenHH"].Visible = false;

            dgvNhap.Columns["NgayNhap"].Width = 80;
            dgvNhap.Columns["SoLuong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvXuat.Columns["NgayXuat"].Width = 80;
            dgvXuat.Columns["SoLuong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            if (pageNumber < maxPage)
            {
                pageNumber++;
            }
            DataUpdate();
            lblPage.Text = pageNumber.ToString() + "/" + maxPage.ToString();
        }

        private void btnRF_Click(object sender, EventArgs e)
        {
            pageNumber = maxPage;
            DataUpdate();
            lblPage.Text = pageNumber.ToString() + "/" + maxPage.ToString();
            MessageBox.Show("Đã là mẫu tin cuối cùng", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            if (pageNumber > 1)
            {
                pageNumber--;
            }
            DataUpdate();
            lblPage.Text = pageNumber.ToString() + "/" + maxPage.ToString();
        }

        private void btnLF_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            DataUpdate();
            lblPage.Text = pageNumber.ToString() + "/" + maxPage.ToString();
            MessageBox.Show("Đã là mẫu tin đầu tiên", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DataUpdate()
        {
            txtMaHangHoa.Text = null;
            txtTenHangHoa.Text = null;

            var rs = from chiTiet in db.PhieuNhap_ChiTiets
                     join phieuNhap in db.PhieuNhaps on chiTiet.MSPN equals phieuNhap.MSPN
                     join hangHoa in db.HangHoas on chiTiet.MSHH equals hangHoa.MSHH
                     select new
                     {
                         phieuNhap.NgayNhap,
                         chiTiet.SoLuong,
                         hangHoa.MSHH,
                         hangHoa.TenHH
                     };
            var rs2 = from chiTiet in db.PhieuXuat_ChiTiets
                      join phieuXuat in db.PhieuXuats on chiTiet.MSPX equals phieuXuat.MSPX
                      join hangHoa in db.HangHoas on chiTiet.MSHH equals hangHoa.MSHH
                      select new
                      {
                          phieuXuat.NgayXuat,
                          chiTiet.SoLuong,
                          hangHoa.MSHH,
                          hangHoa.TenHH
                      };
            dgvNhap.DataSource = rs.Skip((1 - 1) * numberRecord).Take(numberRecord).ToList();
            dgvXuat.DataSource = rs2.Skip((1 - 1) * numberRecord).Take(numberRecord).ToList();

            if (gridIndex == 1)
            {
                int i = 0;
                if (rs != null)
                {
                    foreach (var d in rs)
                    {
                        i++;
                    }
                }
                double t = i;
                double r = Math.Ceiling(t / 5);
                maxPage = (int)r;

                lblPage.Text = pageNumber.ToString() + "/" + maxPage.ToString();
            }
            else
            {
                int i = 0;
                if (rs2 != null)
                {
                    foreach (var d in rs)
                    {
                        i++;
                    }
                }
                double t = i;
                double r = Math.Ceiling(t / 5);
                maxPage = (int)r;

                lblPage.Text = pageNumber.ToString() + "/" + maxPage.ToString();
            }
        }

        private void dgvXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                gridIndex = 2;

                r = dgvXuat.Rows[e.RowIndex];

                txtMaHangHoa.Text = r.Cells["MSHH"].Value.ToString();
                txtTenHangHoa.Text = r.Cells["TenHH"].Value.ToString();

                txtTongXuat.Text = tongXuat.ToString();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTim.Text.Trim().ToLower();

            if (chbMaSoHangHoa.Checked)
            {
                var rsNhap = from chiTiet in db.PhieuNhap_ChiTiets
                             join phieuNhap in db.PhieuNhaps on chiTiet.MSPN equals phieuNhap.MSPN
                             join hangHoa in db.HangHoas on chiTiet.MSHH equals hangHoa.MSHH
                             where hangHoa.MSHH.ToLower().Contains(tuKhoa)
                             select new
                             {
                                 phieuNhap.NgayNhap,
                                 chiTiet.SoLuong,
                                 hangHoa.MSHH,
                                 hangHoa.TenHH
                             };

                var rsXuat = from chiTiet in db.PhieuXuat_ChiTiets
                             join phieuXuat in db.PhieuXuats on chiTiet.MSPX equals phieuXuat.MSPX
                             join hangHoa in db.HangHoas on chiTiet.MSHH equals hangHoa.MSHH
                             where hangHoa.MSHH.ToLower().Contains(tuKhoa)
                             select new
                             {
                                 phieuXuat.NgayXuat,
                                 chiTiet.SoLuong,
                                 hangHoa.MSHH,
                                 hangHoa.TenHH
                             };

                // Hiển thị kết quả tìm kiếm trên DataGridView
                dgvNhap.DataSource = rsNhap.ToList();
                dgvXuat.DataSource = rsXuat.ToList();

                r = dgvNhap.Rows[0];
                if (r != null)
                {
                    txtMaHangHoa.Text = r.Cells["MSHH"].Value.ToString();
                    txtTenHangHoa.Text = r.Cells["TenHH"].Value.ToString();
                }
                else
                {
                    r = dgvXuat.Rows[0];

                    if (r != null)
                    {
                        txtMaHangHoa.Text = r.Cells["MSHH"].Value.ToString();
                        txtTenHangHoa.Text = r.Cells["TenHH"].Value.ToString();
                    }
                }
            }
            else if (chbTenHangHoa.Checked)
            {
                var rsNhap = from chiTiet in db.PhieuNhap_ChiTiets
                             join phieuNhap in db.PhieuNhaps on chiTiet.MSPN equals phieuNhap.MSPN
                             join hangHoa in db.HangHoas on chiTiet.MSHH equals hangHoa.MSHH
                             where hangHoa.TenHH.ToLower().Contains(tuKhoa)
                             select new
                             {
                                 phieuNhap.NgayNhap,
                                 chiTiet.SoLuong,
                                 hangHoa.MSHH,
                                 hangHoa.TenHH
                             };

                var rsXuat = from chiTiet in db.PhieuXuat_ChiTiets
                             join phieuXuat in db.PhieuXuats on chiTiet.MSPX equals phieuXuat.MSPX
                             join hangHoa in db.HangHoas on chiTiet.MSHH equals hangHoa.MSHH
                             where hangHoa.TenHH.ToLower().Contains(tuKhoa)
                             select new
                             {
                                 phieuXuat.NgayXuat,
                                 chiTiet.SoLuong,
                                 hangHoa.MSHH,
                                 hangHoa.TenHH
                             };

                // Hiển thị kết quả tìm kiếm trên DataGridView
                dgvNhap.DataSource = rsNhap.ToList();
                dgvXuat.DataSource = rsXuat.ToList();

                r = dgvNhap.Rows[0];
                if (r != null)
                {
                    txtMaHangHoa.Text = r.Cells["MSHH"].Value.ToString();
                    txtTenHangHoa.Text = r.Cells["TenHH"].Value.ToString();
                }
                else
                {
                    r = dgvXuat.Rows[0];

                    if (r != null)
                    {
                        txtMaHangHoa.Text = r.Cells["MSHH"].Value.ToString();
                        txtTenHangHoa.Text = r.Cells["TenHH"].Value.ToString();
                    }
                }
            }
        }

        private void chbMaSoHangHoa_CheckedChanged(object sender, EventArgs e)
        {
            chbTenHangHoa.Checked = false;
        }

        private void chbTenHangHoa_CheckedChanged(object sender, EventArgs e)
        {
            chbMaSoHangHoa.Checked = false;
        }

        private void dgvNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                gridIndex = 1;

                r = dgvNhap.Rows[e.RowIndex];

                txtMaHangHoa.Text = r.Cells["MSHH"].Value.ToString();
                txtTenHangHoa.Text = r.Cells["TenHH"].Value.ToString();

                txtTongNhap.Text = tongNhap.ToString();
            }
        }
    }
}
