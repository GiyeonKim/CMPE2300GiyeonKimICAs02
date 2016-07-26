using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;

namespace CMPE2300GiyeonKimICAs02
{
    class Ball
    {
        static Random _rand = new Random();
        
        private int Location { get; } //field of point representing the center of the ball, also 
                                      //provide a manual get only property called Location
        Random random = new Random();
        private Point pointer; // poi
        private int yvol;
        private int xvol;
        public int _x { set { xvol = value; } }
        public int _y //restricted the y value to -10 and 10 
        {
            
             set
            {
                if (value < -10)
                    yvol = -10;
                else if (value > 10)
                    yvol = 10;
                else
                    yvol= value;

            }
        }
        private Color colour; // no property
        private int op;
        public int Ball_Opacity { set { op = value; } }
        public int rad = 40;
        
        public Ball(int ix, int iy)
        {
            pointer.X = ix;

            pointer.Y = iy;
            Ball_Opacity = 128;
            colour = RandColor.GetColor();
            
            _x = random.Next(-10,10);
            _y = random.Next(-10, 10);

        }

        public void MoveBall(CDrawer Drawer)
        {
            Drawer.Render();
            pointer.X = xvol + pointer.X;
            pointer.Y = pointer.Y + yvol;

            if (pointer.X + rad + xvol >= Drawer.ScaledWidth || pointer.X - rad + xvol < 0)
            {
                xvol *= -1;
            }
            if (pointer.Y + rad + yvol >= Drawer.ScaledHeight || pointer.Y - rad + yvol < 0)
            {
                yvol *= -1;
            }
            
        }

        public void Showball(CDrawer Drawer)
        {
            Drawer.AddCenteredEllipse(pointer.X, pointer.Y, rad*2, rad*2, Color.FromArgb(op, colour));
           
        }
        public override string ToString()
        {
            return "X=" + pointer.X.ToString() + "," + "Y=" + pointer.Y.ToString() + "- Vel" + xvol.ToString() + "," + yvol.ToString() + ", Opacity:" + op.ToString();  
        }


    }
}
