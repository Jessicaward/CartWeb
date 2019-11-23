using Ninject.Modules;

namespace CartWeb.Implementation
{
    public class NinjectBindings : NinjectModule
    {
        private readonly string _connectionString;

        public NinjectBindings(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        public override void Load()
        {
            Bind<IAccountRepository>()
                .To<AccountManager>()
                .InSingletonScope()
                .WithConstructorArgument("connectionString", _connectionString);
        }
    }
}