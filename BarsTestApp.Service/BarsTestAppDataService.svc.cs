using BarsTestApp.Service.Services;
using System.Collections.Generic;
using System.Configuration;

namespace BarsTestApp.Service
{
    public class BarsTestAppDataService : IBarsTestAppDataService
    {
        private readonly IContractRepository repository;
        public BarsTestAppDataService()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            repository = new ContractRepository(connectionString);
        }

        public IEnumerable<Contract> GetContracts()
        {
            return repository.GetContracts();
        }
    }
}
