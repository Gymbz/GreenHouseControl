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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static int minuteTimer = 0;
        public static int updateCountdownTimer;
        public int countdownTimer = updateCountdownTimer;

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

        public SerialPort nanoPort = new SerialPort();
        public static string ArduinoCurrentTemperature;
        public static string ArduinoCurrentHumidity;

        private void OpenCOMPort()
        {
            nanoPort.BaudRate = 115200;
            nanoPort.PortName = "COM3";

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

            nanoPort.Write("T");
            watch.Start();
            ArduinoCurrentTemperature = await Task.Run(() => nanoPort.ReadLine());
            watch.Stop();

            temperatureValue.Text = ArduinoCurrentTemperature;
            COMresponsetime.Text = string.Format("{0} msec", watch.ElapsedMilliseconds);

            //   nanoPort.Write("H");
            //watch.Start();
            // ArduinoCurrentHumidity = await Task.Run(() => nanoPort.ReadLine());
            // watch.Stop();
            //humidityValue.Text = ArduinoCurrentHumidity;
        }
      
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialize all config
            GreeHouseCommunicationFrequencyChoice.SelectedIndex = 1;

            timer1.Start();


        }

        private void GreeHouseCommunicationFrequencyChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (GreeHouseCommunicationFrequencyChoice.SelectedIndex)
            {
                case 0:
                    updateCountdownTimer = 5;
                    break;
                case 1:
                    updateCountdownTimer = 10;
                    break;
                case 2:
                    updateCountdownTimer = 30;
                    break;
                case 3:
                    updateCountdownTimer = 60;
                    break;
                case 4:
                    updateCountdownTimer = 300;
                    break;
                case 5:
                    updateCountdownTimer = 600;
                    break;
                case 6:
                    updateCountdownTimer = 900;
                    break;
                case 7:
                    updateCountdownTimer = 1800;
                    break;
                case 8:
                    updateCountdownTimer = 3600;
                    break;

            }

            countdownTimer = updateCountdownTimer;
        }


        //NOTE: Current date and time showing on left bottom corner of the window
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Show current date and time from computer
            DateHour.Text = DateTime.Now.ToString();

            //Show countdown for the next parametres update
  
            countdownTimer--;
            if (countdownTimer <0)
            {
                countdownTimer = updateCountdownTimer;
            }
            TimeSpan timeRemaining = TimeSpan.FromSeconds(countdownTimer);
            string strRemaining = timeRemaining.ToString(@"m\:ss");
            labelDisplayUpdateTime.Text = string.Format("Czas do następnej aktualizacji: {0}", strRemaining);  
              
            //Update parametres from Arduino (via serial port)
            if (minuteTimer > updateCountdownTimer)
            {
                GetArduinoParametres();
                minuteTimer = 0;
            }
            minuteTimer++;
        }

   


        public Form1()
        {
            InitializeComponent();

            p1 = new MultipleSlidingPanels(ref panelControlParametres, ref btnControlParametres, ref btnPreviewReports, ref btnAppConfig);
            p2 = new MultipleSlidingPanels(ref panelPreviewReports, ref btnPreviewReports, ref btnControlParametres, ref btnAppConfig);
            p3 = new MultipleSlidingPanels(ref panelAppConfig, ref btnAppConfig, ref btnControlParametres, ref btnPreviewReports);
            pB1 = new ButtonHover(ref ExitButton);
            OpenCOMPort();
            nanoPort.DiscardInBuffer();
            Task delayTask = GetArduinoParametres();
        }


    }
}
