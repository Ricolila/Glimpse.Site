using System.Configuration;

namespace Glimpse.Package
{
    public class ConfigElementServices : ConfigurationElement
    {
        [ConfigurationProperty("minTriggerInterval", DefaultValue = null /*0*/)]
        public int? MinTriggerInterval
        {
            get { return (int?)base["minTriggerInterval"]; }
            set { base["minTriggerInterval"] = value; }
        }
    }
}