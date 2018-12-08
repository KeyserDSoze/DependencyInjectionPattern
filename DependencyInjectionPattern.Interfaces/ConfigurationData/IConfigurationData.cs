using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPattern.Interfaces.ConfigurationData
{
    public interface IConfigurationData
    {
        string GetProperty(string x);
    }
}
