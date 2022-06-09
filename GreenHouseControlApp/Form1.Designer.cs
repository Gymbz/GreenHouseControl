
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelMoisture = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelN2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.levelCO2 = new System.Windows.Forms.Label();
            this.labelCO2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TemperatureValue = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.panelPreviewReports = new System.Windows.Forms.Panel();
            this.panelAppConfig = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LanguagesList = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelConfig = new System.Windows.Forms.Label();
            this.labelAppName = new System.Windows.Forms.Label();
            this.TopBar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radioC = new System.Windows.Forms.RadioButton();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.panelMenu.SuspendLayout();
            this.panelControlParametres.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAppConfig.SuspendLayout();
            this.panel5.SuspendLayout();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.DateHour.Location = new System.Drawing.Point(63, 689);
            this.DateHour.Name = "DateHour";
            this.DateHour.Size = new System.Drawing.Size(122, 22);
            this.DateHour.TabIndex = 5;
            this.DateHour.Text = "data i godzina";
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
            this.btnAppConfig.Location = new System.Drawing.Point(0, 363);
            this.btnAppConfig.Name = "btnAppConfig";
            this.btnAppConfig.Size = new System.Drawing.Size(280, 75);
            this.btnAppConfig.TabIndex = 4;
            this.btnAppConfig.Text = "Konfiguracja";
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
            this.btnPreviewReports.Location = new System.Drawing.Point(0, 288);
            this.btnPreviewReports.Name = "btnPreviewReports";
            this.btnPreviewReports.Size = new System.Drawing.Size(280, 75);
            this.btnPreviewReports.TabIndex = 3;
            this.btnPreviewReports.Text = "Przegląd Raportów";
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
            this.btnControlParametres.Location = new System.Drawing.Point(0, 213);
            this.btnControlParametres.Name = "btnControlParametres";
            this.btnControlParametres.Size = new System.Drawing.Size(280, 75);
            this.btnControlParametres.TabIndex = 2;
            this.btnControlParametres.Text = "Zmiana Parametrów";
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
            this.panelControlParametres.Controls.Add(this.panel4);
            this.panelControlParametres.Controls.Add(this.panel3);
            this.panelControlParametres.Controls.Add(this.panel2);
            this.panelControlParametres.Controls.Add(this.panel1);
            this.panelControlParametres.Location = new System.Drawing.Point(280, 50);
            this.panelControlParametres.Name = "panelControlParametres";
            this.panelControlParametres.Size = new System.Drawing.Size(1000, 671);
            this.panelControlParametres.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(210)))), ((int)(((byte)(190)))));
            this.panel4.Controls.Add(this.labelMoisture);
            this.panel4.Location = new System.Drawing.Point(515, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 270);
            this.panel4.TabIndex = 4;
            // 
            // labelMoisture
            // 
            this.labelMoisture.AutoSize = true;
            this.labelMoisture.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMoisture.Location = new System.Drawing.Point(3, 11);
            this.labelMoisture.Name = "labelMoisture";
            this.labelMoisture.Size = new System.Drawing.Size(163, 29);
            this.labelMoisture.TabIndex = 0;
            this.labelMoisture.Text = "WILGOTNOŚĆ";
            this.labelMoisture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(210)))), ((int)(((byte)(190)))));
            this.panel3.Controls.Add(this.labelN2);
            this.panel3.Location = new System.Drawing.Point(515, 313);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 270);
            this.panel3.TabIndex = 3;
            // 
            // labelN2
            // 
            this.labelN2.AutoSize = true;
            this.labelN2.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelN2.Location = new System.Drawing.Point(3, 15);
            this.labelN2.Name = "labelN2";
            this.labelN2.Size = new System.Drawing.Size(139, 29);
            this.labelN2.TabIndex = 0;
            this.labelN2.Text = "POZIOM N2";
            this.labelN2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(210)))), ((int)(((byte)(190)))));
            this.panel2.Controls.Add(this.levelCO2);
            this.panel2.Controls.Add(this.labelCO2);
            this.panel2.Location = new System.Drawing.Point(36, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 270);
            this.panel2.TabIndex = 2;
            // 
            // levelCO2
            // 
            this.levelCO2.AutoSize = true;
            this.levelCO2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.levelCO2.Location = new System.Drawing.Point(4, 53);
            this.levelCO2.Name = "levelCO2";
            this.levelCO2.Size = new System.Drawing.Size(86, 22);
            this.levelCO2.TabIndex = 1;
            this.levelCO2.Text = "400 ppm";
            this.levelCO2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCO2
            // 
            this.labelCO2.AutoSize = true;
            this.labelCO2.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCO2.Location = new System.Drawing.Point(3, 15);
            this.labelCO2.Name = "labelCO2";
            this.labelCO2.Size = new System.Drawing.Size(155, 29);
            this.labelCO2.TabIndex = 0;
            this.labelCO2.Text = "POZIOM CO2";
            this.labelCO2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(210)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.TemperatureValue);
            this.panel1.Controls.Add(this.labelTemperature);
            this.panel1.Location = new System.Drawing.Point(36, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 270);
            this.panel1.TabIndex = 1;
            // 
            // TemperatureValue
            // 
            this.TemperatureValue.AutoSize = true;
            this.TemperatureValue.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TemperatureValue.Location = new System.Drawing.Point(4, 40);
            this.TemperatureValue.Name = "TemperatureValue";
            this.TemperatureValue.Size = new System.Drawing.Size(83, 22);
            this.TemperatureValue.TabIndex = 2;
            this.TemperatureValue.Text = "25 stopni";
            this.TemperatureValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTemperature.Location = new System.Drawing.Point(3, 11);
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
            this.panel5.Controls.Add(this.radioF);
            this.panel5.Controls.Add(this.radioC);
            this.panel5.Controls.Add(this.LanguagesList);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.labelConfig);
            this.panel5.Location = new System.Drawing.Point(45, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(912, 612);
            this.panel5.TabIndex = 0;
            // 
            // LanguagesList
            // 
            this.LanguagesList.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LanguagesList.FormattingEnabled = true;
            this.LanguagesList.ItemHeight = 22;
            this.LanguagesList.Items.AddRange(new object[] {
            "Polski",
            "English"});
            this.LanguagesList.Location = new System.Drawing.Point(158, 50);
            this.LanguagesList.Name = "LanguagesList";
            this.LanguagesList.Size = new System.Drawing.Size(135, 48);
            this.LanguagesList.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(3, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "data i godzina";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(3, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Częstotliwość zbierania danych:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(3, 261);
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
            this.label5.Location = new System.Drawing.Point(3, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Jednostki temperatury:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "data i godzina";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "data i godzina";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "data i godzina";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.TopBar.Controls.Add(this.pictureBox2);
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
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.fullscreen_exit_116839;
            this.pictureBox2.InitialImage = global::WindowsFormsApp1.Properties.Resources.fullscreen_exit_116839;
            this.pictureBox2.Location = new System.Drawing.Point(932, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
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
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioC.Location = new System.Drawing.Point(206, 111);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(51, 26);
            this.radioC.TabIndex = 15;
            this.radioC.TabStop = true;
            this.radioC.Text = " °C";
            this.radioC.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioF.Location = new System.Drawing.Point(263, 111);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(45, 26);
            this.radioF.TabIndex = 16;
            this.radioF.TabStop = true;
            this.radioF.Text = "°F";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(200)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelAppConfig);
            this.Controls.Add(this.panelPreviewReports);
            this.Controls.Add(this.panelControlParametres);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelControlParametres.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAppConfig.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelMoisture;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelN2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCO2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label levelCO2;
        private System.Windows.Forms.Label TemperatureValue;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label DateHour;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelConfig;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LanguagesList;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RadioButton radioC;
    }
}

