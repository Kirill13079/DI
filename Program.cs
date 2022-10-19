using System;

namespace DI
{
    public class Program
    {

        static void Main(string[] args)
        {
            var console = new ConsoleOutput();
            var today = new TodayWriter(console);

            today.WriteData();

            var builder = new ContainerBuilder();

            builder.Register<IOutput, ConsoleOutput>();
/*          
            private static IContainer Container { get; set; }

            var builder = new ContainerBuilder();

            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<TodayWriter>().As<IDateWriter>();

            Container = builder.Build();

            Container.WriteDate(); */
        }
    }
}
