using backend.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Connect to DB
builder.Services.AddDbContext<RentEZDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RentEZDbConnectionString"))
);

// Add controllers and Swagger/OpenAPI services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// CORS configuration
builder.Services.AddCors(options =>
{
    var frontendURL = builder.Configuration.GetValue<string>("FrontendUrl"); // Correct the config key name here
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
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "webapi v1"));
}

app.UseHttpsRedirection();

// Apply CORS policy
app.UseCors();

// Use authorization (if required)
app.UseAuthorization();

app.MapControllers();

app.Run();
