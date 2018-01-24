using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Ứng_dụng_LYNE
{
    class Link
    {
        public Shape begin;
       public Shape Begin
        {
            get { return begin; }
            set
            {
                begin = value;
            }
        }
        
        public Shape end;
        List<Shape> shape;
        
        
        
        public void Paint(Graphics g)
        {

            //g.DrawLine(new Pen(Color.White, 6),new Point()
        }
    }
}
