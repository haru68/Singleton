using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Class2
    {
        private DatabaseSingleton _database = DatabaseSingleton.GetInstance();

        public void DisplayAllInDB()
        {

            List<string> DBList = DatabaseSingleton.GetInstance().GetAllFromDB();
            foreach (string item in DBList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
