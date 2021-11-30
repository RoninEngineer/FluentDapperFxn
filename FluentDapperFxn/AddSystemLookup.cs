using FluentDapperFxn.Domain.Dto;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace FluentDapperFxn
{
    public class AddSystemLookup
    {
        private readonly IValidator<SystemLookup> _validator;
        public AddSystemLookup( IValidator<SystemLookup> validator)
        {
            _validator = validator;
        }

        [FunctionName("AddSystemLookup")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] SystemLookup syslookup,ILogger log)
        {
                      
            var validationResult = await _validator.ValidateAsync(syslookup);
            if (validationResult.IsValid)
            {
                return new OkObjectResult(syslookup);
            }
            else
            {
                return new BadRequestObjectResult(validationResult);
            }
            
        }
    }
}
