using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace SmartCamp.CoreApp.WebApi.Auth;

public class AuthOptions
{
    public const string ISSUER = "SmartCamp.CoreApp";
    public const string AUDIENCE = "SmartCamp.CoreApp.UI";
    const string KEY = "kasdlfklkDLLKSD8s98DHFsdfsdfaLSDFjdksldkHDDjdfd";
    public const int LIFETIME = 1440; // 1 day
    
    public static SymmetricSecurityKey GetSymmetricSecurityKey()
    {
        return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
    }
}