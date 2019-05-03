using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationConfiguration;
using System.Data;
namespace ApplicationConfiguration.Services
{
    public interface IUserService
    {
        List<string> GetCacheData();
     
    }
}
