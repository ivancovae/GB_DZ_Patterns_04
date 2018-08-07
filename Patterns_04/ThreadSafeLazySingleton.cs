using System;
using System.Threading;

namespace Patterns_04
{
    /// <summary>
    /// Потокозащищенный Синглтон с поздней инициализацией
    /// </summary>
    public class ThreadSafeLazySingleton
    {
        // отложенная инициализация потокозащищенная по принципу только первый поток может инициализировать экземпляр
        private static readonly Lazy<ThreadSafeLazySingleton> _instance = new Lazy<ThreadSafeLazySingleton>(() => new ThreadSafeLazySingleton(), LazyThreadSafetyMode.ExecutionAndPublication);

        // приватный конструктор
        private ThreadSafeLazySingleton()
        {
            Console.WriteLine("Create ThreadSafeLazySingleton");
        }

        /// <summary>
        /// Свойство получения потокозащищенного синглтона с отложенной инициализации
        /// </summary>
        public static ThreadSafeLazySingleton Instance
        {
            get => _instance.Value;
        }
    }
}
