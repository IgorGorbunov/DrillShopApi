using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DrillShopApi.RequestResponse
{
    /// <summary>
    /// Login request.
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// Name of user.
        /// </summary>
        [Required]
        [JsonPropertyName("username")]
        public string UserName { get; set; }

        /// <summary>
        /// Password.
        /// </summary>
        [Required]
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }

    /// <summary>
    /// Login response.
    /// </summary>
    public class LoginResult
    {
        [JsonPropertyName("username")]
        public string UserName { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("originalUserName")]
        public string OriginalUserName { get; set; }

        [JsonPropertyName("accessToken")]
        public string AccessToken { get; set; }

        [JsonPropertyName("refreshToken")]
        public string RefreshToken { get; set; }
    }

    /// <summary>
    /// Refresh token request.
    /// </summary>
    public class RefreshTokenRequest
    {
        [JsonPropertyName("refreshToken")]
        public string RefreshToken { get; set; }
    }

    /// <summary>
    /// Impersonation request.
    /// </summary>
    public class ImpersonationRequest
    {
        [JsonPropertyName("username")]
        public string UserName { get; set; }
    }
}
