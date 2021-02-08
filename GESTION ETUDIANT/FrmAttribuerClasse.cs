
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GESTION_ETUDIANT.services;

namespace GESTION_ETUDIANT
{
    public partial class FrmAttribuerClasse : Form
    {
        Service metier = new Service();
        public FrmAttribuerClasse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

          

        private void btnAddClasse_Click(object sender, EventArgs e)
        {
            //vider datasource list box classe

            lboClassesEnseignees.Items.Clear();

            //vider datasource list box module

            lboModulesEnseignes.Items.Clear();
        }

        private void FrmAttribuerClasse_Load(object sender, EventArgs e)
        {

        }
    }

    
}
