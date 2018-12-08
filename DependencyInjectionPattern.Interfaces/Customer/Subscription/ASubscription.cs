using DependencyInjectionPattern.Interfaces.Customer.Subscription.Api;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPattern.Interfaces.Customer.Subscription
{
    /// <summary>
    /// Abstraction for every implementation of Subscription and Api
    /// </summary>
    public abstract class ASubscription
    {
        private IApi api;
        /// <summary>
        /// Dependency injection for IApi
        /// </summary>
        /// <param name="api">Interface for Dependency Injection</param>
        public ASubscription(IApi api)
        {
            this.api = api;
        }
        /// <summary>
        /// Template pattern.
        /// </summary>
        /// <returns></returns>
        public bool Subscribe()
        {
            this.api.Activate();
            this.api.Notify();
            this.api.Pay();
            return true;
        }
        public abstract void Something();
    }
}
