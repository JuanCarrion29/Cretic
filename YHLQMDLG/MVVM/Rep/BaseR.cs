using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YHLQMDLG.MVVM.Rep
{
    public abstract class BaseR
    {
        private readonly string _connectionString;
        public BaseR()
        {
            _connectionString = "Server=(local); Database=MVVMX100PRE; Integrated Security=true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }



    }
}
