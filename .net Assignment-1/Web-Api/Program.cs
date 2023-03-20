using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Model;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<Traineedb17Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Mykey")));
builder.Services.AddCors(p=>p.AddPolicy("corspolicy",builder=>builder.WithOrigins("*").AllowAnyHeader().AllowAnyMethod()));
// builder.Services.AddControllersWithViews().AddNewtonsoftJson(options =>
//     options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
// );
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("corspolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
