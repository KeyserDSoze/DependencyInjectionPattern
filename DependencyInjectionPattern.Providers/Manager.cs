using DependencyInjectionPattern.Interfaces;
using DependencyInjectionPattern.Interfaces.ConfigurationData;
using DependencyInjectionPattern.Interfaces.Customer;
using DependencyInjectionPattern.Interfaces.Customer.Subscription;
using DependencyInjectionPattern.Interfaces.Log;
using DependencyInjectionPattern.Providers.ConfigurationData;
using DependencyInjectionPattern.Providers.Customer;
using DependencyInjectionPattern.Providers.Customer.Subscription;
using DependencyInjectionPattern.Providers.Log;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPattern.Providers
{
    public class Manager : IManager
    {
        public IConfigurationData ConfigurationData { get; } = new SqlConfigurationData();
        public ILog Log { get; } = new TableStorageLog();

        // get CustomerBase from private field, it's not possible to pass the id parameter
        private ACustomerBase customerBase;
        public ACustomerBase CustomerBase => customerBase != null ? customerBase : customerBase = new CosmosDBCustomerBase(0, new SimpleSubscription(), this);

        // get CustomerBase with a Dependency Injection of ASubscription
        public ACustomerBase DifferentProviderCustomerBase(int id, ASubscription subscription) => new CosmosDBCustomerBase(id, subscription, this);

        // get CustomerBase with a Dependency Injection of id
        public ACustomerBase this[int id] => new CosmosDBCustomerBase(id, new SimpleSubscription(), this);

        // get CustomerBase with a Dependency Injection of ASubscription
        public ACustomerBase this[ASubscription subscription] => new CosmosDBCustomerBase(0, new SimpleSubscription(), this);
    }
}
