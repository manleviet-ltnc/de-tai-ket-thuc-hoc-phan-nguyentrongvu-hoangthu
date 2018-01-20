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
        
        Graphics g;
        PictureBox dau;
        PictureBox cuoi;
        PictureBox Dau;
        PictureBox Cuoi;
        private void pbxImage1_MouseDown(object sender, MouseEventArgs e)
        {
            
            dau = (PictureBox)sender;
            
            
            
        }



        ////private void frmStage1_Load(object sender, EventArgs e)
        ////{
        ////    pbxImage1.Size = new Size(105, 101);
        ////    pbxImage12.Size = new Size(105, 101);
        ////    pbxImage13.Size = new Size(105, 101);
        ////}
        

        private void pbxImage1_MouseUp(object sender, MouseEventArgs e)
        {
            
            cuoi = (PictureBox)sender;
            
            Pen p = new Pen(Color.White,6F);
            g = this.CreateGraphics();
            g.DrawLine(p, dau.Location,cuoi.Location);
            g.Dispose();
        }

        private void frmStage1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Red, 30);
            e.Graphics.DrawRectangle(p, new Rectangle(150, 230, 50, 50));
            e.Graphics.DrawRectangle(p, new Rectangle(350, 230, 50, 50));
            e.Graphics.DrawRectangle(p, new Rectangle(550, 230, 50, 50));
        }
    }
}
