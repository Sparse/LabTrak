using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlServerCe;
using System.Text;
using System.Threading.Tasks;

namespace LabTrak.SQLTools
{
    class CompactDatabaseCommand
    {
        public SqlCeCommand SqlCeCommandString { get { return mSqlCeCommandString; } set { mSqlCeCommandString = value; } }
        private SqlCeCommand mSqlCeCommandString;

        public void CreateCommand(SqlCeCommand pSqlCommand)
        {
            mSqlCeCommandString = pSqlCommand;
        }

        //ToDo: Parse command types based on the CommandString and the Query it contains
    }
}
