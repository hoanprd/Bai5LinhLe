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
    public partial class PhieuNhapForm : Form
    {
        DataGridViewRow r;
        private QLXNHHDatabaseDataContext db;

        public PhieuNhapForm()
        {
            InitializeComponent();
        }

        private void PhieuNhapForm_Load(object sender, EventArgs e)
        {
            db = new QLXNHHDatabaseDataContext();
            ShowData();

            dgvMain.Columns["MSPN"].Width = 100;
            dgvMain.Columns["NgayNhap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ShowData()
        {
            var rs = from s in db.PhieuNhaps
                     select new
                     {
                         s.MSPN,
                         s.NgayNhap
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

                txtMaPhieuNhap.Text = r.Cells["MSPN"].Value.ToString();
                dtpNgayNhap.Text = r.Cells["NgayNhap"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaPhieuNhap.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã số phiếu nhập!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaPhieuNhap.Select();
                    return;
                }

                PhieuNhap l = new PhieuNhap();
                l.MSPN = txtMaPhieuNhap.Text;
                l.NgayNhap = dtpNgayNhap.Value;
                db.PhieuNhaps.InsertOnSubmit(l);
                try
                {
                    db.SubmitChanges();
                    ShowData();
                    MessageBox.Show("Thêm phiếu nhập thành công", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    db.PhieuNhaps.DeleteOnSubmit(l);
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
                MessageBox.Show("Vui lòng chọn phiếu nhập!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var l = db.PhieuNhaps.SingleOrDefault(x => x.MSPN == r.Cells["MSPN"].Value.ToString());
                db.PhieuNhaps.DeleteOnSubmit(l);
                db.SubmitChanges();
                PhieuNhap l2 = new PhieuNhap();
                l2.MSPN = txtMaPhieuNhap.Text;
                l2.NgayNhap = dtpNgayNhap.Value;
                db.PhieuNhaps.InsertOnSubmit(l2);
                try
                {
                    db.SubmitChanges();
                    ShowData();
                    MessageBox.Show("Sửa phiếu nhập thành công", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    db.PhieuNhaps.DeleteOnSubmit(l2);
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
                MessageBox.Show("Vui lòng chọn phiếu nhập!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (
                MessageBox.Show("Bạn thực sự muốn xóa phiếu nhập mã " + r.Cells["MSPN"].Value.ToString() + " ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {
                    var l = db.PhieuNhaps.SingleOrDefault(x => x.MSPN == r.Cells["MSPN"].Value.ToString());
                    db.PhieuNhaps.DeleteOnSubmit(l);
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
            txtMaPhieuNhap.Text = null;
        }
    }
}
