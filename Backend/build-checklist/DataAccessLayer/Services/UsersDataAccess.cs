using DataAccessLayer.DTO;
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
                            Admin = c.Admin,
                            Lead = c.Lead,
                            Role = c.Role
                        };
            return query.ToList();
        }
    }
}
