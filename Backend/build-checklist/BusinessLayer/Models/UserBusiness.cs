using AutoMapper;
using BusinessLayer.ViewModels;
using DataAccessLayer.DTO;
using DataAccessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer.Models
{
    public class UserBusiness
    {
        MapperConfiguration configOVD;
        MapperConfiguration configODV;
        public UserBusiness()
        {
            configOVD = new MapperConfiguration(cfg => cfg.CreateMap<UserVM, UserDTO>());
            configODV = new MapperConfiguration(cfg => cfg.CreateMap<UserDTO, UserVM>());
        }

        public List<UserVM> GetAllUsers()
        {
            UsersDataAccess UsersDataAccess = new UsersDataAccess();
            var outputList = new List<UserVM>();
            var inputList = UsersDataAccess.GetAllUsers();

            foreach (var row in inputList)
            {
                outputList.Add(new UserVM
                {
                    UserId = row.UserId,
                    Name = row.Name,
                    Email = row.Email,
                    Password = row.Password,
                    Admin = row.Admin,
                    Lead = row.Lead,
                    Role = row.Role
                });
            }
            return outputList;
        }

        public UserVM UpdateUser(UserVM user)
        {
            UsersDataAccess userDataAccess = new UsersDataAccess();

            var mapperVD = new Mapper(configOVD);
            UserDTO userDTO = mapperVD.Map<UserDTO>(user);

            var inputUser = userDataAccess.UpdateUserInDB(userDTO);
            var mapperDV = new Mapper(configODV);
            UserVM userVM = mapperDV.Map<UserVM>(inputUser);
            return userVM;
        }
    }
}
