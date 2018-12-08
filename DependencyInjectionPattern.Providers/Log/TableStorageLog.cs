using DependencyInjectionPattern.Interfaces.Log;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPattern.Providers.Log
{
    public class TableStorageLog : ILog
    {
        public void Save()
        {
            Console.WriteLine("Logged");
        }
    }
}
