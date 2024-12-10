using backend.Data;
using backend.Repository;
using backend.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Connect to DB
builder.Services.AddDbContext<RentEZDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RentEZDbConnectionString"))
);

// Register IPropertyRepository and its implementation
builder.Services.AddScoped<IPropertyRepository, PropertyRepository>();
builder.Services.AddScoped<IPropertyService, PropertyService>();

// Register Feature Repository and Service
builder.Services.AddScoped<IFeatureRepository, FeatureRepository>();
builder.Services.AddScoped<IFeatureService, FeatureService>();

builder.Services.AddScoped<IImageRepository, ImageRepository>();
builder.Services.AddScoped<IImageService, ImageService>();



// Add controllers and Swagger/OpenAPI services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register the JWT service with the secret key
var secretKey = builder.Configuration.GetValue<string>("Jwt:SecretKey");
builder.Services.AddSingleton<TokenService>(new TokenService(secretKey));

// Add authentication using JWT Bearer
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = "RentEZApp",
            ValidAudience = "RentEZUsers",
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
        };
    });

// CORS configuration
builder.Services.AddCors(options =>
{
    var frontendURL = builder.Configuration.GetValue<string>("FrontendUrl"); // Ensure this is the correct key in your appsettings.json
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins(frontendURL)  // Your frontend's URL (e.g., "http://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials();  // Allows cookies and authentication headers if needed
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "webapi v1"));
}

app.UseHttpsRedirection();

// Apply CORS policy
app.UseCors(); // Ensure the CORS policy is applied globally

// Use authentication and authorization
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
