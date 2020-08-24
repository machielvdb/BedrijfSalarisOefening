namespace BedrijfSalarisOefening.Forms
{
    partial class NieuweWerknemer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbContractType = new System.Windows.Forms.ComboBox();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbLoon = new System.Windows.Forms.TextBox();
            this.cbHerkomst = new System.Windows.Forms.ComboBox();
            this.btnVorige = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loon: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Herkomst:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contracttype:";
            // 
            // cbContractType
            // 
            this.cbContractType.FormattingEnabled = true;
            this.cbContractType.Location = new System.Drawing.Point(88, 78);
            this.cbContractType.Name = "cbContractType";
            this.cbContractType.Size = new System.Drawing.Size(177, 21);
            this.cbContractType.TabIndex = 4;
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(88, 6);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(177, 20);
            this.tbNaam.TabIndex = 5;
            // 
            // tbLoon
            // 
            this.tbLoon.Location = new System.Drawing.Point(88, 30);
            this.tbLoon.Name = "tbLoon";
            this.tbLoon.Size = new System.Drawing.Size(177, 20);
            this.tbLoon.TabIndex = 6;
            // 
            // cbHerkomst
            // 
            this.cbHerkomst.FormattingEnabled = true;
            this.cbHerkomst.Location = new System.Drawing.Point(88, 54);
            this.cbHerkomst.Name = "cbHerkomst";
            this.cbHerkomst.Size = new System.Drawing.Size(177, 21);
            this.cbHerkomst.TabIndex = 7;
            // 
            // btnVorige
            // 
            this.btnVorige.Location = new System.Drawing.Point(15, 105);
            this.btnVorige.Name = "btnVorige";
            this.btnVorige.Size = new System.Drawing.Size(119, 23);
            this.btnVorige.TabIndex = 8;
            this.btnVorige.Text = "Vorige";
            this.btnVorige.UseVisualStyleBackColor = true;
            this.btnVorige.Click += new System.EventHandler(this.btnVorige_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(140, 105);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(125, 23);
            this.btnToevoegen.TabIndex = 9;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // NieuweWerknemer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 135);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.btnVorige);
            this.Controls.Add(this.cbHerkomst);
            this.Controls.Add(this.tbLoon);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.cbContractType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NieuweWerknemer";
            this.Text = "NieuweWerknemer";
            this.Load += new System.EventHandler(this.NieuweWerknemer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbContractType;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbLoon;
        private System.Windows.Forms.ComboBox cbHerkomst;
        private System.Windows.Forms.Button btnVorige;
        private System.Windows.Forms.Button btnToevoegen;
    }
}