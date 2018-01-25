using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Ứng_dụng_LYNE
{
    class Rectangle: Shape
    {
        
       public int height;
      public  int width;
        
        public Rectangle(int height, int width,Point center) : base(center)
        {
            this.height = height;
            this.width = width;            
        }
        // Hàm paint
        public override void Paint(Graphics g)
        {
            int x = center.X - width / 2;
            int y = center.Y - height / 2;
            Pen p = new Pen(Color.Red, 30);
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, width, height);
            g.DrawRectangle(p, rect );
        }
        // Kiểm tra con trỏ chuột có nằm trong hình vẽ hay không
        public override bool HitTest(Point p)
        {
            int x = center.X - width / 2;
            int y = center.Y - height / 2;
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, width, height);
            return rect.Contains(p);
        }
    }
}
