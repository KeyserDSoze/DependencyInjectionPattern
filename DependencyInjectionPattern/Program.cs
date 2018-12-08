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
            manager.CustomerBase.Subscribe(9);  //in this case I use Subscibe method with id
            manager.DifferentProviderCustomerBase(5, new SimpleSubscription()).Subscribe(); //in this case I don't need to use the id in Subscribe method
            manager[7].Subscribe(); //in this case I don't need to use the id in Subscribe method
            manager[new SimpleSubscription()].Subscribe(9); //in this case I use Subscibe method with id
            //Choose the one you prefer
            Console.ReadLine();
        }
    }
}
