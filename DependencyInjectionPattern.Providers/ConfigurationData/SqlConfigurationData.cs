using DependencyInjectionPattern.Interfaces.ConfigurationData;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPattern.Providers.ConfigurationData
{
    public class SqlConfigurationData : IConfigurationData
    {
        public string GetProperty(string x)
        {
            return string.Empty;
        }
    }
}
