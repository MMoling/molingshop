var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.UseCors(options =>
    options
        .WithOrigins("http://localhost:4200")
        .WithMethods("GET","POST","PUT","DELETE")
        .AllowAnyHeader()
);

app.MapControllers();

app.Run();
