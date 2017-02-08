using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SNDSCheck
{
    [ServiceContract]
    public interface ISNDSCheckService
    {

        [OperationContract]
        bool isListed(String IP, String sndsKey);

        [OperationContract]
        List<String> getListedIPs(String sndsKey);
    }
}
