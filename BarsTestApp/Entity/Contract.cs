using System;

namespace BarsTestApp.Entity
{
    public class Contract
    {
        public int ContractNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool IsActive { get => LastUpdate.Date > DateTime.Now.AddDays(-60).Date; set { } }
    }
}
