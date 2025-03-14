using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lemonPharmacy.Common.Domain;

namespace lemonPharmacy.Domain
{
    public class InsuranceCompany : AggregateRootBase
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public string? Address { get; set; }
        public double? AddressLat { get; set; }
        public double? AddressLong { get; set; }

    }
}
