using System;
using FluentValidation;
using FluentValidation.Results;
using MediatR;

namespace HyBe.Application.Common.Behaviors;

public class RequestValidationBehavior<TRequest,TResponse> : IPipelineBehavior<TRequest,TResponse>
	where TRequest : IRequest<TResponse>
{
    #region Fields
    private readonly IEnumerable<IValidator<TRequest>> _validators;
    #endregion

    #region Constructor
    public RequestValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }
    #endregion

    #region Methods
    public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        ValidationContext<object> context = new(request);
        List<ValidationFailure> failures = _validators
            .Select(validator => validator.Validate(context))
            .SelectMany(result => result.Errors)
            .Where(failure => failure != null)
            .ToList();

        if (failures.Count != 0)
            throw new ValidationException(failures);

        return next();

    }
    #endregion
}

