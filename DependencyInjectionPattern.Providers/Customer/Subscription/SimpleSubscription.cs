using DependencyInjectionPattern.Interfaces.Customer.Subscription;
using DependencyInjectionPattern.Interfaces.Customer.Subscription.Api;
using DependencyInjectionPattern.Providers.Customer.Subscription.Api;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPattern.Providers.Customer.Subscription
{
    public class SimpleSubscription : ASubscription
    {
        public SimpleSubscription() : base(new SimpleProvider())
        {

        }
        
        public override void Something()
        {
            Console.WriteLine("Something");
        }
    }
}
