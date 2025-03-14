using System;
using System.Runtime.Serialization;
using lemonPharmacy.Common.Domain;

namespace lemonPharmacy.Common.Infrastructure.Validator
{
    [Serializable]
    public class ValidationException : CoreException
    {
        public ValidationException(ValidationResultModel validationResultModel)
        {
            ValidationResultModel = validationResultModel;
        }

        public ValidationResultModel ValidationResultModel { get; }

        protected ValidationException(SerializationInfo info, StreamingContext context)
           : base(info, context)
        {
        }
    }
}