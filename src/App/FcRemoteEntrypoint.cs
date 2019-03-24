using System;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;
using Aliyun.Serverless.Core.Http;
using Microsoft.AspNetCore.Hosting;

namespace App
{
    public class FcRemoteEntrypoint : FcHttpEntrypoint
    {
        protected override void Init(IWebHostBuilder builder)
        {
            builder.UseWebRoot("/mnt/share/www/wwwroot")      
                    .UseStartup<Startup>();
        }
    }
}