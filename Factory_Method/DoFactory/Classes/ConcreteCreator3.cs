namespace DoFactory
{
    public class ConcreteCreator3 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct3();
        }
    }

    internal class ConcreteProduct3 : IProduct
    {
        public string Operation()
        {
            return "New Method implemented";
        }
    }
}
