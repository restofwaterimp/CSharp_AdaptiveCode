using System;

namespace StragegyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public interface IStrategy
    {
        void Execute();
    }

    public class ConcreteStrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("ConcreteStrategyA.Ecexute()");
        }
    }

    public class ConcreteStrategyB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("ConcreteStrategyB.Ecexute()");
        }
    }

    public class Context
    {
        public Context()
        {
            currentStrategy = strategyA;

        }

        public void DoSomething()
        {
            currentStrategy.Execute();
            currentStrategy = (currentStrategy == strategyA) ? strategyB : strategyA;

        }

        private readonly IStrategy strategyA = new ConcreteStrategyA();
        private readonly IStrategy strategyB = new ConcreteStrategyB();
        private IStrategy currentStrategy;
    }




}
