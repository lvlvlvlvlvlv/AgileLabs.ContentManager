﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AgileLabs.ContentManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
              .UseKestrel()
              .UseContentRoot(Directory.GetCurrentDirectory())
              .ConfigureLogging(logBuilder =>
              {
                  logBuilder.SetMinimumLevel(LogLevel.Trace);
              })
              .UseStartup<Startup>()
              .Build();

            host.Run();
        }
    }
}
