namespace BedrijfSalarisOefening.Forms
{
    partial class Bedrijven
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbBedrijven = new System.Windows.Forms.ComboBox();
            this.cbWerknemers = new System.Windows.Forms.ComboBox();
            this.btnNieuwBedrijf = new System.Windows.Forms.Button();
            this.btnNieuweWerknemer = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbBedrijven
            // 
            this.cbBedrijven.FormattingEnabled = true;
            this.cbBedrijven.Location = new System.Drawing.Point(12, 12);
            this.cbBedrijven.Name = "cbBedrijven";
            this.cbBedrijven.Size = new System.Drawing.Size(184, 21);
            this.cbBedrijven.TabIndex = 0;
            this.cbBedrijven.SelectedIndexChanged += new System.EventHandler(this.cbBedrijven_SelectedIndexChanged);
            // 
            // cbWerknemers
            // 
            this.cbWerknemers.FormattingEnabled = true;
            this.cbWerknemers.Location = new System.Drawing.Point(221, 12);
            this.cbWerknemers.Name = "cbWerknemers";
            this.cbWerknemers.Size = new System.Drawing.Size(184, 21);
            this.cbWerknemers.TabIndex = 1;
            // 
            // btnNieuwBedrijf
            // 
            this.btnNieuwBedrijf.Location = new System.Drawing.Point(12, 39);
            this.btnNieuwBedrijf.Name = "btnNieuwBedrijf";
            this.btnNieuwBedrijf.Size = new System.Drawing.Size(184, 23);
            this.btnNieuwBedrijf.TabIndex = 2;
            this.btnNieuwBedrijf.Text = "Nieuw bedrijf";
            this.btnNieuwBedrijf.UseVisualStyleBackColor = true;
            // 
            // btnNieuweWerknemer
            // 
            this.btnNieuweWerknemer.Location = new System.Drawing.Point(221, 39);
            this.btnNieuweWerknemer.Name = "btnNieuweWerknemer";
            this.btnNieuweWerknemer.Size = new System.Drawing.Size(88, 23);
            this.btnNieuweWerknemer.TabIndex = 3;
            this.btnNieuweWerknemer.Text = "Nieuwe werknemer";
            this.btnNieuweWerknemer.UseVisualStyleBackColor = true;
            this.btnNieuweWerknemer.Click += new System.EventHandler(this.btnNieuweWerknemer_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(315, 39);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(87, 23);
            this.btnVerwijder.TabIndex = 4;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // Bedrijven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 72);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnNieuweWerknemer);
            this.Controls.Add(this.btnNieuwBedrijf);
            this.Controls.Add(this.cbWerknemers);
            this.Controls.Add(this.cbBedrijven);
            this.Name = "Bedrijven";
            this.Text = "Bedrijven";
            this.Load += new System.EventHandler(this.Bedrijven_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBedrijven;
        private System.Windows.Forms.ComboBox cbWerknemers;
        private System.Windows.Forms.Button btnNieuwBedrijf;
        private System.Windows.Forms.Button btnNieuweWerknemer;
        private System.Windows.Forms.Button btnVerwijder;
    }
}