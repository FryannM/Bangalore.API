using Bangalore.API.Interfaces;
using Bangalore.API.Services;
using Bangalores.CORE.Interfaces;
using Bangalores.CORE.Services;
using Ninject.Modules;

namespace Bangalore.API.Container
{
    public class InjectionContainer : NinjectModule
    {
        public override void Load()
        {
            Bind<IAuthServices>().To<AuthServices>();
            Bind<IUserServices>().To<UserServices>();
        }
    }
}
