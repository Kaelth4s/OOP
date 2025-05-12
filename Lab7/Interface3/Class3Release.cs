namespace OOP.Lab7.Interface3
{
    public class Class3Release : IInterface3
    {
        private readonly IInterface2 _dep;
        public Class3Release(IInterface2 dep) => _dep = dep;
        public void Run() { Console.WriteLine("Class3Release running"); _dep.Execute(); }
    }
}
