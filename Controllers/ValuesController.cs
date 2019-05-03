using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationConfiguration.Models;
using ApplicationConfiguration.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationConfiguration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IUserService _userService;
        public ValuesController( IUserService userService)
        {            
            _userService = userService;
        }  
        [HttpGet]
            public List<string> getData()
        {
            return _userService.GetCacheData();
        }       

    }
}