using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlServerCe;
using System.Text;
using System.Threading.Tasks;

namespace LabTrak.SQLTools
{
    class CompactDataBaseConnection
    {
        public SqlCeConnection SqlCeSocket { get { return mSqlCeSocket; } set { mSqlCeSocket = value; } }
        private SqlCeConnection mSqlCeSocket;

        public void ConnectToDatabase(string pConnectionString)
        {
            mSqlCeSocket = new SqlCeConnection(pConnectionString);
            mSqlCeSocket.Open();
        }

        public void CloseDatabaseConnection(SqlCeConnection pSqlCeSocket)
        {
            pSqlCeSocket.Close();
        }
    }
}
