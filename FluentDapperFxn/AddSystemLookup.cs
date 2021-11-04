using FluentDapperFxn.Data.Interface;
using FluentDapperFxn.Domain.Dto;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace FluentDapperFxn
{
    public class AddSystemLookup
    {
        private readonly ISystemLookupRepository _systemRepo;
        private readonly IValidator<SystemLookup> _validator;
        public AddSystemLookup(ISystemLookupRepository systemRepo, IValidator<SystemLookup> validator)
        {
            _validator = validator;
            _systemRepo = systemRepo;
        }

        [FunctionName("AddSystemLookup")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,ILogger log)
        {
            var content = await new StreamReader(req.Body).ReadToEndAsync();

            var myClass = JsonConvert.DeserializeObject<SystemLookup>(content);
            
            var validationResult = _validator.Validate(myClass);
            return new OkObjectResult(validationResult);
        }
    }
}
