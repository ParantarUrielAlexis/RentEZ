using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly RentEZDbContext _context;
        private readonly IConfiguration _configuration;

        // Inject the RentEZDbContext and IConfiguration into the controller
        public UserController(RentEZDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        // Register a new user
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("User data is null.");
            }

            // Check if username or email already exists
            bool userExists = await _context.Users.AnyAsync(u => u.Username == user.Username || u.Email == user.Email);
            if (userExists)
            {
                return BadRequest("Username or email already exists.");
            }

            // Add the user to the database
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            // Return a success message
            return Ok(new { message = "User registered successfully." });
        }

        // Login endpoint
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            if (loginRequest == null)
            {
                return BadRequest("Login data is null.");
            }

            // Find the user by email
            var user = await _context.Users
                                      .FirstOrDefaultAsync(u => u.Email == loginRequest.Email);

            if (user == null || user.Password != loginRequest.Password)  // Here, use hashed password in a real-world scenario
            {
                return Unauthorized(new { message = "Invalid email or password." });
            }

            // Generate JWT token
            var token = GenerateJwtToken(user);

            // Return the JWT token
            return Ok(new { message = "Login successful.", token });
        }

        [HttpGet("me")]
        [Authorize]  // Ensures the user is authenticated
        public async Task<IActionResult> GetCurrentUser()
        {
            var userEmail = HttpContext.User.Identity?.Name; // Use claims to fetch the user
            if (string.IsNullOrEmpty(userEmail))
            {
                return Unauthorized(new { message = "User not logged in." });
            }

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == userEmail);
            if (user == null)
            {
                return Unauthorized(new { message = "User not found." });
            }

            return Ok(new { username = user.Username, email = user.Email });
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            // Clear session or JWT (depending on your authentication implementation)
            return Ok(new { message = "Logged out successfully." });
        }

        // Helper method to generate JWT token
        private string GenerateJwtToken(User user)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Email),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Role, "User")  // Add any roles or claims as needed
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:SecretKey"])); // Fetch secret from config
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "yourIssuer",  // Replace with your issuer name
                audience: "yourAudience",  // Replace with your audience name
                claims: claims,
                expires: DateTime.Now.AddHours(1),  // Set expiration
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token); // Convert token to string
        }
    }

    // Model to receive login credentials
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
