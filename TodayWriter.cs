using System;

namespace DI
{
    public interface IOutput
    {
        void Write(string content);
    }

    public class ConsoleOutput: IOutput
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }

    public interface IDateWriter
    {
        void WriteData();
    }

    public class TodayWriter : IDateWriter
    {
        private IOutput _output;

        public TodayWriter(IOutput output)
        {
            _output = output;
        }

        public void WriteData()
        {
            _output.Write(DateTime.Today.ToShortDateString());
        }
    }
}