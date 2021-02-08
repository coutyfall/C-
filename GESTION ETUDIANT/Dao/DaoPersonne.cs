using GESTION_ETUDIANT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GESTION_ETUDIANT.Dao
{
    class DaoPersonne
    {
        private DaoSql sqlServer;

        public DaoPersonne()
        {
            sqlServer = new DaoSql();
        }

        public int Insert(Personne pers)
        {
            String sql = String.Format("INSERT INTO gestion_etu.personne" +
                "nom_complet,type, " +
                "tuteur,modules" +
                "grade,matricule,classe_id,login,pwd) " +
                "VALUES({0},{1},{2},{3},{4},{5},{6},{7})",
                pers.NomComplet, pers.Type,
                ((Etudiant)pers).Tuteur, Models.Convert.ListToString(((Professeur)pers).Modules),
                ((Professeur)pers).Grade,
                ((Professeur)pers).Matricule,
                ((Etudiant)pers).Classe.Id
                );
            return sqlServer.ExecuteUpdate(sql);
        }
        public DataTable FindByClasse(Classe classe)
        {
            List<Etudiant> lEtudiants = new List<Etudiant>();
            //Ecrire la requete
            String sql = string.Format("select" +
                " p.id,nom_complet as 'Nom & Prenom',tuteur," +
                "libelle as 'Classe',nbre as 'Nombre'" +
                " from gestion_etu.personne p,gestion_etu.classe cl" +
                " where classe_id={0}" +
                " and cl.id=p.classe_id", classe.Id);
            //Remplir la liste
            return sqlServer.ExecuteSelect(sql);
        }
        public Personne FindUserConnect(String login, String pwd)
        {
            Personne pers = null;
            String sql = String.Format("select * from gestion_etu.personne where login='{0}' and pwd='{1}'", login, pwd);
            //Executer la requete
            DataTable dt = sqlServer.ExecuteSelect(sql);
            foreach (DataRow row in dt.Rows)
            {
                String type = row.ItemArray[2].ToString().Trim();
                if (type.CompareTo("Admin") == 0)
                {
                    pers = new Admin();
                }
                if (type.CompareTo("Etudiant") == 0)
                {
                    pers = new Etudiant()
                    {

                        Tuteur = row.ItemArray[3].ToString().Trim()
                    };

                }
                if (type.CompareTo("Professeur") == 0)
                {
                    pers = new Professeur()
                    {
                        Grade = row.ItemArray[4].ToString().Trim(),
                        Matricule = row.ItemArray[6].ToString().Trim(),
                        Modules = Models.Convert.StringToList(row.ItemArray[5].ToString().Trim())
                    };
                }
                //champs communs
                pers.Id = int.Parse(row.ItemArray[0].ToString().Trim());
                pers.NomComplet = row.ItemArray[1].ToString().Trim();
            }
            return pers;
        }
        public Professeur FindProfesseurByMatricule(String matricule)
        {
            Professeur professeur = null;
            String sql = string.Format("select * from gestion_etu.personne where  matricule={0}", matricule);
            return professeur;
        }
        public List<Professeur> FindALLProfesseur()
        {
            List<Professeur> lProfesseurs = new List<Professeur>();
            String sql = string.Format("select * from gestion_etu.personne where type='Professeur'");
            //remplir la liste
            DataTable dt = sqlServer.ExecuteSelect(sql);
            //Convertir notre DataTable en une List<Personne>
            //DataRow est une ligne d'un DataTable
            foreach (DataRow row in dt.Rows)
            {
                //Convertir DataRow en objet de classe
                Professeur prof = new Professeur()
                {
                    Id = int.Parse(row.ItemArray[0].ToString().Trim()),
                    NomComplet = row.ItemArray[1].ToString().Trim(),
                    Grade = row.ItemArray[4].ToString().Trim(),
                    Matricule = row.ItemArray[6].ToString().Trim(),
                    Modules = Models.Convert.StringToList(row.ItemArray[5].ToString().Trim())

                };
                lProfesseurs.Add(prof);
            }
            return lProfesseurs;
        }
        public List<Etudiant> FindALLEtudiant()
        {
            List<Etudiant> lEtudiants = new List<Etudiant>();
            String sql = string.Format("select * from gestion_etu.personne where type='Etudiant'");
            //remplir la liste
            DataTable dt = sqlServer.ExecuteSelect(sql);
            //Convertir notre DataTable en une List<Personne>
            //DataRow est une ligne d'un DataTable
            foreach (DataRow row in dt.Rows)
            {
                //Convertir DataRow en objet de classe
                Etudiant etu = new Etudiant();
                etu.Id = int.Parse(row.ItemArray[0].ToString().Trim());
                etu.NomComplet = row.ItemArray[1].ToString().Trim();
                etu.Tuteur = row.ItemArray[3].ToString().Trim();
                etu.Classe.Id = int.Parse(row.ItemArray[7].ToString().Trim());
                lEtudiants.Add(etu);
            }
            return lEtudiants;
        }
    }
}
