using RPSLS_Endpoint.Controllers;
using RPSLS_Endpoint.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<RPSLSGameService>();


//configure cors policy for unrestricted access
//this piece of code will allow any request from any domain to access our endpoint ("Example.com");
builder.Services.AddCors(options=> {
    options.AddPolicy("AllowAll",
    policy=>{
        // who can knock at our door and what can they bring in
        policy.AllowAnyOrigin() // allows requests from any origin
            .AllowAnyMethod() // allows http requests  (GET,POST,PUT , DELETE) 
            .AllowAnyMethod();  //allows any header
    });

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
