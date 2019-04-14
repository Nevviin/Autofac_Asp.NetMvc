using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_RepositoryAutoFac.Models;

namespace MVC_RepositoryAutoFac.Repositories
{
   public interface IRepository
    {
        Company GetCompany();
    }
}
