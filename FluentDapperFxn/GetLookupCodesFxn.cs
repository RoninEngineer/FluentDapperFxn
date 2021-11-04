using FluentDapperFxn.Data.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace FluentDapperFxn
{
    public class GetLookupCodesFxn
    {
        private readonly ISystemLookupRepository _systemRepo;
        public GetLookupCodesFxn(ISystemLookupRepository systemRepo)
        {
            _systemRepo = systemRepo;
        }

        [FunctionName("GetLookupCodesFxn")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,ILogger log)
        {
            var result = await _systemRepo.GetAllSystemLookupCodes();

            return new OkObjectResult(result);
        }
    }
}
