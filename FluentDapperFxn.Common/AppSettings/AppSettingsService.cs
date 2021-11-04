using FluentDapperFxn.Common.Consts;
using FluentDapperFxn.Common.Interface;
using System;

namespace FluentDapperFxn.Common.AppSettings
{
    public class AppSettingsService : IAppSettingsService
    {
        public string DBConnectionString => Environment.GetEnvironmentVariable(AppSettingsKey.DBConnectionString);
    }
}
