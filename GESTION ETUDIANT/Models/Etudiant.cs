using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_ETUDIANT.Models
{
    class Etudiant : Personne
    {
        private String tuteur;
        private Classe classe;

        //Par défaut
        public Etudiant()
        {
            Type = "Etudiant";
        }
        //Selection
        public Etudiant(int id, String nomComplet, string tuteur, Classe classe) : base(id, nomComplet)
        {
            Type = "Etudiant";
            this.Tuteur = tuteur;
            this.Classe = classe;
        }
        //Insertion
        public Etudiant(String nomComplet, string tuteur, Classe classe) : base(nomComplet)
        {
            Type = "Etudiant";
            this.Tuteur = tuteur;
            this.Classe = classe;
        }
        //Get and Set
        public string Tuteur { get => tuteur; set => tuteur = value; }
        internal Classe Classe { get => classe; set => classe = value; }

    }

}
