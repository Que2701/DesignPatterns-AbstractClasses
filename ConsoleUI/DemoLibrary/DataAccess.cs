using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public abstract class DataAccess
    {
        /// <summary>
        /// Load the connection string
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public virtual string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "TestConnectionString";
        }
        public abstract void LoadData(string sql);
        public abstract void SaveData(string sql);
    }
}
