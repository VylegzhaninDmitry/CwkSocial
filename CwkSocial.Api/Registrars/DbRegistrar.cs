﻿using CwkSocial.Dal;
using Microsoft.EntityFrameworkCore;

namespace CwkSocial.Api.Registrars;

public class DbRegistrar : IWebApplicationBuilderRegistrar
{
    public void RegisterServices(WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("Default");
        builder.Services.AddDbContext<DataContext>(opt =>
        {
            opt.UseSqlServer(connectionString);
        });
    }
}