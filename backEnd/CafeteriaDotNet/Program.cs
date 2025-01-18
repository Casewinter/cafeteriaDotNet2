using Menu.Data;
using Menu.Routers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<MenuContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


// Serve arquivos estáticos da pasta wwwroot
app.UseStaticFiles();


app.MapGet("", () =>
{
    return Results.Redirect("/index.html");
});

app.MenuRouters();
app.UseHttpsRedirection();

app.Run();
