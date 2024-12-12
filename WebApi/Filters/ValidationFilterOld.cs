using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApi.Filters
{
    public class ValidationFilterOld : IActionFilter
    {
        private readonly IValidatorFactory _validatorFactory;

        public ValidationFilterOld(IValidatorFactory validatorFactory)
        {
            _validatorFactory = validatorFactory;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            foreach (var argument in context.ActionArguments)
            {
                if (argument.Value == null)
                {
                    throw new ValidationException($"{argument.Key} cannot be null");
                }

                var validator = _validatorFactory.GetValidator(argument.Value.GetType());
                if (validator == null)
                    continue;

                ValidationResult result = validator.Validate(new ValidationContext<object>(argument.Value));
                if (!result.IsValid)
                {
                    throw new ValidationException(result.Errors);
                }
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }
    }
}
