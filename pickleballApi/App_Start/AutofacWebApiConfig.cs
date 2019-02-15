using System.Configuration;
using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using DataProvider;
using DataProvider.Contracts;
using Facade;
using Facade.Contracts;
using Service;
using Service.Contracts;
using Service.Contracts.Mappers;
using Service.Mappers;

namespace pickleballApi.App_Start
{
    public class AutofacWebApiConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Register your Web API controllers.  
            var assembly = Assembly.GetExecutingAssembly();
            builder.RegisterApiControllers(assembly);

            builder.RegisterType<RegisterFacade>().As<IRegisterFacade>().InstancePerRequest();
            builder.RegisterType<StripePaymentService>().As<IStripePaymentService>().InstancePerRequest();
            builder.RegisterType<RatingService>().As<IRatingService>().InstancePerRequest();
            builder.RegisterType<PartnerService>().As<IPartnerService>().InstancePerRequest();
            builder.RegisterType<PartnerMapper>().As<IPartnerMapper>().InstancePerRequest();
            builder.RegisterType<PlayerService>().As<IPlayerService>().InstancePerRequest();
            builder.RegisterType<PlayerMapper>().As<IPlayerMapper>().InstancePerRequest();
            builder.RegisterType<RatingService>().As<IRatingService>().InstancePerRequest();

            builder.RegisterType<CommandQuery>().As<ICommandQuery>().InstancePerRequest();
            builder.RegisterType<Database>().As<IDatabase>().InstancePerRequest();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.Register(
                    x => new UnitOfWork(ConfigurationManager.ConnectionStrings["pickleball"].ConnectionString)).InstancePerDependency()
                    .As<IUnitOfWork>();

            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();

            return Container;
        }
    }
}