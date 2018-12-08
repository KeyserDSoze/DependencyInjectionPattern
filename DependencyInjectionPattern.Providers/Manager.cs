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
        private ACustomerBase customerBase;
        public ACustomerBase CustomerBase => customerBase != null ? customerBase : customerBase = new CosmosDBCustomerBase(0, new SimpleSubscription(), this);
        public ACustomerBase DifferentProviderCustomerBase(int id, ASubscription subscription) => new CosmosDBCustomerBase(id, subscription, this);
        public ACustomerBase this[int id] => new CosmosDBCustomerBase(id, new SimpleSubscription(), this);
        public ACustomerBase this[ASubscription subscription] => new CosmosDBCustomerBase(0, new SimpleSubscription(), this);
    }
}
