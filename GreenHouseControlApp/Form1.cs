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
        int panelsWidth = 1000;
        bool panelControlParametresHidden;
        bool panelPreviewReportsHidden;
        bool panelAppConfigHidden;

        public Form1()
        {
            InitializeComponent();

            panelControlParametres.Width = 0;
            panelPreviewReports.Width = 0;
            panelAppConfig.Width = 0;

            panelControlParametresHidden = true;
            panelPreviewReportsHidden = true;
            panelAppConfigHidden = true;
        }

        private void btnControlParametres_Click(object sender, EventArgs e)
        {
            btnControlParametres.BackColor = Color.Red;
            panelControlParametresHidden = true;
            timer1.Start();
        }

        private void btnPreviewReports_Click(object sender, EventArgs e)
        {
            btnPreviewReports.BackColor = Color.Red;
            panelPreviewReportsHidden = true;
            timer2.Start();
        }

        private void btnAppConfig_Click(object sender, EventArgs e)
        {
            btnAppConfig.BackColor = Color.Red;
        }

        private void btnControlParametres_Leave(object sender, EventArgs e)
        {
            btnControlParametres.BackColor = Color.FloralWhite;
            panelControlParametresHidden = false;
            timer1.Start();
        }

        private void btnPreviewReports_Leave(object sender, EventArgs e)
        {
            btnPreviewReports.BackColor = Color.FloralWhite; 
            panelPreviewReportsHidden = false;
            timer2.Start();
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
                if (panelControlParametres.Width >= panelsWidth)
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panelPreviewReportsHidden)
            {
                panelPreviewReports.Width = panelPreviewReports.Width + 20;
                if (panelPreviewReports.Width >= panelsWidth)
                {
                    timer2.Stop();
                    panelPreviewReportsHidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelPreviewReports.Width = panelPreviewReports.Width - 20;
                if (panelPreviewReports.Width == 0)
                {
                    timer2.Stop();
                    panelPreviewReportsHidden = true;
                    this.Refresh();
                }
            }
        }
    }
}
