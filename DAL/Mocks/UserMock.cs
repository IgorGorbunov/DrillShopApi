using DrillShopApi.DAL.Domain;
using System.Collections.Generic;
using System.Linq;

namespace DrillShopApi.DAL.Mocks
{
    public static class UserMocks
    {
        public static List<User> Users = new List<User>
        {
            new User {Id = 1, Login = "admin", Password = "password"},
            new User {Id = 2, Login = "test1", Password = "test1"}
        };

        public static List<Role> Roles = new List<Role>
        {
            new Role {Id = 1, Name = "Admin"},
            new Role {Id = 1, Name = "Default"}
        };

        public static List<UserRoles> UserRoles = new List<UserRoles>
        {
            new UserRoles {Role = Roles.First(), User = Users.First()},
            new UserRoles {Role = Roles.Last(), User = Users.Last()}
        };
    }
}