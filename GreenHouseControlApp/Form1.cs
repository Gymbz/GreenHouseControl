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
using System.Globalization;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        CultureInfo currentCulture = CultureInfo.GetCultureInfo("en-US");
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\Studia\\POS\\GreenHouseControl\\GreenHouseControlApp\\Measurements.mdf;Integrated Security=True");


        public static int minuteTimer = 0;
        public static int updateCountdownTimer;
        public int countdownTimer = updateCountdownTimer;

        MultipleSlidingPanels p1, p2, p3;
        ButtonHover pB1;

        string serialDataIn1;
        string serialDataIn2;



        #region TopBar
        //  This section is responsible for moving the window of the app with mouse and for
        //  exit and fullscreen buttons

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
        //  NOTE: For some reason I had to make the same methods for label on the top bar
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

        #region ApplicationConfiguration


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

        #endregion

        #region ParameterControl


        Parameter temperature;
        Parameter humidity;

        //  not used because of hardware limitations
        Parameter co2;
        Parameter n2;


        //  step of how much we increase or decrease wanted value of parametres
        float stepTemperature = 0.1f;
        float stepHumidity = 1;

        float measuredTemperatureValue;
        float measuredHumidityValue;
        float setTemperatureValue;
        float setHumidityValue;

        DateTime dateTime;



        #endregion

        #region SerialCommunication 
        void getAvailablePortNames()
        {
            string[] portNames = SerialPort.GetPortNames();
            availablePortsBox.Items.AddRange(portNames);

        }
        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (availablePortsBox.SelectedItem == null) warningPort.Text = "Proszę wybrać port!";
                else
                {
                    arduinoPort.PortName = availablePortsBox.Text;
                    arduinoPort.BaudRate = 9600;
                    arduinoPort.Open();

                    btnClosePort.Enabled = true;
                    btnOpenPort.Enabled = false;

                    availablePortsBox.Enabled = false;
                    warningPort.Text = "";
                }
            }

            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Nieautoryzowany dostęp");
            }
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            arduinoPort.Close();
            btnClosePort.Enabled = false;
            btnOpenPort.Enabled = true;
            availablePortsBox.Enabled = true;
        }

        private void arduinoPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            serialDataIn1 = arduinoPort.ReadLine();
            serialDataIn2 = arduinoPort.ReadLine();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            temperatureValue.Text = "";
            temperatureValue.Text += serialDataIn1;

            humidityValue.Text = "";
            humidityValue.Text += serialDataIn2;

            saveDataToDataBase();

        }

        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialize all config
            GreeHouseCommunicationFrequencyChoice.SelectedIndex = 1;

            timer1.Start();


        }

        private void temperatureValue_TextChanged(object sender, EventArgs e)
        {
            temperatureValue.SelectionStart = temperatureValue.Text.Length;
            temperatureValue.ScrollToCaret();
        }

        private void humidityValue_TextChanged(object sender, EventArgs e)
        {
            humidityValue.SelectionStart = humidityValue.Text.Length;
            humidityValue.ScrollToCaret();
        }

        private void applyTemperatureSettings_Click(object sender, EventArgs e)
        {
            //  Here should be code that sends special message to Arduino via serialport.
            //  This message should have the value of Temperature user wants in the Greenhouse,
            //  the whole control of the greenhouse should be in the Arduino
        }

        private void btnPreviewReports_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select TempeatureMeasured ,TemperatureSet,HumidityMeasured,HumiditySet, TimeOfMeasurement from dbo.Measurement";
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            con.Open();
            da.Fill(ds);
            this.ChartTemperature.DataSource = ds.Tables[0];
            this.ChartHumidity.DataSource = ds.Tables[0];

            //Mapping a field with x-value of chart
            this.ChartTemperature.Series[0].XValueMember = "TimeOfMeasurement";
            this.ChartTemperature.Series[1].XValueMember = "TimeOfMeasurement";
            this.ChartHumidity.Series[0].XValueMember = "TimeOfMeasurement";
            this.ChartHumidity.Series[1].XValueMember = "TimeOfMeasurement";


            //Mapping a field with y-value of Chart
            this.ChartTemperature.Series[0].YValueMembers = "TempeatureMeasured";
            this.ChartTemperature.Series[1].YValueMembers = "TemperatureSet";
            this.ChartHumidity.Series[0].YValueMembers = "HumidityMeasured";
            this.ChartHumidity.Series[1].YValueMembers = "HumiditySet";


            //Bind the DataTable with Chart
            this.ChartTemperature.DataBind();

            con.Close();





        }



        //  NOTE: Current date and time showing on left bottom corner of the window
        private void timer1_Tick(object sender, EventArgs e)
        {
            //  Show current date and time from computer
            DateHour.Text = DateTime.Now.ToString();

            //  Show countdown for the next parametres update
  
            countdownTimer--;
            if (countdownTimer <0)
            {
                countdownTimer = updateCountdownTimer;
            }
            TimeSpan timeRemaining = TimeSpan.FromSeconds(countdownTimer);
            string strRemaining = timeRemaining.ToString(@"m\:ss");
            labelDisplayUpdateTime.Text = string.Format("Czas do następnej aktualizacji: {0}", strRemaining);  
              
            //  Update parametres from Arduino (via serial port)
            //  Note: Update delay is arround 2 seconds
            if (minuteTimer > updateCountdownTimer -2)
            {
                if (arduinoPort.IsOpen)
                {
                    arduinoPort.WriteLine("T");
                }
                minuteTimer = 0;
            }
            minuteTimer++;

        }

        private void saveDataToDataBase()
        {

            //  Convert displayed values to float
            measuredTemperatureValue = float.Parse(temperatureValue.Text, currentCulture);
            setTemperatureValue = float.Parse(setTemperature.Text, currentCulture);
            measuredHumidityValue = float.Parse(humidityValue.Text, currentCulture);
            setHumidityValue = float.Parse(setHumidity.Text, currentCulture);
            dateTime = DateTime.Now;

            //  Table Columns:
            //[TempeatureMeasured] FLOAT(53) NOT NULL,
            //[TemperatureSet]     FLOAT(53) NOT NULL,
            //[HumidityMeasured]   FLOAT(53) NOT NULL,
            //[HumiditySet]        FLOAT(53) NOT NULL,
            //[TimeOfMeasurement]  DATETIME NOT NULL, 


            string sqlQuery = "INSERT INTO Measurement VALUES (@measuredTemperatureValue, @setTemperatureValue, @measuredHumidityValue, @setHumidityValue, @dateTime)";

       

            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);

            sc.Parameters.AddWithValue("@measuredTemperatureValue", measuredTemperatureValue);
            sc.Parameters.AddWithValue("@setTemperatureValue", setTemperatureValue);
            sc.Parameters.AddWithValue("@measuredHumidityValue", measuredHumidityValue);
            sc.Parameters.AddWithValue("@setHumidityValue", setHumidityValue);
            sc.Parameters.AddWithValue("@dateTime", dateTime);

            sc.ExecuteNonQuery();
            con.Close();
        }

        public Form1()
        {
            InitializeComponent();
            getAvailablePortNames();
            


            p1 = new MultipleSlidingPanels(ref panelControlParametres, ref btnControlParametres, ref btnPreviewReports, ref btnAppConfig);
            p2 = new MultipleSlidingPanels(ref panelPreviewReports, ref btnPreviewReports, ref btnControlParametres, ref btnAppConfig);
            p3 = new MultipleSlidingPanels(ref panelAppConfig, ref btnAppConfig, ref btnControlParametres, ref btnPreviewReports);

            pB1 = new ButtonHover(ref ExitButton);

            temperature = new Parameter(ref setTemperature, ref increaseTemperature, ref decreaseTemperature, ref stepTemperature);
            humidity = new Parameter(ref setHumidity, ref increaseHumidity, ref decreaseHumidity, ref stepHumidity);
        }


    }
}
