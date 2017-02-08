using SNDSCheck.SmartNetworkDataService;
using System;
using System.Collections.Generic;
using ServerMonitorShared;
using SNDSCheck.Components;

namespace SNDSCheck
{
    public class SNDSCheckService : ISNDSCheckService
    {
        public List<String> getListedIPs(string sndsKey)
        {
            var sndsFileContents = SNDSFileFactory.Create(sndsKey).Contents;
            return new IPFromTextExtracter(sndsFileContents);
        }

        public bool isListed(string IP, string sndsKey)
        {
            return getListedIPs(sndsKey).Contains(IP);
        }
        public bool isListed(Server server, string sndsKey)
        {
            return isListed(server.IP, sndsKey);
        }
    }
}
