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
    public partial class HangHoaForm : Form
    {
        DataGridViewRow r;
        private QLXNHHDatabaseDataContext db;

        public HangHoaForm()
        {
            InitializeComponent();
        }

        private void HangHoaForm_Load(object sender, EventArgs e)
        {
            db = new QLXNHHDatabaseDataContext();
            ShowData();

            dgvMain.Columns["MSHH"].Width = 100;
            dgvMain.Columns["TenHH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMain.Columns["TonDau"].Width = 100;
        }

        private void ShowData()
        {
            var rs = from s in db.HangHoas
                     select new
                     {
                         s.MSHH,
                         s.TenHH,
                         s.TonDau
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

                txtMaHangHoa.Text = r.Cells["MSHH"].Value.ToString();
                txtTenHangHoa.Text = r.Cells["TenHH"].Value.ToString();
                txtTonDau.Text = r.Cells["TonDau"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaHangHoa.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã số hàng hóa!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaHangHoa.Select();
                    return;
                }
                if (string.IsNullOrEmpty(txtTenHangHoa.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên hàng hóa!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenHangHoa.Select();
                    return;
                }
                if (string.IsNullOrEmpty(txtTonDau.Text))
                {
                    MessageBox.Show("Vui lòng nhập số lượng tồn kho đầu kỳ!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTonDau.Select();
                    return;
                }

                HangHoa l = new HangHoa();
                l.MSHH = txtMaHangHoa.Text;
                l.TenHH = txtTenHangHoa.Text;
                l.TonDau = Int32.Parse(txtTonDau.Text);
                db.HangHoas.InsertOnSubmit(l);
                try
                {
                    db.SubmitChanges();
                    ShowData();
                    MessageBox.Show("Thêm hàng hóa thành công", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    db.HangHoas.DeleteOnSubmit(l);
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
                MessageBox.Show("Vui lòng chọn hàng hóa!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var l = db.HangHoas.SingleOrDefault(x => x.MSHH == r.Cells["MSHH"].Value.ToString());
                db.HangHoas.DeleteOnSubmit(l);
                db.SubmitChanges();
                HangHoa l2 = new HangHoa();
                l2.MSHH = txtMaHangHoa.Text;
                l2.TenHH = txtTenHangHoa.Text;
                l2.TonDau = Int32.Parse(txtTonDau.Text);
                db.HangHoas.InsertOnSubmit(l2);
                try
                {
                    db.SubmitChanges();
                    ShowData();
                    MessageBox.Show("Sửa hàng hóa thành công", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    db.HangHoas.DeleteOnSubmit(l2);
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
                MessageBox.Show("Vui lòng chọn hàng hóa!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (
                MessageBox.Show("Bạn thực sự muốn xóa hàng hóa " + r.Cells["TenHH"].Value.ToString() + " ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {
                    var l = db.HangHoas.SingleOrDefault(x => x.MSHH == r.Cells["MSHH"].Value.ToString());
                    db.HangHoas.DeleteOnSubmit(l);
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
            txtMaHangHoa.Text = null;
            txtTenHangHoa.Text = null;
            txtTonDau.Text = null;
        }
    }
}
