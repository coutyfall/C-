using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_ETUDIANT.Dao
{
    class DaoSql
    {
        private SqlConnection conn;
        //Execution des Requetes
        private SqlCommand cmd;
        //Convertir les enregistrement de la BD dans un DataSet
        private SqlDataAdapter da;

        public DaoSql()
        {
            //gerer la connexion dans BD SqlServer
            conn = new SqlConnection();
            //Execution des requetes
            cmd = new SqlCommand();
            //Convertir les Enregistrement de la BD dans un DataSet
            //DataSet est une BD en memoire centrale
            //un DataSet est forme d'un DataTable
            //DataTable est Table()
            da = new SqlDataAdapter();
        }

        public void OuvrirConnexionBD()
        {
            if (conn.State == ConnectionState.Closed ||
               conn.State == ConnectionState.Broken)
            {
                conn.ConnectionString = @"Data Source =DESKTOP-82AJ0UU ;  Initial Catalog=gestion_etudiant;Integrated Security=True ";
                conn.Open();

            }

        }
        public void FermerConnexionBD()
        {
            if (conn.State == ConnectionState.Open ||
                conn.State == ConnectionState.Connecting)
            {
                conn.Close();

            }
        }
        public int ExecuteUpdate(string sql)
        {
            int nbreLigne = 0;

            OuvrirConnexionBD();

            cmd.Connection = conn;
            cmd.CommandText = sql;
            nbreLigne = cmd.ExecuteNonQuery();

            FermerConnexionBD();

            return nbreLigne;
        }
        public DataTable ExecuteSelect(string sql)
        {
            OuvrirConnexionBD();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            //DataSet =>Base  de Donnee en Memoire Centrale(RAM)
            //DataSet est Forme de DataTable => Table BD
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds, "result");
            FermerConnexionBD();

            return ds.Tables["result"];

        }
    }
}