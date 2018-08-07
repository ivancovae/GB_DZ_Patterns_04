using System;

namespace Patterns_04
{
    /// <summary>
    /// Потокозащищенный Синглтон с объектом блокировки средствами lock
    /// </summary>
    public class ThreadSafeLockSingleton
    {
        private static ThreadSafeLockSingleton _instance;
        // объект блокировки
        private static object syncObject = new Object();

        // приватный конструктор
        private ThreadSafeLockSingleton()
        {
            Console.WriteLine("Create ThreadSafeLockSingleton");
        }

        /// <summary>
        /// Свойство объекта синглатона
        /// </summary>
        public static ThreadSafeLockSingleton Instance
        {
            get
            {
                if (_instance == null)
                {                    
                    lock (syncObject)
                    {
                        if (_instance == null)
                            _instance = new ThreadSafeLockSingleton();
                    }
                }
                return _instance;
            }
        }
    }
}
