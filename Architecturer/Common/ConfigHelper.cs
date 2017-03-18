using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ConfigHelper
    {
        public static string GetConfig(string configName) {
            return ConfigurationManager.AppSettings[configName];
        }
    }
}
