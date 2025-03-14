using AutoMapper;
using lemonPharmacy.ApplicationLayer.DTOs;
using lemonPharmacy.ApplicationLayer.Handlers;
using lemonPharmacy.Domain;

namespace lemonPharmacy.Application.MappingProfile
{
    public class lemonPharmacyMappingProfile : Profile
    {
        public lemonPharmacyMappingProfile()
        {
            //InsuranceCompany
            CreateMap<InsuranceCompany, CreateInsuranceCompanyCommand>().ReverseMap();
            CreateMap<InsuranceCompany, InsuranceCompanyDTO>().ReverseMap();
            
        }
    }
}

