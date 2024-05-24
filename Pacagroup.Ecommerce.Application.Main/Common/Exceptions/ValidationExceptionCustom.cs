using Pacagroup.Ecommerce.CrossSectional.Common;

namespace Pacagroup.Ecommerce.Application.UseCases.Common.Exceptions
{
    public class ValidationExceptionCustom : Exception
    {
        public IEnumerable<BaseError>? Errors { get; set; }
        public ValidationExceptionCustom() : base("One or more validation failures")
        {
            Errors = new List<BaseError>();
        }
        public ValidationExceptionCustom(IEnumerable<BaseError>? errors) : this()
        {
            Errors = errors;
        }
    }
}
