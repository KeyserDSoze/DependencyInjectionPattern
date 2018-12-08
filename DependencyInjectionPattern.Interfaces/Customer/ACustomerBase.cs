using DependencyInjectionPattern.Interfaces.ConfigurationData;
using DependencyInjectionPattern.Interfaces.Customer.Subscription;
using DependencyInjectionPattern.Interfaces.Log;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPattern.Interfaces.Customer
{
    public abstract class ACustomerBase
    {
        private int id;
        private ASubscription subscription;
        private ILog log;
        private IConfigurationData configurationData;
        public ACustomerBase(int id, ASubscription subscription, IManager manager)
        {
            this.id = id;
            this.subscription = subscription;
            this.log = manager.Log;
            this.configurationData = manager.ConfigurationData;
        }
        public virtual void Subscribe(int? id = null)
        {
            if (id != null) this.id = (int)id;
            if (this.id == 0) { Console.WriteLine("no id found"); return; }
            this.subscription.Subscribe();
            this.log.Save();
        }
    }
}
