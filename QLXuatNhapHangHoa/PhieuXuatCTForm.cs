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
    public partial class PhieuXuatCTForm : Form
    {
        DataGridViewRow r;
        private QLXNHHDatabaseDataContext db;

        public PhieuXuatCTForm()
        {
            InitializeComponent();
        }

        private void PhieuXuatCTForm_Load(object sender, EventArgs e)
        {
            db = new QLXNHHDatabaseDataContext();
            ShowData();

            dgvMain.Columns["MSPX"].Width = 100;
            dgvMain.Columns["MSHH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMain.Columns["SoLuong"].Width = 100;
        }

        private void ShowData()
        {
            var rs = from s in db.PhieuXuat_ChiTiets
                     select new
                     {
                         s.MSPX,
                         s.MSHH,
                         s.SoLuong
                     };
            dgvMain.DataSource = rs;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvMain.Rows[e.RowIndex];

                txtMaPhieuXuat.Text = r.Cells["MSPX"].Value.ToString();
                txtMaHangHoa.Text = r.Cells["MSHH"].Value.ToString();
                txtSoLuong.Text = r.Cells["SoLuong"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaPhieuXuat.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã phiếu xuất!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaPhieuXuat.Select();
                    return;
                }
                if (string.IsNullOrEmpty(txtMaHangHoa.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã số hàng hóa!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaHangHoa.Select();
                    return;
                }
                if (string.IsNullOrEmpty(txtSoLuong.Text))
                {
                    MessageBox.Show("Vui lòng nhập số lượng!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoLuong.Select();
                    return;
                }

                PhieuXuat_ChiTiet l = new PhieuXuat_ChiTiet();
                l.MSPX = txtMaPhieuXuat.Text;
                l.MSHH = txtMaHangHoa.Text;
                l.SoLuong = Int32.Parse(txtSoLuong.Text);
                db.PhieuXuat_ChiTiets.InsertOnSubmit(l);
                try
                {
                    db.SubmitChanges();
                    ShowData();
                    MessageBox.Show("Thêm phiếu xuất chi tiết thành công", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    db.PhieuXuat_ChiTiets.DeleteOnSubmit(l);
                    ShowData();
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            ResetField();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn chi tiết phiếu xuất!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var l = db.PhieuXuat_ChiTiets.Where(x => x.MSPX == r.Cells["MSPX"].Value.ToString() && x.MSHH == r.Cells["MSHH"].Value.ToString()).FirstOrDefault();
                db.PhieuXuat_ChiTiets.DeleteOnSubmit(l);
                db.SubmitChanges();
                PhieuXuat_ChiTiet l2 = new PhieuXuat_ChiTiet();
                l2.MSPX = txtMaPhieuXuat.Text;
                l2.MSHH = txtMaHangHoa.Text;
                l2.SoLuong = Int32.Parse(txtSoLuong.Text);
                db.PhieuXuat_ChiTiets.InsertOnSubmit(l2);
                try
                {
                    db.SubmitChanges();
                    ShowData();
                    MessageBox.Show("Sửa chi tiết phiếu xuất thành công", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    db.PhieuXuat_ChiTiets.DeleteOnSubmit(l2);
                    ShowData();
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            ResetField();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn chi tiết phiếu xuất!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (
                MessageBox.Show("Bạn thực sự muốn xóa chi tiết phiếu xuất mã " + r.Cells["MSPX"].Value.ToString() + " ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {
                    var l = db.PhieuXuat_ChiTiets.Where(x => x.MSPX == r.Cells["MSPX"].Value.ToString() && x.MSHH == r.Cells["MSHH"].Value.ToString()).FirstOrDefault();
                    db.PhieuXuat_ChiTiets.DeleteOnSubmit(l);
                    db.SubmitChanges();
                    ShowData();
                    MessageBox.Show("Xóa thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                ResetField();
            }
        }

        private void ResetField()
        {
            r = null;
            txtMaPhieuXuat.Text = null;
            txtMaHangHoa.Text = null;
            txtSoLuong.Text = null;
        }
    }
}
