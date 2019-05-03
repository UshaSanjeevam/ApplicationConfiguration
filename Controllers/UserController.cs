using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationConfiguration.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationConfiguration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUserService _userService;
        public UserController(IUserService userService)
        {

            _userService = userService;

        }
        public List<string> getData()
        {
            return _userService.GetCacheData();
        }
    }
}