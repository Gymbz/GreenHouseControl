using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class MultipleSlidingPanels
    {
        Panel span;
        Button button;
        Button other_button1;
        Button other_button2;

        bool hidden;
        bool extending;

        Timer t;

        public MultipleSlidingPanels(ref Panel p, ref Button b, ref Button ob1,ref Button ob2)
        {
            this.span = p;
            this.button = b;
            this.other_button1 = ob1;
            this.other_button2 = ob2;

            hidden = true;
            extending = false;

            p.Width = 0;

            b.Click += new EventHandler(Button_clicked);
            ob1.Click += new EventHandler(ButtonOther_clicked);
            ob2.Click += new EventHandler(ButtonOther_clicked);


            t = new Timer();
            t.Interval = 10;
            t.Tick += new EventHandler(Timer_tick);
        }

        private void ButtonOther_clicked(object sender, EventArgs e)
        {
            hidden = false;
            t.Start();
        }

        void ChangeSize(int val)
        {
            span.Width += val;
            if (span.Width >= 1000 || span.Width <= 0)
            {
                t.Stop();
                hidden = !hidden;
                extending = false;
            }
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            if (hidden) ChangeSize(+50);
            else ChangeSize(-50);
        }

        private void Button_clicked(object sender, EventArgs e)
        {
            if (extending)
            {
                t.Stop();
                hidden = false;
                t.Start();
            }

            t.Start();
            extending = true;
        }


    }
}
