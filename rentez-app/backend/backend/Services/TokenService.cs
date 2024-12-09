using backend.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtRegisteredClaimNames = System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames; // Make sure to use the correct namespace for your User model

namespace backend.Services
{
    public class TokenService
    {
        private readonly string _secretKey;

        public TokenService(IConfiguration config)
        {
            _secretKey = config["Jwt:SecretKey"];  // Retrieve secret key from appsettings.json
        }

        public string GenerateToken(User user)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.NameId, user.Id.ToString()),
                new Claim("username", user.Username),
                // Add any other claims as needed
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "YourApp",  // Adjust this
                audience: "YourApp",  // Adjust this
                claims: claims,
                expires: DateTime.Now.AddHours(1),  // Set token expiration time
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
