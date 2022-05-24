using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace BarsTestApp.Service.Services
{
    internal class ContractRepository : IContractRepository, IDisposable
    {
        private readonly string _connectionString;

        public ContractRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Contract> GetContracts()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<Contract>("SELECT * FROM [dbo.Contracts]").ToList();
            }
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}