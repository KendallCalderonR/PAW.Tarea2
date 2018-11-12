using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace paw.tarea2.main.Logica
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicio1" in both code and config file together.
    [ServiceContract]
    public interface IServicio1
    {
        [OperationContract]
        void DoWork();
    }
}
