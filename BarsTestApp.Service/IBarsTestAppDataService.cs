using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace BarsTestApp.Service
{
    [ServiceContract]
    public interface IBarsTestAppDataService
    {

        [OperationContract]
        IEnumerable<Contract> GetContracts();
    }

    [DataContract]
    public class Contract
    {
        [DataMember]
        public int ContractNumber { get; set; }

        [DataMember]
        public DateTime CreatedOn { get; set; }

        [DataMember]
        public DateTime LastUpdate { get; set; }
    }
}
