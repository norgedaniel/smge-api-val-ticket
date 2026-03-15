using SMGE_API_VAL_TICKET;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenLocalhost(5161); // HTTP
});

var app = builder.Build();

app.UseStaticFiles();

app.MapControllers();

app.Run();



