using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WebApi.Filters;

namespace WebApi.Attribute
{
    public class ValidationFilterAttribute : TypeFilterAttribute
    {
        public ValidationFilterAttribute() : base(typeof(ValidationFilter))
        {
        }
    }
}
