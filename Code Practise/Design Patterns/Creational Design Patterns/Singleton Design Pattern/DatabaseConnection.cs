using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practise.Design_Patterns.Creational_Design_Patterns.Singleton_Design_Pattern
{
    public class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private static readonly object _lock = new object();
        private DatabaseConnection() { }

        public static DatabaseConnection CreateInstance()
        {
            if(_instance == null)
            {
                // check lock status
                lock (_lock)
                {
                    /* because of lock keyword, the first thread to come will be able to pass 
                     * and then this execution will be locked for other process to access
                     * it will be locked till the execution completes for first thread
                     * then it will be unlocked for second to come thread and so on
                     * */
                    if (_instance == null)
                    {
                        _instance = new DatabaseConnection();
                    }
                }
            }
            return _instance;
        }
    }
}
