using backend.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container

// Connect to DB
builder.Services.AddDbContext<RentEZDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RentEZDbConnectionString"))
);

// Add controllers and Swagger/OpenAPI services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add session support
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Set session timeout
    options.Cookie.HttpOnly = true;                // Prevent client-side script access
    options.Cookie.IsEssential = true;             // Ensure session cookie is always created
});

// CORS configuration
builder.Services.AddCors(options =>
{
    var frontendURL = builder.Configuration.GetValue<string>("FrontendUrl");
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins(frontendURL)
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RentEZ API v1"));
}

app.UseHttpsRedirection();

// Apply CORS policy
app.UseCors();

// Enable session
app.UseSession();

// Use authorization (if required)
app.UseAuthorization();

app.MapControllers();

app.Run();
