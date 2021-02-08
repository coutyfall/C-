using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_ETUDIANT.Models
{
    public class Classe
    {   //Asttributs
        private int id;
        private String libelle;
        private int nbreEtudiant;

        //Constructeurs
        //Surcharge
        //Par Defaut
        public Classe()
        {
        }
        //par insertion
        public Classe(string libelle, int nbreEtudiant)
        {
            this.Libelle = libelle;
            this.NbreEtudiant = nbreEtudiant;
        }

        public Classe(int id)
        {
            this.id = id;
        }

        //par selection
        public Classe(int id, string libelle, int nbreEtudiant)
        {
            this.Id = id;
            this.Libelle = libelle;
            this.NbreEtudiant = nbreEtudiant;
        }
        //Get et Set => Propriete

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public int NbreEtudiant { get => nbreEtudiant; set => nbreEtudiant = value; }

        //ToString()
        public override string ToString()
        {
            return libelle;
        }





    }
}