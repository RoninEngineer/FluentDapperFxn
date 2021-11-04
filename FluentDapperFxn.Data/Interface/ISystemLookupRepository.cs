using FluentDapperFxn.Domain.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FluentDapperFxn.Data.Interface
{
    public interface ISystemLookupRepository
    {
        Task<List<SystemLookup>> GetAllSystemLookupCodes();
    }
}
