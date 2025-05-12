using OOP.Lab7.Interface1;
using OOP.Lab7.Interface2;
using OOP.Lab7.Interface3;

namespace OOP.Lab7.Configs
{
    public static class ConfigB
    {
        public static void Configure(Injector injector)
        {
            injector.Register<IInterface1, Class1Release>(LifeStyle.PerRequest);
            injector.Register<IInterface2, Class2Release>(LifeStyle.Singleton);
            injector.Register<IInterface3, Class3Release>(LifeStyle.Scoped);
        }
    }
}
