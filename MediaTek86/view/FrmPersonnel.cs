using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MediaTek86.controller;
using MediaTek86.model;

namespace MediaTek86.view
{
    /// <summary>
    /// Affiche une fenêtre qui permet de gérer le personnel
    /// </summary>
    public partial class frmPersonnel : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean ModifEnCoursPersonnel = false;
        /// <summary>
        /// Objet pour gérer la liste du personnel
        /// </summary>
        private readonly BindingSource bdgPersonnel = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des services
        /// </summary>
        private readonly BindingSource bdgService = new BindingSource();
        /// <summary>
        /// contrôleur de la fenêtre
        /// </summary>
        private FrmPersonnelController controller;
        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public frmPersonnel()
        {
            InitializeComponent();
            Init();
        }
        /// <summary>
        /// 
        /// </summary>
        private void Init()
        {
            controller = new FrmPersonnelController();
            RemplirListePersonnel();
            RemplirListeService();
            EnCoursModifPersonnel(false);
        }
        /// <summary>
        /// Affiche le personnel
        /// </summary>
        private void RemplirListePersonnel()
        {
            List<Personnel> lePersonnel = controller.GetLePersonnel();
            bdgPersonnel.DataSource = lePersonnel;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void RemplirListeService()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgService.DataSource = lesServices;
            cboService.DataSource = bdgService;
        }
        /// <summary>
        /// propriétés lorsque la fenêtre charge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPersonnel_Load(object sender, EventArgs e)
        {
            txtNom.Enabled = false;
            txtPrenom.Enabled = false;
            txtTel.Enabled = false;
            txtMail.Enabled = false;
            cboService.Enabled = false;
        }
        /// <summary>
        /// demande d'ajout d'un nouveau membre dans le personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterPersonnel_Click(object sender, EventArgs e)
        {
            txtNom.Enabled = true;
            txtPrenom.Enabled = true;
            txtTel.Enabled = true;
            txtMail.Enabled = true;
            cboService.Enabled = true;
        }
        /// <summary>
        /// enregistre les informations du membre du personnel et l'affiche dans la liste si c'est une nouveau membre sinon met à jour les informations s'il est déjà dans la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerPersonnel_Click(object sender, EventArgs e)
        {
            if (!txtNom.Equals("") && !txtPrenom.Equals("") && !txtTel.Equals("") && !txtMail.Equals("") && cboService.SelectedIndex != -1)
            {
                Service service = (Service)bdgService.List[bdgService.Position];
                if (ModifEnCoursPersonnel)
                {
                    Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    personnel.nom = txtNom.Text;
                    personnel.prenom = txtPrenom.Text;
                    personnel.tel = txtTel.Text;
                    personnel.mail = txtMail.Text;
                    personnel.service = service;
                    controller.UpdatePersonnel(personnel);
                }
                else
                {
                    Personnel personnel = new Personnel(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service);
                    controller.AddPersonnel(personnel);
                }
                RemplirListePersonnel();
                EnCoursModifPersonnel(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Informations");
            }
        }
        /// <summary>
        /// modification de l'affichage si on est en cours de modification ou d'ajout un membre dans le personnel
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursModifPersonnel(Boolean modif)
        {
            ModifEnCoursPersonnel = modif;
            grbPersonnel.Enabled = !modif;
            if (modif)
            {
                grbPersonnel.Text = "modifier un membre du personnel";
            }
            else
            {
                grbPersonnel.Text = "ajouter un nouveau membre dans le personnel";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
            }
        }
    }
}
