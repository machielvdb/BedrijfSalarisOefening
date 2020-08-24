namespace BedrijfSalarisOefening.Forms
{
    partial class Salarissen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblHerkomst = new System.Windows.Forms.Label();
            this.lblContractType = new System.Windows.Forms.Label();
            this.lblLoon = new System.Windows.Forms.Label();
            this.btnVorige = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbWerknemers
            // 
            this.cbWerknemers.FormattingEnabled = true;
            this.cbWerknemers.Location = new System.Drawing.Point(12, 12);
            this.cbWerknemers.Name = "cbWerknemers";
            this.cbWerknemers.Size = new System.Drawing.Size(214, 21);
            this.cbWerknemers.TabIndex = 0;
            this.cbWerknemers.SelectedIndexChanged += new System.EventHandler(this.cbWerknemers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naam: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Herkomst: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contracttype: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Loon:";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(90, 36);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(0, 13);
            this.lblNaam.TabIndex = 5;
            // 
            // lblHerkomst
            // 
            this.lblHerkomst.AutoSize = true;
            this.lblHerkomst.Location = new System.Drawing.Point(90, 58);
            this.lblHerkomst.Name = "lblHerkomst";
            this.lblHerkomst.Size = new System.Drawing.Size(0, 13);
            this.lblHerkomst.TabIndex = 6;
            // 
            // lblContractType
            // 
            this.lblContractType.AutoSize = true;
            this.lblContractType.Location = new System.Drawing.Point(90, 81);
            this.lblContractType.Name = "lblContractType";
            this.lblContractType.Size = new System.Drawing.Size(0, 13);
            this.lblContractType.TabIndex = 7;
            // 
            // lblLoon
            // 
            this.lblLoon.AutoSize = true;
            this.lblLoon.Location = new System.Drawing.Point(90, 105);
            this.lblLoon.Name = "lblLoon";
            this.lblLoon.Size = new System.Drawing.Size(0, 13);
            this.lblLoon.TabIndex = 8;
            // 
            // btnVorige
            // 
            this.btnVorige.Location = new System.Drawing.Point(12, 142);
            this.btnVorige.Name = "btnVorige";
            this.btnVorige.Size = new System.Drawing.Size(214, 23);
            this.btnVorige.TabIndex = 9;
            this.btnVorige.Text = "Vorige";
            this.btnVorige.UseVisualStyleBackColor = true;
            // 
            // Salarissen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 177);
            this.Controls.Add(this.btnVorige);
            this.Controls.Add(this.lblLoon);
            this.Controls.Add(this.lblContractType);
            this.Controls.Add(this.lblHerkomst);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbWerknemers);
            this.Name = "Salarissen";
            this.Text = "Salarissen";
            this.Load += new System.EventHandler(this.Salarissen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbWerknemers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblHerkomst;
        private System.Windows.Forms.Label lblContractType;
        private System.Windows.Forms.Label lblLoon;
        private System.Windows.Forms.Button btnVorige;
    }
}