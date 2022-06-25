
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.DateHour = new System.Windows.Forms.Label();
            this.btnAppConfig = new System.Windows.Forms.Button();
            this.btnPreviewReports = new System.Windows.Forms.Button();
            this.btnControlParametres = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.panelControlParametres = new System.Windows.Forms.Panel();
            this.labelDisplayUpdateTime = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.humidityIcon = new System.Windows.Forms.PictureBox();
            this.setHumidity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.humidityUnit1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.increaseHumidity = new System.Windows.Forms.Button();
            this.decreaseHumidity = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.humidityUnit = new System.Windows.Forms.Label();
            this.humidityValue = new System.Windows.Forms.TextBox();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelN2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.co2Icon = new System.Windows.Forms.PictureBox();
            this.labelCO2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.temperatureIcon = new System.Windows.Forms.PictureBox();
            this.setTemperature = new System.Windows.Forms.TextBox();
            this.applyTemperatureSettings = new System.Windows.Forms.Button();
            this.temperatureUnit1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.increaseTemperature = new System.Windows.Forms.Button();
            this.decreaseTemperature = new System.Windows.Forms.Button();
            this.temperatureUnit = new System.Windows.Forms.Label();
            this.temperatureValue = new System.Windows.Forms.TextBox();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.panelPreviewReports = new System.Windows.Forms.Panel();
            this.panelAppConfig = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.warningPort = new System.Windows.Forms.Label();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.availablePortsBox = new System.Windows.Forms.ComboBox();
            this.labelSerialPort = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.GreeHouseCommunicationFrequencyChoice = new System.Windows.Forms.ComboBox();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelConfig = new System.Windows.Forms.Label();
            this.labelAppName = new System.Windows.Forms.Label();
            this.TopBar = new System.Windows.Forms.Panel();
            this.FullScreenButton = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.arduinoPort = new System.IO.Ports.SerialPort(this.components);
            this.panelMenu.SuspendLayout();
            this.panelControlParametres.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humidityIcon)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.co2Icon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureIcon)).BeginInit();
            this.panelAppConfig.SuspendLayout();
            this.panel5.SuspendLayout();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FullScreenButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(212)))), ((int)(((byte)(190)))));
            this.panelMenu.Controls.Add(this.DateHour);
            this.panelMenu.Controls.Add(this.btnAppConfig);
            this.panelMenu.Controls.Add(this.btnPreviewReports);
            this.panelMenu.Controls.Add(this.btnControlParametres);
            this.panelMenu.Controls.Add(this.panelUser);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(280, 720);
            this.panelMenu.TabIndex = 0;
            // 
            // DateHour
            // 
            this.DateHour.AutoSize = true;
            this.DateHour.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateHour.Location = new System.Drawing.Point(60, 689);
            this.DateHour.Name = "DateHour";
            this.DateHour.Size = new System.Drawing.Size(189, 22);
            this.DateHour.TabIndex = 5;
            this.DateHour.Text = "dd.mm.yyyy hh:mm:ss";
            this.DateHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAppConfig
            // 
            this.btnAppConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(212)))), ((int)(((byte)(190)))));
            this.btnAppConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppConfig.FlatAppearance.BorderSize = 0;
            this.btnAppConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppConfig.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAppConfig.Image = global::WindowsFormsApp1.Properties.Resources.setting1;
            this.btnAppConfig.Location = new System.Drawing.Point(0, 363);
            this.btnAppConfig.Name = "btnAppConfig";
            this.btnAppConfig.Size = new System.Drawing.Size(280, 75);
            this.btnAppConfig.TabIndex = 4;
            this.btnAppConfig.Text = "   KONFIGURACJA";
            this.btnAppConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppConfig.UseMnemonic = false;
            this.btnAppConfig.UseVisualStyleBackColor = false;
            // 
            // btnPreviewReports
            // 
            this.btnPreviewReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(212)))), ((int)(((byte)(190)))));
            this.btnPreviewReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviewReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPreviewReports.FlatAppearance.BorderSize = 0;
            this.btnPreviewReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviewReports.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPreviewReports.Image = global::WindowsFormsApp1.Properties.Resources.business_report1;
            this.btnPreviewReports.Location = new System.Drawing.Point(0, 288);
            this.btnPreviewReports.Name = "btnPreviewReports";
            this.btnPreviewReports.Size = new System.Drawing.Size(280, 75);
            this.btnPreviewReports.TabIndex = 3;
            this.btnPreviewReports.Text = "   PRZEGLĄD RAPORTÓW";
            this.btnPreviewReports.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreviewReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreviewReports.UseVisualStyleBackColor = false;
            // 
            // btnControlParametres
            // 
            this.btnControlParametres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(212)))), ((int)(((byte)(190)))));
            this.btnControlParametres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControlParametres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnControlParametres.FlatAppearance.BorderSize = 0;
            this.btnControlParametres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlParametres.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnControlParametres.Image = global::WindowsFormsApp1.Properties.Resources.equalizer1;
            this.btnControlParametres.Location = new System.Drawing.Point(0, 213);
            this.btnControlParametres.Name = "btnControlParametres";
            this.btnControlParametres.Size = new System.Drawing.Size(280, 75);
            this.btnControlParametres.TabIndex = 2;
            this.btnControlParametres.Text = "   ZMIANA PARAMETRÓW\r\n";
            this.btnControlParametres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnControlParametres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnControlParametres.UseVisualStyleBackColor = false;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(212)))), ((int)(((byte)(190)))));
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(280, 213);
            this.panelUser.TabIndex = 1;
            // 
            // panelControlParametres
            // 
            this.panelControlParametres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(230)))), ((int)(((byte)(203)))));
            this.panelControlParametres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelControlParametres.Controls.Add(this.labelDisplayUpdateTime);
            this.panelControlParametres.Controls.Add(this.panel4);
            this.panelControlParametres.Controls.Add(this.panel3);
            this.panelControlParametres.Controls.Add(this.panel2);
            this.panelControlParametres.Controls.Add(this.panel1);
            this.panelControlParametres.Location = new System.Drawing.Point(280, 50);
            this.panelControlParametres.Name = "panelControlParametres";
            this.panelControlParametres.Size = new System.Drawing.Size(1000, 671);
            this.panelControlParametres.TabIndex = 1;
            // 
            // labelDisplayUpdateTime
            // 
            this.labelDisplayUpdateTime.AutoSize = true;
            this.labelDisplayUpdateTime.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDisplayUpdateTime.Location = new System.Drawing.Point(674, 639);
            this.labelDisplayUpdateTime.Name = "labelDisplayUpdateTime";
            this.labelDisplayUpdateTime.Size = new System.Drawing.Size(256, 22);
            this.labelDisplayUpdateTime.TabIndex = 5;
            this.labelDisplayUpdateTime.Text = "Czas do następnej aktualizacji: ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(210)))), ((int)(((byte)(190)))));
            this.panel4.Controls.Add(this.humidityIcon);
            this.panel4.Controls.Add(this.setHumidity);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.humidityUnit1);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.increaseHumidity);
            this.panel4.Controls.Add(this.decreaseHumidity);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.humidityUnit);
            this.panel4.Controls.Add(this.humidityValue);
            this.panel4.Controls.Add(this.labelHumidity);
            this.panel4.Location = new System.Drawing.Point(515, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 270);
            this.panel4.TabIndex = 4;
            // 
            // humidityIcon
            // 
            this.humidityIcon.Image = global::WindowsFormsApp1.Properties.Resources.humidity;
            this.humidityIcon.Location = new System.Drawing.Point(3, 3);
            this.humidityIcon.Name = "humidityIcon";
            this.humidityIcon.Size = new System.Drawing.Size(34, 43);
            this.humidityIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.humidityIcon.TabIndex = 19;
            this.humidityIcon.TabStop = false;
            // 
            // setHumidity
            // 
            this.setHumidity.BackColor = System.Drawing.Color.LightCyan;
            this.setHumidity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setHumidity.Enabled = false;
            this.setHumidity.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.setHumidity.Location = new System.Drawing.Point(126, 144);
            this.setHumidity.Name = "setHumidity";
            this.setHumidity.Size = new System.Drawing.Size(79, 33);
            this.setHumidity.TabIndex = 18;
            this.setHumidity.Text = "20.0";
            this.setHumidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(297, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "Zastosuj";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // humidityUnit1
            // 
            this.humidityUnit1.AutoSize = true;
            this.humidityUnit1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.humidityUnit1.Location = new System.Drawing.Point(237, 142);
            this.humidityUnit1.Name = "humidityUnit1";
            this.humidityUnit1.Size = new System.Drawing.Size(35, 33);
            this.humidityUnit1.TabIndex = 17;
            this.humidityUnit1.Text = "%";
            this.humidityUnit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(4, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "Kontrola:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // increaseHumidity
            // 
            this.increaseHumidity.BackColor = System.Drawing.Color.Azure;
            this.increaseHumidity.FlatAppearance.BorderSize = 0;
            this.increaseHumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increaseHumidity.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.increaseHumidity.Location = new System.Drawing.Point(211, 148);
            this.increaseHumidity.Name = "increaseHumidity";
            this.increaseHumidity.Size = new System.Drawing.Size(25, 25);
            this.increaseHumidity.TabIndex = 14;
            this.increaseHumidity.Text = "+";
            this.increaseHumidity.UseVisualStyleBackColor = false;
            // 
            // decreaseHumidity
            // 
            this.decreaseHumidity.BackColor = System.Drawing.Color.Azure;
            this.decreaseHumidity.FlatAppearance.BorderSize = 0;
            this.decreaseHumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decreaseHumidity.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decreaseHumidity.Location = new System.Drawing.Point(95, 148);
            this.decreaseHumidity.Name = "decreaseHumidity";
            this.decreaseHumidity.Size = new System.Drawing.Size(25, 25);
            this.decreaseHumidity.TabIndex = 13;
            this.decreaseHumidity.Text = "-";
            this.decreaseHumidity.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(4, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "Zmierzona:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humidityUnit
            // 
            this.humidityUnit.AutoSize = true;
            this.humidityUnit.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.humidityUnit.Location = new System.Drawing.Point(211, 64);
            this.humidityUnit.Name = "humidityUnit";
            this.humidityUnit.Size = new System.Drawing.Size(35, 33);
            this.humidityUnit.TabIndex = 6;
            this.humidityUnit.Text = "%";
            this.humidityUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humidityValue
            // 
            this.humidityValue.BackColor = System.Drawing.Color.LightCyan;
            this.humidityValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.humidityValue.Enabled = false;
            this.humidityValue.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.humidityValue.Location = new System.Drawing.Point(126, 64);
            this.humidityValue.Name = "humidityValue";
            this.humidityValue.Size = new System.Drawing.Size(79, 33);
            this.humidityValue.TabIndex = 5;
            this.humidityValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.humidityValue.TextChanged += new System.EventHandler(this.humidityValue_TextChanged);
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHumidity.Location = new System.Drawing.Point(43, 11);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(163, 29);
            this.labelHumidity.TabIndex = 0;
            this.labelHumidity.Text = "WILGOTNOŚĆ";
            this.labelHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(210)))), ((int)(((byte)(190)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.labelN2);
            this.panel3.Location = new System.Drawing.Point(515, 313);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 270);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.n2;
            this.pictureBox1.Location = new System.Drawing.Point(8, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // labelN2
            // 
            this.labelN2.AutoSize = true;
            this.labelN2.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelN2.Location = new System.Drawing.Point(43, 15);
            this.labelN2.Name = "labelN2";
            this.labelN2.Size = new System.Drawing.Size(186, 29);
            this.labelN2.TabIndex = 0;
            this.labelN2.Text = "POZIOM AZOTU";
            this.labelN2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(210)))), ((int)(((byte)(190)))));
            this.panel2.Controls.Add(this.co2Icon);
            this.panel2.Controls.Add(this.labelCO2);
            this.panel2.Location = new System.Drawing.Point(36, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 270);
            this.panel2.TabIndex = 2;
            // 
            // co2Icon
            // 
            this.co2Icon.Image = global::WindowsFormsApp1.Properties.Resources.carbon_dioxide;
            this.co2Icon.Location = new System.Drawing.Point(3, 3);
            this.co2Icon.Name = "co2Icon";
            this.co2Icon.Size = new System.Drawing.Size(34, 54);
            this.co2Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.co2Icon.TabIndex = 14;
            this.co2Icon.TabStop = false;
            // 
            // labelCO2
            // 
            this.labelCO2.AutoSize = true;
            this.labelCO2.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCO2.Location = new System.Drawing.Point(43, 15);
            this.labelCO2.Name = "labelCO2";
            this.labelCO2.Size = new System.Drawing.Size(340, 29);
            this.labelCO2.TabIndex = 0;
            this.labelCO2.Text = "POZIOM DWUTLENKU WĘGLA";
            this.labelCO2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(210)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.temperatureIcon);
            this.panel1.Controls.Add(this.setTemperature);
            this.panel1.Controls.Add(this.applyTemperatureSettings);
            this.panel1.Controls.Add(this.temperatureUnit1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.increaseTemperature);
            this.panel1.Controls.Add(this.decreaseTemperature);
            this.panel1.Controls.Add(this.temperatureUnit);
            this.panel1.Controls.Add(this.temperatureValue);
            this.panel1.Controls.Add(this.labelTemperature);
            this.panel1.Location = new System.Drawing.Point(36, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 270);
            this.panel1.TabIndex = 1;
            // 
            // temperatureIcon
            // 
            this.temperatureIcon.Image = global::WindowsFormsApp1.Properties.Resources.thermometer;
            this.temperatureIcon.Location = new System.Drawing.Point(3, 3);
            this.temperatureIcon.Name = "temperatureIcon";
            this.temperatureIcon.Size = new System.Drawing.Size(34, 43);
            this.temperatureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.temperatureIcon.TabIndex = 13;
            this.temperatureIcon.TabStop = false;
            // 
            // setTemperature
            // 
            this.setTemperature.BackColor = System.Drawing.Color.LightCyan;
            this.setTemperature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setTemperature.Enabled = false;
            this.setTemperature.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.setTemperature.Location = new System.Drawing.Point(126, 144);
            this.setTemperature.Name = "setTemperature";
            this.setTemperature.Size = new System.Drawing.Size(79, 33);
            this.setTemperature.TabIndex = 12;
            this.setTemperature.Text = "20.0";
            this.setTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // applyTemperatureSettings
            // 
            this.applyTemperatureSettings.BackColor = System.Drawing.Color.Azure;
            this.applyTemperatureSettings.FlatAppearance.BorderSize = 0;
            this.applyTemperatureSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyTemperatureSettings.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.applyTemperatureSettings.Location = new System.Drawing.Point(297, 221);
            this.applyTemperatureSettings.Name = "applyTemperatureSettings";
            this.applyTemperatureSettings.Size = new System.Drawing.Size(107, 25);
            this.applyTemperatureSettings.TabIndex = 7;
            this.applyTemperatureSettings.Text = "Zastosuj";
            this.applyTemperatureSettings.UseVisualStyleBackColor = false;
            this.applyTemperatureSettings.Click += new System.EventHandler(this.applyTemperatureSettings_Click);
            // 
            // temperatureUnit1
            // 
            this.temperatureUnit1.AutoSize = true;
            this.temperatureUnit1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.temperatureUnit1.Location = new System.Drawing.Point(237, 142);
            this.temperatureUnit1.Name = "temperatureUnit1";
            this.temperatureUnit1.Size = new System.Drawing.Size(42, 33);
            this.temperatureUnit1.TabIndex = 11;
            this.temperatureUnit1.Text = "°C";
            this.temperatureUnit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(4, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Kontrola:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(5, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Zmierzona:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // increaseTemperature
            // 
            this.increaseTemperature.BackColor = System.Drawing.Color.Azure;
            this.increaseTemperature.FlatAppearance.BorderSize = 0;
            this.increaseTemperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increaseTemperature.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.increaseTemperature.Location = new System.Drawing.Point(211, 148);
            this.increaseTemperature.Name = "increaseTemperature";
            this.increaseTemperature.Size = new System.Drawing.Size(25, 25);
            this.increaseTemperature.TabIndex = 6;
            this.increaseTemperature.Text = "+";
            this.increaseTemperature.UseVisualStyleBackColor = false;
            // 
            // decreaseTemperature
            // 
            this.decreaseTemperature.BackColor = System.Drawing.Color.Azure;
            this.decreaseTemperature.FlatAppearance.BorderSize = 0;
            this.decreaseTemperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decreaseTemperature.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decreaseTemperature.Location = new System.Drawing.Point(95, 148);
            this.decreaseTemperature.Name = "decreaseTemperature";
            this.decreaseTemperature.Size = new System.Drawing.Size(25, 25);
            this.decreaseTemperature.TabIndex = 5;
            this.decreaseTemperature.Text = "-";
            this.decreaseTemperature.UseVisualStyleBackColor = false;
            // 
            // temperatureUnit
            // 
            this.temperatureUnit.AutoSize = true;
            this.temperatureUnit.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.temperatureUnit.Location = new System.Drawing.Point(211, 64);
            this.temperatureUnit.Name = "temperatureUnit";
            this.temperatureUnit.Size = new System.Drawing.Size(42, 33);
            this.temperatureUnit.TabIndex = 1;
            this.temperatureUnit.Text = "°C";
            this.temperatureUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temperatureValue
            // 
            this.temperatureValue.BackColor = System.Drawing.Color.LightCyan;
            this.temperatureValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.temperatureValue.Enabled = false;
            this.temperatureValue.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.temperatureValue.Location = new System.Drawing.Point(126, 63);
            this.temperatureValue.Name = "temperatureValue";
            this.temperatureValue.Size = new System.Drawing.Size(79, 33);
            this.temperatureValue.TabIndex = 4;
            this.temperatureValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.temperatureValue.TextChanged += new System.EventHandler(this.temperatureValue_TextChanged);
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTemperature.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTemperature.Location = new System.Drawing.Point(43, 11);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(176, 29);
            this.labelTemperature.TabIndex = 0;
            this.labelTemperature.Text = "TEMPERATURA";
            this.labelTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPreviewReports
            // 
            this.panelPreviewReports.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelPreviewReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelPreviewReports.Location = new System.Drawing.Point(280, 50);
            this.panelPreviewReports.Name = "panelPreviewReports";
            this.panelPreviewReports.Size = new System.Drawing.Size(1000, 670);
            this.panelPreviewReports.TabIndex = 2;
            // 
            // panelAppConfig
            // 
            this.panelAppConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(230)))), ((int)(((byte)(203)))));
            this.panelAppConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelAppConfig.Controls.Add(this.panel5);
            this.panelAppConfig.Location = new System.Drawing.Point(280, 50);
            this.panelAppConfig.Name = "panelAppConfig";
            this.panelAppConfig.Size = new System.Drawing.Size(1000, 670);
            this.panelAppConfig.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(210)))), ((int)(((byte)(190)))));
            this.panel5.Controls.Add(this.warningPort);
            this.panel5.Controls.Add(this.btnClosePort);
            this.panel5.Controls.Add(this.btnOpenPort);
            this.panel5.Controls.Add(this.comboBox3);
            this.panel5.Controls.Add(this.availablePortsBox);
            this.panel5.Controls.Add(this.labelSerialPort);
            this.panel5.Controls.Add(this.comboBox2);
            this.panel5.Controls.Add(this.GreeHouseCommunicationFrequencyChoice);
            this.panel5.Controls.Add(this.radioF);
            this.panel5.Controls.Add(this.radioC);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.labelBaudRate);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.labelConfig);
            this.panel5.Location = new System.Drawing.Point(45, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(912, 612);
            this.panel5.TabIndex = 0;
            // 
            // warningPort
            // 
            this.warningPort.AutoSize = true;
            this.warningPort.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.warningPort.ForeColor = System.Drawing.Color.DarkRed;
            this.warningPort.Location = new System.Drawing.Point(528, 170);
            this.warningPort.Name = "warningPort";
            this.warningPort.Size = new System.Drawing.Size(0, 22);
            this.warningPort.TabIndex = 24;
            this.warningPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClosePort
            // 
            this.btnClosePort.BackColor = System.Drawing.SystemColors.Control;
            this.btnClosePort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClosePort.Enabled = false;
            this.btnClosePort.FlatAppearance.BorderSize = 0;
            this.btnClosePort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePort.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClosePort.ForeColor = System.Drawing.Color.Black;
            this.btnClosePort.Location = new System.Drawing.Point(402, 136);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(121, 26);
            this.btnClosePort.TabIndex = 23;
            this.btnClosePort.Text = "Zamknij";
            this.btnClosePort.UseVisualStyleBackColor = false;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOpenPort.FlatAppearance.BorderSize = 0;
            this.btnOpenPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPort.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOpenPort.ForeColor = System.Drawing.Color.Black;
            this.btnOpenPort.Location = new System.Drawing.Point(275, 136);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(121, 26);
            this.btnOpenPort.TabIndex = 22;
            this.btnOpenPort.Text = "Otwórz";
            this.btnOpenPort.UseVisualStyleBackColor = false;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(109, 168);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 21;
            this.comboBox3.Visible = false;
            // 
            // availablePortsBox
            // 
            this.availablePortsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.availablePortsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availablePortsBox.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.availablePortsBox.FormattingEnabled = true;
            this.availablePortsBox.Location = new System.Drawing.Point(147, 138);
            this.availablePortsBox.Name = "availablePortsBox";
            this.availablePortsBox.Size = new System.Drawing.Size(121, 24);
            this.availablePortsBox.TabIndex = 20;
            // 
            // labelSerialPort
            // 
            this.labelSerialPort.AutoSize = true;
            this.labelSerialPort.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSerialPort.Location = new System.Drawing.Point(4, 138);
            this.labelSerialPort.Name = "labelSerialPort";
            this.labelSerialPort.Size = new System.Drawing.Size(139, 22);
            this.labelSerialPort.TabIndex = 19;
            this.labelSerialPort.Text = "Port Szeregowy:";
            this.labelSerialPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Polski"});
            this.comboBox2.Location = new System.Drawing.Point(158, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 18;
            // 
            // GreeHouseCommunicationFrequencyChoice
            // 
            this.GreeHouseCommunicationFrequencyChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GreeHouseCommunicationFrequencyChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GreeHouseCommunicationFrequencyChoice.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GreeHouseCommunicationFrequencyChoice.FormattingEnabled = true;
            this.GreeHouseCommunicationFrequencyChoice.Items.AddRange(new object[] {
            "5 sekund",
            "10 sekund",
            "30  sekund",
            "minuta",
            "5 minut",
            "10 minut",
            "15 minut",
            "30 minut",
            "godzina"});
            this.GreeHouseCommunicationFrequencyChoice.Location = new System.Drawing.Point(264, 227);
            this.GreeHouseCommunicationFrequencyChoice.Name = "GreeHouseCommunicationFrequencyChoice";
            this.GreeHouseCommunicationFrequencyChoice.Size = new System.Drawing.Size(121, 24);
            this.GreeHouseCommunicationFrequencyChoice.TabIndex = 17;
            this.GreeHouseCommunicationFrequencyChoice.SelectedIndexChanged += new System.EventHandler(this.GreeHouseCommunicationFrequencyChoice_SelectedIndexChanged);
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioF.Location = new System.Drawing.Point(264, 85);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(45, 26);
            this.radioF.TabIndex = 16;
            this.radioF.Text = "°F";
            this.radioF.UseVisualStyleBackColor = true;
            this.radioF.Visible = false;
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Checked = true;
            this.radioC.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioC.Location = new System.Drawing.Point(207, 85);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(51, 26);
            this.radioC.TabIndex = 15;
            this.radioC.TabStop = true;
            this.radioC.Text = " °C";
            this.radioC.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(4, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Częstotliwość kontroli szklarni:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(4, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Jednostki temperatury:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBaudRate.Location = new System.Drawing.Point(5, 168);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(98, 22);
            this.labelBaudRate.TabIndex = 7;
            this.labelBaudRate.Text = "Baud Rate:";
            this.labelBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaudRate.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wersja Językowa:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelConfig
            // 
            this.labelConfig.AutoSize = true;
            this.labelConfig.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelConfig.Location = new System.Drawing.Point(3, 0);
            this.labelConfig.Name = "labelConfig";
            this.labelConfig.Size = new System.Drawing.Size(185, 29);
            this.labelConfig.TabIndex = 1;
            this.labelConfig.Text = "KONFIGURACJA";
            this.labelConfig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAppName.Location = new System.Drawing.Point(6, 9);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(321, 33);
            this.labelAppName.TabIndex = 1;
            this.labelAppName.Text = "GREENHOUSE CONTROL";
            this.labelAppName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAppName_MouseDown);
            this.labelAppName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelAppName_MouseMove);
            this.labelAppName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelAppName_MouseUp);
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.TopBar.Controls.Add(this.FullScreenButton);
            this.TopBar.Controls.Add(this.ExitButton);
            this.TopBar.Controls.Add(this.labelAppName);
            this.TopBar.Location = new System.Drawing.Point(280, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(1000, 50);
            this.TopBar.TabIndex = 4;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // FullScreenButton
            // 
            this.FullScreenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FullScreenButton.Image = global::WindowsFormsApp1.Properties.Resources.fullscreen_exit_116839;
            this.FullScreenButton.InitialImage = global::WindowsFormsApp1.Properties.Resources.fullscreen_exit_116839;
            this.FullScreenButton.Location = new System.Drawing.Point(932, 12);
            this.FullScreenButton.Name = "FullScreenButton";
            this.FullScreenButton.Size = new System.Drawing.Size(25, 25);
            this.FullScreenButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FullScreenButton.TabIndex = 3;
            this.FullScreenButton.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Image = global::WindowsFormsApp1.Properties.Resources.exit_icon_icons_com_70975;
            this.ExitButton.Location = new System.Drawing.Point(963, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(25, 25);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButton.TabIndex = 2;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // arduinoPort
            // 
            this.arduinoPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.arduinoPort_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(200)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.panelAppConfig);
            this.Controls.Add(this.panelControlParametres);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelPreviewReports);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelControlParametres.ResumeLayout(false);
            this.panelControlParametres.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humidityIcon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.co2Icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureIcon)).EndInit();
            this.panelAppConfig.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FullScreenButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnControlParametres;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Button btnAppConfig;
        private System.Windows.Forms.Button btnPreviewReports;
        private System.Windows.Forms.Panel panelControlParametres;
        private System.Windows.Forms.Panel panelPreviewReports;
        private System.Windows.Forms.Panel panelAppConfig;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.PictureBox ExitButton;
        private System.Windows.Forms.PictureBox FullScreenButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelN2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCO2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label temperatureUnit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label DateHour;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelConfig;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox GreeHouseCommunicationFrequencyChoice;
        private System.Windows.Forms.Label labelDisplayUpdateTime;
        private System.Windows.Forms.Label labelSerialPort;
        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox availablePortsBox;
        private System.IO.Ports.SerialPort arduinoPort;
        private System.Windows.Forms.Label warningPort;
        private System.Windows.Forms.TextBox temperatureValue;
        private System.Windows.Forms.TextBox humidityValue;
        private System.Windows.Forms.Label humidityUnit;
        private System.Windows.Forms.Button increaseTemperature;
        private System.Windows.Forms.Button decreaseTemperature;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label temperatureUnit1;
        private System.Windows.Forms.Button applyTemperatureSettings;
        private System.Windows.Forms.TextBox setTemperature;
        private System.Windows.Forms.TextBox setHumidity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label humidityUnit1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button increaseHumidity;
        private System.Windows.Forms.Button decreaseHumidity;
        private System.Windows.Forms.PictureBox temperatureIcon;
        private System.Windows.Forms.PictureBox humidityIcon;
        private System.Windows.Forms.PictureBox co2Icon;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

