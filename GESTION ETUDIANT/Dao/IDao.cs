using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_ETUDIANT.Dao
{
    public interface IDao<T>
    {
        int Insert(T obj);
    }
}