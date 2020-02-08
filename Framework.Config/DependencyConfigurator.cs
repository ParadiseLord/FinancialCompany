using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Framework.Application;
using Framwork;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Config
{
    public class DependencyConfigurator
    {
        public static void Config(IWindsorContainer windsorContainer)
        {
            //ConventionRegistry.Register(
            //    nameof(ImmutablePocoConvention),
            //    new ConventionPack { new ImmutablePocoConvention() },
            //    _ => true);

            windsorContainer.Register(Component.For<IEventBus>().ImplementedBy<EventAggregator>().LifestylePerWebRequest());// Install-Package Castle.Facilities.AspNet.SystemWeb
            windsorContainer.Register(Component.For<ICommandBus>().ImplementedBy<CommandBus>().LifestylePerWebRequest());// Install-Package Castle.Facilities.AspNet.SystemWeb
            windsorContainer.Register(Component.For<ICommandHandlerFactory>().ImplementedBy<CastleCommandHandlerFactory>()

                .UsingFactoryMethod<CastleCommandHandlerFactory>(p =>
                {
                    return new CastleCommandHandlerFactory(windsorContainer);
                })

                .LifestyleSingleton());// Install-Package Castle.Facilities.AspNet.SystemWeb

            windsorContainer.Register(Component.For<IDbConnection>().UsingFactoryMethod<SqlConnection>(a =>
            {
                var connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                var connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }).LifestylePerWebRequest().OnDestroy(a =>
            {
                a.Close();
            }).Forward<DbConnection>());
        }
    }

}
