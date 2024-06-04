
namespace MediaTek86.view
{
    partial class frmAbsence
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
            this.grbAbsence = new System.Windows.Forms.GroupBox();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.btnAjouterAbsence = new System.Windows.Forms.Button();
            this.btnModifierAbsence = new System.Windows.Forms.Button();
            this.btnSupprimerAbsence = new System.Windows.Forms.Button();
            this.btnEnregistrerAbsence = new System.Windows.Forms.Button();
            this.btnAnnulerAbsence = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grbAbsence
            // 
            this.grbAbsence.Location = new System.Drawing.Point(12, 12);
            this.grbAbsence.Name = "grbAbsence";
            this.grbAbsence.Size = new System.Drawing.Size(632, 329);
            this.grbAbsence.TabIndex = 0;
            this.grbAbsence.TabStop = false;
            this.grbAbsence.Text = "Absences";
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(238, 347);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 22);
            this.dtpDebut.TabIndex = 1;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(444, 347);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 22);
            this.dtpFin.TabIndex = 2;
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(290, 375);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(354, 22);
            this.txtMotif.TabIndex = 3;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(238, 378);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(46, 17);
            this.lblMotif.TabIndex = 4;
            this.lblMotif.Text = "motif :";
            // 
            // btnAjouterAbsence
            // 
            this.btnAjouterAbsence.Location = new System.Drawing.Point(650, 18);
            this.btnAjouterAbsence.Name = "btnAjouterAbsence";
            this.btnAjouterAbsence.Size = new System.Drawing.Size(87, 50);
            this.btnAjouterAbsence.TabIndex = 5;
            this.btnAjouterAbsence.Text = "ajouter";
            this.btnAjouterAbsence.UseVisualStyleBackColor = true;
            // 
            // btnModifierAbsence
            // 
            this.btnModifierAbsence.Location = new System.Drawing.Point(650, 74);
            this.btnModifierAbsence.Name = "btnModifierAbsence";
            this.btnModifierAbsence.Size = new System.Drawing.Size(86, 50);
            this.btnModifierAbsence.TabIndex = 6;
            this.btnModifierAbsence.Text = "modifier";
            this.btnModifierAbsence.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerAbsence
            // 
            this.btnSupprimerAbsence.Location = new System.Drawing.Point(650, 130);
            this.btnSupprimerAbsence.Name = "btnSupprimerAbsence";
            this.btnSupprimerAbsence.Size = new System.Drawing.Size(86, 50);
            this.btnSupprimerAbsence.TabIndex = 7;
            this.btnSupprimerAbsence.Text = "supprimer";
            this.btnSupprimerAbsence.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrerAbsence
            // 
            this.btnEnregistrerAbsence.Location = new System.Drawing.Point(456, 403);
            this.btnEnregistrerAbsence.Name = "btnEnregistrerAbsence";
            this.btnEnregistrerAbsence.Size = new System.Drawing.Size(91, 26);
            this.btnEnregistrerAbsence.TabIndex = 8;
            this.btnEnregistrerAbsence.Text = "enregistrer";
            this.btnEnregistrerAbsence.UseVisualStyleBackColor = true;
            // 
            // btnAnnulerAbsence
            // 
            this.btnAnnulerAbsence.Location = new System.Drawing.Point(553, 403);
            this.btnAnnulerAbsence.Name = "btnAnnulerAbsence";
            this.btnAnnulerAbsence.Size = new System.Drawing.Size(91, 26);
            this.btnAnnulerAbsence.TabIndex = 9;
            this.btnAnnulerAbsence.Text = "annuler";
            this.btnAnnulerAbsence.UseVisualStyleBackColor = true;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(12, 347);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(86, 50);
            this.btnRetour.TabIndex = 10;
            this.btnRetour.Text = "retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // Absence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAnnulerAbsence);
            this.Controls.Add(this.btnEnregistrerAbsence);
            this.Controls.Add(this.btnSupprimerAbsence);
            this.Controls.Add(this.btnModifierAbsence);
            this.Controls.Add(this.btnAjouterAbsence);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.grbAbsence);
            this.Name = "Absence";
            this.Text = "Absence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAbsence;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Button btnAjouterAbsence;
        private System.Windows.Forms.Button btnModifierAbsence;
        private System.Windows.Forms.Button btnSupprimerAbsence;
        private System.Windows.Forms.Button btnEnregistrerAbsence;
        private System.Windows.Forms.Button btnAnnulerAbsence;
        private System.Windows.Forms.Button btnRetour;
    }
}