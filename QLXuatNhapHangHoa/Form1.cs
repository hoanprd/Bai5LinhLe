using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXuatNhapHangHoa
{
    public partial class Form1 : Form
    {
        private Form currentFormChild;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void quảnLýPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhieuNhapForm());
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýChiTiếtPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhieuNhapCTForm());
        }

        private void quảnLýPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhieuXuatForm());
        }

        private void quảnLýChiTiếtPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhieuXuatCTForm());
        }

        private void quảnLýHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HangHoaForm());
        }

        private void quanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLNhapXuatForm());
        }
    }
}
