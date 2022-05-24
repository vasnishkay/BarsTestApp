using System.Collections.Generic;

namespace BarsTestApp.Service.Services
{
    internal interface IContractRepository
    {
        IEnumerable<Contract> GetContracts();
    }
}
