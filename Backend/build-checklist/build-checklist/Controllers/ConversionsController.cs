using BusinessLayer.Models;
using BusinessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace build_checklist.Controllers
{
    [RoutePrefix("api/conversions")]
    public class ConversionsController : ApiController
    {
        [HttpGet]
        [Route("getallconversions")]
        public List<ConversionsVM> GetConversions()
        {
            ConversionsBusiness conversionsBusiness = new ConversionsBusiness();
            return conversionsBusiness.GetAllConversions();
        }

        [HttpPost]
        [Route("editconversion/{id}")]
        public ConversionsVM UpdateConversion(ConversionsVM conversion, int id)
        {
            ConversionsBusiness conversionBusiness = new ConversionsBusiness();
            conversion.ConversionId = id;
            return conversionBusiness.UpdateConversion(conversion);
        }

        //[HttpPost]
        //[Route("adduser")]
        //public void AddUser(UserVM user)
        //{
        //    UserBusiness userBusiness = new UserBusiness();
        //    int UserId = userBusiness.CreateNewUser(user);            //YES originally present
        //    //int UserId = user.UserId;                                  //I added
        //    //userBusiness.CreateNewUser(user);                           //I added
        //    //return id;                                        //originally commented
        //}
    }
}
