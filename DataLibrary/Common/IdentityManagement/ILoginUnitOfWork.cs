using DataModels.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Common.IdentityManagement
{
    public interface ILoginUnitOfWork

    {

        AuthenticateModel Authenticate(string username, string password);

    }
}
