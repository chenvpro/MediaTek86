using MediaTek86.controller;
using System;
using System.Windows.Forms;
using MediaTek86.model;
using MediaTek86.bddmanager;

/// <summary>
/// 
/// </summary>
namespace MediaTek86.view
{
    /// <summary>
    /// Fenêtre de connexion pour accéder à la fenêtre qui permet de gérer le personnel et les absences (seul le responsable peut se connecter)
    /// </summary>
    public partial class frmConnexion : Form
    {
        /// <summary>
        /// contrôleur de la fenêtre
        /// </summary>
        private FrmConnexionController controller;
        /// <summary>
        /// Construction des composants graphiques et appels des autres initialisations
        /// </summary>
        public frmConnexion()
        {
            InitializeComponent();
            Init();
        }
        /// <summary>
        /// Initialisation : 
        /// création du contrôleur
        /// </summary>
        private void Init()
        {
            controller = new FrmConnexionController();
        }
        /// <summary>
        /// demande au contrôleur de vérifier les informations de connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            String login = txtLogin.Text;
            String pwd = txtPwd.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("les champs ne doivent pas être vides","informations");
            }
            else
            {
                Responsable responsable = new Responsable(login, pwd);
                if (controller.ControleConnexion(responsable))
                {
                    frmPersonnel frm = new frmPersonnel();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("login ou mot de passe incorrect", "Alerte");
                }
            }
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }
    }
}
