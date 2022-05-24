using BarsTestApp.Entity;
using System.Collections.Generic;
using System.Linq;

namespace BarsTestApp.Services
{
    public class ContractService : IContractService
    {
        public IEnumerable<Contract> GetContracts()
        {
            using (var svc = new BarsTestAppDataService.BarsTestAppDataServiceClient())
            {
                var data = svc.GetContracts();
                return data.Select(x =>
                    new Contract
                    {
                        ContractNumber = x.ContractNumber,
                        CreatedOn = x.CreatedOn,
                        LastUpdate = x.LastUpdate
                    });
            }
        }
    }
}
