using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ứng_dụng_LYNE
{
    public partial class frmSets : Form
    {
        public frmSets()
        {
            InitializeComponent();
        }
        // CHuyển form
        private void btnStage1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStage1 dlg = new frmStage1();
            dlg.ShowDialog();
            this.Close();
           
        }

        private void btnStage2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStage2 dlg = new frmStage2();
            dlg.ShowDialog();
            this.Close();
        }

        private void btnStage3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStage3 dlg = new frmStage3();
            dlg.ShowDialog();
            this.Close();
        }

        private void btnStage4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStage4 dlg = new frmStage4();
            dlg.ShowDialog();
            this.Close();
        }

        private void btnStage5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStage5 dlg = new frmStage5();
            dlg.ShowDialog();
            this.Close();
        }

        private void btnStage6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStage6 dlg = new frmStage6();
            dlg.ShowDialog();
            this.Close();
        }

        private void btnStage7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStage7 dlg = new frmStage7();
            dlg.ShowDialog();
            this.Close();
        }

        private void btnStage8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStage8 dlg = new frmStage8();
            dlg.ShowDialog();
            this.Close();
        }

        private void btnStage9_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStage9 dlg = new frmStage9();
            dlg.ShowDialog();
            this.Close();
        }

        private void btnStage10_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStage10 dlg = new frmStage10();
            dlg.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManHinh dlg = new frmManHinh();
            dlg.ShowDialog();
            this.Close();
        }
    }
}
