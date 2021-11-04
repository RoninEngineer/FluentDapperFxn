using System;
using System.Collections.Generic;
using System.Text;

namespace FluentDapperFxn.Common.Interface
{
    public interface IAppSettingsService
    {
        string DBConnectionString { get; }
    }
}
