using DependencyInjectionPattern.Interfaces.ConfigurationData;
using DependencyInjectionPattern.Interfaces.Customer;
using DependencyInjectionPattern.Interfaces.Customer.Subscription;
using DependencyInjectionPattern.Interfaces.Log;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPattern.Interfaces
{
    /// <summary>
    /// Interface that group every DI
    /// </summary>
    public interface IManager
    {
        IConfigurationData ConfigurationData { get; }
        ILog Log { get; }
        ACustomerBase CustomerBase { get; }
        ACustomerBase DifferentProviderCustomerBase(int id, ASubscription subscription);
        ACustomerBase this[int id] { get; }
        ACustomerBase this[ASubscription subscription] { get; }
    }
}
