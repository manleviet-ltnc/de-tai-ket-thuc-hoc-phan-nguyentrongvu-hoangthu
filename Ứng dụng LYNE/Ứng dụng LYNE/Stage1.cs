using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Ứng_dụng_LYNE
{
    public partial class frmStage1 : Form
    {
        Manchoi mc;
        Shape s1;
        bool drag = false;

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
       
        Rectangle rect;
        private void frmStage1_Paint(object sender, PaintEventArgs e)
        {
            mc.Paint(CreateGraphics());
            
        }
        Graphics g;
        private void frmStage1_MouseDown(object sender, MouseEventArgs e)
        {
            Shape s = mc.GetShapeClicked(new Point(e.X, e.Y));

            if (s != null)
            {
                if (drag)
                {
                    // thuc hien kiem tra va noi hai Shape voi nhau
                    // trong s1
                    Link l = new Link();
                    l.begin = s1;
                    l.end = s;
                    mc.links.Add(l);
                    s1 = null;
                }
                else
                    s1 = s;
                drag = !drag;
            }
            else
                s1 = null;
            
        }

<<<<<<< HEAD
        private void frmStage1_Load(object sender, EventArgs e)
        {
            mc = new Manchoi();
=======
        ////private void frmStage1_Load(object sender, EventArgs e)
        ////{
        ////    pbxImage1.Size = new Size(105, 101);
        ////    pbxImage12.Size = new Size(105, 101);
        ////    pbxImage13.Size = new Size(105, 101);
        ////}
        
>>>>>>> f2f7c381939be03a1511a4e59921c10022a2e16f

            Rectangle rc1 = new Rectangle(20, 20, new Point(500, 500));
            Rectangle rc2 = new Rectangle(20, 20, new Point(200, 200));

            mc.shapes.Add(rc1);
            mc.shapes.Add(rc2);
        }

<<<<<<< HEAD
=======
        private void frmStage1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Red, 30);
            e.Graphics.DrawRectangle(p, new Rectangle(150, 230, 50, 50));
            e.Graphics.DrawRectangle(p, new Rectangle(350, 230, 50, 50));
            e.Graphics.DrawRectangle(p, new Rectangle(550, 230, 50, 50));
        }
>>>>>>> f2f7c381939be03a1511a4e59921c10022a2e16f
    }
}
