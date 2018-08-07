using System;

namespace Patterns_04
{
    /// <summary>
    /// Потоконезащищенный Синглтон
    /// </summary>
    public class SingletonClass
    {
        private static SingletonClass _instance;

        private SingletonClass()
        {
            Console.WriteLine("Create Singleton");
        }

        /// <summary>
        /// Свойство объекта синглатона
        /// </summary>
        public static SingletonClass Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SingletonClass();
                }
                return _instance;
            }
        }
    }
}
