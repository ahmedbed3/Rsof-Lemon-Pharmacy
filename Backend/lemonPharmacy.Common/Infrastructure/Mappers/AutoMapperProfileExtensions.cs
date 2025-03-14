using AutoMapper;
using MediatR;
using lemonPharmacy.Common.Domain;

namespace lemonPharmacy.Common.Infrastructure.Mappers
{
    public static class AutoMapperProfileExtension
    {
       

        public static Profile MapTo<TSource, TDestination>(this Profile profile)
        {
            profile.CreateMap(typeof(TSource), typeof(TDestination)).ReverseMap();
            return profile;
        }

        public static Profile MapToNotification<TSource, TDestination>(this Profile profile)
        {
            // Source: https://stackoverflow.com/questions/13075588/configure-automapper-to-map-to-concrete-types-but-allow-interfaces-in-the-defini/13075915
            profile.CreateMap(typeof(TSource), typeof(TDestination));
            profile.CreateMap(typeof(TSource), typeof(INotification)).As(typeof(TDestination));
            return profile;
        }

    }
}
