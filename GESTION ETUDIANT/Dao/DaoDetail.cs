using GESTION_ETUDIANT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_ETUDIANT.Dao
{
    class DaoDetail : IDao<Detail>
    {
        private DaoSql sqlServer;

        public DaoDetail()
        {
            sqlServer = new DaoSql();
        }

        public int Insert(Detail detail)
        {
            String sql = String.Format("INSERT INTO gestion_etu.details" +
                "classe_id,professeur_id, " +
                "modules,annee" +
                "VALUES({0},{1},{2},{3})",
                detail.Classe.Id, detail.Professeur.Id,
                 Models.Convert.ListToString(detail.Modules),
                detail.Annee
                );
            return sqlServer.ExecuteUpdate(sql);
        }
        public List<String> ListerModulesProfesseurParClasse(Classe cl, Personne pers)
        {
            List<string> lModules = new List<string>();
            //Ecrire la requete
            String sql = string.Format("select" +
                "modules" +
                " from gestion_etu.details" +
                " where classe_id={0},professeur_id={0}," +
                " details.classe_id=cl.id and details.professeur_id=pers.id", cl.Id, pers.Id);
            //Remplir la liste 
            Detail detail = new Detail();
            lModules.Add(Models.Convert.StringToList(detail.Modules));
            return lModules;
        }
        public List<Classe> ListerClassesEnseignées(Personne prof)
        {
            List<Classe> lClasses = new List<Classe>();
            String sql = string.Format("select" +
                "classe_id" +
                " from gestion_etu.details" +
                " where professeur_id={0}" +
                " and details.professeur_id=pers.id", prof.Id);
            Detail detail = new Detail();
            lClasses.Add(detail.Classe);
            return lClasses;
        }


    }
}
