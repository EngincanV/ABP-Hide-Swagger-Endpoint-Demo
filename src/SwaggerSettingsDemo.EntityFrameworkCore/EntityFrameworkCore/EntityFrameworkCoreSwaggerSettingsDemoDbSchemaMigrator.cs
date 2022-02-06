﻿using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SwaggerSettingsDemo.Data;
using Volo.Abp.DependencyInjection;

namespace SwaggerSettingsDemo.EntityFrameworkCore;

public class EntityFrameworkCoreSwaggerSettingsDemoDbSchemaMigrator
    : ISwaggerSettingsDemoDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSwaggerSettingsDemoDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SwaggerSettingsDemoDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SwaggerSettingsDemoDbContext>()
            .Database
            .MigrateAsync();
    }
}
