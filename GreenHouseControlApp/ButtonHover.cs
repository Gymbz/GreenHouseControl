using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    //  Class created to make button increase in size when the mouse is over it
    //  and decrease in size while it's not there.
    //  It's only for visual purpose

    class ButtonHover
    {
        bool IsMouseOverTheButton;
        PictureBox picturebox;
        Timer t;
        int initialWidth;
        int initialHeight;

        public ButtonHover(ref PictureBox pB )
        {
            this.picturebox = pB;
            IsMouseOverTheButton = false;

            initialHeight = pB.Height;
            initialWidth = pB.Width;

            pB.MouseHover += new EventHandler(HoverMouse);
            pB.MouseLeave += new EventHandler(LeaveMouse);
            

            t = new Timer();
            t.Interval = 1;
            t.Tick += new EventHandler(Timer_tick);
            t.Start();
        }

        private void LeaveMouse(object sender, EventArgs e)
        {
            IsMouseOverTheButton = false;
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            if (IsMouseOverTheButton)
            {
                while (picturebox.Width <= initialWidth + 10)
                {
                    picturebox.Width += 1;
                    picturebox.Height += 1;
                }

            }
            else
            {
                picturebox.Width = initialWidth;
                picturebox.Height = initialHeight;
            }

        }

        private void HoverMouse(object sender, EventArgs e)
        {
            IsMouseOverTheButton = true;
        }

    }
}
