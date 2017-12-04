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
    public partial class frmStage4 : Form
    {
        public frmStage4()
        {
            InitializeComponent();
        }

        private void btnMenu4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSets dlg = new frmSets();
            dlg.ShowDialog();
            this.Close();
        }

        private void frmStage4_Load(object sender, EventArgs e)
        {
            pbxStage41.Size = new Size(112, 94);
            pbxStage42.Size = new Size(112, 94);
            pbxStage43.Size = new Size(112, 94);
            pbxStage44.Size = new Size(112, 94);
            pbxStage45.Size = new Size(112, 94);
            pbxStage46.Size = new Size(112, 94);
            pbxStage47.Size = new Size(112, 94);
            pbxStage48.Size = new Size(112, 94);
            pbxStage49.Size = new Size(112, 94);
        }
    }
}
