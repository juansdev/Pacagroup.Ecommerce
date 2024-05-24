﻿using MediatR;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Pacagroup.Ecommerce.Application.UseCases.Common.Behaviours
{
    public class LoggingBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly ILogger<LoggingBehaviour<TRequest, TResponse>> _logger;

        public LoggingBehaviour(ILogger<LoggingBehaviour<TRequest, TResponse>> logger)
        {
            _logger = logger;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            // Pre
            _logger.LogInformation("Clean Architecture Request Handling: {name} {@request}", typeof(TRequest).Name, JsonSerializer.Serialize(request));
            var response = await next();
            // Pos
            _logger.LogInformation("Clean Architecture Response Handling: {name} {@response}", typeof(TRequest).Name, JsonSerializer.Serialize(response));
            
            return response;
        }
    }
}
