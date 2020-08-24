namespace BedrijfSalarisOefening
{
    partial class Hoofdmenu
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
            this.btnWerknemers = new System.Windows.Forms.Button();
            this.btnSalarissen = new System.Windows.Forms.Button();
            this.btnBedrijven = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWerknemers
            // 
            this.btnWerknemers.Location = new System.Drawing.Point(12, 12);
            this.btnWerknemers.Name = "btnWerknemers";
            this.btnWerknemers.Size = new System.Drawing.Size(96, 23);
            this.btnWerknemers.TabIndex = 0;
            this.btnWerknemers.Text = "Werknemers";
            this.btnWerknemers.UseVisualStyleBackColor = true;
            this.btnWerknemers.Click += new System.EventHandler(this.btnWerknemers_Click);
            // 
            // btnSalarissen
            // 
            this.btnSalarissen.Location = new System.Drawing.Point(12, 41);
            this.btnSalarissen.Name = "btnSalarissen";
            this.btnSalarissen.Size = new System.Drawing.Size(96, 23);
            this.btnSalarissen.TabIndex = 1;
            this.btnSalarissen.Text = "Salarissen";
            this.btnSalarissen.UseVisualStyleBackColor = true;
            this.btnSalarissen.Click += new System.EventHandler(this.btnSalarissen_Click);
            // 
            // btnBedrijven
            // 
            this.btnBedrijven.Location = new System.Drawing.Point(12, 70);
            this.btnBedrijven.Name = "btnBedrijven";
            this.btnBedrijven.Size = new System.Drawing.Size(96, 23);
            this.btnBedrijven.TabIndex = 2;
            this.btnBedrijven.Text = "Bedrijven";
            this.btnBedrijven.UseVisualStyleBackColor = true;
            this.btnBedrijven.Click += new System.EventHandler(this.btnBedrijven_Click);
            // 
            // Hoofdmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 103);
            this.Controls.Add(this.btnBedrijven);
            this.Controls.Add(this.btnSalarissen);
            this.Controls.Add(this.btnWerknemers);
            this.Name = "Hoofdmenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Hoofdmenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWerknemers;
        private System.Windows.Forms.Button btnSalarissen;
        private System.Windows.Forms.Button btnBedrijven;
    }
}

