using AutoMapper;
using lemonPharmacy.ApplicationLayer.DTOs;
using lemonPharmacy.Domain;
using lemonPharmacy.Common.Domain;
using lemonPharmacy.Common.Infrastructure.AspNetCore.CleanArch;
using lemonPharmacy.Common.Infrastructure.Wrappers;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace lemonPharmacy.ApplicationLayer.Handlers
{
    public class CreateInsuranceCompanyHandler : TxRequestHandlerBase<CreateInsuranceCompanyCommand, Response<InsuranceCompanyDTO>>
    {
        private readonly IUnitOfWorkAsync _uow;
        private readonly IMapper _mapper;

        public CreateInsuranceCompanyHandler(IUnitOfWorkAsync uow,
            IQueryRepositoryFactory queryRepositoryFactory,
            IMapper mapper) : base(uow, queryRepositoryFactory)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public override async Task<Response<InsuranceCompanyDTO>> Handle(CreateInsuranceCompanyCommand request, CancellationToken cancellationToken)
        {
            if (request is null)
                throw new ArgumentNullException(nameof(request));

            // Map request DTO to Entity
            var insuranceCompany = _mapper.Map<InsuranceCompany>(request);
            insuranceCompany.CreateEvent();

            // Insert into database
            var commandRepository = CommandFactory.RepositoryAsync<InsuranceCompany>();
            var insertedCompany = await commandRepository.AddAsync(insuranceCompany);
            _uow.SaveChanges();

            // Map entity to response DTO
            var resultDTO = new InsuranceCompanyDTO(
                insertedCompany.Id,
                insertedCompany.Name,
                insertedCompany.Email,
                insertedCompany.Phone,
                insertedCompany.Address,
                insertedCompany.AddressLat,
                insertedCompany.AddressLong
            );

            return new Response<InsuranceCompanyDTO>(resultDTO, "Insurance company successfully created");
        }
    }
}
