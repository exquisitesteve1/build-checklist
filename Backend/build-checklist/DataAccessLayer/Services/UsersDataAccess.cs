using DataAccessLayer.DTO;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services
{
    public class UsersDataAccess
    {
        //Gets list of all users
        public List<UserDTO> GetAllUsers()
        {
            BuildChecklistContext dbContext = new BuildChecklistContext();
            var query = from c in dbContext.Users
                        select new UserDTO()
                        {
                            UserId = c.UserId,
                            Name = c.Name,
                            Email = c.Email,
                            Password = c.Password,
                            Admin = c.Admin,
                            Lead = c.Lead,
                            Role = c.Role
                        };
            return query.ToList();
        }


        public UserDTO UpdateUserInDB(UserDTO user)
        {
            BuildChecklistContext dbContext = new BuildChecklistContext();
            Users users = dbContext.Users.Where(c => c.UserId == user.UserId).FirstOrDefault();
            users.UserId = user.UserId;                 //I added later
            users.Name = user.Name;
            users.Email = user.Email;
            users.Password = user.Password;
            users.Admin = user.Admin;
            users.Lead = user.Lead;
            users.Role = user.Role;

            dbContext.SaveChanges();
            return user;
        }
    }

}
