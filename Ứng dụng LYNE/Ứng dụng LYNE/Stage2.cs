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
    public partial class frmStage2 : Form
    {
        public frmStage2()
        {
            InitializeComponent();
        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSets dlg = new frmSets();
            dlg.ShowDialog();
            this.Close();
        }

        private void frmStage2_Load(object sender, EventArgs e)
        {
            pbxStage21.Size = new Size(115, 106);
            pbxStage22.Size = new Size(115, 106);
            pbxStage23.Size = new Size(115, 106);
            pbxStage24.Size = new Size(115, 106);
            pbxStage25.Size = new Size(115, 106);
            pbxStage26.Size = new Size(115, 106);
            pbxStage27.Size = new Size(115, 106);
            pbxStage28.Size = new Size(115, 106);
            pbxStage29.Size = new Size(115, 106);
            pbxStage210.Size = new Size(115, 106);
            pbxStage211.Size = new Size(115, 106);
            pbxStage212.Size = new Size(115, 106);
        }
    }
}
