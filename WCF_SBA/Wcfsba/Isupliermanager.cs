using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcfsba
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Isupliermanager" in both code and config file together.
    [ServiceContract]
    public interface Isupliermanager
    {
        [OperationContract]
        SUPPLIER[] GetSUPPLIERs();
        [OperationContract]
        SUPPLIER GetUPPLIER(int supno);
        [OperationContract]
        void add(SUPPLIER obj);
        [OperationContract]
        void update(SUPPLIER obj);
        [OperationContract]
        void delete(int id);


    }
}
