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
    public partial class FrmInscription : Form
    {
        private Service metier = new Service();

       

        public FrmInscription()
        {
            InitializeComponent();
        }

        private void FrmInscription_Load(object sender, EventArgs e)
        {
            //Chargement du combobox
            //Propriete Afficher => DisplayMember
            //Propriete retournee apres Select d'un elt du combo => ValueMember
            cboClasse.DataSource = metier.ListerClasse();
            cboClasse.DisplayMember = "libelle";
            cboClasse.ValueMember = "id";
        }

        private void btnInscrire_Click(object sender, EventArgs e)
        {
            //Inscription d'un Etudiant
            if (string.IsNullOrEmpty(txtNomPrenom.Text) || string.IsNullOrEmpty(txtTuteur.Text))
            {
                MessageBox.Show("Champs Obligatoire,Erreur,MessageBoxButtons.OK,MessageBoxIcon.Error");

            }
            else
            {
                Etudiant etu = new Etudiant();
                 
                   etu. NomComplet = txtNomPrenom.Text.Trim();
                    etu.Tuteur = txtTuteur.Text.Trim();
                    etu.Type = "Etudiant";
                    etu.Classe.Id = int.Parse(cboClasse.SelectedValue.ToString());
                 
                if (metier.CreerPersonne(etu))
                {

                    MessageBox.Show("Etudiant inscrit avec succes,Information,MessageBoxButtons.OK,MessageBoxIcon.Information");
                }

                else
                {
                    MessageBox.Show("Ereur d'inscription,Erreur,MessageBoxButtons.OK,MessageBoxIcon.Error");


                }
            }
        }

       
    }
}
