namespace DrillShopApi.Services.Interfaces
{
    /// <summary>
    /// Interface for service user.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Check user.
        /// </summary>
        bool IsAnExistingUser(string userName);

        /// <summary>
        /// Validate user data.
        /// </summary>
        bool IsValidUserCredentials(string userName, string password);

        /// <summary>
        /// Get user role if exists.
        /// </summary>
        string GetUserRole(string userName);
    }
}
