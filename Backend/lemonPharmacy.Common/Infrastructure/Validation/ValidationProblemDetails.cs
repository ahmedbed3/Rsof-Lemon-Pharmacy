using System.Collections.Generic;
using lemonPharmacy.Common.Infrastructure.Validator;
using Microsoft.AspNetCore.Mvc;

namespace lemonPharmacy.Common.Infrastructure.AspNetCore.Validation
{
    public class ValidationProblemDetails : ProblemDetails
    {
        public ICollection<ValidationError> ValidationErrors { get; set; }
    }
}
