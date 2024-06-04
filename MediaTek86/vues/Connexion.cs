using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86
{
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void BtnEntrer(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Keys.Enter))
            {
                btnConnexion_Click(null, null);
            }
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

        private void btnConnexion_KeyPress(object sender, KeyPressEventArgs e)
        {
            BtnEntrer(null, null);
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            BtnEntrer(null, null);
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            BtnEntrer(null, null);
        }
    }
}
