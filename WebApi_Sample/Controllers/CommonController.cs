using DataLibrary.Common.IdentityManagement;
using DataModels;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_Sample.Controllers
{
    public class CommonController : Controller
    {
        private ILoginUnitOfWork _loginUow;

        public CommonController(ILoginUnitOfWork loginUow)
        {
            _loginUow = loginUow;
        }

        [HttpGet]

        [Route("api/Common/Login/{username}/{password}")]

        public ResponseItem Login(string username, string password)
        {

            ResponseItem result = new ResponseItem();

            result.Result = true;


            try

            {

                result.Data = _loginUow.Authenticate(username, password);

                result.Message = "Login Successful";

            }

            catch (System.Exception ex)

            {

                result.Result = false;

                result.Message = ex.Message;

                return result;

            }

            return result;


        }
    }


}

