using System;
using System.Collections.Generic;

namespace GESTION_ETUDIANT.Models
{
    class Detail
    {
        private String annee;
        private List<String> modules;
        private Classe classe;
        private Professeur professeur;

        public Detail()
        {
        }

        public Detail(string annee, Classe classe, Professeur professeur)
        {
            this.Annee = annee;
            this.Classe = classe;
            this.Professeur = professeur;
        }

        public Detail(string annee, List<string> modules, Classe classe, Professeur professeur)
        {
            Annee = annee;
            Modules = modules;
            Classe = classe;
            Professeur = professeur;
        }

        public string Annee { get => annee; set => annee = value; }
        public List<string> Modules { get => modules; set => modules = value; }
        internal Professeur Professeur { get => professeur; set => professeur = value; }
        internal Classe Classe { get => classe; set => classe = value; }

        
    }
}