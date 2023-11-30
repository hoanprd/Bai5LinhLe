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
    public partial class PhieuXuatForm : Form
    {
        DataGridViewRow r;
        private QLXNHHDatabaseDataContext db;

        public PhieuXuatForm()
        {
            InitializeComponent();
        }

        private void PhieuXuatForm_Load(object sender, EventArgs e)
        {
            db = new QLXNHHDatabaseDataContext();
            ShowData();

            dgvMain.Columns["MSPX"].Width = 100;
            dgvMain.Columns["NgayXuat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ShowData()
        {
            var rs = from s in db.PhieuXuats
                     select new
                     {
                         s.MSPX,
                         s.NgayXuat
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
                dtpNgayXuat.Text = r.Cells["NgayXuat"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaPhieuXuat.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã số phiếu xuất!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaPhieuXuat.Select();
                    return;
                }

                PhieuXuat l = new PhieuXuat();
                l.MSPX = txtMaPhieuXuat.Text;
                l.NgayXuat = dtpNgayXuat.Value;
                db.PhieuXuats.InsertOnSubmit(l);
                try
                {
                    db.SubmitChanges();
                    ShowData();
                    MessageBox.Show("Thêm phiếu xuất thành công", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    db.PhieuXuats.DeleteOnSubmit(l);
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
                MessageBox.Show("Vui lòng chọn phiếu xuất!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var l = db.PhieuXuats.SingleOrDefault(x => x.MSPX == r.Cells["MSPX"].Value.ToString());
                db.PhieuXuats.DeleteOnSubmit(l);
                db.SubmitChanges();
                PhieuXuat l2 = new PhieuXuat();
                l2.MSPX = txtMaPhieuXuat.Text;
                l2.NgayXuat = dtpNgayXuat.Value;
                db.PhieuXuats.InsertOnSubmit(l2);
                try
                {
                    db.SubmitChanges();
                    ShowData();
                    MessageBox.Show("Sửa phiếu xuất thành công", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    db.PhieuXuats.DeleteOnSubmit(l2);
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
                MessageBox.Show("Vui lòng chọn phiếu xuất!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (
                MessageBox.Show("Bạn thực sự muốn xóa phiếu xuất mã " + r.Cells["MSPX"].Value.ToString() + " ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {
                    var l = db.PhieuXuats.SingleOrDefault(x => x.MSPX == r.Cells["MSPX"].Value.ToString());
                    db.PhieuXuats.DeleteOnSubmit(l);
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
        }
    }
}
