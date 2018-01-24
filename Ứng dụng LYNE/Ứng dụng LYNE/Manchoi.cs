using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;


namespace Ứng_dụng_LYNE
{
    class Manchoi
    {
        // Danh sách các shapes
        public List<Shape> shapes;
        // các kết nối đúng để kiểm tra
        public List<Link> links;

        public Manchoi()
        {
            shapes = new List<Shape>();
            links = new List<Link>();
        }
        
        public void Paint(Graphics g)
        {
            
           
            foreach (Link l in links)
                l.Paint(g);
            
            foreach (Shape s in shapes)
                s.Paint(g);
        }

        public Shape GetShapeClicked(Point p)
        {
            foreach (Shape s in shapes)
                if (s.HitTest(p))
                    return s;
            return null;
        }
    }
}
