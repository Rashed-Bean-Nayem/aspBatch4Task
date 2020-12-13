using Autofac;
using Foundation.Contexts;
using Foundation.Repositories;
using Foundation.Services;
using Foundation.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation
{
    public class FoundationModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public FoundationModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegistrationContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<CourseRepository>().As<ICourseRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<StudentRepository>().As<IStudentRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<RegistrationRepository>().As<IRegistrationRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<RegistrationUnitOfWork>().As<IRegistrationUnitOfWork>()
                .InstancePerLifetimeScope();
            builder.RegisterType<AddingService>().As<IAddingService>()
                .InstancePerLifetimeScope();
            builder.RegisterType<GetService>().As<IGetService>()
               .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
