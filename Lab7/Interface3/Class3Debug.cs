namespace OOP.Lab7.Interface3
{
    public class Class3Debug : IInterface3
    {
        private readonly IInterface1 _dep;
        public Class3Debug(IInterface1 dep) => _dep = dep;
        public void Run() { Console.WriteLine("Class3Debug running"); _dep.DoWork(); }
    }
}
