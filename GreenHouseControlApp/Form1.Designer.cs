
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnControlParametres = new System.Windows.Forms.Button();
            this.btnPreviewReports = new System.Windows.Forms.Button();
            this.btnAppConfig = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(268, 681);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 144);
            this.panel2.TabIndex = 1;
            // 
            // btnControlParametres
            // 
            this.btnControlParametres.BackColor = System.Drawing.Color.FloralWhite;
            this.btnControlParametres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControlParametres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnControlParametres.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnControlParametres.Location = new System.Drawing.Point(0, 144);
            this.btnControlParametres.Name = "btnControlParametres";
            this.btnControlParametres.Size = new System.Drawing.Size(268, 75);
            this.btnControlParametres.TabIndex = 2;
            this.btnControlParametres.Text = "Zmiana Parametrów";
            this.btnControlParametres.UseVisualStyleBackColor = false;
            this.btnControlParametres.Click += new System.EventHandler(this.btnControlParametres_Click);
            this.btnControlParametres.Leave += new System.EventHandler(this.btnControlParametres_Leave);
            // 
            // btnPreviewReports
            // 
            this.btnPreviewReports.BackColor = System.Drawing.Color.FloralWhite;
            this.btnPreviewReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviewReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPreviewReports.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPreviewReports.Location = new System.Drawing.Point(0, 219);
            this.btnPreviewReports.Name = "btnPreviewReports";
            this.btnPreviewReports.Size = new System.Drawing.Size(268, 75);
            this.btnPreviewReports.TabIndex = 3;
            this.btnPreviewReports.Text = "Przegląd Raportów";
            this.btnPreviewReports.UseVisualStyleBackColor = false;
            this.btnPreviewReports.Click += new System.EventHandler(this.btnPreviewReports_Click);
            this.btnPreviewReports.Leave += new System.EventHandler(this.btnPreviewReports_Leave);
            // 
            // btnAppConfig
            // 
            this.btnAppConfig.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAppConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppConfig.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAppConfig.Location = new System.Drawing.Point(0, 294);
            this.btnAppConfig.Name = "btnAppConfig";
            this.btnAppConfig.Size = new System.Drawing.Size(268, 75);
            this.btnAppConfig.TabIndex = 4;
            this.btnAppConfig.Text = "Konfiguracja";
            this.btnAppConfig.UseVisualStyleBackColor = false;
            this.btnAppConfig.Click += new System.EventHandler(this.btnAppConfig_Click);
            this.btnAppConfig.Leave += new System.EventHandler(this.btnAppConfig_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrola Klimatu Mikroszklarni";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnControlParametres;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAppConfig;
        private System.Windows.Forms.Button btnPreviewReports;
    }
}

