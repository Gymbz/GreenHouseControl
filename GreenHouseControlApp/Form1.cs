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
        int panelControlParametresWidth = 1000;
        bool panelControlParametresHidden;

        public Form1()
        {
            InitializeComponent();
            panelControlParametres.Width = 0;
            panelControlParametresHidden = true;
        }

        private void btnControlParametres_Click(object sender, EventArgs e)
        {
            btnControlParametres.BackColor = Color.Red;
            timer1.Start();
        }

        private void btnPreviewReports_Click(object sender, EventArgs e)
        {
            btnPreviewReports.BackColor = Color.Red;
        }

        private void btnAppConfig_Click(object sender, EventArgs e)
        {
            btnAppConfig.BackColor = Color.Red;
        }

        private void btnControlParametres_Leave(object sender, EventArgs e)
        {
            btnControlParametres.BackColor = Color.FloralWhite;
        }

        private void btnPreviewReports_Leave(object sender, EventArgs e)
        {
            btnPreviewReports.BackColor = Color.FloralWhite;
        }

        private void btnAppConfig_Leave(object sender, EventArgs e)
        {
            btnAppConfig.BackColor = Color.FloralWhite;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panelControlParametresHidden)
            {
                panelControlParametres.Width = panelControlParametres.Width + 20;
                if (panelControlParametres.Width >= panelControlParametresWidth)
                {
                    timer1.Stop();
                    panelControlParametresHidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelControlParametres.Width = panelControlParametres.Width - 20;
                if(panelControlParametres.Width == 0 )
                {
                    timer1.Stop();
                    panelControlParametresHidden = true;
                    this.Refresh();
                }
            }
        }
    }
}
