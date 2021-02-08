using System;
using System.Collections.Generic;


namespace GESTION_ETUDIANT.Models
{
    public class Professeur : Personne
    {
        private String grade;
        private String matricule;
        private List<String> modules;

        public Professeur()
        {
            Type = "Professeur";
        }

        public Professeur(int id, string nomComplet, string grade, string matricule) : base(id, nomComplet)
        {
            this.Grade = grade;
            this.Matricule = matricule;
            Type = "Professeur";
        }
        public Professeur(string nomComplet, string grade, string matricule) : base(nomComplet)
        {
            this.Grade = grade;
            this.Matricule = matricule;
            Type = "Professeur";
        }

        public string Grade { get => grade; set => grade = value; }
        public string Matricule { get => matricule; set => matricule = value; }
        public List<string> Modules { get => modules; set => modules = value; }
    }
}