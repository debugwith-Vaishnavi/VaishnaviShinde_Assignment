using Question7.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

// Register your service (IMPORTANT)
builder.Services.AddScoped<IEmployeeServices, EmployeeServices>();

var app = builder.Build();

// Configure the HTTP request pipeline
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();