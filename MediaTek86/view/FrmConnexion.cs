using System;
using System.Windows.Forms;

/// <summary>
/// 
/// </summary>
namespace MediaTek86.view
{
    /// <summary>
    /// Fenêtre de connexion pour accéder à la fenêtre qui permet de gérer le personnel et les absences
    /// </summary>
    public partial class frmConnexion : Form
    {
        /// <summary>
        /// Construction des composants graphiques et appels des autres initialisations
        /// </summary>
        public frmConnexion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ferme cette fenêtre et ouvre la fenêtre "Personnel" si le login et le mot de passe sont correctes. Affiche une erreur
        /// si les champs sont vides.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Equals("") || txtPwd.Text.Equals(""))
            {
                MessageBox.Show("les champs ne doivent pas être vides");
            }
        }

        /// <summary>
        /// Permet d'appeler la méthode btnConnexion_Click lorsqu'on appui sur la touche entrer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEntrer(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Keys.Enter))
            {
                btnConnexion_Click(null, null);
            }
        }

        /// <summary>
        /// Appel de la méthode BtnEntrer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_KeyPress(object sender, KeyPressEventArgs e)
        {
            BtnEntrer(null, null);
        }

        /// <summary>
        /// Appel de la méthode BtnEntrer 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            BtnEntrer(null, null);
        }

        /// <summary>
        /// Appel de la méthode BtnEntrer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            BtnEntrer(null, null);
        }
    }
}
