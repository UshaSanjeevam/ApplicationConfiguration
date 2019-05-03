using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationConfiguration.EF;
using ApplicationConfiguration;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using ApplicationConfiguration.Models;
using System.DirectoryServices.AccountManagement;

namespace ApplicationConfiguration.Services
{
    public class UserService : IUserService
    {
        private Common _common;
        private DataContext _datacontext;

        public UserService(DataContext dataContext,Common common)
        {
            _common = common;
            _datacontext = dataContext;
        }
        public List<string> GetCacheData()
        {
            List<String> authors = new List<String>();
            authors.Add("Mahesh Chand");
            authors.Add("Chris Love");
            authors.Add("Allen O'neill");
            authors.Add("Naveen Sharma");
            authors.Add("Monica Rathbun");
            authors.Add("David McCarter");
            return authors;
        }

      
        


    }
}
