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
    public partial class frmStage6 : Form
    {
        public frmStage6()
        {
            InitializeComponent();
        }

        private void btnMenu6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSets dlg = new frmSets();
            dlg.ShowDialog();
            this.Close();
        }

        private void frmStage6_Load(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(113, 108);
            pictureBox2.Size = new Size(113, 108);
            pictureBox3.Size = new Size(113, 108);
            pictureBox4.Size = new Size(113, 108);
            pictureBox5.Size = new Size(113, 108);
            pictureBox6.Size = new Size(113, 108);
            pictureBox7.Size = new Size(113, 108);
            pictureBox8.Size = new Size(113, 108);
            pictureBox9.Size = new Size(113, 108);
            pictureBox10.Size = new Size(113, 108);
            pictureBox11.Size = new Size(113, 108);
            pictureBox12.Size = new Size(113, 108);
        }
    }
}
