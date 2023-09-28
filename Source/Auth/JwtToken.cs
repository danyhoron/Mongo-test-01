#pragma warning disable CS8618
namespace endlessday.services.Auth;

internal sealed class JwtToken
{
    /// <summary>
    /// The JWT token string
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// The expiry date of the JWT Token
    /// </summary>
    public string Expiry { get; set; }
}