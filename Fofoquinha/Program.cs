using Fofoquinha.Models;
using Fofoquinha.UseCases;
using Fofoquinha.UseCases.DeletePost;
using Fofoquinha.UseCases.GetProfileData;
using Fofoquinha.UseCases.Login;
using Fofoquinha.UseCases.PublishPost;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FofoquinhaDbContext>(options => {
    var sqlConn = Environment.GetEnvironmentVariable("SQL_CONNECTION");
    options.UseSqlServer(sqlConn);
});

builder.Services.AddTransient<LoginUseCase>();
builder.Services.AddTransient<DeletePostUseCase>();
builder.Services.AddTransient<CreateProfileUseCase>();
builder.Services.AddTransient<PublishPostUseCase>();
builder.Services.AddTransient<GetProfileDataUseCase>();

var app = builder.Build();

app.Run();