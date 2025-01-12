var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Explicitly set the URLs to listen on
//app.Urls.Add("https://localhost:5001"); // HTTPS
//app.Urls.Add("http://localhost:5000");  // HTTP (optional)

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
