using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ứng_dụng_LYNE
{
    public partial class frmStage1 : Form
    {
        public frmStage1()
        {
            InitializeComponent();
        }
        
        
        private void btnMenu1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSets dlg = new frmSets();
            dlg.ShowDialog();
            this.Close();
        }
        bool kiemtra=false;
        Graphics g;
       
        private void pbxImage1_MouseDown(object sender, MouseEventArgs e)
        {
            kiemtra = true;
           
            
                
            
        }



        private void frmStage1_Load(object sender, EventArgs e)
        {
            pbxImage1.Size = new Size(105, 101);
            pbxImage12.Size = new Size(105, 101);
            pbxImage13.Size = new Size(105, 101);
        }
        private void pbxImage12_MouseUp(object sender, MouseEventArgs e)
        {
            
            kiemtra = false;
            g = this.CreateGraphics();
            g.DrawLine(Pens.White, new Point(0,200), new Point(0, 400));
            g.Dispose();
        }
    }
}
