using ApoUtilityPrototype1.Contracts;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace ApoUtilityPrototype1.DI
{
    public static class DependencyResolver
    {
        private static readonly WindsorContainer Container;

        static DependencyResolver()
        {
            Container = new WindsorContainer();
        }

        public static void RegisterAll()
        {
            Container.Register(Component.For<ILoginBll>().ImplementedBy<Bll.LoginBll>());
            Container.Register(Component.For<ILoginDal>().ImplementedBy<Dal.LoginDal>());
        }

        public static T ResolveBll<T>() where T : ILoginBll
        {
            return (T)Container.Resolve<ILoginBll>();
        }

        public static T ResolveDal<T>() where T : ILoginDal
        {
            return (T)Container.Resolve<ILoginDal>();
        }
    }
}
