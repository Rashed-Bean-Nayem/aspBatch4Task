using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCalculatorLibrary
{
    public class CalculatorModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public CalculatorModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Calculator>().As<ICalculator>().SingleInstance();
            base.Load(builder);
        }
    }
}
