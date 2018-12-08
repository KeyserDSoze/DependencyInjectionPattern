using DependencyInjectionPattern.Interfaces.Customer.Subscription.Api;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPattern.Providers.Customer.Subscription.Api
{
    internal class SimpleProvider : IApi
    {
        public bool Activate()
        {
            return true;
        }

        public bool Deactivate()
        {
            return true;
        }

        public bool Notify()
        {
            return true;
        }

        public bool Pay()
        {
            return true;
        }
    }
}
