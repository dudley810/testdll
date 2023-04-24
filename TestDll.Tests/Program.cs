using System;
using Microsoft.Extensions.DependencyInjection;
using TestDIDll;
using Xunit.Sdk;

namespace TestDll.Tests
{
	public class Program
	{
        public Program()
        {
            var services = new ServiceCollection();
            services.AddSingleton<TestClass>();
            services.AddSingleton<MyDIClass>();
            ServiceProvider = services.BuildServiceProvider();
        }

        public ServiceProvider ServiceProvider { get; private set; }
    }
}

