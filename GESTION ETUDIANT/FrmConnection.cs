
using GESTION_ETUDIANT.Models;
using GESTION_ETUDIANT.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_ETUDIANT
{
    public partial class FrmConnection : Form
    {
        Service metier = new Service();
        public FrmConnection()
        {
            InitializeComponent();
        }

        private void FrmConnection_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            //1-verifier les champs

            if (string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrEmpty(txtPwd.Text))

            {

                lblError.Text = "Login ou Mot de passe obligatoire";

                lblError.Visible = true;

            }
            else
            {
                //champs valides
                Personne pers = metier.SeConnecter(txtLogin.Text.Trim(), txtPwd.Text.Trim());
                if (pers == null)
                {
                    lblError.Text = "Login ou Mot de passe incorrect";

                    lblError.Visible = true;
                }
                else
                {
                    //Ouvrir FrmMenu
                    FrmMenu frmMenu = new FrmMenu();
                    frmMenu.Show();
                    //this => Formulaire de connexion
                    this.Hide();
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtPwd.Clear();
        }

        private void FrmConnection_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
