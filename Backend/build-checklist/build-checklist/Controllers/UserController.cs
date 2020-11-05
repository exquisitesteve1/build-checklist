﻿using BusinessLayer.Models;
using BusinessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace build_checklist.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("getallusers")]
        public List<UserVM> GetUsers()
        {
            UserBusiness UserBusiness = new UserBusiness();
            return UserBusiness.GetAllUsers();
        }

        [HttpPost]
        [Route("edituser/{id}")]
        public UserVM UpdateOwner(UserVM user, int id)
        {
            UserBusiness userBusiness = new UserBusiness();
            user.UserId= id;
            return userBusiness.UpdateUser(user);
        }
    }
}
