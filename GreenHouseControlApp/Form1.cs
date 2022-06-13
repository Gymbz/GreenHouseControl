using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MultipleSlidingPanels p1, p2, p3;
        ButtonHover pB1;


        #region TopBar
        //Note: This section is responsible for moving the window of the app with mouse and for
        //exit and fullscreen buttons

        int mouseX = 0;
        int mouseY = 0;
        int mouseinX;
        int mouseinY;
        bool mouseDown;

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {

            mouseDown = true;

            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }
        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        //NOTE: For some reasong I had to make the same methods for label on the top bar
        private void labelAppName_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;

            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }
        private void labelAppName_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
        private void labelAppName_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region SerialPortCommunication

        public SerialPort nanoPort;
        public static string ArduinoCurrentTemperature;

        private void OpenCOMPort()
        {
            nanoPort = new SerialPort();
            nanoPort.BaudRate = 9600;
            nanoPort.PortName = "COM 3";

            try
            {
                nanoPort.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Nalezy podlaczyc urzadzenie do portu szeregowego!");
                return;
            }
        }

        private async Task GetArduinoParametres()
        {
            Stopwatch watch = new Stopwatch();

            nanoPort.DiscardInBuffer();

            nanoPort.Write("R");
            watch.Start();
            ArduinoCurrentTemperature = await Task.Run(() => nanoPort.ReadLine());
            watch.Stop();

            TemperatureValue.Text = ArduinoCurrentTemperature;
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //NOTE: Current date and time showing on left bottom corner of the window
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateHour.Text = DateTime.Now.ToString();
        }

   


        public Form1()
        {
            InitializeComponent();

            p1 = new MultipleSlidingPanels(ref panelControlParametres, ref btnControlParametres, ref btnPreviewReports, ref btnAppConfig);
            p2 = new MultipleSlidingPanels(ref panelPreviewReports, ref btnPreviewReports, ref btnControlParametres, ref btnAppConfig);
            p3 = new MultipleSlidingPanels(ref panelAppConfig, ref btnAppConfig, ref btnControlParametres, ref btnPreviewReports);
            pB1 = new ButtonHover(ref ExitButton);

        }


    }
}
