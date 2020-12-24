using DrillShopApi.DAL.Domain;
using Microsoft.EntityFrameworkCore;

namespace DrillShopApi.DAL.Contexts
{
    /// <summary>
    /// JWT Auth Demo context.
    /// </summary>
    public class JwtContext : DbContext
    {
        /// <summary>
        /// Users.
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Roles.
        /// </summary>
        public DbSet<Role> Roles { get; set; }

        /// <summary>
        /// User roles.
        /// </summary>
        public DbSet<UserRoles> UserRoles { get; set; }

        /// <summary>
        /// Initialize object of <see cref="JwtContext"/>.
        /// </summary>
        /// <param name="options">Options of context config.</param>
        public JwtContext(DbContextOptions options) : base(options)
        {
        }
    }
}
