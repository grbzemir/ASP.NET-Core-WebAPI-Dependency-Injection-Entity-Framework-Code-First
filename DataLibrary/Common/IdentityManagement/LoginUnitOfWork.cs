using DataModels.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Common.IdentityManagement
{
    public class LoginUnitOfWork:ILoginUnitOfWork
    {

        private readonly SampleDatabaseContext _dbcontext;

        public LoginUnitOfWork(SampleDatabaseContext dbcontext)
        {
            _dbcontext = dbcontext;

        }


        public AuthenticateModel Authenticate(string username, string password)
        {
            
            return (from user in _dbcontext.MltpUsers
                    where user.Username == username && user.Password == password
                    select new AuthenticateModel
                    {
                        Id = user.Id,
                        Name = user.Name,
                        Surname = user.Surname,
           
                     }).FirstOrDefault();
       
        
        }

        
    }
    
}

