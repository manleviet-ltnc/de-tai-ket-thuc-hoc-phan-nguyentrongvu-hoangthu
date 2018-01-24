using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ứng_dụng_LYNE
{
    class Circle : Shape
    {
        SizeF radius;
        public Circle(SizeF radius,Point center): base(center)
        {
            this.radius = radius;
        }

        public override void Paint(Graphics g)
        {
            Pen p = new Pen(Color.Red, 30);
            g.DrawEllipse(p, new RectangleF(center,radius));
        }

        public override bool HitTest(Point p)
        {
            int r = (int)radius.Width;
            int x = center.X - r;
            int y = center.Y - r;
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, r, r);
            return rect.Contains(p);
        }
    }
}
