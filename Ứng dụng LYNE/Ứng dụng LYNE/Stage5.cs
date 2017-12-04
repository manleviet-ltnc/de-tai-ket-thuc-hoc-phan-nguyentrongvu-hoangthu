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
    public partial class frmStage5 : Form
    {
        public frmStage5()
        {
            InitializeComponent();
        }

        private void btnMenu5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSets dlg = new frmSets();
            dlg.ShowDialog();
            this.Close();
        }

        private void frmStage5_Load(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(119, 107);
            pictureBox2.Size = new Size(119, 107);
            pictureBox3.Size = new Size(119, 107);
            pictureBox4.Size = new Size(119, 107);
            pictureBox5.Size = new Size(119, 107);
            pictureBox6.Size = new Size(119, 107);
            pictureBox7.Size = new Size(119, 107);
            pictureBox8.Size = new Size(119, 107);
            pictureBox9.Size = new Size(119, 107);
            pictureBox10.Size = new Size(119, 107);
            pictureBox11.Size = new Size(119, 107);
            pictureBox12.Size = new Size(119, 107);
        }
    }
}
