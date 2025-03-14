using lemonPharmacy.ApplicationLayer.DTOs;
using lemonPharmacy.Common.Infrastructure.Wrappers;
using MediatR;

namespace lemonPharmacy.ApplicationLayer.Handlers
{
    public record CreateInsuranceCompanyCommand
       (
         String Name,
         String Email,
         String Phone,
         String? Address,
         double? AddressLat,
         double? AddressLong
    ) : IRequest<Response<InsuranceCompanyDTO>>;
}
