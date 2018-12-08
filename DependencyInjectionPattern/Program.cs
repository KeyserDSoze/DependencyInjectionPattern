using DependencyInjectionPattern.Providers;
using DependencyInjectionPattern.Providers.Customer.Subscription;
using System;

namespace DependencyInjectionPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.ConfigurationData.GetProperty("xxx");
            manager.Log.Save();
            manager.CustomerBase.Subscribe(9);
            manager.DifferentProviderCustomerBase(5, new SimpleSubscription()).Subscribe();
            manager[7].Subscribe();
            manager[new SimpleSubscription()].Subscribe(9);
            Console.ReadLine();
        }
    }
}
