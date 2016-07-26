using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace CMPE2300GiyeonKimICAs02
{
    public partial class Form1 : Form
    {
        CDrawer Drawing = new CDrawer(800,600);
        List<Ball> _ball = new List<Ball>();
        Point mouse;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _opacity_Label.Text = OpacityTrack.Value.ToString();
            X_label.Text = XTrack.Value.ToString();
            _Y_label.Text = YTrack.Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point start = mouse;
            Point end = mouse;
            if (Drawing.GetLastMouseLeftClick(out mouse))
            {
                _ball.Add(new Ball(mouse.X, mouse.Y));
            }
            Drawing.Clear();
            if (Drawing.GetLastMouseRightClick(out mouse))
            {
                while (_ball.Count > 0)
                {
                    _ball.RemoveAt(_ball.Count - 1);
                }


            }
            for (int i = 0; i < _ball.Count; i++)
            {
                _ball[i].MoveBall(Drawing);
                _ball[i].Showball(Drawing);


            }
            if (_ball.Count > 0)
            {
                this.Text = _ball[_ball.Count - 1].ToString();
            }
            Drawing.Render();
        }

        private void OpacityTrack_Scroll(object sender, EventArgs e)
        {
            _opacity_Label.Text = OpacityTrack.Value.ToString();
            if (All_checkBox.Checked == false)
                _ball[_ball.Count - 1].Ball_Opacity = OpacityTrack.Value;
            else
            {
                for(int a =0; a < _ball.Count; a++)
                {
                    _ball[a].Ball_Opacity = OpacityTrack.Value;
                }
            }
          
        }

        private void XTrack_Scroll(object sender, EventArgs e)
        {
            X_label.Text = XTrack.Value.ToString();
            if(All_checkBox.Checked == false)
                _ball[_ball.Count - 1]._x = XTrack.Value;
            else
            {
                for (int a = 0; a < _ball.Count; a++)
                {
                    _ball[a]._x = XTrack.Value;
                }
            }
            
        }

        private void YTrack_Scroll(object sender, EventArgs e)
        {
            _Y_label.Text = YTrack.Value.ToString();
            if(All_checkBox.Checked == false)
                _ball[_ball.Count - 1]._y = YTrack.Value;
            else
            {
                for (int a = 0; a < _ball.Count; a++)
                {
                    _ball[a]._y = YTrack.Value;
                }
            }
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
