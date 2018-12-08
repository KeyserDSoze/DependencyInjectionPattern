using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPattern.Interfaces.Customer.Subscription.Api
{
    public interface IApi
    {
        bool Activate();
        bool Deactivate();
        bool Pay();
        bool Notify();
    }
}
