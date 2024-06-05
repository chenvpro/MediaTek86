
namespace MediaTek86.view
{
    partial class frmPersonnel
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
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.btnAjouterPersonnel = new System.Windows.Forms.Button();
            this.btnModifierPersonnel = new System.Windows.Forms.Button();
            this.btnSupprimerPersonnel = new System.Windows.Forms.Button();
            this.btnGererAbsence = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.btnEnregistrerPersonnel = new System.Windows.Forms.Button();
            this.btnAnnulerPersonnel = new System.Windows.Forms.Button();
            this.grbPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.dgvPersonnel);
            this.grbPersonnel.Location = new System.Drawing.Point(13, 13);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Size = new System.Drawing.Size(574, 388);
            this.grbPersonnel.TabIndex = 0;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "liste du personnel";
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(7, 22);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.RowHeadersWidth = 51;
            this.dgvPersonnel.RowTemplate.Height = 24;
            this.dgvPersonnel.Size = new System.Drawing.Size(561, 360);
            this.dgvPersonnel.TabIndex = 0;
            // 
            // btnAjouterPersonnel
            // 
            this.btnAjouterPersonnel.Location = new System.Drawing.Point(317, 407);
            this.btnAjouterPersonnel.Name = "btnAjouterPersonnel";
            this.btnAjouterPersonnel.Size = new System.Drawing.Size(86, 31);
            this.btnAjouterPersonnel.TabIndex = 1;
            this.btnAjouterPersonnel.Text = "ajouter";
            this.btnAjouterPersonnel.UseVisualStyleBackColor = true;
            this.btnAjouterPersonnel.Click += new System.EventHandler(this.btnAjouterPersonnel_Click);
            // 
            // btnModifierPersonnel
            // 
            this.btnModifierPersonnel.Location = new System.Drawing.Point(409, 407);
            this.btnModifierPersonnel.Name = "btnModifierPersonnel";
            this.btnModifierPersonnel.Size = new System.Drawing.Size(86, 31);
            this.btnModifierPersonnel.TabIndex = 2;
            this.btnModifierPersonnel.Text = "modifier";
            this.btnModifierPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerPersonnel
            // 
            this.btnSupprimerPersonnel.Location = new System.Drawing.Point(501, 407);
            this.btnSupprimerPersonnel.Name = "btnSupprimerPersonnel";
            this.btnSupprimerPersonnel.Size = new System.Drawing.Size(86, 31);
            this.btnSupprimerPersonnel.TabIndex = 3;
            this.btnSupprimerPersonnel.Text = "supprimer";
            this.btnSupprimerPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnGererAbsence
            // 
            this.btnGererAbsence.Location = new System.Drawing.Point(12, 407);
            this.btnGererAbsence.Name = "btnGererAbsence";
            this.btnGererAbsence.Size = new System.Drawing.Size(144, 31);
            this.btnGererAbsence.TabIndex = 4;
            this.btnGererAbsence.Text = "gérer les absences";
            this.btnGererAbsence.UseVisualStyleBackColor = true;
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(734, 13);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(85, 17);
            this.lblInformation.TabIndex = 5;
            this.lblInformation.Text = "informations";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(618, 41);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(47, 17);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "nom : ";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(618, 69);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(68, 17);
            this.lblPrenom.TabIndex = 7;
            this.lblPrenom.Text = "prenom : ";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(618, 97);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(31, 17);
            this.lblTel.TabIndex = 8;
            this.lblTel.Text = "tel :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(618, 125);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(45, 17);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "mail : ";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(618, 153);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(65, 17);
            this.lblService.TabIndex = 10;
            this.lblService.Text = "service : ";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(692, 38);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(238, 22);
            this.txtNom.TabIndex = 11;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(692, 66);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(238, 22);
            this.txtPrenom.TabIndex = 12;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(692, 94);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(238, 22);
            this.txtTel.TabIndex = 13;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(692, 122);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(238, 22);
            this.txtMail.TabIndex = 14;
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(692, 150);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(238, 24);
            this.cboService.TabIndex = 15;
            // 
            // btnEnregistrerPersonnel
            // 
            this.btnEnregistrerPersonnel.Location = new System.Drawing.Point(752, 183);
            this.btnEnregistrerPersonnel.Name = "btnEnregistrerPersonnel";
            this.btnEnregistrerPersonnel.Size = new System.Drawing.Size(86, 31);
            this.btnEnregistrerPersonnel.TabIndex = 16;
            this.btnEnregistrerPersonnel.Text = "enregistrer";
            this.btnEnregistrerPersonnel.UseVisualStyleBackColor = true;
            this.btnEnregistrerPersonnel.Click += new System.EventHandler(this.btnEnregistrerPersonnel_Click);
            // 
            // btnAnnulerPersonnel
            // 
            this.btnAnnulerPersonnel.Location = new System.Drawing.Point(844, 183);
            this.btnAnnulerPersonnel.Name = "btnAnnulerPersonnel";
            this.btnAnnulerPersonnel.Size = new System.Drawing.Size(86, 31);
            this.btnAnnulerPersonnel.TabIndex = 17;
            this.btnAnnulerPersonnel.Text = "annuler";
            this.btnAnnulerPersonnel.UseVisualStyleBackColor = true;
            // 
            // frmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.btnAnnulerPersonnel);
            this.Controls.Add(this.btnEnregistrerPersonnel);
            this.Controls.Add(this.cboService);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.btnGererAbsence);
            this.Controls.Add(this.btnSupprimerPersonnel);
            this.Controls.Add(this.btnModifierPersonnel);
            this.Controls.Add(this.btnAjouterPersonnel);
            this.Controls.Add(this.grbPersonnel);
            this.Name = "frmPersonnel";
            this.Text = "Personnel";
            this.Load += new System.EventHandler(this.frmPersonnel_Load);
            this.grbPersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPersonnel;
        private System.Windows.Forms.Button btnAjouterPersonnel;
        private System.Windows.Forms.Button btnModifierPersonnel;
        private System.Windows.Forms.Button btnSupprimerPersonnel;
        private System.Windows.Forms.Button btnGererAbsence;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.Button btnEnregistrerPersonnel;
        private System.Windows.Forms.Button btnAnnulerPersonnel;
        private System.Windows.Forms.DataGridView dgvPersonnel;
    }
}