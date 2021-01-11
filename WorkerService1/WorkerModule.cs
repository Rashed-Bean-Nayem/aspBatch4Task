using Autofac;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService1 
{
    public class WorkerModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;
        private readonly IConfiguration _configuration;
        private readonly string _rootPath;
        private readonly string _filePath;

        public WorkerModule(string connectionStringName, string migrationAssemblyName,
            IConfiguration configuration)
        {
            _connectionString = connectionStringName;
            _migrationAssemblyName = migrationAssemblyName;
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<TestService>().As<ITestService>()
            //    .SingleInstance();

            base.Load(builder);
        }
    }
}
