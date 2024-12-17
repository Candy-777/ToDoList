using Microsoft.AspNetCore.Mvc.Filters;
using FluentValidation;
using FluentValidation.Results;

namespace WebApi.Filters
{
    public class ValidationFilter : ActionFilterAttribute
    {
        private readonly IServiceProvider _serviceProvider;

        public ValidationFilter(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            foreach (var arg in context.ActionArguments)
            {
                if (arg.Value == null)
                {
                    throw new ValidationException($"{arg.Key} cannot be null");
                }

                var type = arg.Value.GetType();
                var validatorType = typeof(IValidator<>).MakeGenericType(type);

                // Получаем валидатор из DI
                var validator = _serviceProvider.GetService(validatorType) as IValidator;
                if (validator == null)
                {
                    continue;
                }
                var validationContext = new ValidationContext<object>(arg.Value);

                var validationResult = validator.Validate(validationContext);

                if (!validationResult.IsValid)
                {
                    throw new ValidationException(validationResult.Errors);
                }
            }
        }
    }
}
