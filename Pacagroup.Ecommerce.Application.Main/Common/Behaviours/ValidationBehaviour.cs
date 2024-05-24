﻿using FluentValidation;
using MediatR;
using Pacagroup.Ecommerce.Application.UseCases.Common.Exceptions;
using Pacagroup.Ecommerce.CrossSectional.Common;

namespace Pacagroup.Ecommerce.Application.UseCases.Common.Behaviours
{
    public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : notnull
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (_validators.Any())
            {
                var context = new ValidationContext<TRequest>(request);
                var validationResults = await Task.WhenAll(_validators.Select(v=>v.ValidateAsync(context, cancellationToken)));
                var failures = validationResults.Where(r => r.Errors.Any()).SelectMany(r => r.Errors)
                    .Select(r=>new BaseError { PropertyMessage = r.PropertyName, ErrorMessage = r.ErrorMessage });
                if(failures.Any())
                {
                    throw new ValidationExceptionCustom(failures);
                }
            }

            return await next();
        }
    }
}
