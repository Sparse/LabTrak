using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlServerCe;
using System.Text;
using System.Threading.Tasks;

namespace LabTrak.SQLTools
{
    class CompactDatabaseReader
    {
        public SqlCeDataReader SqlCeReader { get { return mSqlCeReader; } set { mSqlCeReader = value; } }
        private SqlCeDataReader mSqlCeReader;

        public void CreateReader(SqlCeDataReader pDataReader)
        {
            mSqlCeReader = pDataReader;
        }

        public string ReadDataStrings(SqlCeDataReader pDataReader, int[] pDataIndices)
        {
            StringBuilder sb = new StringBuilder();
            while (pDataReader.Read())
            {
                for (int i = 0; i < pDataIndices.Length; i++)
                {
                    sb.Append(pDataReader.GetString(pDataIndices[i]));
                }
            }

            return sb.ToString();
        }

        //ToDo: For making a dynamic DataReader, based off of the SQLCeCommandString
        //public void ReadData(SqlCeDataReader pDataReader, string[] pStringValues, bool[] pBooleanValues, int[] pIntegerValues, int[] pDataBaseIndecies)
        //{
        //    pDataReader.Read();
        //}

    }
}
