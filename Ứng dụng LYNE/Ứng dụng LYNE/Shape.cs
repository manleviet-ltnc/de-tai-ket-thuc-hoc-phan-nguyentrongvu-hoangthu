using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Ứng_dụng_LYNE
{
    abstract class Shape
    {
        Manchoi mc;
        // Vị trí trung tâm
        protected Point center;
        // lưu các đường nối đến các shapes khác
        List<Shape> links;
        public Shape(Point center)
        {
            this.center = center;
        }
        public abstract void Paint(Graphics g);
        public abstract bool HitTest(Point p);

        
    }
}
