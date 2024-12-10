using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace backend.Services
{
    public class TokenService
    {
        private readonly string _secretKey;

        public TokenService(string secretKey)
        {
            _secretKey = secretKey;
        }

        // Method to generate a JWT token
        public string GenerateToken(string username)
        {
            var claims = new[]
            {
            new Claim(ClaimTypes.Name, username),
            // You can add more claims like roles here
        };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "RentEZApp",  // The issuer could be the name of your app or service
                audience: "RentEZUsers",  // The audience could be the group of users or systems that the token is intended for
                claims: claims,
                expires: DateTime.Now.AddHours(1),  // Expiry time for the token (1 hour in this case)
                signingCredentials: credentials
            );


            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
