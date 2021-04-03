using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public sealed class SingletonClass
    {

        private static SingletonClass _instance = null;
        private static readonly object _lock = new object();

        SingletonClass() { }
        public static SingletonClass GetInstance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonClass();
                    }
                }
                return _instance;
            }
        }
    }
}
