using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_RepositoryAutoFac.Models;

namespace MVC_RepositoryAutoFac.Repositories
{
    public class SqlServerRepository:IRepository
    {
        public Company GetCompany()
        {
            var company = new Company() { Name = "Macquire", CompanyType = "Investment", Headquarters = "Sydney" };
            return company;
        }
    }
}