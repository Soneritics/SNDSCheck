using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SNDSCheck.SmartNetworkDataService
{
    public static class SNDSFileFactory
    {
        private static SNDSFileDictionary dictionary = new SNDSFileDictionary(int.Parse(ConfigurationManager.AppSettings.Get("FileCacheMinutes")));

        public static SNDSFile Create(String key)
        {
            if (!dictionary.ContainsKey(key))
            {
                var sndsFile = new SNDSFile(new Uri("https://postmaster.live.com/snds/ipStatus.aspx?key=" + key));
                dictionary.Add(key, sndsFile);
            }

            return dictionary[key];
        }
    }
}