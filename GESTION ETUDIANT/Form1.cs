
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GESTION_ETUDIANT.services;
using GESTION_ETUDIANT.Models;

namespace GESTION_ETUDIANT
{
    public partial class Form1 : Form
    {
        private Service metier = new Service();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadDataGridView()
        {
            dtgvClasse.DataSource = metier.ListerClasse();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLibelle.Text) || string.IsNullOrEmpty(txtLibelle.Text))
            {
                MessageBox.Show("Libelle ou Nombre d'étudiants obligatoires",
                    "Message d'erreur",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                Classe classe = new Classe()
                {
                    Libelle = txtLibelle.Text.Trim(),
                    NbreEtudiant = int.Parse(txtNbreEtudiant.Text.Trim())
                };
                if (metier.CreerClasse(classe))
                {
                    MessageBox.Show("Classe créée avec succés",
                    "Message d'information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                    txtLibelle.Clear();
                    txtNbreEtudiant.Clear();
                    LoadDataGridView();
                }
            }
        }

        private void dtgvClasse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //e.RowIndex =Index de lla ligne selectionne
            //1-Recuperer la ligne selectionner
            DataGridViewRow row = dtgvClasse.Rows[e.RowIndex];
            //2-Selectionnere toute la ligne
            row.Selected = true;
            //3-Recuperation de l' Id Classe
            // row.Cells; recupere les cellule de la ligne
            int id = int.Parse(row.Cells[0].Value.ToString());
            Classe classe = new Classe()

            {
                Id = id
            };
            //charger le dtgv Etudiant
            dtgvEtudiant.DataSource = metier.ListerEtudiantParClasse(classe);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             LoadDataGridView();
        }
    }
}

