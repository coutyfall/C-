using System;

namespace GESTION_ETUDIANT.Models
{
    public abstract class Personne
    {
        
        private int id;
        private String nomComplet;
        private String type;
        private String login;
        private String pwd;
       

        //par défaut
        public Personne()
        {
        }
        //surcharge
        public Personne(string nomComplet)
        {
            this.nomComplet = nomComplet;

        }
        //selection
        public Personne(int id, string nomComplet)
        {
            this.Id = id;
            this.nomComplet = nomComplet;

        }

        public Personne(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }


        //Getter and Setter
        public int Id { get; set; }
        public string NomComplet { get; set; }
        public string Type { get; set; }
        public string Login { get; set; }
        public string Pwd { get; set; }
       
        //ToString
        public override string ToString()
        {
            return base.ToString();
        }
       

    }
}
