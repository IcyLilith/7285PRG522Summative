﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PRG522_SA_7285.Startup))]
namespace PRG522_SA_7285
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
