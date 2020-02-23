namespace DoFactory
{
    // Concrete Creators anulan el método de fábrica para cambiar el tipo de producto resultante.
    public class ConcreteCreator1 : Creator
    {
        // Tenga en cuenta que la firma del método todavía usa el tipo de producto abstracto, 
        // aunque el producto concrete realmente se devuelve del método.
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }

    // Los productos concrete proporcionan diversas implementaciones de la interfaz del producto
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
