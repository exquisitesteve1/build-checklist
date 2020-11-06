using AutoMapper;
using BusinessLayer.ViewModels;
using DataAccessLayer.DTO;
using DataAccessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class ConversionsBusiness
    {
        MapperConfiguration configOVD;
        MapperConfiguration configODV;
        public ConversionsBusiness()
        {
            configOVD = new MapperConfiguration(cfg => cfg.CreateMap<ConversionsVM, ConversionsListDTO>());
            configODV = new MapperConfiguration(cfg => cfg.CreateMap<ConversionsListDTO, ConversionsVM>());
        }

        public List<ConversionsVM> GetAllConversions()
        {
            ConversionsDataAccess conversionsDataAccess = new ConversionsDataAccess();
            var outputList = new List<ConversionsVM>();
            var inputList = conversionsDataAccess.GetAllConversions();

            foreach (var row in inputList)
            {
                outputList.Add(new ConversionsVM
                {
                    ConversionId = row.ConversionId,
                    ConversionName = row.ConversionName,
                    ConversionDescription = row.ConversionDescription,
                    IdMember1 = row.IdMember1,
                    IdMember2 = row.IdMember2,
                    IdMember3 = row.IdMember3,
                    IdMember4 = row.IdMember4,
                    CompletedStatus = row.CompletedStatus,
                    Type = row.Type

                });
            }
            return outputList;
        }

        public ConversionsVM UpdateConversion(ConversionsVM conversion)
        {
            ConversionsDataAccess conversionsDataAccess= new ConversionsDataAccess();

            var mapperVD = new Mapper(configOVD);
            ConversionsListDTO conversionsListDTO = mapperVD.Map<ConversionsListDTO>(conversion);

            var inputConversion = conversionsDataAccess.UpdateConversionInDB(conversionsListDTO);
            var mapperDV = new Mapper(configODV);
            ConversionsVM conversionsVM = mapperDV.Map<ConversionsVM>(inputConversion);
            return conversionsVM;
        }

        //public int CreateNewUser(UserVM userVM)
        //{
        //    UsersDataAccess usersDataAccess = new UsersDataAccess();
        //    UserDTO userDTO = new UserDTO();

        //    userDTO.UserId = userVM.UserId;             //originally this line is not there
        //    userDTO.Name = userVM.Name;
        //    userDTO.Email = userVM.Email;
        //    userDTO.Password = userVM.Password;
        //    userDTO.Admin = userVM.Admin;
        //    userDTO.Lead = userVM.Lead;
        //    userDTO.Role = userVM.Role;

        //    int UserId = usersDataAccess.AddUserToDB(userDTO);          //YES originally present line
        //    //usersDataAccess.AddUserToDB(userDTO);                       //I added
        //    return UserId;                                            //YES originally present line
        //    //return 1;                                                      //I added
        //}
    }
}
