using System;

namespace Patterns_04
{
    /// <summary>
    /// Потокозащищенный Синглтон через дополнительный класс
    /// </summary>
    public class ThreadSafeSingleton
    {
        private ThreadSafeSingleton()
        {
            Console.WriteLine("Create ThreadSafeSingleton");
        }

        /// <summary>
        /// Свойство объекта синглатона
        /// </summary>
        public static ThreadSafeSingleton Instance
        {
            get => Nested.instance;
        }

        private class Nested
        {
            static Nested() {}

            internal static readonly ThreadSafeSingleton instance = new ThreadSafeSingleton();
        }
    }
}
