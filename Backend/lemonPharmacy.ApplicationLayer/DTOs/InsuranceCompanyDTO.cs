using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonPharmacy.ApplicationLayer.DTOs
{
    public record InsuranceCompanyDTO
     (
         int id,
         String Name,
         String Email,
         String Phone,
         String? Address,
         double? AddressLat,
         double? AddressLong
    );
}
