using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPattern.Interfaces.ConfigurationData
{
    /// <summary>
    /// Interface for any configurations
    /// </summary>
    public interface IConfigurationData
    {
        string GetProperty(string x);
    }
}
