using DependencyInjectionPattern.Interfaces;
using DependencyInjectionPattern.Interfaces.ConfigurationData;
using DependencyInjectionPattern.Interfaces.Customer;
using DependencyInjectionPattern.Interfaces.Customer.Subscription;
using DependencyInjectionPattern.Interfaces.Log;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPattern.Providers.Customer
{
    public class CosmosDBCustomerBase : ACustomerBase
    {
        public CosmosDBCustomerBase(int id, ASubscription subscription, IManager manager) : base(id, subscription, manager)
        {
            
        }
    }
}
