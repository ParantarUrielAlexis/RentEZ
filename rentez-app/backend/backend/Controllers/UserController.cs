using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly RentEZDbContext _context;

        // Inject the RentEZDbContext into the controller
        public UserController(RentEZDbContext context)
        {
            _context = context;
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

            if (user == null)
            {
                return Unauthorized(new { message = "Invalid email or password." });
            }

            // Check if the provided password matches the user's password (you should use password hashing in a real application)
            if (user.Password != loginRequest.Password)
            {
                return Unauthorized(new { message = "Invalid email or password." });
            }

            // If successful, return a success message (In a real app, you should issue a token here)
            return Ok(new { message = "Login successful." });
        }
        [HttpGet("isLoggedIn")]
        public IActionResult IsLoggedIn()
        {
            var isLoggedIn = HttpContext.Session.GetString("UserLoggedIn") == "true";
            var username = HttpContext.Session.GetString("UserName");

            return Ok(new { isLoggedIn, username });
        }
    }


    // Model to receive login credentials
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
