﻿using System;
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
        // Chuyển form
        private void btnMenu3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSets dlg = new frmSets();
            dlg.ShowDialog();
            this.Close();
        }

        Manchoi mc;
        Shape s1;
        bool drag = false;
        // Paint
        private void frmStage3_Paint(object sender, PaintEventArgs e)
        {
            mc.Paint(CreateGraphics());

        }

        Graphics g;
        //Sự kiện mouse down
        private void frmStage3_MouseDown(object sender, MouseEventArgs e)
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
        // Load hình lên
        private void frmStage3_Load(object sender, EventArgs e)
        {
            mc = new Manchoi();
            Rectangle rc1 = new Rectangle(70, 70, new Point(350, 250));
            Rectangle rc2 = new Rectangle(70, 70, new Point(100, 250));
            Rectangle rc3 = new Rectangle(70, 70, new Point(600, 250));
            RectangleF circle1 = new RectangleF(350, 400, 50,50);
            mc.shapes.Add(rc1);
            mc.shapes.Add(rc2);
            mc.shapes.Add(rc3);
            //mc.shapes.Add(circle1);
        }
    }
}
