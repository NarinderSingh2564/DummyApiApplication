using DummyApiApplication.Web.Data;
using DummyApiApplication.Web.Data.DbClasses;
using DummyApiApplication.Web.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Web.Http;
using System.Web.Http.Results;

namespace DummyApiApplication.Web.Controllers
{
    [System.Web.Http.Route("api/[controller]")]
    public class UserController : ApiController
    {
        [Microsoft.AspNetCore.Mvc.HttpPost("UserAddEdit")]
        public async Task<ApiResponseModel> UserAddEdit(UserModel userModel)
        {
            var returnObject = new ApiResponseModel();

            try
            {
                var Model = new User();

                Model.Id = userModel.Id;
                Model.Name = userModel.Name;
                Model.Email = userModel.Email;
                Model.Password = userModel.Password;
                Model.Mobile = userModel.Mobile;
            
                using (ApplicationDbContext dbContext = new ApplicationDbContext())
                {
                   await dbContext.tblUser.AddAsync(Model);
                   await dbContext.SaveChangesAsync();
                }

                returnObject.Status = true;
                returnObject.Message = "Data is Successfully Submited.";
            }

            catch (Exception ex)
            {
                returnObject.Status = false;
                returnObject.Message = "Something went wrong.";
            }

            return returnObject;
        }

        [Microsoft.AspNetCore.Mvc.HttpGet("GetUserList")]
        public async Task<ApiResponseModel> GetUserList()
        {
            var returnObject = new ApiResponseModel();
            try
            {
                using (ApplicationDbContext dbContext = new ApplicationDbContext())
                {
                    returnObject.Response = await dbContext.tblUser.ToListAsync();
                }

                returnObject.Status = true;
            }

            catch (Exception ex)
            {
                returnObject.Status = false;
                returnObject.Message = "Something went wrong.";
            }

            return returnObject;
        }
    }
}
