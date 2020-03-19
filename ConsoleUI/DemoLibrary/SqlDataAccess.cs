using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SqlDataAccess : DataAccess
    {
        /// <summary>
        /// Loads Microsoft SQl Data
        /// </summary>
        /// <param name="sql"></param>
        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading Microsoft SQL Data");
        }
        /// <summary>
        /// Saves to Microsoft SQL Server
        /// </summary>
        /// <param name="sql"></param>
        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving data to Microsoft SQL Server");
        }
    }
}
