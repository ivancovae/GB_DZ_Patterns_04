using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace Patterns_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // потоконезащищенный синглтон
            (new Thread(() =>
            {
                SingletonClass instanceOne = SingletonClass.Instance;
            })).Start();
            SingletonClass instanceTwo = SingletonClass.Instance;

            // потокозащищенный синглтон
            (new Thread(() =>
            {
                ThreadSafeSingleton instanceSafeOne = ThreadSafeSingleton.Instance;
            })).Start();
            ThreadSafeSingleton instanceSafeTwo = ThreadSafeSingleton.Instance;

            // потокозащищенный синглтон
            (new Thread(() =>
            {
                ThreadSafeLazySingleton instanceSafeLazyOne = ThreadSafeLazySingleton.Instance;
            })).Start();
            ThreadSafeLazySingleton instanceSafeLazyTwo = ThreadSafeLazySingleton.Instance;

            // потокозащищенный синглтон
            (new Thread(() =>
            {
                ThreadSafeLockSingleton instanceSafeLockOne = ThreadSafeLockSingleton.Instance;
            })).Start();
            ThreadSafeLockSingleton instanceSafeLockTwo = ThreadSafeLockSingleton.Instance;
            Console.ReadKey();
        }
    }
}
