using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MultipleSlidingPanels p1, p2, p3;
        int mouseX = 0;
        int mouseY = 0;
        bool mouseDown;

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X -600;
                mouseY = MousePosition.Y - 20;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }


        public Form1()
        {
            InitializeComponent();

            p1 = new MultipleSlidingPanels(ref panelControlParametres, ref btnControlParametres, ref btnPreviewReports, ref btnAppConfig);
            p2 = new MultipleSlidingPanels(ref panelPreviewReports, ref btnPreviewReports, ref btnControlParametres, ref btnAppConfig);
            p3 = new MultipleSlidingPanels(ref panelAppConfig, ref btnAppConfig, ref btnControlParametres, ref btnPreviewReports);

        }


    }
}
