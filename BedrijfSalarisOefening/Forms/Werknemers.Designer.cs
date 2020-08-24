namespace BedrijfSalarisOefening.Forms
{
    partial class Werknemers
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
            this.cbWerknemers = new System.Windows.Forms.ComboBox();
            this.lblSalaris = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAfkomst = new System.Windows.Forms.Label();
            this.btnVorige = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbWerknemers
            // 
            this.cbWerknemers.FormattingEnabled = true;
            this.cbWerknemers.Location = new System.Drawing.Point(12, 12);
            this.cbWerknemers.Name = "cbWerknemers";
            this.cbWerknemers.Size = new System.Drawing.Size(206, 21);
            this.cbWerknemers.TabIndex = 0;
            this.cbWerknemers.SelectedIndexChanged += new System.EventHandler(this.cbWerknemers_SelectedIndexChanged);
            // 
            // lblSalaris
            // 
            this.lblSalaris.AutoSize = true;
            this.lblSalaris.Location = new System.Drawing.Point(12, 36);
            this.lblSalaris.Name = "lblSalaris";
            this.lblSalaris.Size = new System.Drawing.Size(0, 13);
            this.lblSalaris.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Afkomst:";
            // 
            // lblAfkomst
            // 
            this.lblAfkomst.AutoSize = true;
            this.lblAfkomst.Location = new System.Drawing.Point(54, 69);
            this.lblAfkomst.Name = "lblAfkomst";
            this.lblAfkomst.Size = new System.Drawing.Size(0, 13);
            this.lblAfkomst.TabIndex = 4;
            // 
            // btnVorige
            // 
            this.btnVorige.Location = new System.Drawing.Point(12, 87);
            this.btnVorige.Name = "btnVorige";
            this.btnVorige.Size = new System.Drawing.Size(208, 23);
            this.btnVorige.TabIndex = 5;
            this.btnVorige.Text = "Vorige";
            this.btnVorige.UseVisualStyleBackColor = true;
            this.btnVorige.Click += new System.EventHandler(this.btnVorige_Click);
            // 
            // Werknemers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 117);
            this.Controls.Add(this.btnVorige);
            this.Controls.Add(this.lblAfkomst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSalaris);
            this.Controls.Add(this.cbWerknemers);
            this.Name = "Werknemers";
            this.Text = "Werknemers";
            this.Load += new System.EventHandler(this.Werknemers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbWerknemers;
        private System.Windows.Forms.Label lblSalaris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAfkomst;
        private System.Windows.Forms.Button btnVorige;
    }
}