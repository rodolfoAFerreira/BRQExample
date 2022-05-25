using BRQExampleDomain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BRQExampleDomain.Interface.Service
{
    public interface ICategoryService
    {
        Task<string> ValidCategory(List<Trade> trades);
    }
}
