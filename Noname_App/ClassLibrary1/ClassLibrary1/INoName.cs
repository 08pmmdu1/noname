using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NoName
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INoName" in both code and config file together.
    [ServiceContract]
    public interface INoName
    {
        [OperationContract]
        void DoWork();
    }
}
