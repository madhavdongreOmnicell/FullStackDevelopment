using Autofac;

namespace WebAPI
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // load all types in this assembly into Autofac as the interfaces they implement.
            builder.RegisterAssemblyTypes(typeof(ApplicationModule).Assembly)
                .AsImplementedInterfaces();
        }
    }
}
