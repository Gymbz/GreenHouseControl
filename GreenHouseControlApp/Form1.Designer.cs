
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAppConfig = new System.Windows.Forms.Button();
            this.btnPreviewReports = new System.Windows.Forms.Button();
            this.btnControlParametres = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelControlParametres = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelPreviewReports = new System.Windows.Forms.Panel();
            this.panelAppConfig = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelControlParametres.SuspendLayout();
            this.panelPreviewReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btnAppConfig);
            this.panel1.Controls.Add(this.btnPreviewReports);
            this.panel1.Controls.Add(this.btnControlParametres);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 681);
            this.panel1.TabIndex = 0;
            // 
            // btnAppConfig
            // 
            this.btnAppConfig.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAppConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppConfig.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAppConfig.Location = new System.Drawing.Point(0, 363);
            this.btnAppConfig.Name = "btnAppConfig";
            this.btnAppConfig.Size = new System.Drawing.Size(280, 75);
            this.btnAppConfig.TabIndex = 4;
            this.btnAppConfig.Text = "Konfiguracja";
            this.btnAppConfig.UseVisualStyleBackColor = false;
            this.btnAppConfig.Click += new System.EventHandler(this.btnAppConfig_Click);
            this.btnAppConfig.Leave += new System.EventHandler(this.btnAppConfig_Leave);
            // 
            // btnPreviewReports
            // 
            this.btnPreviewReports.BackColor = System.Drawing.Color.FloralWhite;
            this.btnPreviewReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviewReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPreviewReports.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPreviewReports.Location = new System.Drawing.Point(0, 288);
            this.btnPreviewReports.Name = "btnPreviewReports";
            this.btnPreviewReports.Size = new System.Drawing.Size(280, 75);
            this.btnPreviewReports.TabIndex = 3;
            this.btnPreviewReports.Text = "Przegląd Raportów";
            this.btnPreviewReports.UseVisualStyleBackColor = false;
            this.btnPreviewReports.Click += new System.EventHandler(this.btnPreviewReports_Click);
            this.btnPreviewReports.Leave += new System.EventHandler(this.btnPreviewReports_Leave);
            // 
            // btnControlParametres
            // 
            this.btnControlParametres.BackColor = System.Drawing.Color.FloralWhite;
            this.btnControlParametres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControlParametres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnControlParametres.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnControlParametres.Location = new System.Drawing.Point(0, 213);
            this.btnControlParametres.Name = "btnControlParametres";
            this.btnControlParametres.Size = new System.Drawing.Size(280, 75);
            this.btnControlParametres.TabIndex = 2;
            this.btnControlParametres.Text = "Zmiana Parametrów";
            this.btnControlParametres.UseVisualStyleBackColor = false;
            this.btnControlParametres.Click += new System.EventHandler(this.btnControlParametres_Click);
            this.btnControlParametres.Leave += new System.EventHandler(this.btnControlParametres_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 213);
            this.panel2.TabIndex = 1;
            // 
            // panelControlParametres
            // 
            this.panelControlParametres.BackColor = System.Drawing.Color.DarkRed;
            this.panelControlParametres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelControlParametres.Controls.Add(this.panelPreviewReports);
            this.panelControlParametres.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControlParametres.Location = new System.Drawing.Point(280, 0);
            this.panelControlParametres.Name = "panelControlParametres";
            this.panelControlParametres.Size = new System.Drawing.Size(1000, 681);
            this.panelControlParametres.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelPreviewReports
            // 
            this.panelPreviewReports.BackColor = System.Drawing.Color.DarkOrange;
            this.panelPreviewReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelPreviewReports.Controls.Add(this.panelAppConfig);
            this.panelPreviewReports.Location = new System.Drawing.Point(0, 0);
            this.panelPreviewReports.Name = "panelPreviewReports";
            this.panelPreviewReports.Size = new System.Drawing.Size(1008, 689);
            this.panelPreviewReports.TabIndex = 2;
            // 
            // panelAppConfig
            // 
            this.panelAppConfig.BackColor = System.Drawing.Color.Gold;
            this.panelAppConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelAppConfig.Location = new System.Drawing.Point(0, 0);
            this.panelAppConfig.Name = "panelAppConfig";
            this.panelAppConfig.Size = new System.Drawing.Size(1008, 689);
            this.panelAppConfig.TabIndex = 3;
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelControlParametres);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrola Klimatu Mikroszklarni";
            this.panel1.ResumeLayout(false);
            this.panelControlParametres.ResumeLayout(false);
            this.panelPreviewReports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnControlParametres;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAppConfig;
        private System.Windows.Forms.Button btnPreviewReports;
        private System.Windows.Forms.Panel panelControlParametres;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelPreviewReports;
        private System.Windows.Forms.Panel panelAppConfig;
        private System.Windows.Forms.Timer timer2;
    }
}

