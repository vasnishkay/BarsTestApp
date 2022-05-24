using BarsTestApp.Entity;
using System.Collections.Generic;

namespace BarsTestApp.Services
{
    public interface IContractService
    {
        IEnumerable<Contract> GetContracts();
    }
}
