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
    public partial class frmStage3 : Form
    {
        public frmStage3()
        {
            InitializeComponent();
        }

        private void btnMenu3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSets dlg = new frmSets();
            dlg.ShowDialog();
            this.Close();
        }

        private void frmStage3_Load(object sender, EventArgs e)
        {
            pbxStage31.Size = new Size(116, 106);
            pbxStage32.Size = new Size(116, 106);
            pbxStage33.Size = new Size(116, 106);
            pbxStage34.Size = new Size(116, 106);
            pbxStage35.Size = new Size(116, 106);
            pbxStage36.Size = new Size(116, 106);
            pbxStage37.Size = new Size(116, 106);
            pbxStage38.Size = new Size(116, 106);
            pbxStage39.Size = new Size(116, 106);
            pbxStage310.Size = new Size(116, 106);
            pbxStage311.Size = new Size(116, 106);
            pbxStage312.Size = new Size(116, 106);
        }
    }
}
