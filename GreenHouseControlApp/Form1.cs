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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnControlParametres_Click(object sender, EventArgs e)
        {
            btnControlParametres.BackColor = Color.Red;
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
    }
}
